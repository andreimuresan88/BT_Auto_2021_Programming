﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BT_Auto_2021_Programming
{
    class Person
    {
        string name;
        char sex;
        string[] nationality;
        bool isHungry;
        DateTime dob;

        public void Eat()
        {
            Console.WriteLine("The pesone is eating..");
                isHungry = false;
        }

        public void Run()
        {
            Console.WriteLine("The pesrons is running....");
            isHungry = true;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public void SetSex(char sex)
        {
            this.sex = sex;
        }

        public void PrintPersone()
        {
            Console.WriteLine("Name of the person is {0} ", name);
            Console.WriteLine("-> Current state for hungry is {0}", isHungry);
            Console.WriteLine("-> ");
            Console.WriteLine(" ");
        }
    }
}
