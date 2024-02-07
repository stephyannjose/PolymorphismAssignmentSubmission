using System;

// Define the IQuittable interface with a method Quit()
public interface IQuittable
{
    void Quit();
}

// Define the Employee class which inherits from IQuittable interface
class Employee : IQuittable
{
    // Implement the Quit() method defined in the interface
    public void Quit()
    {
        Console.WriteLine("Employee has quit the job.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create an object of type Employee
        Employee employee = new Employee();

        // Use polymorphism to create an object of type IQuittable
        // Since Employee class implements IQuittable interface, employee object can be treated as IQuittable
        IQuittable quittableEmployee = employee;

        // Call the Quit() method on the object of type IQuittable
        quittableEmployee.Quit();
    }
}
