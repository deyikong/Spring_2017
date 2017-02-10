using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //String lastName1  = "Shawn"test";
            //String lastName = "Smith\"test"; // Output: Smith"test
            String lastName = @"Smith\";// test"; @ treat escape char \ as normal char
            Console.WriteLine(lastName);
            Console.ReadLine();

            TestClass testClass = null;

            String firstName = testClass.FirstName;
        }
    }
}


