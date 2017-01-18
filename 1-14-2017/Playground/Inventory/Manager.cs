using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    class Manager: Employee
    {
        private string managerId;

        public string ManagerId
        {
            get
            {
                return managerId;
            }

            set
            {
                managerId = value;
            }
        }

        public Manager(int id,string firstName, string lastName):base(id,firstName,lastName)
        {
            managerId = "M" + Title+id;
        }

        public bool HireEmployee(Employee employeeToBeHired)
        {
            return true;
        }

        public bool FireEmployee(Employee employeeToBeFired)
        {
            return true;
        }

        public bool AssignEmployeeToProject(Employee employee, Project project)
        {
            return true;
        }
    }
}
