namespace Class04.Extensions.Models;

public class Product
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }

    public override string GetInfo()
    {
        return $"{Id}) {Title} - {Description}";
    }
}
