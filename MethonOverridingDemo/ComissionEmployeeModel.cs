namespace MethonOverridingDemo
{
    public class ComissionEmployeeModel : EmployeeModel
    {
        public decimal CommissionAmount { get; set; }

        public override decimal GetPaycheck(int hoursWorked)
        {
            decimal initialPay = base.GetPaycheck(hoursWorked);
            return initialPay + CommissionAmount;
        }
    }
}
