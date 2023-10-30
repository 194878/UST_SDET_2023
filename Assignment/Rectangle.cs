using Assignment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Rectangle : Shape, IDrawable
    {
        double length, breadth;

        public Rectangle(double length, double breadth)
        {
            this.length = length;
            this.breadth = breadth;
        }

        public override double CalculateArea()
        {
            return length * breadth;
        }

        public override double CalculatePerimeter()
        {
            return 2 * (length + breadth);
        }



        public void Draw()
        {
            Console.WriteLine("Shape is Rectangle And Area={0} \tPereimeter={1}", CalculateArea(), CalculatePerimeter());
        }
    }
}