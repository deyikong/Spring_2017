using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionDemo
{
    class Program
    {
        

        static int Divide(int firstNum ,int[] operants)
        {
            int result = 0;

            try
            {
                result = firstNum;
                foreach (int item in operants)
                {
                    result = result / item;
                }
            }
            //catch (DivideByZeroException ex)
            //{
            //    //throw new Exception("Random Exception");
            //    Console.WriteLine("Input can't contain Zero");
            //}
            catch (Exception e)
            {
                throw;
                Console.WriteLine("Input is wrong");
            }
            finally
            {
                Console.WriteLine("End of Divide function");
            }

            return result;
        }

        static int VerifyAge(int age)
        {
            if(age>100)
            {
                throw new AgeException("Age too much");
            }
            return age;
        }

        static void Main(string[] args)
        {
            //VerifyAge(110);

            try
            {
                string input = Console.ReadLine();
                string[] inputNumArray = input.Split(',', ' ', '-');
                List<int> inputintArray = new List<int>();
                foreach (string item in inputNumArray)
                {
                    inputintArray.Add(int.Parse(item));
                }
                Console.WriteLine(Divide(10000, inputintArray.ToArray()));
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
