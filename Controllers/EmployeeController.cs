using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using appbasic1.Models;

namespace appbasic1.Controllers
{
    [Route("api/v1/[controller]")]
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            var Emps = new EmployeeDatabase();
            return View(Emps);
        }

        // GET api/values
        [HttpGet]
        [Route("api/v1/employees")]
        public IEnumerable<Employee> Get()
        {
            var Emps = new EmployeeDatabase();
            return Emps;
        }

    }
}
