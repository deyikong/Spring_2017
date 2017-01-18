using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    class Project
    {

        #region Private Variables
        private int id;
        private string name;
        private string description;
        private Employee[] assignedEmployees = new Employee[] { };
        private Item[] item = new Item[] { };
        #endregion

        #region Properties
        public string Description
        {
            get
            {
                return description;
            }

            set
            {
                description = value;
            }
        }

        public Employee[] AssignedEmployees
        {
            get
            {
                return assignedEmployees;
            }

            set
            {
                assignedEmployees = value;
            }
        }

        internal Item[] Items
        {
            get
            {
                return item;
            }

            set
            {
                item = value;
            }
        }
        #endregion
        
        #region Constructor
        public Project(string name)
        {
            this.name = name;
            SerialNumberGenerator serialNumberGenerator = new Inventory.SerialNumberGenerator();
            id = serialNumberGenerator.GetSerialNumber();
            description = "A New Project!";
        }
        #endregion
    }
}
