using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Initializers
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer(0000)
            {
                FirstName = "HelloWare",
                LastName = "Academy"
            };

            Console.WriteLine(customer.FirstName + " " + customer.LastName);
        }
    }
}
