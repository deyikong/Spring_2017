/*
 * C# Program to Swap two Numbers
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace TwoNumberSwap
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, temp;
            Console.WriteLine("Enter the First Number : ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Second Number : ");
            num2 = int.Parse(Console.ReadLine());
            temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine("After Swapping : ");
            Console.WriteLine("First Number : " + num1);
            Console.WriteLine("Second Number : " + num2);
            Console.ReadLine();
        }
    }
}