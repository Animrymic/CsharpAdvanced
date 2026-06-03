#region Value and Reference Types
using Class10.Dispose_ManageResources;
using Class10.DisposeAndManageResources.Helpers;
using System.Diagnostics;

ExtendedConsole.PrintInColor("\n================ STACK and HEAP ================\n", ConsoleColor.Dark    Cyan);
ExtendedConsole.PrintInColor("\n============= VALUE TYPES and REFERENCE TYPES =============\n", ConsoleColor.Cyan);

Console.WriteLine("\n===== Value Types =====\n");
int num1 = 10;
int num2 = num1; // num2 gets a copy of the value in num1
num2 = 20; // Changing num2 does not affect num1
Console.WriteLine($"num1: {num1}, num2: {num2}");

Console.WriteLine("\n===== Reference Types =====\n");
List<int> ints1 = new List<int> { 1, 2, 3 };
List<int> ints2 = ints1; // ints2 references the same list as ints1
ints2[1] = 100; // Changing ints2 affects ints1 because they reference the same list

ints1.ForEach(Console.WriteLine); // Output: 1, 100, 3
ints2.ForEach(Console.WriteLine); // Output: 1, 100, 3

// Example User 
User john = new User("John", "Malkovic", 70);
User john2 = john; // john2 references the same User object as john
john2.Age = 32; // Changing john2's Age also changes john's Age because they reference the same object

User john3 = john2;
john3.LastName = "Doe";

john.PrintInfo(); // Output: John Doe, Age: 32
john2.PrintInfo(); // Output: John Doe, Age: 32
john3.PrintInfo(); // Output: John Doe, Age: 32

Console.WriteLine("\n===== Strings =====\n");

// Example *String*
string stringOne = "Hello";
string stringTwo = stringOne; // stringTwo references the same string as stringOne
stringTwo = "World"; // Changing stringTwo does not affect stringOne because strings are immutable

Console.WriteLine(stringOne);
Console.WriteLine(stringTwo);

#endregion

#region Objects Lifecycle

ExtendedConsole.PrintInColor("\n================ OBJECTS LIFECYCLE ================\n", ConsoleColor.Yellow);

static void TestObjectFinalizer()
{
    User bob = new User("Bob", "Bobsky", 34);
    User john = new User(firstName: "John", lastName: "Doe", age: 32);
    Console.WriteLine("Logic with bob object...");
    bob.PrintInfo();
    Console.WriteLine("More logic...");
    john.PrintInfo();
    Console.WriteLine("Okay we do not need the objects anymore. Throw them away :D");
}

TestObjectFinalizer();

#endregion

Console.WriteLine("dkaldaklsd");