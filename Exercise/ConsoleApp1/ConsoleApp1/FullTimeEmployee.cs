// Định nghĩa lớp FullTimeEmployee kế thừa từ Employee
public class FullTimeEmployee : Employee
{
    // Constructor để khởi tạo đối tượng FullTimeEmployee
    public FullTimeEmployee(string name, int paymentPerHour)
        : base(name, paymentPerHour)
    {
    }

    // Phương thức ghi đè để tính lương cho nhân viên toàn thời gian
    public override int CalculateSalary()
    {
        return 8 * GetPaymentPerHour();
    }

    // Phương thức ghi đè để chuyển đối tượng thành chuỗi
    public override string ToString()
    {
        return $"FullTimeEmployee[{base.ToString()}, salary={CalculateSalary()}]";
    }
}
