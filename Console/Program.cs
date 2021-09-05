using System;
using System.Collections.Generic;
using GeometryMaster;

namespace GeometryMaster
{
    class Program
    {
        static void Main(string[] args)
        {
            // Showcase
            var figures = new List<IFigure>()
            {
                new Triangle(3, 3, 3),
                new Circle(10)
            };

            foreach (var figure in figures)
            {
                Console.WriteLine("Square of " + figure.GetType().Name + " is " + figure.Square);
            }

            Console.WriteLine("Press any key to close...");
            Console.ReadLine();
        }
    }
}
