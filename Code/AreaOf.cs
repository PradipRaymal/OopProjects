using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopProjects.Code
{
    internal class AreaOf
    {
        public double Area(int baseLength, int height)
        {
            return 0.5 * baseLength * height;
        }

        public double Area(double radius)
        {
            return 3.14159 * radius * radius;
        }

        public double Area(double length, double width)
        {


            return length * width;

        }

        public double Area(int length)
        {
            return length * length;
        }
    }


        public class Program
        {
            public static void Main()
            {
                AreaOf a = new AreaOf();

                double triangleArea = a.Area(5, 10);
                Console.WriteLine("Area of triangle: " + triangleArea);


                double circleArea = a.Area(4);
                Console.WriteLine("Area of circle: " + circleArea);


                double rectangleArea = a.Area(5, 10);
                Console.WriteLine("Area of rectangle: " + rectangleArea);


                double squareArea = a.Area(5);
                Console.WriteLine("Area of square: " + squareArea);
            }
        }
    }



