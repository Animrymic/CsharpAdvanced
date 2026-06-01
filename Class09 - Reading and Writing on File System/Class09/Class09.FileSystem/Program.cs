Console.WriteLine("Hello, World!");

#region Paths

Console.WriteLine("============================ PATHS ============================");

//ABSOLUTE PATHS
string studentRepoClassFullPath = @"C:\Users\Student\Documents\GitHub\REDACTED_PROJECT_NAME\README.md";
string studentRepoClassHomeworkFullPath = @"C:\Users\Student\Documents\GitHub\REDACTED_PROJECT_NAME\Class09.FileSystem\Homework";

//RELATIVE PATHS
string classReadmeRelavePath = @"..\..\..\README.md";

#endregion

#region Directory

Console.WriteLine("============================ DIRECTORY ============================");

string currentDirectory = Directory.GetCurrentDirectory();
Console.WriteLine($"Current Directory: {currentDirectory}");

string testFolderPath = @"..\..\..\TestFolder";
bool testFolderExists = Directory.Exists(testFolderPath);
Console.WriteLine($"Test Folder Exists: {testFolderExists}");

//Create a new folder if it does not exist
//if (!testFolderExists)
//{
//    Directory.CreateDirectory(testFolderPath);
//    Console.WriteLine("Test Folder created.");
//}
//else
//{
//    Console.WriteLine("Test Folder already exists.");
//}

//Delete the TestFolder

//if (Directory.Exists(testFolderPath))
//{
//    Directory.Delete(testFolderPath);
//    Console.WriteLine("Test Folder deleted.");
//}
//else
//{
//    Console.WriteLine("Test Folder does not exist, cannot delete.");
//}

#endregion

#region File

Console.WriteLine("============================ FILE ============================");

//check if a file exists 

string stestFolderPath = @"..\..\..\TestFolder";
string fileName = "example.txt";

//string filePath = $@"{testFolderPath}\{fileName}";  ==> with concatenation
string filePath = Path.Combine(stestFolderPath, fileName); //==> with Path.Combine

bool fileExists = File.Exists(filePath);

if (!Directory.Exists(stestFolderPath))
{
    Directory.CreateDirectory(testFolderPath);
}

if (!fileExists)
{
    File.Create(filePath);
}
else
{
    Console.WriteLine("File already exists, cannot create.");
}

// Delete the file
//if (File.Exists(filePath))
//{
//    File.Delete(filePath);
//    Console.WriteLine("File deleted.");
//}
//else
//{
//    Console.WriteLine("File does not exist, cannot delete.");
//}

// write in the file
File.WriteAllText(filePath, "Hello from SEDC!");

//Read from the file
string fileContent = File.ReadAllText(filePath);
Console.WriteLine($"File Content: {fileContent}");
#endregion

#region FileStreams
Console.WriteLine("============================ FILE STREAMS ============================");

string folderPath = @"..\..\..\TestFiles";

if (!Directory.Exists(folderPath))
{
    Directory.CreateDirectory(folderPath);
}

string filename = "notes.txt";
string fullFilePath = Path.Combine(folderPath, filename);

Console.WriteLine("============================ STREAM WRITER ============================");

try
{
    using (StreamWriter streamWriter = new StreamWriter(fullFilePath))
    {
        streamWriter.WriteLine("This is a sample note!");
        streamWriter.WriteLine("This file is created using StreamWriter.");
        streamWriter.WriteLine("Have a nice day!");
    }

    using (StreamWriter streamWriter = new StreamWriter(fullFilePath, true))
    {
        streamWriter.WriteLine("NEW This is a NEW sample note!");
        streamWriter.WriteLine("NEW This NEW file is created using StreamWriter.");
        streamWriter.WriteLine("NEW Have a NEW nice day!");
    }
}
catch (Exception ex)
{
    Console.WriteLine( "Error writing in file: " + ex.Message);
}

#endregion