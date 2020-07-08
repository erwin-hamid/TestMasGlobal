namespace MasGlobal.Business.EmployeeFactory
{
    using Entity;

    /// <summary>
    /// Type HourlySalaryContract to factory.
    /// </summary>
    public class HourlySalaryContract : EmployeeFactory
    {
        /// <summary>
        /// Get the anual salary to employees with Hourly Salary Contract.
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        public override double GetAnualSalary(Employee employee)
        {
            double anualSalary = 120 * employee.HourlySalary * 12;

            return anualSalary;
        }
    }
}
