using System.Numerics;
using gb;
using ImGuiNET;
using LibreLancer;
using SDL3;
using static SDL3.SDL;
using static SDL3.SDL.SDL_InitFlags;
using static SDL3.SDL.SDL_EventType;
using static SDL3.SDL.SDL_PixelFormat;
using static SDL3.SDL.SDL_ScaleMode;

const int GB_SCREEN_WIDTH = 160;
const int GB_SCREEN_HEIGHT = 144;

const int SCALE_FACTOR = 8;

const int GB_CPU_FREQUENCY = 4194304;
const int SCREEN_FPS = 60;

const int CYCLES_PER_FRAME = 70224 / 100;

DllMap.Register(typeof(SDL).Assembly);

// var bootRom = File.ReadAllBytes("dmg_bootrom.bin");
var rom = File.ReadAllBytes("rom.gb");

var header = GameBoyCartridgeHeader.FromBytes(rom[0x100..0x152]);

unsafe
{
    if (!Init(out var window, out var surface, out var renderer)) return 1;

    var texture = SDL_CreateTexture(renderer, SDL_PIXELFORMAT_RGBA32, SDL_TextureAccess.SDL_TEXTUREACCESS_STREAMING,
        GB_SCREEN_WIDTH, GB_SCREEN_HEIGHT);

    if (texture == null)
    {
        SDL_Log($"Texture could not be created! SDL_Error: {SDL_GetError()}");
        Close(window, surface, renderer);
        return 1;
    }

    SDL_SetTextureScaleMode((IntPtr)texture, SDL_SCALEMODE_NEAREST);

    var vramTexture =
        SDL_CreateTexture(renderer, SDL_PIXELFORMAT_RGBA32, SDL_TextureAccess.SDL_TEXTUREACCESS_STREAMING, 20 * 8,
            20 * 8);
    SDL_SetTextureScaleMode((IntPtr)vramTexture, SDL_SCALEMODE_NEAREST);

    var bg0Texture =
        SDL_CreateTexture(renderer, SDL_PIXELFORMAT_RGBA32, SDL_TextureAccess.SDL_TEXTUREACCESS_STREAMING, 32 * 8,
            32 * 8);
    SDL_SetTextureScaleMode((IntPtr)bg0Texture, SDL_SCALEMODE_NEAREST);

    var bg1Texture =
        SDL_CreateTexture(renderer, SDL_PIXELFORMAT_RGBA32, SDL_TextureAccess.SDL_TEXTUREACCESS_STREAMING, 32 * 8,
            32 * 8);
    SDL_SetTextureScaleMode((IntPtr)bg1Texture, SDL_SCALEMODE_NEAREST);

    ImGui.CreateContext();

    ImGui_SDL3.ImGui_ImplSDL3_InitForSDLRenderer(window, renderer);
    ImGui_SDL3.ImGui_ImplSDLRenderer3_Init(renderer);

    SDL_SetWindowTitle(window, header.GetTitle());

    var gb = new GameBoy();
    // gb.LoadBootRom(bootRom);
    gb.LoadRom(rom);
    gb.ResetNoBootRom(header);

    try
    {
        var running = true;
        var frameStart = DateTime.Now;

        var msPerFrame = 1000.0 / SCREEN_FPS;

        while (running)
        {
            while (SDL_PollEvent(out var @event))
            {
                ImGui_SDL3.ImGui_ImplSDL3_ProcessEvent(&@event);
                if (@event.type == (uint)SDL_EVENT_QUIT)
                    running = false;
            }

            var cyclesToEmulate = CYCLES_PER_FRAME;
            while (cyclesToEmulate > 0) cyclesToEmulate -= gb.Step();

            var rect = new SDL_Rect
            {
                x = 0,
                y = 0,
                w = GB_SCREEN_WIDTH,
                h = GB_SCREEN_HEIGHT,
            };
            if (SDL_LockTexture((IntPtr)texture, ref rect,
                    out var pixels, out var pitch))
            {
                var data = new Span<uint>((void*)pixels, GB_SCREEN_WIDTH * GB_SCREEN_HEIGHT);

                gb.PPU.FrameBuffer.CopyTo(data);

                SDL_UnlockTexture((IntPtr)texture);
            }
            else
            {
                Console.WriteLine($"Could not lock texture! SDL_Error: {SDL_GetError()}");
                running = false;
            }

            var srect = new SDL_FRect
            {
                x = 0,
                y = 0,
                w = GB_SCREEN_WIDTH,
                h = GB_SCREEN_HEIGHT,
            };

            var drect = new SDL_FRect
            {
                x = 0,
                y = 0,
                w = GB_SCREEN_WIDTH * SCALE_FACTOR,
                h = GB_SCREEN_HEIGHT * SCALE_FACTOR,
            };

            SDL_RenderClear(renderer);
            SDL_RenderTexture(renderer, (IntPtr)texture, ref srect, ref drect);

            ImGui_SDL3.ImGui_ImplSDLRenderer3_NewFrame();
            ImGui_SDL3.ImGui_ImplSDL3_NewFrame();
            ImGui.NewFrame();

            ImGui.Begin("Registers");

            gb.CPU.ImGuiRegistersDisplay();

            ImGui.End();

            ImGui.Begin("Memory");

            ImGui.BeginTabBar("MemoryTabs");

            if (ImGui.BeginTabItem("VRAM"))
            {
                var vramRect = new SDL_Rect
                {
                    x = 0,
                    y = 0,
                    w = 20 * 8,
                    h = 20 * 8,
                };

                if (SDL_LockTexture((IntPtr)vramTexture, ref vramRect, out pixels, out pitch))
                {
                    var data = new Span<uint>((void*)pixels, 20 * 8 * 20 * 8);

                    for (var y = 0; y < 20; y++)
                    for (var x = 0; x < 20; x++)
                    {
                        var tileIndex = x + y * 20;

                        var address = (ushort)(tileIndex * 16);
                        var tileData = GetTileData(gb, address);

                        DrawTile(gb, data, tileData, x * 8, y * 8, 20 * 8);
                    }

                    SDL_UnlockTexture((IntPtr)vramTexture);
                }

                ImGui.Image((IntPtr)vramTexture, new() { X = 20 * 8 * 3, Y = 20 * 8 * 3 }, Vector2.Zero, Vector2.One);
                ImGui.EndTabItem();
            }

            if (ImGui.BeginTabItem("BG0"))
            {
                var bg0tm = gb.PPU.GetBg0TileMap();

                var bgRect = new SDL_Rect
                {
                    x = 0,
                    y = 0,
                    w = 32 * 8,
                    h = 32 * 8,
                };

                if (SDL_LockTexture((IntPtr)bg0Texture, ref bgRect, out pixels, out pitch))
                {
                    var data = new Span<uint>((void*)pixels, 32 * 8 * 32 * 8);
                    for (var y = 0; y < 32; y++)
                    for (var x = 0; x < 32; x++)
                    {
                        var tileIndex = bg0tm[x + y * 32];

                        var tileData = gb.PPU.GetBgTile(tileIndex);

                        DrawTile(gb, data, tileData, x * 8, y * 8, 32 * 8);
                    }

                    SDL_UnlockTexture((IntPtr)bg0Texture);
                }

                ImGui.Image((IntPtr)bg0Texture, new() { X = 32 * 8 * 3, Y = 32 * 8 * 3 }, Vector2.Zero, Vector2.One);
                ImGui.EndTabItem();
            }

            if (ImGui.BeginTabItem("BG1"))
            {
                var bg1tm = gb.PPU.GetBg1TileMap();

                var bgRect = new SDL_Rect
                {
                    x = 0,
                    y = 0,
                    w = 32 * 8,
                    h = 32 * 8,
                };

                if (SDL_LockTexture((IntPtr)bg1Texture, ref bgRect, out pixels, out pitch))
                {
                    var data = new Span<uint>((void*)pixels, 32 * 8 * 32 * 8);
                    for (var y = 0; y < 32; y++)
                    for (var x = 0; x < 32; x++)
                    {
                        var tileIndex = bg1tm[x + y * 32];

                        var tileData = gb.PPU.GetBgTile(tileIndex);

                        DrawTile(gb, data, tileData, x * 8, y * 8, 32 * 8);
                    }

                    SDL_UnlockTexture((IntPtr)bg1Texture);
                }

                ImGui.Image((IntPtr)bg1Texture, new() { X = 32 * 8 * 3, Y = 32 * 8 * 3 }, Vector2.Zero, Vector2.One);
                ImGui.EndTabItem();
            }

            ImGui.EndTabBar();

            ImGui.End();

            ImGui.Render();

            ImGui_SDL3.ImGui_ImplSDLRenderer3_RenderDrawData(ImGui.GetDrawData(), renderer);

            SDL_RenderPresent(renderer);

            var frameTime = (DateTime.Now - frameStart).TotalMilliseconds;
            if (frameTime < msPerFrame)
            {
                var delay = (uint)(msPerFrame - frameTime);
                if (delay > 0) SDL_Delay(delay);
            }

            frameStart = DateTime.Now;
        }
    }
    catch (Exception e)
    {
        Console.WriteLine($"An error occurred: {e.Message}");
        Console.WriteLine(e.StackTrace);

        gb.Dump();

        return 1;
    }
    finally
    {
        Close(window, surface, renderer);
    }
}

byte[] GetTileData(GameBoy gb, ushort address)
{
    var result = new byte[16];
    for (var i = 0; i < 16; i++) result[i] = gb.PPU.VRAM[address + i];

    return result;
}

void DrawTile(GameBoy gb, Span<uint> pixels, byte[] tileData, int xx, int yy, int width)
{
    for (var y = 0; y < 8; y++)
    {
        var lsb = tileData[y * 2];
        var msb = tileData[y * 2 + 1];
        for (var x = 0; x < 8; x++)
        {
            var bit1 = (byte)(lsb >> (7 - x)) & 1;
            var bit2 = (byte)(msb >> (7 - x)) & 1;

            pixels[(yy + y) * width + xx + x] = gb.PPU.GetColor((byte)(bit1 | (bit2 << 1)));
        }
    }
}

unsafe bool Init(out IntPtr window, out SDL_Surface* surface, out IntPtr renderer)
{
    window = IntPtr.Zero;
    renderer = IntPtr.Zero;

    surface = null;

    if (!SDL_Init(SDL_INIT_VIDEO | SDL_INIT_EVENTS))
    {
        SDL_Log($"SDL could not initialize! SDL_Error: {SDL_GetError()}");
        return false;
    }

    if (SDL_CreateWindowAndRenderer("GB Emu", GB_SCREEN_WIDTH * SCALE_FACTOR, GB_SCREEN_HEIGHT * SCALE_FACTOR, 0,
            out window, out renderer) == false)
    {
        SDL_Log($"Window could not be created! SDL_Error: {SDL_GetError()}");
        return false;
    }

    surface = SDL_GetWindowSurface(window);

    return true;
}

unsafe void Close(IntPtr window, SDL_Surface* surface, IntPtr renderer)
{
    SDL_DestroySurface(new(surface));
    SDL_DestroyRenderer(renderer);
    SDL_DestroyWindow(window);
    SDL_Quit();
}

return 0;