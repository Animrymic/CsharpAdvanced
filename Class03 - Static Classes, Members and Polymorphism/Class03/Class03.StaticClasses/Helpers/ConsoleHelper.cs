namespace Class03.StaticClasses.Helpers;

public static class ConsoleHelper
{
        public static void WriteInColor(string message, ConsoleColor
        color = ConsoleColor.White)
    {
        Console.ForegroundColor = color;
        Console.WriteLine(message);
        Console.ResetColor();
    }

    public static void WriteError(string message)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(message);
        Console.ResetColor(); 
    }
}
