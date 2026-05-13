namespace Class04.Extensions.Helpers;

public static class ListHelper
{
    public static void PrintItems<T>(List<T> items)
    {
        foreach (T item in items)
        {
            Console.WriteLine(item);
        }
    }
}
