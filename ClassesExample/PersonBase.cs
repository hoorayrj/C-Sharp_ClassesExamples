// See https://aka.ms/new-console-template for more information
public class PersonBase
{
    public class Person
    {
        // Class variable
        public string Name;

        // Class Method
        public void Introduce(string to)
        {
            // String template used here. 
            Console.WriteLine("Hi {0}, I am {1}", to, Name);
        }

        // Parse Method within the class to handle the string. Make it static so that it is accessible for the class
        // and not an object
        public static Person Parse(string str)
        {
            var parPerson = new Person();
            parPerson.Name = str;

            return parPerson;
        }
    }
}

/* Run this in the main program to run this class. Make sure to say 'using static PersonBase' in the beginning.
class Program
{
    static void Main(string[] args)
    { 
        var person = Person.Parse("John");

        person.Introduce("Ray");
    }
}
*/