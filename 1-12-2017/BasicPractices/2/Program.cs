using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Exercise 2: Write a C# program that determines a student’s grade.
The program will read three types of scores(quiz score, mid-term score, and final score) and determine the grade based on the following rules:
-if the average score =90% =>grade=A
-if the average score >= 70% and<90% => grade=B
-if the average score>=50% and<70% =>grade=C
-if the average score<50% =>grade=F
 */
namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Local Variables
            int quizScore;
            int midTermScore;
            int finalScore;
            int average;
            char letterGrade;
            #endregion

            #region Get User Input
            Console.WriteLine("Please input quiz score:");
            quizScore = int.Parse(Console.ReadLine());
            Console.WriteLine("Please input mid-term score:");
            midTermScore = int.Parse(Console.ReadLine());
            Console.WriteLine("Please input final score:");
            finalScore = int.Parse(Console.ReadLine());
            #endregion


            #region Processing Data
            average = (quizScore + midTermScore + finalScore) / 3;
            //if statements
            if (average > 90)
            {
                letterGrade = 'A';//because variable 'letterGrade' is of type 'char', so the value it is assigned to has to be of type 'char'. In C#, char is always denoted by single quotation marks like 'A','B';
            }
            else
            {
                if(average>70)
                {
                    letterGrade = 'B';
                }
                else
                {
                    if(average>50)
                    {
                        letterGrade = 'C';
                    }
                    else
                    {
                        letterGrade = 'F';
                    }
                }
            }
            #endregion

            #region Output Result
            Console.WriteLine("The grade is: " + letterGrade);
            #endregion

            Console.ReadKey();
        }
    }
}
