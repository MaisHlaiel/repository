using System;

interface IQuitable
{
    void Quit();
}

class Employee : IQuitable
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public Employee(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    public void Quit()
    {
        Console.WriteLine(FirstName + " " + LastName + " has quit the job.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        IQuitable employee = new Employee("John", "Smith");
        employee.Quit();
        Console.ReadLine();
    }
}