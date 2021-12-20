using System;
using System.Collections.Generic;
using System.Text;

namespace BT_Auto_2021_Programming
{
    class Shape
    {
        ConsoleColor color;

        public virtual void Draw()
        {
            Console.WriteLine("we are drawing a shape");
        }

        public virtual void Erase()
        {
            Console.WriteLine("we are erasing the shpae");
        }

        public ConsoleColor GetColor()
        {
            return color;
        }

        public void SetColor(ConsoleColor color)
        {
            this.color = color;
        }

        public override string ToString()
        {
            return "this is a generic shape";
        }
    }
}
