namespace Hospital.App;

public static class ConsoleHelper
{
    private static void PrintLine(string message, ConsoleColor color)
    {
        Console.ForegroundColor = color;
        Console.WriteLine(message);
        Console.ResetColor();
    }
    
    private static void Print(string message, ConsoleColor color)
    {
        Console.ForegroundColor = color;
        Console.Write(message);
        Console.ResetColor();
    }

    #region Print

    public static void PrintInfo(string message)
    {
        PrintLine(message, ConsoleColor.Blue);
    }
    
    public static void PrintError(string message)
    {
        PrintLine(message, ConsoleColor.Red);
    }
    
    public static void PrintWarning(string message)
    {
        PrintLine(message, ConsoleColor.Yellow);
    }
    
    public static void PrintSuccess(string message)
    {
        PrintLine(message, ConsoleColor.Green);
    }

    #endregion

    #region Input

    public static string Input(string message)
    {
        Print(message, ConsoleColor.Cyan);
        return Console.ReadLine();
    }
    
    public static int InputNumber(string message)
    {
        Print(message, ConsoleColor.Cyan);
        return Convert.ToInt32(Console.ReadLine());
    }

    #endregion
    
}