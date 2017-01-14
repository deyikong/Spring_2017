using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreaCalculator
{
    class ShapeAreaCalculator
    {
        private double _width;
        private double _height;
        private double _radius;

        public double Width
        {
            get
            {
                return _width;
            }

            set
            {
                _width = value;
            }
        }

        public double Height
        {
            get
            {
                return _height;
            }

            set
            {
                _height = value;
            }
        }

        public double Radius
        {
            get
            {
                return _radius;
            }

            set
            {
                _radius = value;
            }
        }

        public ShapeAreaCalculator(double width,double height)
        {
            _width = width;
            _height = height;
        }

        public ShapeAreaCalculator(double radius)
        {
            _radius = radius;
        }

        public double GetRectangleShapeArea()
        {
            return _height * _width;
        }

        public double GetCircleShapeArea()
        {
            return 3.14 * _radius * _radius;
        }

    }
}
