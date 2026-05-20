using LinqMethods.Data;
using LinqMethods.Entities;
using LinqMethods.Helpers;
using System.Data.Common;

ConsoleHelper.PrintInColor("\n======================================= LINQ =======================================\n", ConsoleColor.DarkCyan);
//LINQ - Language Integrated Query
//LINQ provides a consistent way to query and manipulate data from different sources (collections, databases, XML, etc.) using a common syntax and set of operators.
//It allows developers to write queries in a more readable and concise manner, often resembling SQL-like syntax.



ConsoleHelper.PrintInColor("\n======================================= Where =======================================\n", ConsoleColor.DarkYellow);
//Where - filter a collection based on a condition
//Find all students with the first name "Bob"
//Lambda - like LINQ

IEnumerable<Student> findBobsLambda = SEDC.Students
    .Where(s => s.FirstName.Equals("Bob", StringComparison.OrdinalIgnoreCase));

//SQL -like LINQ
IEnumerable<Student> findBobsSql = from s in SEDC.Students
                                   where s.FirstName == "Bob"
                                   select s;



ConsoleHelper.PrintInColor("\n======================================= Select =======================================\n", ConsoleColor.Yellow);
//Select - projects each element of a collection into a new form
//SelectMany - projects each element of a collection to an IEnumerable and flattens the resulting collections into one collection
//Select - transforms each element of a collection into a new form, while SelectMany flattens the resulting collections into a single collection

List<string> firstNames = SEDC.Students
    .Select(s => s.FirstName)
    .ToList();
firstNames.PrintSimple();

//Example: get students which are part time and have subjects from the programming acdemy
//SQL like syntax complex example
IEnumerable<Student> partTimeProgrammingStudentsSql = from student in SEDC.Students
                                                      where student.IsPartTime 
                                                      && (from subject in student.Subjects
                                                          where subject.Type == Academy.Programming
                                                          select subject).Count() != 0
                                                      select student;

// Lambda syntax complex example
List<Student> partTimeProgrammingStudentsLambda = SEDC.Students
    .Where(s => s.IsPartTime 
    && s.Subjects.Any(sub => sub.Type == Academy.Programming))
    .ToList();

ConsoleHelper.PrintInColor("\n======================================= First/Single/Last (OrDefault) =======================================\n", 
    ConsoleColor.DarkMagenta);
//First - returns the first element of a sequence that satisfies a condition or a default value if no such element is found
//Single - returns the only element of a sequence that satisfies a condition or a default value if no such element is found; this method throws an exception if there is more than one element in the sequence
//Last - returns the last element of a sequence that satisfies a condition or a default value if no such element is found
//OrDefault - returns a default value if the sequence contains no elements

Student petko = SEDC.Students.FirstOrDefault(s => s.FirstName == "Petko"); //This will return null because there is no student with the first name "Petko"

Student bob = SEDC.Students.SingleOrDefault(s => s.FirstName == "Bob"); //This will throw an exception because there are multiple students with the first name "Bob"

ConsoleHelper.PrintInColor("\n======================================= Any/All =======================================\n",
//Any - determines whether any element of a sequence satisfies a condition
//All - determines whether all elements of a sequence satisfy a condition

bool hasBob = SEDC.Students.Any(s => s.FirstName == "Bob"); //This will return true because there are students with the first name "Bob"

ConsoleHelper.PrintInColor("\n======================================= Distinct/DisticntBy =======================================\n",

List<string> distinctStudentNames = SEDC.Students
    .Select(s => s.FirstName)
    .Distinct()
    .ToList(); // This will return a list of distinct first names of students
