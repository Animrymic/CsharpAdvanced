using Domain.BaseEntity;
using Domain.Interfaces;

namespace Domain.Models;

public class Operations : Person, IOperations
{
    public List<string> Projects { get; set; } = new();

    public Operations(
        string firstName, 
        string lastName, 
        int age, 
        string mobileNumber,
        List<string> projects) 
        : base(firstName, lastName, age, mobileNumber)
    {
        Projects = projects;
    }

    public override string GetInfo()
    {
        return $"{GetFullName()} ({Age}) - Currently working on {Projects.Count} projects";
    }

    public bool CheckInfrastructure(int status)
    {
        throw new NotImplementedException();
    }
}
