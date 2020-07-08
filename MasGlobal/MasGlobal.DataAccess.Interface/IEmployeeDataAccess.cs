namespace MasGlobal.DataAccess.Interface
{
    using System.Collections.Generic;
    using Entity;

    /// <summary>
    /// Interface IEmployeeDataAccess.
    /// </summary>
    public interface IEmployeeDataAccess
    {
        /// <summary>
        /// Find Employee.
        /// </summary>
        /// <returns></returns>
        List<Employee> FindEmployee();
    }
}
