namespace Class03.Polymorphism.Models;

public class Dog: Pet 
{
    public bool isFriendly { get; set; }
    public override void Eat()
    {
        Console.WriteLine($"The {(isFriendly ? "Friendly" : "")} dog {Name} is eating...");
    }
}
