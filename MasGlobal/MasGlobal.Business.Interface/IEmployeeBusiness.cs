namespace MasGlobal.Business.Interface
{
    using System.Collections.Generic;
    using Entity;

    /// <summary>
    /// Interface IEmployeeBusiness.
    /// </summary>
    public interface IEmployeeBusiness
    {
        /// <summary>
        /// Find employee by id.
        /// </summary>
        /// <param name="idEmployee"></param>
        /// <returns></returns>
        List<Employee> FindEmployee(int idEmployee);
    }
}
