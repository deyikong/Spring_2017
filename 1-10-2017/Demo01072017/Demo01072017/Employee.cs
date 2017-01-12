#region References
using System;
#endregion

namespace Demo01072017
{
    class Employee
    {
        //Ctrl K, Ctrl S
        #region Fields
        private String firstName;
        //public String _firstName;//not good practice to delcare as public

        #endregion

        #region Constructors
        //Short key to define constructor: ctor, 2 tabs
        //default constructor, parameter less
        //It is good practice to provide a default
        //constructor if you defined named constructors.
        public Employee()
        {
        }

        //Named constructor
        public Employee(String firstName)
        {
            //this means the current object
            //this is a special object reference to itself within class
            //"this" is a keyword
            //Employee this = new Employee()
            this.firstName = firstName;
        }
        #endregion

        #region Methods
        //Access modifier: public, private, internal, protected, internal protected
        //return type: void and any data type
        //Method name: Pascal case, descriptive, action
        //Return type void: DoSomething
        //Return type exists: GetSomething
        //Parameter:
        //Arguments:
        public void DemoMethod1()
        {
            //Employee employee = new Employee();
            //String myName1 = employee.firstName;
            String myName = this.firstName;
            String myName3 = firstName;
        }

        public Decimal GetEmployeeCostByMonths(int months)
        {
            return 5000 * months;
        }

        public Department GetDepartment()
        {
            return new Department();
        }

        //VB.NET, method is Function
        #endregion

        #region Properties
        //Properties is also special methods
        //getter
        //private String GetFirstName() 
        //{
        //        return firstName;
        //};
        //setter
        //private void SetFirstName(String value) 
        //{
        //        firstName = value;
        //};
        public String FirstName
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

        public String LastName { get; set; }
        #endregion
    }

    class Department
    {
        public String Name { get; set; }
        public String  Address1 { get; set; }
    }
}