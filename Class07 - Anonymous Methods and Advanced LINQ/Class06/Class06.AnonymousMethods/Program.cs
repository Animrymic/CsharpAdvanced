List<string> names = ["Alice", "Bob", "Charlie", "John", "Anna"];
List<string> empty = [];

string johnName = names.Find(name => name == "John");

Console.WriteLine(johnName);