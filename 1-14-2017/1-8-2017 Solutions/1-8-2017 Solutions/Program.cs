using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_8_2017_Solutions
{
    class Program
    {
        static void Main(string[] args)
        {
            //MVC 
            //Model, View, Controller
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            Calculator calculator = new Calculator();
            Console.WriteLine(calculator.Add(firstNum, secondNum));
            calculator.Add(100.5, 150.5);
            calculator.Add(100, 200, 300);

            calculator.Subtract(100, 150);
            calculator.Subtract(100.5, 150.5);
            calculator.Subtract(100, 200, 300);
        }
    }
}
