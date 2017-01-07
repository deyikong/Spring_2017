using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground
{
    class Program
    {
        static void Main(string[] args)
        {

            MoonCake wheatMoonCake = new MoonCake();
            wheatMoonCake.Age = 20;

            MoonCake cornFlourMoonCake = new MoonCake("Corn Flour");
            cornFlourMoonCake.Age = 18;
            int result = cornFlourMoonCake.Get3Times4Times5Times(6);
            Console.WriteLine(cornFlourMoonCake.Age);
            

            #region Expression and statement

            //#region Switch Statements
            //string unknownDay = "Wednesday";
            //char unknownChar = '1';

            ////if (unknownDay == "Monday") { }

            ///*
            // Data Type
            // Unique Case
            // Not Range
            // Default
            // */
            //char gender = 'M';
            //int age = 18;
            //switch (age)
            //{
            //    case 18:
            //        switch(gender)
            //        {
            //            case 'M':
            //                Console.WriteLine("18 M");
            //                break;
            //        }
            //        Console.WriteLine("Adult");
            //        break;
            //    case 20:
            //        Console.WriteLine("20");
            //        break;
            //    default:
            //        Console.WriteLine("Not 18");
            //        break;
            //}
            //#endregion

            //string monday = "Monday";
            //string tuesday = "Tuesday";

            string[] days = {"Monday","Tuesday","Wednesday","Thursday"};
            //Console.WriteLine(days[1]);

            //Console.WriteLine("Hello \n World!");

            //intro to debugger
            string[] lines = File.ReadAllLines(@"Test Data 1\input2.txt");
            //relative path
            //absolute path
            //string randomString = "sss";
            //#region foreach Demo
            //foreach (string _ in days)
            //{
            //    Console.WriteLine(_);
            //}
            //#endregion

            //Console.WriteLine();

            //#region for statement Demo
            //for (int i = 2; i < days.Length; i = i + 1)
            //{
            //    Console.WriteLine(days[i]);
            //}

            //#endregion

            //Console.WriteLine();

            //#region While statement Demo
            //int whileCounter = 0;
            //while (whileCounter < lines.Length)
            //{
            //    Console.WriteLine(lines[whileCounter]);
            //    whileCounter++;
            //}
            //#endregion

            //Console.WriteLine();

            //#region Do statement Demo
            //int doCounter = 0;
            //do
            //{
            //    Console.WriteLine(lines[doCounter]);
            //} while (++doCounter < lines.Length);
            //#endregion

            #endregion
        }
    }
}
