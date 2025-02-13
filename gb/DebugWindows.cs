using System.Globalization;
using ImGuiNET;
using SDL3;

namespace gb;

using static SDL;

public partial class Application
{
    private void GlobalMenu(Data data)
    {
        if (ImGui.BeginMainMenuBar())
        {
            if (ImGui.BeginMenu("File"))
            {
                if (ImGui.MenuItem("Load ROM"))
                    FileDialog.Open(path =>
                    {
                        if (!string.IsNullOrEmpty(path)) LoadRom(path);
                    });

                if (ImGui.BeginMenu("Recent ROMs"))
                {
                    var recentRoms = data.GetRecentRomPaths();
                    foreach (var rom in recentRoms)
                    {
                        if (!ImGui.MenuItem(rom)) continue;

                        LoadRom(rom);
                        break;
                    }

                    if (recentRoms.Length == 0) ImGui.MenuItem("No recent ROMs");

                    ImGui.Separator();

                    if (ImGui.MenuItem("Clear"))
                    {
                        var recentRomsPath = Path.Combine(data.UserDataPath, "recent_roms.txt");
                        File.Delete(recentRomsPath);
                    }

                    ImGui.EndMenu();
                }


                ImGui.EndMenu();
            }

            if (ImGui.BeginMenu("Emu"))
            {
                var running = _runningMode == EmulatorRunningMode.Running;
                ImGui.Checkbox("Running", ref running);
                _runningMode = running ? EmulatorRunningMode.Running : EmulatorRunningMode.Stopped;

                if (ImGui.MenuItem("Reset"))
                {
                    // TODO: Reset
                }

                ImGui.EndMenu();
            }

            ImGui.EndMainMenuBar();
        }
    }

    private void Debugger()
    {
        if (ImGui.Begin("Debugger"))
        {
            if (ImGui.Button("Step")) _step = true;
            ImGui.SameLine();
            if (ImGui.Button("Continue")) _runningMode = EmulatorRunningMode.Running;
            ImGui.SameLine();
            if (ImGui.Button("Stop")) _runningMode = EmulatorRunningMode.Stopped;
            ImGui.SameLine();
            ImGui.Text($"Running: {_runningMode}");

            ImGui.DragFloat("Speed", ref _speedMultiplier, 0.01f, 0f, 1f);

            ImGui.Separator();

            if (ImGui.CollapsingHeader("Processor Breakpoints"))
            {
                ImGui.Columns(2);
                ImGui.SetColumnOffset(1, 85);

                ImGui.Separator();

                ImGui.PushItemWidth(70);
                if (ImGui.InputTextWithHint("##breakpoint", "XX:XXXX", ref _nextBreakpoint, 7,
                        ImGuiInputTextFlags.AutoSelectAll | ImGuiInputTextFlags.EnterReturnsTrue))
                {
                    // TODO: Bank
                    _breakpoints.Add(new(int.Parse(_nextBreakpoint, NumberStyles.HexNumber), 0));
                    _nextBreakpoint = "";
                }

                ImGui.PopItemWidth();

                if (ImGui.Button("Add##add_breakpoint", new(70, 0)))
                {
                    // TODO: Bank
                    _breakpoints.Add(new(int.Parse(_nextBreakpoint, NumberStyles.HexNumber), 0));
                    _nextBreakpoint = "";
                }

                if (ImGui.Button("Clear All##clear_all", new(70, 0))) _breakpoints.Clear();

                ImGui.NextColumn();

                ImGui.BeginChild("breakpoints", new(0, 80));

                foreach (var (breakpoint, i) in _breakpoints.Select((b, i) => (b, i)).ToList())
                {
                    if (ImGui.SmallButton($"X##remove_breakpoint_{i}")) _breakpoints.Remove(breakpoint);

                    ImGui.SameLine();
                    ImGui.TextColored(new(1, 0, 0, 1), $"{breakpoint.AddrString}");
                }

                ImGui.EndChild();
                ImGui.Columns(1);
                ImGui.Separator();
            }
        }

        ImGui.End();
    }

    private void MemoryWindow()
    {
        ImGui.Begin("Memory");
        ImGui.BeginTabBar("MemoryTabs");

        const int scale = 3;

        if (ImGui.BeginTabItem("VRAM"))
        {
            DrawVram();
            ImGui.Image(_vramTexture, new(20 * 8 * scale, 20 * 8 * scale));
            ImGui.EndTabItem();
        }

        if (ImGui.BeginTabItem("BG0"))
        {
            var bg = _gameBoy.PPU.GetBg0TileMap();
            DrawBg(_bg0Texture, new(bg.ToArray()));
            ImGui.Image(_bg0Texture, new(32 * 8 * scale, 32 * 8 * scale));
            ImGui.EndTabItem();
        }

        if (ImGui.BeginTabItem("BG1"))
        {
            var bg = _gameBoy.PPU.GetBg1TileMap();
            DrawBg(_bg1Texture, new(bg.ToArray()));
            ImGui.Image(_bg1Texture, new(32 * 8 * scale, 32 * 8 * scale));
            ImGui.EndTabItem();
        }

        ImGui.EndTabBar();
        ImGui.End();
        return;

        void DrawBg(SdlTexture bg, Memory<byte> tilemap)
        {
            var bgRect = new SDL_Rect { x = 0, y = 0, w = 32 * 8, h = 32 * 8 };

            bg.Update(ref bgRect, (pixels, pitch) =>
            {
                for (var y = 0; y < 32; y++)
                for (var x = 0; x < 32; x++)
                {
                    var tileIndex = tilemap.Span[x + y * 32];

                    var tileData = _gameBoy.PPU.GetBgTile(tileIndex);

                    DrawTile(_gameBoy, pixels, tileData, x * 8, y * 8, 32 * 8);
                }
            });
        }

        void DrawVram()
        {
            var vramRect = new SDL_Rect { x = 0, y = 0, w = 20 * 8, h = 20 * 8 };

            _vramTexture.Update(ref vramRect, (pixels, pitch) =>
            {
                for (var y = 0; y < 20; y++)
                for (var x = 0; x < 20; x++)
                {
                    var tileIndex = x + y * 20;

                    var tileData = _gameBoy.PPU.GetTileData((ushort)tileIndex);

                    DrawTile(_gameBoy, pixels, tileData, x * 8, y * 8, 20 * 8);
                }
            });
        }
    }

    private void DrawTile(GameBoy gb, Span<uint> pixels, Span<byte> tileData, int xx, int yy, int width)
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
}