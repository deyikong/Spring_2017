using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Exercise 3: Write a C# program that allows the user to choose the correct answer of a question.
See the example below:
What is the correct way to declare a variable to store an integer value in C#?
a. int 1x= 10;
b. int x = 10;
c. float x = 10.0f;
d. string x = "10";
Choose the answer letter: c
Incorrect choice!
*/

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Local Variables           
            char answer;
            #endregion

            #region Get User Input
            Console.WriteLine("What is the correct way to declare a variable to store an integer value in C#?");
            Console.WriteLine("a. int 1x = 10");
            Console.WriteLine("b. int x = 10");
            Console.WriteLine("c. float x = 10.0f");
            Console.WriteLine("d. string x = \"10\"");
            Console.WriteLine("Choose the answer letter:");
            answer = (char)Console.Read();
            #endregion


            #region Processing Data
           switch(answer)//no ; here, because it's not the end of the switch statement here
            {
                case 'B':
                case 'b'://because variable 'answer' is of type 'char', so data type after 'case' has to be 'char' as well: 
                    Console.WriteLine("Correct");
                    break;
                default://when user chooses something other than 'b' or 'B'
                    Console.WriteLine("Incorrect!");
                    break;

            }
            #endregion

            Console.ReadKey();
        }
    }
}
