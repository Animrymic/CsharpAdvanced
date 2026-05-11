using Class03.Polymorphism.Models;

namespace Class03.Polymorphism.Services;

public class PetService
{
    public void PrintPetInfo()
    {
        Console.WriteLine("Some pet info");
    }

    public void PrintPetInfo(Cat cat)
    {
        Console.WriteLine($"This cat is {(cat.isLazy ? "Lazy" : "Not Lazy")}");
    }

    public void PrintPetInfo(Dog dog)
    {
        Console.WriteLine($"This dog is {(dog.isFriendly ? "Friendly" : "Not Friendly")}");
    }

    public void PrintPetInfo(string owner, Dog dog)
    {
        Console.WriteLine($"The owner {owner} has dog named {dog.Name}"); 
    }
}
