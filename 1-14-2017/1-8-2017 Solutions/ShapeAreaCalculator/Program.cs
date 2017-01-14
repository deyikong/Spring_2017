using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreaCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            ShapeAreaCalculator rectangle = new ShapeAreaCalculator(111.1,222.2);
            //rectangle.Height = 333.3;
            Console.WriteLine(rectangle.GetRectangleShapeArea());

            ShapeAreaCalculator circle = new ShapeAreaCalculator(444.4);
            circle.Radius = 555.5;
            Console.WriteLine(circle.GetCircleShapeArea());
        }
    }
}
