using Class04.Extensions.Helpers;
using Class04.Extensions.Helpers.PiggyBaking;
using Class04.Extensions.Models;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;

List<int> integers = new List<int>() { 1, 2, 3, 4, 5 }; 
List<string> strings = ["str1", "str2", "str3"];

//ListHelper.PrintItems<int>(integers);
//ListHelper.PrintItems(strings);
integers.PrintItems();
strings.PrintItems();

integers.PrintListInfo();

string bobLong = "Bob Bobsky";
string bobShorten = bobLong.Truncate(5);
Console.WriteLine(bobShorten);
Console.WriteLine("Bob Bobsky".Truncate(3));

string johnShort = StringExtensions.Truncate("John Doe", 6);
Console.WriteLine(johnShort);
Console.WriteLine(johnShort.Quote());

Product product = new Product
{
    Id = 1,
    Description = "Product Description",
    Title = "Product Title"
}; 
product.PrintInfo(product)
