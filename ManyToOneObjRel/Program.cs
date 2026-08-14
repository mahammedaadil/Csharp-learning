using System;
using System.Collections.Generic;
using EmpSpace;

namespace ManyToOneObjRel
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Employee emp1 = new Employee() { EmpName = "aadil", EmpSalary = 2000 };
            Employee emp2 = new Employee() { EmpName = "sahil", EmpSalary = 3000 };

            Department deptInit = new Department() { DepartmentId = 1, DepartmentName = "Account" };

            emp1.dept = deptInit;
            emp2.dept = deptInit;

            Console.WriteLine($"EmpName:{emp1.EmpName} EmpSalary:{emp1.EmpSalary} EmpDept:{emp1.dept.DepartmentName}");
            Console.WriteLine($"EmpName:{emp2.EmpName} EmpSalary:{emp2.EmpSalary} EmpDept:{emp2.dept.DepartmentName}");

        }
    }
}
