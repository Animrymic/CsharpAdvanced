using Domain.BaseEntity;

namespace Domain.Models;

public class QAEngineer : Person
{
    public List<string> TestingFrameworks { get; set; }

    public QAEngineer(
        string firstName,
        string lastName,
        int age,
        string mobileNumber,
        List<string> frameworks)
        : base(firstName, lastName, age, mobileNumber)
    {
        TestingFrameworks = frameworks;
    }

}
