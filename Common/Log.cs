namespace Lab_10;

public static class Log
{
    private static DateTime _now = new(2026, 11, 20, 9, 0, 0);

    public static void Write(string source, string message)
    {
        Console.WriteLine($"[{_now:HH:mm:ss}] [{source}] {message}");
        _now = _now.AddSeconds(5);
    }

    public static void Section(string title) =>
        Console.WriteLine($"\n===== {title} =====");
}