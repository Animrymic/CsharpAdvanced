

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


Console.ReadLine();
