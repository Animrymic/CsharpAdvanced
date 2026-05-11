using Class03.StaticClasses.Helpers;

namespace Class03.StaticClasses.Models;

public class User : BaseEntity
{
    //public int Id { get; set; }
    private string username; 
    public string Username
    {
        get { return username;  }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("Username cannot be empty");
            }
            username = value;
        }
    }
    public string Address { get; set; }
    public List<Order> Orders { get; set; } = new List<Order>();

    public User()
    {
        
    }

    public User(string username, string address, List<Order> orders)
    {
        Username = username;
        Address = address;
        Orders = orders; 
    }

    public void PrintUsers()
    {
        ConsoleHelper.WriteInColor($"Orders of {Username}"); 

        for (int i = 0; i< Orders.Count; i++)
        {
            Console.WriteLine($"({i + 1}) {Orders[i].GetInfo()}");
        }
    }
}
