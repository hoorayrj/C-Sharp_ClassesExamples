using System.Collections.Generic;

public class Customer
{
    // Declare field
    public int Id;
    public string Name;
    public List<Order> Orders; // <Order> represents a generic object

    public Customer()
    {
        Orders = new List<Order>();
    }
    // Declar a constructor
    public Customer(int id)
        // using :this() it goes through the first constructor, which initilizes the Order list
        // then goes to here, and initializes the Id. 
        : this()
    {
        this.Id = id;
    }
    public Customer(int id, string name)
        : this(id)
    {
        this.Name = name;
    }
}






