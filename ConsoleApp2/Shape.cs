using System;
using System.Collections.Generic;
using System.Text;

namespace BT_Auto_2021_Programming
{
    class Shape : AbstractShape
    {
        ConsoleColor color;

        protected void Test()
        {

        }

        public override void Draw()
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

        public override void Color()
        {
            throw new NotImplementedException();
        }


    }
}
