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
            SalaryEmployee salaryEmployee = new SalaryEmployee(000, "san", 50000, "si");

            WageEmployee wageEmployee = new WageEmployee(001, "li", "zhang", 20, 15);

            Console.WriteLine(salaryEmployee.GetMonthlySalary());
            Console.WriteLine(wageEmployee.GetMonthlySalary());
            
            Employee employee = wageEmployee;
       
            Console.WriteLine(employee);

            Manager manager = new Manager(1, "San", "Zhang");
            Console.WriteLine(manager.ManagerId);

            Employee employee_1 = manager;
            // manager = new Employee();
            Console.WriteLine(employee_1.FirstName);

            #region Old Code
            //Employee[] assignedEmployee = new Employee[3];

            //Employee zhangSan = new Employee(000, "San", "Zhang");
            //Employee liSi = new Employee(001, "Si", "Li");
            //Employee wangWu = new Employee(002, "Wu", "Wang");

            //assignedEmployee[0] = zhangSan;
            //assignedEmployee[1] = liSi;
            //assignedEmployee[2] = wangWu;


            //Item[] itemsToBeUsed = new Item[3];

            //Item screwDriver = new Item(333, "Screw Driver");
            ////Item hammer = new Item(123, "Hammer");
            ////Hammer hammerReal = new Hammer();
            //Item nails = new Item(005, "Nails");

            //itemsToBeUsed[0] = nails;
            //itemsToBeUsed[1] = screwDriver;
            ////itemsToBeUsed[2] = hammerReal;

            //Project fixUpper = new Project("Fix Upper");
            //fixUpper.AssignedEmployees = assignedEmployee;
            //fixUpper.Items = itemsToBeUsed;




            //foreach (Employee employee in fixUpper.AssignedEmployees)
            //{
            //    Console.WriteLine(employee.FirstName+" "+employee.LastName);
            //}

            //foreach (Item item in fixUpper.Items)
            //{
            //    Console.WriteLine(item.Name);
            //} 
            #endregion


        }
    }
}
