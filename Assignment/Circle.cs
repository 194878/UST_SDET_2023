using Assignment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Circle : Shape, IDrawable
    {
        double radius;
        const double pi = 3.14;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double CalculateArea()
        {
            return pi * radius * radius;
        }

        public override double CalculatePerimeter()
        {
            return 2 * pi * radius;
        }



        public void Draw()
        {
            Console.WriteLine("Shape is Circle And Area={0} \tPereimeter={1}", CalculateArea(), CalculatePerimeter());
        }
    }

}
