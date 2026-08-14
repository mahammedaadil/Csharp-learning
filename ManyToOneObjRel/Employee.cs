using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManyToOneObjRel;

namespace EmpSpace
{
    internal class Employee
    {
        public string EmpName { get; set; }
        public double EmpSalary { get; set; }

        public Department dept { get; set; }

       
    }
}
