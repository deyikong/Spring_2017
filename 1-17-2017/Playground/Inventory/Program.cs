using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employeeList = new List<Employee>();
            employeeList.Add(new SalaryEmployee(000, "san", 50000, "si"));
            employeeList.Add(new WageEmployee(001, "li", "zhang", 20, 15));
            employeeList.Insert(0, new WageEmployee(001, "li", "zhang", 20, 16));

            List<Employee> employeeList2 = new List<Employee>();
            employeeList2.Add(new SalaryEmployee(000, "san", 100000, "si"));
            employeeList2.Add(new WageEmployee(001, "li", "zhang", 20, 25));

            //employeeList.RemoveAt(0);
            Employee[] employeeTeam = employeeList.ToArray();
            //        {
            //        new SalaryEmployee(000, "san", 50000, "si"),
            //        new WageEmployee(001, "li", "zhang", 20, 15)
            //};
            employeeList.AddRange(employeeTeam);

            foreach (Employee _employee in employeeTeam)
            {
                Console.WriteLine(_employee.GetMonthlySalary());
            }
        }
    }
}
