using System;
using System.Collections.Generic;

#nullable disable

namespace NetCoreEFDBFirst.Models
{
    public partial class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string EmpEmail { get; set; }
        public string EmpAddress { get; set; }
    }
}
