using System;
using System.Collections.Generic;

// Lớp Program để thực hiện chức năng chính
class Program
{
    static void Main()
    {
        // Tạo danh sách động để quản lý nhân viên
        List<Employee> employees = new List<Employee>();

        while (true)
        {
            // Hiển thị menu
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Add FullTimeEmployee");
            Console.WriteLine("2. Add PartTimeEmployee");
            Console.WriteLine("3. Find Employee with Highest Salary");
            Console.WriteLine("4. Find Employee by Name");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");
            int choice = int.Parse(Console.ReadLine());

            // Xử lý lựa chọn của người dùng
            switch (choice)
            {
                case 1:
                    AddFullTimeEmployee(employees);
                    break;
                case 2:
                    AddPartTimeEmployee(employees);
                    break;
                case 3:
                    FindHighestSalaryEmployee(employees);
                    break;
                case 4:
                    FindEmployeeByName(employees);
                    break;
                case 5:
                    Console.WriteLine("Exiting...");
                    return;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }

    // Phương thức để thêm nhân viên toàn thời gian vào danh sách
    private static void AddFullTimeEmployee(List<Employee> employees)
    {
        try
        {
            // Nhập tên và lương mỗi giờ từ người dùng
            Console.Write("Enter name: ");
            string name = Console.ReadLine();
            Console.Write("Enter payment per hour: ");
            int paymentPerHour = int.Parse(Console.ReadLine());

            // Thêm nhân viên vào danh sách
            employees.Add(new FullTimeEmployee(name, paymentPerHour));
            Console.WriteLine("FullTimeEmployee added.");
        }
        catch (Exception e)
        {
            Console.WriteLine("Error: " + e.Message);
        }
    }

    // Phương thức để thêm nhân viên bán thời gian vào danh sách
    private static void AddPartTimeEmployee(List<Employee> employees)
    {
        try
        {
            // Nhập tên, lương mỗi giờ và số giờ làm việc từ người dùng
            Console.Write("Enter name: ");
            string name = Console.ReadLine();
            Console.Write("Enter payment per hour: ");
            int paymentPerHour = int.Parse(Console.ReadLine());
            Console.Write("Enter working hours: ");
            int workingHours = int.Parse(Console.ReadLine());

            // Thêm nhân viên vào danh sách
            employees.Add(new PartTimeEmployee(name, paymentPerHour, workingHours));
            Console.WriteLine("PartTimeEmployee added.");
        }
        catch (Exception e)
        {
            Console.WriteLine("Error: " + e.Message);
        }
    }

    // Phương thức để tìm nhân viên có lương cao nhất trong danh sách
    private static void FindHighestSalaryEmployee(List<Employee> employees)
    {
        if (employees.Count == 0)
        {
            Console.WriteLine("No employees to search.");
            return;
        }

        // Khởi tạo biến lưu trữ nhân viên có lương cao nhất
        Employee highestSalaryEmployee = employees[0];

        // Duyệt qua danh sách để tìm nhân viên có lương cao nhất
        foreach (Employee emp in employees)
        {
            if (emp.CalculateSalary() > highestSalaryEmployee.CalculateSalary())
            {
                highestSalaryEmployee = emp;
            }
        }

        Console.WriteLine("Employee with highest salary: " + highestSalaryEmployee);
    }

    // Phương thức để tìm nhân viên theo tên trong danh sách
    private static void FindEmployeeByName(List<Employee> employees)
    {
        Console.Write("Enter name: ");
        string name = Console.ReadLine();

        // Duyệt qua danh sách để tìm nhân viên theo tên
        foreach (Employee emp in employees)
        {
            if (emp.GetName().Equals(name, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine(emp);
                return;
            }
        }

        Console.WriteLine("Employee not found.");
    }
}
