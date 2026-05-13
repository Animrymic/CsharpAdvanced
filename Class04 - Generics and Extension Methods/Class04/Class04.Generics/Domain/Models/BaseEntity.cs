namespace Class04.Generics.Domain.Models;

public abstract class BaseEntity
{
    public int Id { get; set; }
    public abstract string GetInfo();
}
