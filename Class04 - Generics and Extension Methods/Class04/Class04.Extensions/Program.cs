using Class04.Extensions.Helpers;
using System.Diagnostics;

List<int> integers = new List<int>() { 1, 2, 3, 4, 5 }; 
List<string> strings = ["str1", "str2", "str3"];

ListHelper.PrintItems<int>(integers);
ListHelper.PrintItems(strings);
integers.PrintItems();
strings.PrintItems();

integers.PrintListInfo(); 
