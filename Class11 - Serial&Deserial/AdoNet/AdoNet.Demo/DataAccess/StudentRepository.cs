using AdoNet.Demo.Models;
using Microsoft.Data.SqlClient;
using System.Data;

namespace AdoNet.Demo.DataAccess;

internal class StudentRepository
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
    
}
