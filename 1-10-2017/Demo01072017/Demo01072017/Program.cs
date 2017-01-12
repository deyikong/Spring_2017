using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01072017
{
    class Program
    {
        static void Main(string[] args)
        {    
            //Naming convention
            //Pascal case for class names,
            //Camel case for variable names        
            Employee employee = new Employee();
            //employee._firstName = "Shawn"; //Not good practice
            employee.FirstName = "Shawn";
            employee.LastName = "Shi";
            int months = 2;
            Decimal cost = employee.GetEmployeeCostByMonths(months); //2 is argument

            //If nullable a reference, it is a candidate to be
            //garbage collect by CLR.
            employee = null;
        }
    }
}
