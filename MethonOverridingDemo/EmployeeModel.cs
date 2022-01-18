namespace MethonOverridingDemo
{
    public class EmployeeModel : PersonModel
    {
        public decimal HourlyRate { get; set; }
        public virtual decimal GetPaycheck(int hoursWorked)
        {
            return HourlyRate * hoursWorked;
        }
    }
}
