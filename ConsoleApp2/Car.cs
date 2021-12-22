using System;
using System.Collections.Generic;
using System.Text;

namespace BT_Auto_2021_Programming
{
    class Car
    {
        double currentAcceleration;
        bool cardStatus;
        double direction;

        float fuelLevel;
        byte gear;
        float speed;
        ConsoleColor color;
        const byte MAX_GEAR = 6;
        string carName;

        public Car(double currentAcceleration, bool cardStatus, double direction, float fuelLevel, byte gear, float speed, ConsoleColor color) : this(currentAcceleration, cardStatus, direction)
        {
            this.fuelLevel = fuelLevel;
            this.gear = gear;
            this.speed = speed;
            this.color = color;
        }

      

        public Car(double currentAcceleration, bool cardStatus, double direction)
        {
            this.currentAcceleration = currentAcceleration;
            this.cardStatus = cardStatus;
            this.direction = direction;
        }

        public Car()
        {
        }

        public void Accelerate(double speedDelta)
        {
            currentAcceleration += speedDelta;
        }

        public void Decelarate(double spedDelta)
        {
            if(currentAcceleration - spedDelta < 0)
            {
                currentAcceleration = 0;
            }
            else
            {
                currentAcceleration -= spedDelta;
            }
        }

        public void Steer(double angle)
        {
            direction += angle;
        }

        public void GearUp()
        {
            if(gear == MAX_GEAR)
            {
                Console.WriteLine("Cannot increase gear, we are at maximim gear: {0}", MAX_GEAR);
            }
            else
            {
                gear++;
            }
        }

        public void GearDown()
        {
            if(gear == 0)
            {
                Console.WriteLine("Already on gear 0");
            }
            else
            {
                gear--;
            }
        }

        public void Accelerate()
        {
            currentAcceleration += 5;
        }

        public void Start()
        {
            cardStatus = true;
        }

        public void Stop()
        {
            cardStatus = false;
            speed = 0;
            gear = 0;
        }

        public void TurnLeft() 
        {
            direction -= 90;
        }

        public void TurnRight()
        {
            direction += 90;
        }

        public static double ConvertHpToKw(double hp)
        {
            return hp * 0.735499;
        }

        public void PrintCar()
        {
            Console.WriteLine("Current status of the car is: ");
            Console.WriteLine("GearLevel {0}", gear);
            Console.WriteLine("Direction angle {0}", direction);
            Console.WriteLine("Car status {0)", cardStatus);
            Console.WriteLine("Car speed {0}" , speed);
            
        }
    }
}
