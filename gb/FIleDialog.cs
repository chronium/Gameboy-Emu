// MIT License - Copyright (c) Callum McGing
// This file is subject to the terms and conditions defined in
// LICENSE, which is part of this source code package

using System.Runtime.InteropServices;
using System.Text;
using SDL3;

namespace gb;

public class FileDialogFilters(params FileFilter[] filters)
{
    public readonly FileFilter[] Filters = filters;

    public static FileDialogFilters operator +(FileDialogFilters left, FileDialogFilters right)
    {
        return new(left.Filters.Concat(right.Filters).ToArray());
    }
}

public class FileFilter(string name, params string[] exts)
{
    public readonly string[] Extensions = exts;
    public readonly string Name = name;
}

public static class FileDialog
{
    internal static IntPtr Sdl3Handle = IntPtr.Zero;

    public static unsafe void Open(Action<string> onOpen, FileDialogFilters? filters = null, string? defaultPath = null)
    {
        if (Sdl3Handle == IntPtr.Zero) return;

        using var sf = SdlFilters.Create(filters);

        SDL.SDL_DialogFileCallback cb = Callback;
        var cbh = GCHandle.Alloc(cb, GCHandleType.Normal);
        SDL.SDL_ShowOpenFileDialog(cb,
            (IntPtr)cbh,
            Sdl3Handle,
            new((void*)sf.Pointer, (int)sf.Count),
            (int)sf.Count,
            defaultPath,
            true);
        return;

        void Callback(IntPtr userdata, IntPtr fileList, int filter)
        {
            var self = GCHandle.FromIntPtr(userdata);
            self.Free();
            if (fileList == IntPtr.Zero)
                return;
            var files = (IntPtr*)fileList;
            if (*files == IntPtr.Zero)
                return;
            onOpen(Marshal.PtrToStringUTF8(*files) ?? string.Empty);
        }
    }

    public static unsafe void ChooseFolder(Action<string> onOpen)
    {
        if (Sdl3Handle == IntPtr.Zero) return;

        SDL.SDL_DialogFileCallback cb = Callback;
        var cbh = GCHandle.Alloc(cb, GCHandleType.Normal);
        SDL.SDL_ShowOpenFolderDialog(cb, (IntPtr)cbh, Sdl3Handle, null, false);
        return;

        void Callback(IntPtr userdata, IntPtr fileList, int filter)
        {
            var self = GCHandle.FromIntPtr(userdata);
            self.Free();
            if (fileList == IntPtr.Zero)
                return;
            var files = (IntPtr*)fileList;
            if (*files == IntPtr.Zero)
                return;
            onOpen(Marshal.PtrToStringUTF8(*files) ?? string.Empty);
        }
    }

    public static unsafe void Save(Action<string> onSave, FileDialogFilters? filters = null)
    {
        if (Sdl3Handle == IntPtr.Zero) return;
        using var sf = SdlFilters.Create(filters);

        SDL.SDL_DialogFileCallback cb = Callback;
        var cbh = GCHandle.Alloc(cb, GCHandleType.Normal);
        SDL.SDL_ShowSaveFileDialog(cb,
            (IntPtr)cbh,
            Sdl3Handle,
            new((void*)sf.Pointer, (int)sf.Count),
            (int)sf.Count,
            null);
        return;

        void Callback(IntPtr userdata, IntPtr fileList, int filter)
        {
            var self = GCHandle.FromIntPtr(userdata);
            self.Free();
            if (fileList == IntPtr.Zero)
                return;
            var files = (IntPtr*)fileList;
            if (*files == IntPtr.Zero)
                return;
            onSave(Marshal.PtrToStringUTF8(*files) ?? string.Empty);
        }
    }

    private unsafe struct Utf8Native : IDisposable
    {
        public IntPtr Pointer;

        public static implicit operator void*(Utf8Native str)
        {
            return (void*)str.Pointer;
        }

        public static implicit operator byte*(Utf8Native str)
        {
            return (byte*)str.Pointer;
        }

        public void Dispose()
        {
            if (Pointer != IntPtr.Zero)
                Marshal.FreeHGlobal(Pointer);
        }

        public static Utf8Native Create(string str)
        {
            if (RuntimeInformation
                .IsOSPlatform(OSPlatform.Windows))
                return new() { Pointer = Marshal.StringToHGlobalUni(str) };
            return new() { Pointer = UnsafeHelpers.StringToHGlobalUtf8(str) };
        }
    }

    private unsafe struct SdlFilters : IDisposable
    {
        public IntPtr Pointer;
        public uint Count;
        private List<IntPtr> _toFree;

        public static SdlFilters Create(FileDialogFilters? filters)
        {
            var f = new SdlFilters();
            f._toFree = [];
            var fitems = filters?.Filters ?? [];
            var items =
                (SDL.SDL_DialogFileFilter*)Marshal.AllocHGlobal(
                    sizeof(SDL.SDL_DialogFileFilter) * (fitems.Length + 1));
            for (var i = 0; i < fitems.Length; i++)
            {
                var n = Utf8Native.Create(fitems[i].Name);
                var spec = Utf8Native.Create(string.Join(';', fitems[i].Extensions));
                items[i].name = n;
                items[i].pattern = spec;
                f._toFree.Add(n.Pointer);
                f._toFree.Add(spec.Pointer);
            }

            var afn = Utf8Native.Create("All Files");
            var afp = Utf8Native.Create("*");
            items[fitems.Length].name = afn;
            items[fitems.Length].pattern = afp;
            f._toFree.Add(afn.Pointer);
            f._toFree.Add(afp.Pointer);
            f.Count = (uint)(fitems.Length + 1);
            f.Pointer = (IntPtr)items;
            f._toFree.Add((IntPtr)items);
            return f;
        }

        public void Dispose()
        {
            foreach (var p in _toFree)
                Marshal.FreeHGlobal(p);
        }
    }
}

public static class UnsafeHelpers
{
    public static byte[] CastArray<T>(T[] src) where T : struct
    {
        var sz = Marshal.SizeOf(typeof(T));
        var dst = new byte[src.Length * sz];
        Buffer.BlockCopy(src, 0, dst, 0, dst.Length);
        return dst;
    }

    public static unsafe IntPtr StringToHGlobalUtf8(string str)
    {
        var bytes = Encoding.UTF8.GetBytes(str);
        var ptr = Marshal.AllocHGlobal(bytes.Length + 1);
        Marshal.Copy(bytes, 0, ptr, bytes.Length);
        ((byte*)ptr)[bytes.Length] = 0;
        return ptr;
    }
}