static class LogLine
{
    public static string Message(string logLine) => (logLine.Remove(0, logLine.IndexOf(':')+1).Trim()); 

    public static string LogLevel(string logLine)
    {
        int x = logLine.IndexOf(':');
        int y = logLine.Length - x;
        String z = logLine.Remove(x, y);
        return (z).Trim('[').Trim(']').ToLower();
    }
    
    public static string Reformat(string logLine) => $"{Message(logLine)} ({LogLevel(logLine)})";
}