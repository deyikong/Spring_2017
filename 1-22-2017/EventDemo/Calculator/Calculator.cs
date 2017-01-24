using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    static class Calculator
    {
        private static double firstNum;
        private static double secondNum;

        public static double SecondNum
        {
            get
            {
                return secondNum;
            }

            set
            {
                secondNum = value;
            }
        }
        public static double FirstNum
        {
            get
            {
                return firstNum;
            }

            set
            {
                firstNum = value;
            }
        }

        public static double Add()
        {
            return firstNum+secondNum;
        }
        public static double Subtract()
        {
            return firstNum - secondNum;
        }
        public static double Multiply()
        {
            return firstNum * secondNum;
        }
        public static double Divide()
        {
            return firstNum / secondNum;
        }
    }
}
