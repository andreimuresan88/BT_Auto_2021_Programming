using System;
using System.Collections.Generic;
using System.Text;

namespace BT_Auto_2021_Programming
{
    class Student : Person
    {
        string currentStudyYear;
        bool hasScholarship;
        bool hasDormRoom;
        string[] courses;


        public Student(string currentStudyYear, bool hasScholarship, bool hasDormRoom, string name, char sex)
        {
            this.currentStudyYear = currentStudyYear;
            this.hasScholarship = hasScholarship;
            this.hasDormRoom = hasDormRoom;
            this.SetName(name);
            this.SetSex(sex);
        }

        public Student()
        {

        }

        public void PrintStudent()
        {
            base.PrintPersone();
            Console.WriteLine("currentStudyYear {0}, hasScholarship {1}, hasDormRoom {2}", currentStudyYear, hasScholarship, hasDormRoom);
        }
    }
}
