namespace MasGlobal.Business
{
    using System;
    using System.Collections.Generic;
    using Entity;
    using MasGlobal.Business.EmployeeFactory;
    using MasGlobal.Business.Interface;
    using MasGlobal.DataAccess.Interface;

    /// <summary>
    /// Class EmployeeBusiness.
    /// </summary>
    public class EmployeeBusiness : IEmployeeBusiness
    {
        /// <summary>
        /// Instance of IEmployeeDataAccess.
        /// </summary>
        private readonly IEmployeeDataAccess managerEmployeeDataAccess;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="employeeDataAccess"></param>
        public EmployeeBusiness(IEmployeeDataAccess employeeDataAccess)
        {
            managerEmployeeDataAccess = employeeDataAccess;
        }

        /// <summary>
        /// Find employee by id.
        /// </summary>
        /// <param name="idEmployee"></param>
        /// <returns></returns>
        public List<Employee> FindEmployee(int idEmployee)
        {
            try
            {
                List<Employee> employeeList = managerEmployeeDataAccess.FindEmployee();
                employeeList = FilterEmployees(idEmployee, employeeList);
                CalculateAnualSalary(employeeList);

                return employeeList;
            }
            catch (Exception)
            {
                return new List<Employee>();
            }
        }

        /// <summary>
        /// Get the anual salary to each employee according to their salary type.
        /// </summary>
        /// <param name="employeeList"></param>
        private static void CalculateAnualSalary(List<Employee> employeeList)
        {
            foreach (Employee employee in employeeList)
            {
                EmployeeFactory.EmployeeFactory employeeFactory = EmployeCreator.EmployeeCreatorFactory(employee.ContractTypeName);
                employee.AnualSalary = employeeFactory.GetAnualSalary(employee);
            }
        }

        /// <summary>
        /// Vallidate and filter the employee by id.
        /// </summary>
        /// <param name="idEmployee"></param>
        /// <param name="employeeList"></param>
        /// <returns></returns>
        private static List<Employee> FilterEmployees(int idEmployee, List<Employee> employeeList)
        {
            if (idEmployee > 0)
                employeeList = employeeList.FindAll(x => x.Id == idEmployee);

            return employeeList;
        }
    }
}
