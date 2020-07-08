namespace MasGlobal.Business.EmployeeFactory
{
    using Entity;

    /// <summary>
    /// Type MonthlySalaryContract to factory.
    /// </summary>
    public class MonthlySalaryContract : EmployeeFactory
    {
        /// <summary>
        /// Get the anual salary to employees with Monthly Salary Contract.
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        public override double GetAnualSalary(Employee employee)
        {
            double anualSalary = employee.MonthlySalary * 12;

            return anualSalary;
        }
    }
}
