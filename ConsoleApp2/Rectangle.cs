using System;
using System.Collections.Generic;
using System.Text;

namespace BT_Auto_2021_Programming
{
    class Rectangle : Shape
    {
        double length;
        double width;

        public Rectangle(double length, double width)
        {

        }

        public Rectangle()
        {

        }

        public void SetSize(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        public double GetLength()
        {
            return length;
        }

        public void SetLength(double length)
        {
            if (length > 0)
            {
                this.length = length;
            }
            else
            {
                Console.WriteLine("length should be positive");
            }
        }

        public virtual double GetArea()
        {
            return length * width;
        }

        public virtual double GetPerimeter()
        {
            return 2 * (length + width);
        }

        public virtual double GetDiagonal()
        {
            return Math.Sqrt(Math.Pow(width, 2) + Math.Pow(length, 2));
        }

        public void PrintRectangle()
        {
            //Console.WriteLine("The rectangle with length {0} asn width {1} has area {2}", length, width, GetArea());
            Console.WriteLine("Area is {0} perimeter is {1} diagonal {2}", GetArea(), GetPerimeter(), GetDiagonal());
        }

        public override string ToString()
        {
            return "this is a rectangle  with " + width + "width and " + length + "length";
        }

        public override void Draw()
        {
            //base.Draw(); apeleaza metoda din parinte
            Console.WriteLine("drawing a rectangle");
        }

    }
}
