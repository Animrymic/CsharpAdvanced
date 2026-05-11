using Class03.StaticClasses.Enums;
using Class03.StaticClasses.Helpers;
using Class03.StaticClasses.Models;

namespace Class03.StaticClasses;

public static class OrdersStaticDB
{
    public static List<Order> Orders { get; set; } = new List<Order>();
    public static List<User> Users { get; set; } = new List<User>();

    private static int orderIdCounter; 

    static OrdersStaticDB()
    {
        ConsoleHelper.WriteInColor("Hello from OrdersStaticDB static constructor", ConsoleColor.DarkMagenta);

        Orders = new List<Order>
        {
            new Order {Id = 1, Title = "Order 1", Description = "Description for order 1", Status = OrderStatus.Processing},
            new Order {Id = 2, Title = "Order 2", Description = "Description for order 2", Status = OrderStatus.Delivered},
            new Order {Id = 3, Title = "Order 3", Description = "Description for order 3", Status = OrderStatus.InProgress},
            new Order {Id = 4, Title = "Order 4", Description = "Description for order 4", Status = OrderStatus.Cancelled},
            new Order {Id = 5, Title = "Order 5", Description = "Description for order 5", Status = OrderStatus.InProgress}

        };

        Users = new List<User>
        {
            new User {Id = 1, Username = "bobsky123", Address = "Bobsky St."},
            new User {Id = 2, Username = "john456", Address = "John's St."}
        };

        Users[0].Orders.Add(Orders[0]);
        Users[0].Orders.Add(Orders[1]);
        Users[0].Orders.Add(Orders[2]);
        Users[1].Orders.Add(Orders[3]);
        Users[1].Orders.Add(Orders[4]);
    }
}
