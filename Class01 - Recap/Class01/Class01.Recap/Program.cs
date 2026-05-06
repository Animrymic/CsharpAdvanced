List<string> names = new List<string>();

Console.WriteLine("Enter names (type 'x' to stop):");

while (true)
{
    string input = Console.ReadLine();

    if (input.ToLower() == "x")
        break;

    names.Add(input);
}

Console.WriteLine("Enter a text:");
string text = Console.ReadLine();

string lowerText = text.ToLower();

Console.WriteLine("\nResults:");

foreach (var name in names)
{
    string lowerName = name.ToLower();
    int count = 0;
    int index = 0;

    while ((index = lowerText.IndexOf(lowerName, index)) != -1)
    {
        count++;
        index += lowerName.Length;
    }

    Console.WriteLine($"{name} appears {count} times.");
}

Console.WriteLine();