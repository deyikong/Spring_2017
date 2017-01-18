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
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < i+1; j++)
                {
                    Console.Write(i+1);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }

            //Vehicle vehicle = new Vehicle("Toyota", "Highlander", 2004);

            //Console.WriteLine(vehicle.Make);
            ////vehicle.Speed = 30;

            //vehicle.Start();
            //vehicle.Accelerate(10, 2);
            //vehicle.Accelerate(2, 10);
            //Console.WriteLine(vehicle.Speed);
            //vehicle.Decelerate(2, 5);
            //vehicle.Decelerate(-2, 5);
            //Console.WriteLine(vehicle.Speed);
            //vehicle.Stop();
            //vehicle.Start();
            //vehicle.Accelerate(1, 2);
            //Console.WriteLine(vehicle.Speed);

        }
    }
}
