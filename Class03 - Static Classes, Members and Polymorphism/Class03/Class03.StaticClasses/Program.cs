using Class03.StaticClasses;
using Class03.StaticClasses.Helpers;

//Console.ForegroundColor = ConsoleColor.Blue;
//Console.WriteLine("====== Welcome to Order Management System ======");
//Console.ResetColor();

ConsoleHelper.WriteInColor("====== Welcome to Order Management System ======", ConsoleColor.Blue);

Console.WriteLine(OrdersStaticDB.Users.Count);

Console.ReadLine(); 