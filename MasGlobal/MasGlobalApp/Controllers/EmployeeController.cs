namespace MasGlobalApp.Controllers
{
    using MasGlobal.Business.Interface;
    using Microsoft.AspNetCore.Mvc;

    /// <summary>
    /// Controller EmployeeController
    /// </summary>
    public class EmployeeController : Controller
    {
        /// <summary>
        /// Intance of IEmployeeBusiness.
        /// </summary>
        private readonly IEmployeeBusiness managerEmployeeBusiness;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="employeeBusiness"></param>
        public EmployeeController(IEmployeeBusiness employeeBusiness)
        {
            managerEmployeeBusiness = employeeBusiness;
        }

        /// <summary>
        /// Index Employee View.
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            var employeeList = managerEmployeeBusiness.FindEmployee(0);

            return View(employeeList);
        }

        /// <summary>
        /// Find employee by id.
        /// </summary>
        /// <param name="idEmployee"></param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult FindEmployee(int idEmployee)
        {
            var employeeList = managerEmployeeBusiness.FindEmployee(idEmployee);

            return View("Index", employeeList);
        }
    }
}