namespace MasGlobal.DataAccess
{
    using System.Collections.Generic;
    using Entity;
    using Entity.Configuration;
    using MasGlobal.DataAccess.Interface;
    using Newtonsoft.Json;

    /// <summary>
    /// Class EmployeeDataAccess
    /// </summary>
    public class EmployeeDataAccess : IEmployeeDataAccess
    {
        /// <summary>
        /// Call employee service.
        /// </summary>
        /// <returns></returns>
        public List<Employee> FindEmployee()
        {
            ServicesClient servicesClient = new ServicesClient(AppSettings.Instance.ServiceEnpoints.EmployeeService);
            var response = servicesClient.Get("Employees", "", string.Empty);
            string result = JsonConvert.SerializeObject(response);
            List<Employee> visitorList = JsonConvert.DeserializeObject<List<Employee>>(result);

            return visitorList;
        }
    }
}
