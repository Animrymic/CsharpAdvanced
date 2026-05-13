namespace Class04.Generics.Helpers;

public class GenericListHelper
{
    public void PrintItems<T>(List<T> items)
    {
        foreach (T item in items)
        {
            Console.WriteLine(item);        
        }
    }

    public static void PrintItemsInfo<T>(List<T> items)
    {
        string elementType = typeof(T).Name;

        Console.WriteLine($"This list has {items.Count} elements and is of type {elementType}");
    } 
}
