using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> myDict = new Dictionary<string, int>();
            myDict["ZhangSan"] = 22;
            myDict["LiSi"] = 30;

            object a = new object();
           

            Console.WriteLine(a.GetHashCode().ToString());
        }
    }
}
