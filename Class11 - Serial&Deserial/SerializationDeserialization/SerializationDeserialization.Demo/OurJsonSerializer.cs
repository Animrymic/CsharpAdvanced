using System.Text;

namespace SerializationDeserialization.Demo;

internal static class OurJsonSerializer
{
    public static string SerializeStudent(Student student)
    {
        //string json = $"{{\n";
        //json += $"    \"firstName\": \"{student.FirstName}\",\n";
        //json += $"    \"lastName\": \"{student.LastName}\",\n";
        //json += $"    \"age\": {student.Age},\n";
        //json += $"    \"isPartTime\": {student.IsPartTime.ToString().ToLower()}\n";
        //json += $"}";
        //return json;

        //Using StringBuilder 
        //StringBuilder is more efficient than string concatenation, especially when building complex strings or when the number of concatenations is large.
        var sb = new StringBuilder();
        sb.AppendLine("{");
        sb.AppendLine($"    \"firstName\": \"{student.FirstName}\",");
        sb.AppendLine($"    \"lastName\": \"{student.LastName}\",");
        sb.AppendLine($"    \"age\": {student.Age},");
        sb.AppendLine($"    \"isPartTime\": {student.IsPartTime.ToString().ToLower()}");
        sb.AppendLine("}");
        return sb.ToString();
    }

    public static Student DeSerializeStudent(string json)
    {
        var student = new Student();

        var properties = json.Trim('{', '}').Split(new[] { ",\n" }, StringSplitOptions.RemoveEmptyEntries);

        foreach (var prop in properties)
        {
            var keyValue = prop.Split(new[] { ": " }, StringSplitOptions.RemoveEmptyEntries);

            var key = keyValue[0].Trim(' ', '"');
            var value = keyValue[1].Trim(' ', '"');

            switch (key)
            {
                case "firstName":
                    student.FirstName = value;
                    break;
                case "lastName":
                    student.LastName = value;
                    break;
                case "age":
                    student.Age = int.Parse(value);
                    break;
                case "isPartTime":
                    student.IsPartTime = bool.Parse(value);
                    break;
            }
        }
        return student; 
    }

}


