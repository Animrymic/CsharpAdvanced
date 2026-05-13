using Class04.Generics.Domain.Data;
using Class04.Generics.Domain.Models;
using Class04.Generics.Helpers;
using System.Collections;


//List<int> integers = new List<int>() { 1, 2, 3, 4, 5 }; 
//List<string> strings = ["str1", "str2", "str3"]; 
//List<bool> booleans = new List<bool>() { true, false, true };


//NonGenericListHelper nonGenericListHelper = new NonGenericListHelper();

//nonGenericListHelper.PrintStrings(strings);
//nonGenericListHelper.PrintInfoForStrings(strings);

//nonGenericListHelper.PrintIntegers(integers);
//nonGenericListHelper.PrintInfoForIntegers(integers);

//nonGenericListHelper.PrintBooleans(booleans);
//nonGenericListHelper.PrintInfoForBooleans(booleans);

//GenericListHelper genericListHelper = new GenericListHelper();
//GenericListHelper.PrintItemsInfo<string>(strings);
//genericListHelper.PrintItems<string>(strings);

//Console.WriteLine("=====================================================");

//GenericListHelper.PrintItemsInfo<int>(integers);
//genericListHelper.PrintItems<int>(integers);

//Console.WriteLine("=====================================================");

//GenericListHelper.PrintItemsInfo<bool>(booleans);
//genericListHelper.PrintItems<bool>(booleans);

//Console.WriteLine("=====================================================");


#region Generic Classes

GenericDB<Order> OrdersDb = new GenericDB<Order>();
GenericDB<Product> ProductsDb = new GenericDB<Product>();

// Inserting data 

OrdersDb.Insert(new Order { Id = 1, Address = "Bob St.", Receiver = "Bob" });
OrdersDb.Insert(new Order { Id = 2, Address = "John St.", Receiver = "John" });
OrdersDb.Insert(new Order { Id = 3, Address = "Jane St.", Receiver = "Jane" });

ProductsDb.Insert(new Product { Id = 1, Title = "Mouse", Description = "Wireless mouse" });
ProductsDb.Insert(new Product { Id = 2, Title = "USB", Description = "64MB" });

//Printing data 

OrdersDb.PrintAll();
ProductsDb.PrintAll();

//GenericDB<Developer> DevelopersDb = new GenericDB<Developer>(); 

#endregion

