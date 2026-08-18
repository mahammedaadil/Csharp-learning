using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmpSpace;

namespace LinqInC_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Employee> empList = new List<Employee>()
            {
                new Employee() { EmpNo = 10, EmpName = "Aadil", EmpSalary = 3000 },
                new Employee() { EmpNo = 11, EmpName = "Sahil", EmpSalary = 3000 },
                new Employee() { EmpNo = 12, EmpName = "Aadil", EmpSalary = 2000 },
                new Employee() { EmpNo = 12, EmpName = "Aadil", EmpSalary = 2000 },
                new Employee() { EmpNo = 10, EmpName = "kadir", EmpSalary = 2000 }

            };

            ////Where in Linq
            //IEnumerable<Employee> emp = empList.Where(e => e.EmpName == "Aadil");
            //foreach (Employee e in emp)
            //{
            //    Console.WriteLine($"EmpNo: {e.EmpNo}");
            //    Console.WriteLine($"Name: {e.EmpName}");
            //    Console.WriteLine($"Salary: {e.EmpSalary}");
            //}


            ////OrderBy and OrderByDescending in Linq
            //IOrderedEnumerable<Employee> AscEmp = empList.OrderBy(e => e.EmpName);
            //foreach (Employee e in AscEmp)
            //{
            //    Console.WriteLine($"EmpNo: {e.EmpNo}");
            //    Console.WriteLine($"Name: {e.EmpName}");
            //    Console.WriteLine($"Salary: {e.EmpSalary}");
            //}

            //IOrderedEnumerable<Employee> DecEmp = empList.OrderByDescending(e => e.EmpName);
            //foreach (Employee e in DecEmp)
            //{
            //    Console.WriteLine($"EmpNo: {e.EmpNo}");
            //    Console.WriteLine($"Name: {e.EmpName}");
            //    Console.WriteLine($"Salary: {e.EmpSalary}");
            //}

            //First And FirstOrDefault in Linq
            //if not found this will throw exception
            //Employee firstEmp = empList.First(e => e.EmpName == "Aadil");
            //Console.WriteLine(firstEmp.EmpName);

            //if not found then it will return null but we have to handle null value by if block
            //Employee firstEmpDefault = empList.FirstOrDefault(e => e.EmpName == "Kiran");
            //if(firstEmpDefault ==null)
            //{

            //    Console.WriteLine("No Emp Found");


            //}
            //else
            //{
            //    Console.WriteLine(firstEmpDefault.EmpName);

            //}


            ////Last and LastOrDefault in Linq

            ////if not found this will give exception too
            //Employee lastEmp = empList.Last(e => e.EmpName == "Aadil");
            //Console.WriteLine(lastEmp.EmpSalary);

            ////if not found this will give null value
            //Employee lastEmpDefault = empList.LastOrDefault(e => e.EmpName == "Jishan");
            //if (lastEmpDefault == null)
            //{
            //    Console.WriteLine("Not Found");
            //}
            //else
            //{
            //    Console.WriteLine(lastEmp.EmpSalary);
            //}


            //Single and SingleOrDefault it checks uniqueness if duplicate found it will return exception and null
            //ElementAt and ElementAtOrDefaulr gives particular indexed found value will return exception and null too 




            ////Min,Max,Average,Sum,Count
            //double maxSal = empList.Max(e => e.EmpSalary);
            //double minSal = empList.Min(e => e.EmpSalary);
            //double avgSal = empList.Average(e => e.EmpSalary);
            //double sumSal = empList.Sum(e => e.EmpSalary);
            //double countObj = empList.Count();
            //Console.WriteLine($"{maxSal} {minSal} {avgSal} {sumSal} {countObj}");
        }
    }
}
