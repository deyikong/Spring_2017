using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Calculator
    {

        public double Add(params double[] operants)
        {
            double result = 0;
            foreach (double item in operants)
            {
                result = result + item;
            }

            return result;
        }
    }
}
