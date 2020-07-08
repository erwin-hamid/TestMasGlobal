namespace MasGlobal.Business.EmployeeFactory
{
    using Entity;

    /// <summary>
    /// Abstract class to Factory Employee.
    /// </summary>
    public abstract class EmployeeFactory
    {
        /// <summary>
        /// Abstract method to get anual salary from employee.
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        public abstract double GetAnualSalary(Employee employee);
    }
}
