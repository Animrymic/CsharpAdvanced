using Domain.BaseEntity;
using Domain.Interfaces;

namespace Domain.Models;

public class DevOps : Person, IDeveloper, IOperations
{
    public bool AWSCertified { get; set; }
    public bool AzureCertified { get; set; }
    public DevOps(
        string firstName, 
        string lastName, 
        int age, 
        string mobileNumber,
        bool hasAwsCertificate,
        bool hasAzureCertificate) 
        : base(firstName, lastName, age, mobileNumber)
    {
        AWSCertified = hasAwsCertificate;
        AzureCertified = hasAzureCertificate;
    }

    public override string GetInfo()
    {
        return $"{GetFullName()} ({Age}) - Has: {(AWSCertified ? "AWS Certificate" : "")} {(AzureCertified ? "Azure Certificate" : "")} {(AWSCertified || AzureCertified ? "" : "No certificates yet!")}";
    }

    public void Code()
    {
        Console.WriteLine("Tak tak tak");
        Console.WriteLine("Create pipeline...");
        Console.WriteLine("Tak tak tak");
    }

    public bool CheckInfrastructure(int status)
    {
        if (status >= 200 || status < 300)
        {
            return true;
        }
        return false;
    }
}
