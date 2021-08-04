using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NetCoreEFDBFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreEFDBFirst.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private EmployeeDBContext employeeDBContext = null;
        public EmployeeController(EmployeeDBContext _employeeDBContext)
        {
            this.employeeDBContext = _employeeDBContext;
        }
    }
}
