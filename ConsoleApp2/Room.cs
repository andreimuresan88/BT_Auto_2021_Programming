using System;
using System.Collections.Generic;
using System.Text;

namespace BT_Auto_2021_Programming
{
    public enum RoomType
    {
        MeetingRoom,
        Kitchen,
        WorkingSpace,
        DepositSpace
    }

    class Room
    {

        double roomArea;
        string[] accessories;
        double capacity;
        RoomType roomType;

        public double RoomArea { get => roomArea; set => roomArea = value; }
        public string[] Accessories { get => accessories; set => accessories = value; }
        public double Capacity { get => capacity; set => capacity = value; }
        public RoomType RoomType { get => roomType; set => roomType = value; }

        public Room(double roomArea, string[] accessories, double capacity, RoomType roomType)
        {
            this.roomArea = roomArea;
            this.accessories = accessories;
            this.capacity = capacity;
            this.roomType = roomType;
        }

        public Room()
        {
        }
    }
}
