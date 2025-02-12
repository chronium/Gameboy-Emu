using ImGuiNET;
using SDL3;

namespace gb;

using static SDL;

public enum EmulatorRunningMode
{
    Running,
    Stopped,
}

public partial class Application
{
    private const int CYCLES_PER_FRAME = 70224;

    private const int GB_SCREEN_WIDTH = 160;
    private const int GB_SCREEN_HEIGHT = 144;

    private const int SCREEN_FPS = 60;

    private readonly HashSet<Breakpoint> _breakpoints = [];

    private readonly GameBoy _gameBoy = new();
    private SdlTexture _bg0Texture;
    private SdlTexture _bg1Texture;
    private bool _disableAllBreakpoints;

    private string _nextBreakpoint = "";
    private Action<Application>? _onQuit;
    private IntPtr _renderer;

    private bool _running;

    private EmulatorRunningMode _runningMode;
    private SdlTexture _screenTexture;
    private float _speedMultiplier = 1.0f;
    private bool _step;
    private unsafe SDL_Surface* _surface = null;

    private SdlTexture _vramTexture;

    private IntPtr _window;
    private int _windowHeight;

    private int _windowWidth;

    public Application Init(int windowWidth, int windowHeight, string romPath = "")
    {
        _windowWidth = windowWidth;
        _windowHeight = windowHeight;
        _runningMode = EmulatorRunningMode.Stopped;

        unsafe
        {
            if (!SdlBits.Init(_windowWidth, _windowHeight, out _window, out _renderer, out _surface)) Quit();
        }

        _vramTexture = new(_renderer, 20 * 8, 20 * 8);
        _bg0Texture = new(_renderer, 32 * 8, 32 * 8);
        _bg1Texture = new(_renderer, 32 * 8, 32 * 8);

        _screenTexture = new(_renderer, GB_SCREEN_WIDTH, GB_SCREEN_HEIGHT);

        FileDialog.Sdl3Handle = _window;

        InitImGui();

        LoadBootRom();

        if (!string.IsNullOrEmpty(romPath)) LoadRom(romPath);

        return this;
    }

    public void Run()
    {
        _running = true;
        var frameStart = DateTime.Now;

        const double msPerFrame = 1000.0 / SCREEN_FPS;

        while (_running)
        {
            while (SDL_PollEvent(out var @event))
            {
                unsafe
                {
                    ImGui_SDL3.ImGui_ImplSDL3_ProcessEvent(&@event);
                }

                if (@event.type == (uint)SDL_EventType.SDL_EVENT_QUIT)
                    _running = false;
            }

            Update();

            Render();

            var frameTime = (DateTime.Now - frameStart).TotalMilliseconds;
            if (frameTime < msPerFrame)
            {
                var delay = (uint)(msPerFrame - frameTime);
                if (delay > 0) SDL_Delay(delay);
            }

            frameStart = DateTime.Now;
        }

        Quit();
    }

    private void Update()
    {
        ImGui_SDL3.ImGui_ImplSDLRenderer3_NewFrame();
        ImGui_SDL3.ImGui_ImplSDL3_NewFrame();
        ImGui.NewFrame();

        GlobalMenu();
        Debugger();
        MemoryWindow();
        _gameBoy.CpuState.ImGuiRegistersDisplay();

        if (_step && _runningMode == EmulatorRunningMode.Stopped)
        {
            _gameBoy.Step();
            _step = false;
        }
        else if (_runningMode == EmulatorRunningMode.Running)
        {
            var cyclesToEmulate = (int)(CYCLES_PER_FRAME * _speedMultiplier);

            while (cyclesToEmulate > 0)
            {
                foreach (var breakpoint in _breakpoints)
                {
                    if (breakpoint.Address != _gameBoy.CpuState.PC) continue;

                    _runningMode = EmulatorRunningMode.Stopped;
                    break;
                }

                var cycles = _gameBoy.Step();
                cyclesToEmulate -= cycles;
            }
        }
    }

    private void Render()
    {
        SDL_RenderClear(_renderer);

        var rect = new SDL_Rect { x = 0, y = 0, w = GB_SCREEN_WIDTH, h = GB_SCREEN_HEIGHT };
        _screenTexture.Update(ref rect, (pixels, pitch) => { _gameBoy.PPU.FrameBuffer.CopyTo(pixels); });

        const int scaleFactor = 8;

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
            w = GB_SCREEN_WIDTH * scaleFactor,
            h = GB_SCREEN_HEIGHT * scaleFactor,
        };

        SDL_RenderTexture(_renderer, _screenTexture, ref srect, ref drect);

        ImGui.Render();

        ImGui_SDL3.ImGui_ImplSDLRenderer3_RenderDrawData(ImGui.GetDrawData(), _renderer);

        SDL_RenderPresent(_renderer);
    }

    private void Quit()
    {
        _onQuit?.Invoke(this);
        unsafe
        {
            SdlBits.Close(_window, _surface, _renderer);
        }
    }

    public Application OnQuit(Action<Application> onQuit)
    {
        _onQuit = onQuit;
        return this;
    }

    private void InitImGui()
    {
        ImGui.CreateContext();
        ImGui.StyleColorsDark();

        ImGui_SDL3.ImGui_ImplSDL3_InitForSDLRenderer(_window, _renderer);
        ImGui_SDL3.ImGui_ImplSDLRenderer3_Init(_renderer);
    }

    private void LoadBootRom()
    {
        var bootRom = File.ReadAllBytes("dmg_bootrom.bin");

        _gameBoy.LoadBootRom(bootRom);
    }

    private void LoadRom(string romPath)
    {
        var rom = File.ReadAllBytes(romPath);

        _gameBoy.LoadRom(rom);
        SDL_SetWindowTitle(_window, $"{_gameBoy.CartridgeHeader?.GetTitle() ?? "GB Emu"}");
    }

    private class Breakpoint(int address, int bank)
    {
        public readonly int Address = address;

        public string AddrString => $"{bank:X2}:{Address:X4}";
    }
}