// Định nghĩa lớp trừu tượng Employee
public abstract class Employee : IEmployee
{
    // Các thuộc tính riêng tư
    private string name;
    private int paymentPerHour;

    // Constructor để khởi tạo đối tượng Employee
    public Employee(string name, int paymentPerHour)
    {
        this.name = name;
        this.paymentPerHour = paymentPerHour;
    }

    // Phương thức để đặt tên
    public void SetName(string name)
    {
        this.name = name;
    }

    // Phương thức để lấy tên
    public string GetName()
    {
        return this.name;
    }

    // Phương thức để đặt mức lương mỗi giờ
    public void SetPaymentPerHour(int paymentPerHour)
    {
        this.paymentPerHour = paymentPerHour;
    }

    // Phương thức để lấy mức lương mỗi giờ
    public int GetPaymentPerHour()
    {
        return this.paymentPerHour;
    }

    // Phương thức trừu tượng để tính lương
    public abstract int CalculateSalary();

    // Phương thức để chuyển đối tượng thành chuỗi
    public override string ToString()
    {
        return $"Employee[name={name}, paymentPerHour={paymentPerHour}]";
    }
}
