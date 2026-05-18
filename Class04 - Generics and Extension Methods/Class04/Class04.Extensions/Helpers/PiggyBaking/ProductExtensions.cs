using Class04.Extensions.Models;
//namespace Class04.Extensions.Helpers.PiggyBaking;
namespace Extensions;
public static class ProductExtensions
{
    public static void PrintInfo(this Product product)
    {
        Console.WriteLine(product.GetInfo());
    }
}
