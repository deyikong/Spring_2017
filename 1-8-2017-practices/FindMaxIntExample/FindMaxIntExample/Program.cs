using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaxIntExample
{
    class Program
    {
        static void Main(string[] args)
        {
            /* local variable definition */
            int a = 100;
            int b = 200;
            int max;
            NumberManipulator numberManipulator = new NumberManipulator();

            //calling the FindMax method
            max = numberManipulator.FindMax(a, b);
            Console.WriteLine("Max value is : {0}", max);
            Console.ReadLine();
        }
    }
}
