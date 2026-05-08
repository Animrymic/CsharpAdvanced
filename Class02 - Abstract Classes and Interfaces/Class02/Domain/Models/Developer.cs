using Domain.BaseEntity;
using Domain.Interfaces;

namespace Domain.Models;

public class Developer : Person, IDeveloper
{
    public List<string> ProgrammingLanguages { get; set; }
    public int YearsOfExperience { get; set; }

    public Developer(
        string firstName, 
        string lastName, 
        int age, 
        string mobileNumber, 
        List<string> programmingLanguages, 
        int yearsOfExperience)
        : base(firstName, lastName, age, mobileNumber)
    {
        ProgrammingLanguages = programmingLanguages;
        YearsOfExperience = yearsOfExperience;
    }

    public override string GetInfo()
    {
        return $"{GetFullName()} ({Age}) - {YearsOfExperience} years of experience. Knows: {string.Join(", ", ProgrammingLanguages)}"; 
    }

    public void Code()
    {
        Console.WriteLine("Tak tak tak...");
        Console.WriteLine("Typing prompt to Claude...");
        Console.WriteLine("Ctrl C + Ctrl V");
    }
}
