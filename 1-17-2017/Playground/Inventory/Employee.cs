using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    abstract class Employee:IEmployee
    {
        int id;
        private string firstName;
        private string lastName;
        private string title;
        private DateTime joinDate;

        public string FirstName
        {
            get
            {
                return firstName;
            }

            set
            {
                firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }

            set
            {
                lastName = value;
            }
        }

        public string Title
        {
            get
            {
                return title;
            }

            set
            {
                title = value;
            }
        }

        public Employee(int id, string firstName, string lastName)
        {
            this.id = id;
            this.firstName = firstName;
           this.lastName = lastName;
            this.joinDate = DateTime.Now;
        }

        public virtual double GetMonthlySalary()
        {
            return 0.0;
        }
    }
}
