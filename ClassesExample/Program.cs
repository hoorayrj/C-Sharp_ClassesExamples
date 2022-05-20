
// See https://aka.ms/new-console-template for more information

using static Customer;
﻿// See https://aka.ms/new-console-template for more information

class Program
{
    static void Main(string[] args)
    {
        var customer = new Customer();
        customer.Id = 1;
        customer.Name = "john";

        var order = new Order();
        customer.Orders.Add(order);

        Console.WriteLine(customer.Id);
        Console.WriteLine(customer.Name);

    }
}






