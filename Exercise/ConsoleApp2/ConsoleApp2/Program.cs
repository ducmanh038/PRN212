using System;
using System.Collections.Generic;

// Program class to implement the main functionality
class Program
{
    static void Main()
    {
        // Create dynamic lists to manage employees and customers
        List<Employee> employees = new List<Employee>();
        List<Customer> customers = new List<Customer>();

        while (true)
        {
            // Display the menu
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Add Employee");
            Console.WriteLine("2. Add Customer");
            Console.WriteLine("3. Find Employee with Highest Salary");
            Console.WriteLine("4. Find Customer with Lowest Balance");
            Console.WriteLine("5. Find Employee by Name");
            Console.WriteLine("6. Exit");
            Console.Write("Choose an option: ");
            int choice = int.Parse(Console.ReadLine());

            // Handle user's choice
            switch (choice)
            {
                case 1:
                    AddEmployee(employees);
                    break;
                case 2:
                    AddCustomer(customers);
                    break;
                case 3:
                    FindHighestSalaryEmployee(employees);
                    break;
                case 4:
                    FindLowestBalanceCustomer(customers);
                    break;
                case 5:
                    FindEmployeeByName(employees);
                    break;
                case 6:
                    Console.WriteLine("Exiting...");
                    return;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }

    // Method to add an employee to the list
    private static void AddEmployee(List<Employee> employees)
    {
        try
        {
            // Input name, address, and salary from the user
            Console.Write("Enter name: ");
            string name = Console.ReadLine();
            Console.Write("Enter address: ");
            string address = Console.ReadLine();
            Console.Write("Enter salary: ");
            int salary = int.Parse(Console.ReadLine());

            // Add the employee to the list
            employees.Add(new Employee(name, address, salary));
            Console.WriteLine("Employee added.");
        }
        catch (Exception e)
        {
            Console.WriteLine("Error: " + e.Message);
        }
    }

    // Method to add a customer to the list
    private static void AddCustomer(List<Customer> customers)
    {
        try
        {
            // Input name, address, and balance from the user
            Console.Write("Enter name: ");
            string name = Console.ReadLine();
            Console.Write("Enter address: ");
            string address = Console.ReadLine();
            Console.Write("Enter balance: ");
            int balance = int.Parse(Console.ReadLine());

            // Add the customer to the list
            customers.Add(new Customer(name, address, balance));
            Console.WriteLine("Customer added.");
        }
        catch (Exception e)
        {
            Console.WriteLine("Error: " + e.Message);
        }
    }

    // Method to find the employee with the highest salary in the list
    private static void FindHighestSalaryEmployee(List<Employee> employees)
    {
        if (employees.Count == 0)
        {
            Console.WriteLine("No employees to search.");
            return;
        }

        // Initialize variable to store the employee with the highest salary
        Employee highestSalaryEmployee = employees[0];

        // Iterate through the list to find the employee with the highest salary
        foreach (Employee emp in employees)
        {
            if (emp.GetSalary() > highestSalaryEmployee.GetSalary())
            {
                highestSalaryEmployee = emp;
            }
        }

        Console.WriteLine("Employee with highest salary: ");
        highestSalaryEmployee.Display();
    }

    // Method to find the customer with the lowest balance in the list
    private static void FindLowestBalanceCustomer(List<Customer> customers)
    {
        if (customers.Count == 0)
        {
            Console.WriteLine("No customers to search.");
            return;
        }

        // Initialize variable to store the customer with the lowest balance
        Customer lowestBalanceCustomer = customers[0];

        // Iterate through the list to find the customer with the lowest balance
        foreach (Customer cust in customers)
        {
            if (cust.GetBalance() < lowestBalanceCustomer.GetBalance())
            {
                lowestBalanceCustomer = cust;
            }
        }

        Console.WriteLine("Customer with lowest balance: ");
        lowestBalanceCustomer.Display();
    }

    // Method to find an employee by name in the list
    private static void FindEmployeeByName(List<Employee> employees)
    {
        Console.Write("Enter name: ");
        string name = Console.ReadLine();

        // Iterate through the list to find the employee by name
        foreach (Employee emp in employees)
        {
            if (emp.GetName().Equals(name, StringComparison.OrdinalIgnoreCase))
            {
                emp.Display();
                return;
            }
        }

        Console.WriteLine("Employee not found.");
    }
}
