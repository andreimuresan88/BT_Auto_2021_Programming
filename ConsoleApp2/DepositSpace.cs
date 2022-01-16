using System;
using System.Collections.Generic;
using System.Text;

namespace BT_Auto_2021_Programming
{
    class DepositSpace : Room
    {
        public DepositSpace()
        {
        }

        public DepositSpace(double roomArea, string[] accessories, double capacity) : base(roomArea, accessories, capacity)
        {
        }
    }
}
