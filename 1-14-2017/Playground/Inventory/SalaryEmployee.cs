using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    class SalaryEmployee:Employee
    {
        private double salary;

        public SalaryEmployee(int id, string firstName,double salary, string lastName)
            :base(id,firstName, lastName)
        {
            this.salary = salary;
        }

        public double Salary
        {
            get
            {
                return salary;
            }

            set
            {
                salary = value;
            }
        }

        public new double GetMonthlySalary()
        {
            return salary / 12;
        }
    }
}
