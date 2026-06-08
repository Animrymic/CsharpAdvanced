using AdoNet.Demo.Models;
using Microsoft.Data.SqlClient;
using System.Data;

namespace AdoNet.Demo.DataAccess;

public class StudentRepository
{
    private readonly string _connectionString;

    public StudentRepository(string connectionString)
    {
        _connectionString = connectionString;
    }

    public List<Student> GetAllStudents()
    {
        List<Student> students = new List<Student>();

        //1) Establish a connection to the database
        //SqlConnection sqlConnection = new SqlConnection(_connectionString);
        //sqlConnection.Open();


        //sqlConnection.Close();
        using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
        {
            sqlConnection.Open();

            //2) Write the SQL query
            string query = @"SELECT 
	            s.ID,
	            s.FirstName,
	            s.LastName,
	            s.DateOfBirth,
	            s.EnrolledDate,
	            s.Gender,
	            s.NationalIdNumber,
	            s.StudentCardNumber
              FROM dbo.Student s";

            //3) Create a SqlCommand object
            using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))

            using (SqlDataReader reader = sqlCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    Student student = new Student
                    {
                        Id = reader.GetInt32(0),
                        FirstName = reader.IsDBNull(1) ? null : reader.GetString(1),
                        LastName = reader.IsDBNull(2) ? null : reader.GetString(2),
                        DateOfBirth = reader.IsDBNull(3) ? null : reader.GetDateTime(3),
                        EnrolledDate = reader.IsDBNull(4) ? null : reader.GetDateTime(4),
                        Gender = reader.IsDBNull(5) ? null : reader.GetString(5)[0],
                        NationalIdNumber = reader.IsDBNull(6) ? null : reader.GetInt64(6),
                        StudentCardNumber = reader.IsDBNull(7) ? null : reader.GetString(7)
                    };
                    students.Add(student);
                }
            }
        }

        return students;
    }

    public void InsertStudentSafe(Student student)
    {
        using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
        {
            sqlConnection.Open();
            string query = @"INSERT INTO dbo.Student (FirstName, LastName, DateOfBirth, EnrolledDate, Gender, NationalIdNumber, StudentCardNumber) 
                            VALUES (@FirstName, @LastName, @DateOfBirth, @EnrolledDate, @Gender, @NationalIdNumber, @StudentCardNumber)";

            using (SqlCommand command = new SqlCommand(query, sqlConnection))
            {
                command.Parameters.AddWithValue("@FirstName", student.FirstName);
                command.Parameters.AddWithValue("@LastName", student.LastName);
                command.Parameters.AddWithValue("@DateOfBirth", student.DateOfBirth);
                command.Parameters.AddWithValue("@EnrolledDate", student.EnrolledDate);
                command.Parameters.AddWithValue("@Gender", student.Gender);
                command.Parameters.AddWithValue("@NationalIdNumber", student.NationalIdNumber);
                command.Parameters.AddWithValue("@StudentCardNumber", student.StudentCardNumber);

                command.ExecuteNonQuery();
            }
        }
    }
    public void InsertStudentSqlInjection(Student student)
    {
        using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
        {
            sqlConnection.Open();
            string query = $"INSERT INTO dbo.Student (FirstName, LastName, DateOfBirth, EnrolledDate, Gender, NationalIdNumber, StudentCardNumber) " +
                           $"VALUES ('{student.FirstName}', '{student.LastName}', '{student.DateOfBirth:yyyy-MM-dd}', '{student.EnrolledDate:yyyy-MM-dd}', '{student.Gender}', {student.NationalIdNumber}, '{student.StudentCardNumber}')";

            using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
            {
                sqlCommand.ExecuteNonQuery();
            }
        }
    }
}