using System;
using System.Reflection.Emit;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\nHello World! This is the OnlineOrdering Project.\n");

        // First order
        Address adress = new Address("123 Street", "Hermosillo", "Sonora", "Mexico");

        Customer customer = new Customer("sebas", adress);

        Order order = new Order(customer);

        Product p1 = new Product("Gaming Mouse", "M123", 350, 2);
        Product p2 = new Product("Mechanical Keyboard", "K456", 1200, 1);
        Product p3 = new Product("Monitor 27\" 144Hz", "MN789", 4200, 1);

        order.AddProduct(p1);
        order.AddProduct(p2);
        order.AddProduct(p3);

        Console.WriteLine("\n--- FIRST ORDER ---");
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order.GetShippingLabel());

        Console.WriteLine("Packing Label:");
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine($"Total Price: ${order.GetTotal()}");

        //Second order
        Address address2 = new Address("234 Elm Street", "Tri-County", "California", "USA");
        
        Customer customer2 = new Customer("Andy", address2);

        Order order2 = new Order(customer2);

        Product x1 = new Product("Woody Collectible Figure", "TS001", 85, 1);
        Product x2 = new Product("Buzz Lightyear Action Figure", "TS002", 120, 1);
        Product x3 = new Product("Mr. Potato Head Classic", "TS003", 50, 2);

        order2.AddProduct(x1);
        order2.AddProduct(x2);
        order2.AddProduct(x3);

        Console.WriteLine("\n--- SECOND ORDER ---");
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());

        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotal()}\n");

    }
}