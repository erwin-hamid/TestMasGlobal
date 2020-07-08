using System.ComponentModel.DataAnnotations;

namespace Entity
{
    /// <summary>
    /// Object Employee.
    /// </summary>
    public class Employee
    {
        [Display(Name = "Employee ID")]
        public int Id { get; set; }

        [Display(Name = "Employee Name")]
        public string Name { get; set; }

        [Display(Name = "Contract Type")]
        public string ContractTypeName { get; set; }

        [Display(Name = "Role ID")]
        public int RoleId { get; set; }

        [Display(Name = "Role Name")]
        public string RoleName { get; set; }

        [Display(Name = "Role Description")]
        public string RoleDescription { get; set; }

        [Display(Name = "Hourly Salary")]
        public double HourlySalary { get; set; }

        [Display(Name = "Monthly Salary")]
        public double MonthlySalary { get; set; }

        [Display(Name = "Anual Salary")]
        public double AnualSalary { get; set; }
    }
}
