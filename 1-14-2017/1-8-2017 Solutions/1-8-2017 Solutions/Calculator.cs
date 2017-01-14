using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_8_2017_Solutions
{
    class Calculator
    {
        //public int Add(int firstNum, int secondNum)
        //{
        //    return firstNum+secondNum;
        //}

         public double Add(double firstNum, double secondNum)
        {
            return firstNum+secondNum;
        }

        public double Add(double firstNum, double secondNum, double thirdNum)
        {
            return firstNum + secondNum + thirdNum;
        }

        //public int Add(int firstNum, int secondNum, int thirdNum)
        //{
        //    return firstNum + secondNum + thirdNum;
        //}

        //public int Subtract(int firstNum, int secondNum)
        //{
        //    return firstNum - secondNum;
        //}

        public double Subtract(double firstNum, double secondNum)
        {
            return firstNum - secondNum;
        }

        public double Subtract(double firstNum, double secondNum, double thirdNum)
        {
            return firstNum - secondNum - thirdNum;
        }

        //public int Subtract(int firstNum, int secondNum, int thirdNum)
        //{
        //    return firstNum - secondNum - thirdNum;
        //}
    }
}
