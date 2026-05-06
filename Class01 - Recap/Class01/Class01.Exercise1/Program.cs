List<string> names = new List<string>();
string input;

Console.WriteLine("Please enter names (Press x to stop): ");

while (true)
{
    input = Console.ReadLine(); 

    if(input.ToLower() == "x")
    {
        break;
    }

    if (!string.IsNullOrWhiteSpace(input))
        names.Add(input); 
}

Console.WriteLine("Enter a text: ");
string text = Console.ReadLine();

Console.WriteLine("\n Occurances: ");

//foreach (var name in names)
{
    //int count = 0;

    //string lowerText = text.ToLower();
    // string lowerName = name.ToLower();

    //int index = 0;

    // while ((index = lowerText.IndexOf(lowerName, index)) != -1)
    //{
    //  count++;
    //   index += lowerName.Length; 
    // }

    //Console.WriteLine($"{name}: {count}");
    //}

    foreach (var name in names)
    {
        int count = 0;
        string currentWord = "";
        string lowerName = name.ToLower();

        for (int i = 0; i < text.Length; i++)
        {
            char c = text[i];

            if (c != ' ' && c != '.' && c != ',' && c != '!' && c != '?' &&
                c != ';' && c != ':' && c != '-' && c != '\n' && c != '\t')
            {
                currentWord += char.ToLower(c);
            }
            else
            {
                if (currentWord == lowerName)
                {
                    count++;
                }

                currentWord = "";
            }
        }

        if (currentWord == lowerName)
        {
            count++;
        }

        Console.WriteLine($"{name}: {count}");
    }
}