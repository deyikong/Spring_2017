using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    class WageEmployee:Employee
    {
        private int hoursPerWeek;
        private double wage;

        public WageEmployee(int iddd,string first, string last, int hoursPerWeek,double wage) : base(iddd, first, last)
        {
            this.wage = wage;
            this.hoursPerWeek = hoursPerWeek;
        }

        public int HoursPerWeek
        {
            get
            {
                return hoursPerWeek;
            }

            set
            {
                hoursPerWeek = value;
            }
        }

        public double Wage
        {
            get
            {
                return wage;
            }

            set
            {
                wage = value;
            }
        }

        public new double GetMonthlySalary()
        {
            return 4 * hoursPerWeek * wage;
        }
    }
}
