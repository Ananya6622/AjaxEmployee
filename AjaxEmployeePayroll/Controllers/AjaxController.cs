using AjaxEmployeePayroll.Context;
using AjaxEmployeePayroll.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace AjaxEmployeePayroll.Controllers
{
    public class AjaxController : Controller
    {
        private readonly EmpContext empContext;
        public AjaxController(EmpContext empContext)
        {
            this.empContext = empContext;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public JsonResult EmployeeList()
        {
            var data = empContext.EmpTable.ToList();
            return new JsonResult(data);
        }

        [HttpPost]
        public JsonResult AddEmployee(EmpEntity employee)
        {
            var emp = new EmpEntity()
            {
                Name = employee.Name,
                ProfileImage = employee.ProfileImage,
                Gender = employee.Gender,
                Department = employee.Department,
                Salary = employee.Salary,
                StartDate = employee.StartDate,
                Notes = employee.Notes

            };
            empContext.EmpTable.Add(emp);
            empContext.SaveChanges();
            return new JsonResult("Data is saved");
        }
    }
}
