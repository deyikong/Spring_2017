using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    class Employee
    {
        int id;
        private string firstName;
        private string lastName;

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

        public Employee(int id, string firstName, string lastName)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
        }
    }
}
