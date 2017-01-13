using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Exercise 1: Write a C# program that prompts the user to input three integer values and find the greatest value of the three values.
 */

namespace BasicPractices
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Local Variables
            int firstNum;
            int secondNum;
            int thirdNum;
            int max;
            #endregion

            #region Get User Input
            Console.WriteLine("Please input first number:");
            firstNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Please input second number:");
            secondNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Please input third number:");
            thirdNum = int.Parse(Console.ReadLine());
            #endregion


            #region Processing Data
            //if statements
            if (firstNum > secondNum)//after if, there has to be a pair of parenthesis 
            {// since this block only has one statement, the {} are optional and can be deleted
                max = firstNum;
            }
            else
            {
                max = secondNum;
            }

            if (max < thirdNum)
                max = thirdNum; //this block has one statement, so no need for {}. But I suggest to put {} all the time, because it's consistent and easy to read.

            #endregion

            #region Output Result
            Console.WriteLine("The Biggest Value is: " + max);
            #endregion


            Console.ReadKey();
        }
    }
}
