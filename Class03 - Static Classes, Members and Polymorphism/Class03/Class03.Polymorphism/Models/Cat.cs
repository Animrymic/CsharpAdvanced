namespace Class03.Polymorphism.Models;

public class Cat : Pet
{
    public bool isLazy { get; set; }

    public void SayHello()
    {
        Console.WriteLine($"Cat {Name} says hello!");
    }

    public override void Eat()
    {
        Console.WriteLine($"The {(isLazy ? "Lazy" : "")} cat {Name} is eating..."); 
    }
}
