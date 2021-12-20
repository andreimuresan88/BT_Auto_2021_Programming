using System;
using System.Collections.Generic;
using System.Text;

namespace BT_Auto_2021_Programming
{
    class Teacher : Person
    {

        string courseSpecialisation;
        string university;
        double salary;

        public Teacher(string courseSpecialisation, string university, double salary)
        {
            this.courseSpecialisation = courseSpecialisation;
            this.university = university;
            this.salary = salary;
        }

        public Teacher(string courseSpecialisation, string university, double salary, string name, char sex)
        {
            this.courseSpecialisation = courseSpecialisation;
            this.university = university;
            this.salary = salary;
            this.SetName(name);
            this.SetSex(sex);
        }

        public Teacher()
        {

        }

        public void Teach()
        {
            Console.WriteLine("Teacher is teaching specialization {0} ", courseSpecialisation);
        }

        public void PrintTeacher()
        {
            base.PrintPersone();
            Console.WriteLine("the teacher works at university {0} on specialization {1} and has salary {2}", university, courseSpecialisation, salary);
        }
    }
}
