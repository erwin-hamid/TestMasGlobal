namespace MasGlobal.Business.EmployeeFactory
{
    /// <summary>
    /// Creatror of employees.
    /// </summary>
    public class EmployeCreator
    {
        /// <summary>
        /// Validate the factory method to create the employee.
        /// </summary>
        /// <param name="contractType"></param>
        /// <returns></returns>
        public static EmployeeFactory EmployeeCreatorFactory(string contractType)
        {
            switch (contractType)
            {
                case "HourlySalaryEmployee":
                    return new HourlySalaryContract();
                case "MonthlySalaryEmployee":
                    return new MonthlySalaryContract();
                default: 
                    return null;
            }
        }
    }
}
