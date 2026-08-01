using System;

// Create an interface named IQuitable.
interface IQuitable
{
    // Any class using this interface must include a Quit method.
    void Quit();
}

// Create an Employee class that implements the IQuitable interface.
class Employee : IQuitable
{
    // Store the employee's first name.
    public string FirstName { get; set; }

    // Store the employee's last name.
    public string LastName { get; set; }

    // Create an Employee object with a first and last name.
    public Employee(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    // Implement the Quit method required by IQuitable.
    public void Quit()
    {
        Console.WriteLine(FirstName + " " + LastName + " has quit the job.");
    }
}

// Create the main program class.
class Program
{
    // This is where the program begins.
    static void Main(string[] args)
    {
        // Create an Employee object and store it as an IQuitable object.
        IQuitable employee = new Employee("John", "Smith");

        // Call the Quit method through the IQuitable interface.
        employee.Quit();

        // Keep the console window open.
        Console.ReadLine();
    }
}
