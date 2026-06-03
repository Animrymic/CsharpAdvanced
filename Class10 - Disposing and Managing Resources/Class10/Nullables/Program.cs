using Class10.DisposeAndManageResources.Helpers;
using Nullables;

ExtendedConsole.PrintInColor("============= NULLABLES =============\n", ConsoleColor.Cyan);

//int number = null; This will cause a compile-time error because int is a non-nullable value type

int? number = null; // This is a nullable int, so it can hold a null value

double decimalNumber = 465.545; // Non-nullable double
double? decimalNum = null; // Nullable double

bool? isTrue = null; // Nullable bool

DateTime? date = null; // Nullable DateTime


string text = null;
string? text2 = null;

Person bob = new Person();
bob.Score = null;


Console.WriteLine("============ DISPOSING ============");

const string FolderPath = @"..\..\..\Text";
string filePath = Path.Combine(FolderPath, "text.txt");
string FilePath = filePath; // if you need a separate FilePath variable

static void CreateFolder(string path)
{
    if (!Directory.Exists(path))
    {
        Directory.CreateDirectory(path);
    }
}

static void CreateFile(string path)
{
    if (!File.Exists(path))
    {
        File.Create(path).Close(); 
    }
}

CreateFolder(FolderPath);
CreateFile(FilePath);

#region Manual Dispose Methods



#endregion