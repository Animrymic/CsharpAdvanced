using Domain.Models;


#region Creating instances (objects)

Developer dev = new Developer("Bob", "Bobsky", 35, "+1 123 532 2343", new List<string> { "JavaScript",
"C#", "C++", }, 5);

Tester tester = new Tester("Jill", "Wayne", 24, "+1 223 305 1234", 10);

Operations operations = new Operations("Greg", "Gregsky", 38, "+1 123 434 5353", ["Optimus", 
"ProtoBeat", "Abacus"]);

DevOps devOps = new DevOps("John", "Doe", 29, "+1 123 123 1234", false, true);

QAEngineer qa = new QAEngineer("Steve", "Stevenson", 34, "+1 123 354 4323", ["Selenium",
"Playwright"]);

Console.WriteLine(tester.GetInfo());
Console.WriteLine(operations.GetInfo());
Console.WriteLine(devOps.GetInfo());
Console.WriteLine(qa.GetInfo());
Console.WriteLine(dev.GetInfo());
#endregion