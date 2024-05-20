// Define the abstract class Person
public abstract class Person
{
    // Private attributes
    private string name;
    private string address;

    // Constructor to initialize Person object
    public Person(string name, string address)
    {
        this.name = name;
        this.address = address;
    }

    // Method to set the name
    public void SetName(string name)
    {
        this.name = name;
    }

    // Method to get the name
    public string GetName()
    {
        return this.name;
    }

    // Method to set the address
    public void SetAddress(string address)
    {
        this.address = address;
    }

    // Method to get the address
    public string GetAddress()
    {
        return this.address;
    }

    // Abstract method to display information
    public abstract void Display();
}

// Define the Employee class that inherits from Person
public class Employee : Person
{
    // Private attribute
    private int salary;

    // Constructor to initialize Employee object
    public Employee(string name, string address, int salary)
        : base(name, address)
    {
        this.salary = salary;
    }

    // Override method to display information
    public override void Display()
    {
        Console.WriteLine($"Employee[name={GetName()}, address={GetAddress()}, salary={salary}]");
    }

    // Method to get the salary
    public int GetSalary()
    {
        return this.salary;
    }
}

// Define the Customer class that inherits from Person
public class Customer : Person
{
    // Private attribute
    private int balance;

    // Constructor to initialize Customer object
    public Customer(string name, string address, int balance)
        : base(name, address)
    {
        this.balance = balance;
    }

    // Override method to display information
    public override void Display()
    {
        Console.WriteLine($"Customer[name={GetName()}, address={GetAddress()}, balance={balance}]");
    }

    // Method to get the balance
    public int GetBalance()
    {
        return this.balance;
    }
}
