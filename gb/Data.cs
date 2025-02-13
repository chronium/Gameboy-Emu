namespace gb;

public class Data
{
    public Data(string appName)
    {
        UserDataPath = GetUserDataPath(appName);

        if (!Directory.Exists(UserDataPath)) Directory.CreateDirectory(UserDataPath);
    }

    public string UserDataPath { get; }

    private static string GetUserDataPath(string appName)
    {
        string basePath;

        if (OperatingSystem.IsWindows())
            basePath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData); // %APPDATA%
        else if (OperatingSystem.IsMacOS())
            basePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Library",
                "Application Support");
        else // Linux
            basePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), ".config");

        return Path.Combine(basePath, appName);
    }

    public string[] GetRecentRomPaths()
    {
        var recentRomsPath = Path.Combine(UserDataPath, "recent_roms.txt");

        return !File.Exists(recentRomsPath) ? [] : File.ReadAllLines(recentRomsPath);
    }

    public void AddRecentRomPath(string romPath)
    {
        var recentRomsPath = Path.Combine(UserDataPath, "recent_roms.txt");

        var recentRoms = GetRecentRomPaths().ToList();

        recentRoms.Remove(romPath);

        recentRoms.Insert(0, romPath);

        if (recentRoms.Count > 10) recentRoms.RemoveAt(10);

        File.WriteAllLines(recentRomsPath, recentRoms);
    }
}