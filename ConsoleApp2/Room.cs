using System;
using System.Collections.Generic;
using System.Text;

namespace BT_Auto_2021_Programming
{
    class Room
    {
        double roomArea;
        string[] accessories;
        double capacity;

        public double RoomArea { get => roomArea; set => roomArea = value; }
        public string[] Accessories { get => accessories; set => accessories = value; }
        public double Capacity { get => capacity; set => capacity = value; }

        public Room(double roomArea, string[] accessories, double capacity)
        {
            this.roomArea = roomArea;
            this.accessories = accessories;
            this.capacity = capacity;
        }

        public Room()
        {
        }
    }
}
