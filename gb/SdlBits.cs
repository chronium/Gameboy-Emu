using SDL3;

namespace gb;

using static SDL;
using static SDL.SDL_InitFlags;

public class SdlBits
{
    public static unsafe bool Init(int windowWidth, int windowHeight, out IntPtr window, out IntPtr renderer,
        out SDL_Surface* surface)
    {
        window = IntPtr.Zero;
        renderer = IntPtr.Zero;

        surface = null;

        var sdlInit = SDL_Init(SDL_INIT_VIDEO | SDL_INIT_EVENTS);
        if (sdlInit == false)
        {
            SDL_Log($"SDL could not initialize! SDL_Error: {SDL_GetError()}");
            return false;
        }

        var sdlCreateWindowAndRenderer =
            SDL_CreateWindowAndRenderer("GB Emu", windowWidth, windowHeight, 0, out window, out renderer);
        if (sdlCreateWindowAndRenderer == false)
        {
            SDL_Log($"Window could not be created! SDL_Error: {SDL_GetError()}");
            return false;
        }

        surface = SDL_GetWindowSurface(window);

        return true;
    }

    public static unsafe void Close(IntPtr window, SDL_Surface* surface, IntPtr renderer)
    {
        if (surface != null) SDL_DestroySurface((IntPtr)surface);
        if (renderer != 0) SDL_DestroyRenderer(renderer);
        if (window != 0) SDL_DestroyWindow(window);

        SDL_Quit();
    }
}

public class SdlTexture
{
    private readonly unsafe SDL_Texture* _handle;

    public SdlTexture(IntPtr renderer, int width, int height, SdlFormat sdlFormat = SdlFormat.Rgba32,
        SdlAccess sdlAccess = SdlAccess.Streaming,
        SdlScaleMode sdlScaleMode = SdlScaleMode.Nearest)
    {
        unsafe
        {
            _handle = SDL_CreateTexture(renderer, sdlFormat.ToSdlPixelFormat(), sdlAccess.ToSdlTextureAccess(), width,
                height);

            Width = width;
            Height = height;
            TextureSdlFormat = sdlFormat;
            TextureSdlAccess = sdlAccess;
            TextureSdlScaleMode = sdlScaleMode;

            if (_handle != null) return;

            SDL_Log($"Failed to create texture: {SDL_GetError()}");

            throw new("Failed to create texture");
        }
    }

    public int Width { get; }
    public int Height { get; }

    public SdlFormat TextureSdlFormat { get; }
    public SdlAccess TextureSdlAccess { get; }

    public SdlScaleMode TextureSdlScaleMode
    {
        get => field;
        set
        {
            SDL_SetTextureScaleMode(this, value.ToSdlScaleMode());
            field = value;
        }
    }

    public void Update(ref SDL_Rect dest, Action<Span<uint>, int> updateFunc)
    {
        if (!SDL_LockTexture(this, ref dest, out var pixels, out var pitch)) return;

        unsafe
        {
            updateFunc(new((void*)pixels, dest.w * dest.h), pitch);
        }

        SDL_UnlockTexture(this);
    }

    public static unsafe implicit operator SDL_Texture*(SdlTexture texture)
    {
        return texture._handle;
    }

    public static implicit operator IntPtr(SdlTexture texture)
    {
        unsafe
        {
            return (IntPtr)texture._handle;
        }
    }
}

public enum SdlAccess
{
    Streaming,
}

public enum SdlFormat
{
    Rgba32,
}

public enum SdlScaleMode
{
    Nearest,
}

public static class SdlBitsExtensions
{
    public static SDL_PixelFormat ToSdlPixelFormat(this SdlFormat format)
    {
        return format switch
        {
            SdlFormat.Rgba32 => SDL_PixelFormat.SDL_PIXELFORMAT_RGBA32,
            _ => throw new NotImplementedException(),
        };
    }

    public static SDL_TextureAccess ToSdlTextureAccess(this SdlAccess access)
    {
        return access switch
        {
            SdlAccess.Streaming => SDL_TextureAccess.SDL_TEXTUREACCESS_STREAMING,
            _ => throw new NotImplementedException(),
        };
    }

    public static SDL_ScaleMode ToSdlScaleMode(this SdlScaleMode scaleMode)
    {
        return scaleMode switch
        {
            SdlScaleMode.Nearest => SDL_ScaleMode.SDL_SCALEMODE_NEAREST,
            _ => throw new NotImplementedException(),
        };
    }
}