using BT_Auto_2021_Programming;
using System;

namespace ConsoleApp2
{
    class Program
    {

        public static void runEx(string[] args)
        {
            const int MAX_SIZE = 100;
            const double PI = 3.1415;
            const int MAX_NUMBER = 5;

            Console.WriteLine("Hello World!");

            int numberOfStudents = 5;
            int count;
            count = 7;
            int a, b;
            a = numberOfStudents + 1;
            a = a + numberOfStudents;

            float numerFloat = 5.6f;
            float numerFloat2 = (float)5.6;
            double numerDouble = 5.6;

            float f = (float)numerDouble;
            int numberInt = (int)f;
            long i = numberOfStudents;

            bool myBoolean = false;

            char ch = 'a';

            string myString = "Ana are mere si pere";
            string result = myString + "si struguri";
            Console.WriteLine(result);

            DateTime dataCurenta = new DateTime(2021, 12, 8);

            Console.WriteLine(dataCurenta);

            Console.WriteLine(numerDouble * a);
            Console.WriteLine(numerFloat * a);
            Console.WriteLine(numerFloat / a);
            Console.WriteLine(numerDouble / a);
            Console.WriteLine(5 / 6);
            Console.WriteLine(5 / 6f);
            Console.WriteLine(5 / 6.0);
            Console.WriteLine(5 % 6);

            int x = 2;
            x = x + 5;
            x += 5;

            Console.WriteLine((x == a));
            Console.WriteLine((x < a));
            Console.WriteLine((x > a));
            Console.WriteLine((x != a));


            Console.WriteLine(typeof(int).IsPrimitive);
            Console.WriteLine("Hello World!");

            int[] list = { 1, 3, 4, 6 };
            for (int j = 0; j < list.Length; j++)
            {
                Console.Write(list[j] + " ");
            }

            int number = 53;
            //int number = -100;
            //int number = 0;
            if (number >= 0)
            {
                Console.WriteLine("number is positive");
            }
            else
            {
                Console.WriteLine("number is negative");
            }

            if (number % 2 == 0)
            {
                Console.WriteLine("evan number!");
            }
            else
            {
                Console.WriteLine("odd number");
            }

            if (number <= 40 && number >= 0)
            {
                if (number <= 20)
                {
                    Console.WriteLine("Student failed");
                }
                else
                {
                    Console.WriteLine("student passed");
                }
            }
            else
            {
                Console.WriteLine("number si invalid");
            }
            //one line if/else
            Console.WriteLine((number % 2 == 0 ? "even" : "odd"));

            if (number == 1)
            {
                Console.WriteLine("Monday");
            }
            if (number == 2)
            {
                Console.WriteLine("Tuesday");
            }
            if (number == 3)
            {
                Console.WriteLine("Wedneday");
            }
            if (number == 4)
            {
                Console.WriteLine("Thurday");
            }
            if (number == 5)
            {
                Console.WriteLine("Friday");
            }
            if (number == 6)
            {
                Console.WriteLine("Saturday");
            }
            if (number == 7)
            {
                Console.WriteLine("Sunday");
            }
            if (number > 7 || number < 0)
            {
                Console.WriteLine("invalid number");
            }

            switch (number)
            {
                case 1:
                    {
                        Console.WriteLine("Monday");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Tuesday");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Wedneday");
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Thurday");
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("Friday");
                        break;
                    }
                case 6:
                    {
                        Console.WriteLine("Saturday");
                        break;
                    }
                case 7:
                    {
                        Console.WriteLine("Sunday");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("invalid number");
                        break;
                    }
            }

            int counter = 0;
            while (counter <= MAX_NUMBER)
            {
                Console.WriteLine("Current number is: " + counter);
                Console.WriteLine("Current number is: " + counter.ToString());
                counter++;
            }

            counter = 0;
            do
            {
                Console.WriteLine("Current number is: " + counter);
                counter++;
            } while (counter <= MAX_NUMBER);

            for (counter = 0; counter < MAX_NUMBER; counter++)
            {
                Console.WriteLine("Counter number is: {0}", counter);
            }

            foreach (String argument in args)
            {
                Console.WriteLine("the argument is: {0}", argument);
            }

            int year = 1900;
            int febDays = 28;

            foreach (string yr in args)
            {
                int febDayss = 28;
                year = int.Parse(yr);
            }

            if (year % 4 == 0)
            {
                if (year % 100 == 0 && year % 400 != 0)
                {
                    febDays = 29;
                }
                if (year % 100 != 0)
                {
                    febDays = 29;
                }
            }
            if (year < 1900 || year > 2018)
            {
                Console.WriteLine("year si out of valid bounds");
            }
            else
            {
                if ((year % 4 == 0 && year % 100 == 0 && year % 400 != 0) || (year % 4 == 0 && year % 100 != 0))
                {
                    febDays = 29;
                }
            }

            Console.WriteLine("Feb has {0} days", febDays);
        }


        public static void runEx1(string[] args)
        {
            if (args.Length == 3)
            {

                float a = float.Parse(args[0]);

                float b = float.Parse(args[2]);

                string op = args[1];

                float result=0;
                // implement calculator logic here
                switch (op)
                {
                    case "+":
                        {
                            result = a + b;
                            break;
                        }
                    case "-":
                        {
                            result = a - b;
                            break;
                        }
                    case "*":
                        {
                            result = a * b;
                            break;
                        }
                    case "/":
                        {
                            result = a / b;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid op");
                            break;
                        }

                }

                Console.WriteLine("Result is: " + result);

            }
            else
            {

                Console.WriteLine("3 args are needed!");

            }
        }

        //Calculate the sum of the first 100 numbers higher than 0
        public static void runEx2()
        {
            int number = 100;
            int sum = 0;
            for (int i = 1; i < number + 1; i++)
            {
                sum += i;
            }
            Console.WriteLine("The sum for the first 100 numbers is: " + sum);
        }


        ////Check if a number is palindrome ( e.g. palindrome 1221, 34143)
        public static void runEx3()
        {
            int number = 1221;
            int sum = 0, temp;
            temp = number;
            while (number > 0)
            {
                sum = (sum * 10) + number % 10;
                number = number / 10;
            }
            if (temp == sum)
                Console.WriteLine(number +" is palindrome.");
            else
                Console.WriteLine(number +" is not palindrome");
        }

        public static Boolean isPrim(int x)
        {
            if(x == 0 || x == 1)
            {
                return false;
            }
            if(x == 2)
            {
                return true;
            }
            for(int i=2; i<=x/2; i++)
            {
                if (x % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        //Display all the prime numbers lower than a given number
        public static void runEx4()
        {
            int number = 30;
            int counter = 0;
            for (int i = 2; i <= number; i++)
            {
                if (isPrim(i))
                {
                    counter++;
                    Console.WriteLine("{0}. : "+i + " is prim", counter);
                }
            }
        }

        static void Main(string[] args)
        {
            //runEx(args);
            //runEx1(args);
            //runEx2();
            //runEx3();
            //runEx4();
            Course02(args);
        }

        static void Course02(string[] args)
        {
            Circle c1 = new Circle();
            Circle c2 = new Circle();
            c1.setRadius(10);
            double area = c1.getArea();
            Console.WriteLine(area);
            //Console.WriteLine(c1.getArea());
            c1.PrintCircle();
            Circle c3 = new Circle();
            c3.setRadius(5);
            //Console.WriteLine(c3.getArea());
            c3.PrintCircle();
            c2.PrintCircle();
            foreach (string s in args)
            {
                Circle c = new Circle();
                c.setRadius(Double.Parse(s));
                Square sq = new Square();
                sq.setSide(Double.Parse(s));
                c.PrintCircle();
                sq.printSquare();
                Rectangle r = new Rectangle();
                r.SetSize(Double.Parse(s), Double.Parse(s));
                r.PrintRectangle();
            }

            Person p1 = new Person();
            p1.SetName("Alex");
            p1.SetSex('m');
            p1.Eat();
            p1.Run();
            p1.Eat();
            p1.PrintPersone();

            Rectangle r1 = new Rectangle();
            r1.SetSize(2, 3);
            r1.PrintRectangle();
          
        }        
    }
}
