using Domain.BaseEntity;

namespace Domain.Models;

public class Developer : Person 
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
}
