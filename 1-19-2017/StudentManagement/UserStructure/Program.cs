using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            Administrator admin = new UserStructure.Administrator();
            Console.WriteLine(admin.Address);
        }
    }
}
