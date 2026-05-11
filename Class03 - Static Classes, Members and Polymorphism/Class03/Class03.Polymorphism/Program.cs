using Class03.Polymorphism.Models;
using Class03.Polymorphism.Services;

#region Runtime Polymorphism


Pet randomPet = new Pet
{
    Name = "Mali"
};
randomPet.Eat();

Cat zuza = new Cat
{
    Name = "Zuza",
    isLazy = true
};
zuza.Eat();

Dog aks = new Dog
{
    Name = "Aks"
};
aks.Eat();

#endregion

#region Compile-Time Polymorphism

PetService petService = new PetService();

petService.PrintPetInfo();
petService.PrintPetInfo(aks);
petService.PrintPetInfo(zuza);
petService.PrintPetInfo("David", aks);

#endregion