using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDemo
{
    class Program
    {
        //static/class method
        public static void Main(string[] args)
        {

            StaticVar s1 = new StaticVar();
            StaticVar s2 = new StaticVar();
            s1.increment();
            s1.increment();
            s1.increment();

            s2.increment();
            s2.increment();
            s2.increment();
            Console.WriteLine("Variable num for s1: {0}", s1.getNum());
            Console.WriteLine("Variable num for s2: {0}", s2.getNum());
            Console.ReadKey();

            ////Console.WriteLine(Company.CompanyName);
            //MoonCake moonCake = new MoonCake();
            //Console.WriteLine(MoonCake.Size);
            //MoonCake.Size = 20;
            //MoonCake moonCake2 = new MoonCake();
            //Console.WriteLine(MoonCake.Size);

            //moonCake.MakeCake();
            //moonCake2.MakeCake();
        }

        //instance members:
        //instance method
        //instance variable
        //instance property
        public void TestTest()
        {

        }
    }

    class StaticVar
    {
        public static int num;
        public void increment()
        {
            num++; //num = num+1;
        }
        public int getNum()
        {
            return num;
        }
    }

    class MoonCake
    {
        private static int size = 10;

        public static int Size
        {
            get
            {
                return size;
            }

            set
            {
                size = value;
            }
        }

        public void MakeCake()
        {
            Console.WriteLine("I am use the size: "+size);
        }
    }

    static class Company
    {
        static string companyName = "HelloWare Academy, LLC";
        static int yearFounded = 2016;

        public static string CompanyName
        {
            get
            {
                return companyName;
            }

            set
            {
                companyName = value;
            }
        }

        public static int YearFounded
        {
            get
            {
                return yearFounded;
            }

            set
            {
                yearFounded = value;
            }
        }

        public static void Test()
        {
            companyName = "HelloWare";
        }

        public static void Test2()
        {
            companyName = "HelloWare Academy";
        }
    }

    class Test
    {
        void TestMain(string[] args)
        {
            Program program = new Program();
            program.TestTest();

            Program.Main(new string[] { });
        }
    }
}
