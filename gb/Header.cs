using System.Runtime.InteropServices;
using System.Text;

namespace gb;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct GameBoyCartridgeHeader
{
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
    public byte[] EntryPoint; // 0x0100-0x0103

    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 48)]
    public byte[] NintendoLogo; // 0x0104-0x0133

    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 15)]
    public byte[] Title; // 0x0134-0x0142

    public byte CGBFlag; // 0x0143

    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
    public byte[] NewLicenseeCode; // 0x0144-0x0145

    public byte SGBFlag; // 0x0146
    public byte CartridgeType; // 0x0147
    public byte ROMSize; // 0x0148
    public byte RAMSize; // 0x0149
    public byte DestinationCode; // 0x014A
    public byte OldLicenseeCode; // 0x014B
    public byte MaskROMVersion; // 0x014C
    public byte HeaderChecksum; // 0x014D

    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
    public byte[] GlobalChecksum; // 0x014E-0x014F

    public static GameBoyCartridgeHeader FromBytes(byte[] data)
    {
        if (data.Length < Marshal.SizeOf<GameBoyCartridgeHeader>())
            throw new ArgumentException("Byte array is too small for a GameBoyCartridgeHeader");

        var handle = GCHandle.Alloc(data, GCHandleType.Pinned);
        try
        {
            return Marshal.PtrToStructure<GameBoyCartridgeHeader>(handle.AddrOfPinnedObject());
        }
        finally
        {
            handle.Free();
        }
    }

    public string GetTitle()
    {
        return Encoding.ASCII.GetString(Title).TrimEnd('\0');
    }
}