// Định nghĩa lớp PartTimeEmployee kế thừa từ Employee
public class PartTimeEmployee : Employee
{
    // Thuộc tính riêng tư
    private int workingHours;

    // Constructor để khởi tạo đối tượng PartTimeEmployee
    public PartTimeEmployee(string name, int paymentPerHour, int workingHours)
        : base(name, paymentPerHour)
    {
        this.workingHours = workingHours;
    }

    // Phương thức ghi đè để tính lương cho nhân viên bán thời gian
    public override int CalculateSalary()
    {
        return workingHours * GetPaymentPerHour();
    }

    // Phương thức ghi đè để chuyển đối tượng thành chuỗi
    public override string ToString()
    {
        return $"PartTimeEmployee[{base.ToString()}, workingHours={workingHours}, salary={CalculateSalary()}]";
    }
}
