using AdoNet.Demo.DataAccess;
using AdoNet.Demo.Models;

const string ConnectionString = "Server=.\\SQLEXPRESS;Database=SEDC_DEMO_SHARP;Trusted_Connection=True;Integrated Security=True;Encrypt=False;";

StudentRepository studentRepository = new StudentRepository(ConnectionString);

List<Student> allStudents = studentRepository.GetAllStudents();

Console.WriteLine("All students:");
foreach (Student student in allStudents)
{
    Console.WriteLine(student);
}

string firstName = Console.ReadLine();

Student student1 = new Student
{
    FirstName = firstName,
    LastName = "Smith",
    DateOfBirth = DateTime.UtcNow.AddYears(-67),
    EnrolledDate = DateTime.UtcNow,
    Gender = 'F',
    NationalIdNumber = 11232314214,
    StudentCardNumber = "sc-123454"
};

studentRepository.InsertStudentSafe(student1);

Console.ReadLine();
