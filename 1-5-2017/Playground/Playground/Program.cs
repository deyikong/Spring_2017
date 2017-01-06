using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Increment and decrement
            //int x = 1;
            //x++;

            //Console.WriteLine(x);//x=2
            //x--;
            //Console.WriteLine(x);//x=1

            //--x;
            //Console.WriteLine(x);//x=0

            //Console.WriteLine(x--);//x=-1

            //Console.WriteLine(x);//x=-1

            //Console.WriteLine(--x);// x=-2

            //Console.ReadLine();
            #endregion


            ////case sensitive
            //int x = 1;
            //Console.WriteLine(X);

            //Naming Conventions
            // variable: string hellowareAcademy = "Awesome";
            //method, class, Namespace: Public string GetLastName();


            //If Statement
            //Comparision Operator: < > <= >= == !=, logical operator: &&(and) ||(or)
            int x = 6;

            if(x>5&&x<15)
            {
                Console.WriteLine("Bigger than 5, smaller than 15");

                NewMethod(x);
            }
            else
            {
                Console.WriteLine("others");
            }

        }

        private static void NewMethod(int x)
        {
            if (x == 6) //nested if statement
            {
                Console.WriteLine("6");
            }
        }
    }
}
