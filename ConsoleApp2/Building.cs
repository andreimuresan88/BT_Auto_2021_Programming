using System;
using System.Collections.Generic;
using System.Text;

namespace BT_Auto_2021_Programming
{
    class Building : AbstractBuilding
    {
        List<Floor> floors = new List<Floor>();
        const int MAX_CAPACITY = 300;

        public Building(List<Floor> floors)
        {
            this.floors = floors;
        }

        public Building()
        {
        }

        public double ComputingArea()
        {
            double area = 0;
            foreach(Floor f in floors){
                foreach(Room r in f.Rooms)
                {
                    area = area + r.RoomArea;
                }
            }
            return area;
        }

        public int GetNumberOfFloors()
        {
            return floors.Count;
        }

        public int GetTotalNumberOfRooms()
        {
            int totalNumerOfRooms = 0;
            foreach(Floor f in floors)
            {
                totalNumerOfRooms = totalNumerOfRooms + f.Rooms.Count;
            }
            return totalNumerOfRooms;
        }

        public double TotalCapacity()
        {
            double capacity =0;
            foreach(Floor f in floors)
            {
                foreach(Room r in f.Rooms)
                {
                    capacity = capacity + r.Capacity;
                }
            }

            if(capacity > MAX_CAPACITY)
            {
                throw new BuildingException("The capacity is greater than MAX CAPACITY");
            }
            return capacity;
        }

        public static void PrintBuilding(Building building)
        {
            Console.WriteLine("Number of rooms: {0}, total area: {1}, total capacity {2}, floor count {3} ", 
                building.GetTotalNumberOfRooms(),
                building.ComputingArea(), 
                building.TotalCapacity(), 
                building.GetNumberOfFloors());
        }
    }
}
