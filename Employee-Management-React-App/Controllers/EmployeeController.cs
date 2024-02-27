using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Employee_Management_React_App.Models;

namespace Employee_Management_React_App.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly EmployeeManagementDbContext employeeManagementDbContext;

        public EmployeeController(EmployeeManagementDbContext _employeeManagementDbContext)
        {
            employeeManagementDbContext = _employeeManagementDbContext;
        }
        [HttpGet]
        [Route("GetEmployees")]
        public IActionResult GetEmployees()
        {
            return Ok(employeeManagementDbContext.Employees.ToList());
        }
    }
}
