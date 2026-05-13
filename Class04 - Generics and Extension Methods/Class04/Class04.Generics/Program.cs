using Class04.Generics.Helpers;
using System.Collections;


List<int> integers = new List<int>() { 1, 2, 3, 4, 5 }; 
List<string> strings = ["str1", "str2", "str3"]; 
List<bool> booleans = new List<bool>() { true, false, true };


NonGenericListHelper nonGenericListHelper = new NonGenericListHelper();

//nonGenericListHelper.PrintStrings(strings);
//nonGenericListHelper.PrintInfoForStrings(strings);

//nonGenericListHelper.PrintIntegers(integers);
//nonGenericListHelper.PrintInfoForIntegers(integers);

//nonGenericListHelper.PrintBooleans(booleans);
//nonGenericListHelper.PrintInfoForBooleans(booleans);

GenericListHelper genericListHelper = new GenericListHelper();
GenericListHelper.PrintItemsInfo<string>(strings);
genericListHelper.PrintItems<string>(strings);

Console.WriteLine("=====================================================");

GenericListHelper.PrintItemsInfo<int>(integers);
genericListHelper.PrintItems<int>(integers);

Console.WriteLine("=====================================================");

GenericListHelper.PrintItemsInfo<bool>(booleans);
genericListHelper.PrintItems<bool>(booleans);

Console.WriteLine("=====================================================");


