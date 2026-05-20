using Class06.AnonymousMethods.Models;
using System.Security.Cryptography.X509Certificates;

List<string> names = ["Alice", "Bob", "Charlie", "John", "Anna"];
List<string> empty = [];

// One line lambda expression to find the name "John" in the list of names
string johnName = names.Find(name => name == "John")!;

string? john2 = names.Find(name =>
{
    if (name == "John")
    {
        return true;
    }
    return false;
});

// In JavaScript:
// let sum = (num1, num2) => num1 + num2;
// sum(10, 20); // Output: 30

//parameter 1 => int
//parameter 2 => int
//return type => int

Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("\n=============FUNC==============");
Console.ResetColor();

//var sum = (num1, num2) => num1 + num2;

//Example of a Func with 2 parameters
Func<int, int, int> sum = (num1, num2) => num1 + num2;
int sumResult = sum(10, 20);
Console.WriteLine(sumResult);

//Example of a Func with no parameters
Func<bool> isNamesEmpty = () => names.Count == 0;
Console.WriteLine("Is list empty: " + isNamesEmpty());

//Example of a Func with 1 parameter
Func<List<string>, bool> isListEmpty = (list) => list.Count == 0;
Console.WriteLine("The list names is: " + isListEmpty(names));
Console.WriteLine("The list empty is: " + isListEmpty(empty));

//Example of a Func with 2 parameters
Func<int, int, bool> isLarger = (num1, num2) =>
{
    if (num1 > num2)
    {
        return true;
    }
    return false;
};

Console.WriteLine("Is 20 larger than 10: " + isLarger(20, 10));
Console.WriteLine("Is 5 larger than 10: " + isLarger(5, 10));

//Example of a Func with 4 parameters
Func<int, string, double, bool, string> getUserInfo = (age, name, height, isStudent) =>
{
    return $"{name} is {age} years old, {height} meters tall, and {(isStudent ? "Yes" : "No")}";
};
Console.WriteLine(getUserInfo(25, "Alice", 1.65, true));
Console.WriteLine(getUserInfo(30, "Bob", 1.80, false));

// ===> Example of a Func that uses class as a type
Func<Person, string> getPersonName = person =>
{
    return person.Name;
};
Person bob = new Person {Name = "Bob"};
Console.WriteLine(getPersonName(bob));

// ===> Example of a Func that only prints Hello World
Action printHello = () =>
{
    Console.WriteLine("Hello");
};



