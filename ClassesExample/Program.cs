
// See https://aka.ms/new-console-template for more information

using static Customer;

class Program
{
    static void Main(string[] args)
    { 
        var customer = new Customer(1, "john");
        Console.WriteLine(customer.Id);
        Console.WriteLine(customer.Name);
    }
}






