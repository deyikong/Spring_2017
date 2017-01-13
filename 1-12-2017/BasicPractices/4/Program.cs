using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Exercise 4: Write C# code to produce the output shown below:
*******
******
*****
****
***
**
*
 */
namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Local Variables
            int count;
            #endregion

            #region Get User Input
            Console.WriteLine("Please input a number:");
            count = int.Parse(Console.ReadLine());
            #endregion


            #region Processing Data and Output
            /*
             The first for loop defines how many rows to print.
             The second for loop defines how many columns to print.
             the difference is made inside of the sencond for loop, because we want to print out different numbers of columns for each row.
             */
            for (int i = 0; i < count; i++)
            {
                for (int j = 0; j < count-i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            #endregion

            Console.ReadKey();
        }
    }
}
