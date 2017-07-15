using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateMenu();

            Run:

            ConsoleKey key = ReadMenu();
            RunAssignment(key);

            if (key != ConsoleKey.Z)
            {
                goto Run;
            }
        }

        private static void CreateMenu()
        {
            Console.WriteLine("01 - Press 1 to run write hello and name in new line.");
            Console.WriteLine("02 - Press 2 to run Display Reverse Letter.");
            Console.WriteLine("03 - Press 3 to run  Displays Triangle.");
            Console.WriteLine("04 - Press 4 to run Check User Account.");
            Console.WriteLine("05 - Press 5 to run Perform An Operation.");
            Console.WriteLine("06 - Press 6 to run  Calculate The Perimeter");

            Console.WriteLine("07 - Press 7 to run Values Of the Function.");
            Console.WriteLine("08 - Press 8 to run Display Speed In Kilometer");
            Console.WriteLine("09 - Press 9 to run  Is Avowel Or Didgit.");

            Console.WriteLine("A - Press A to run Even or odd numbers");

            Console.WriteLine("B - Press B to run  Convert To Binary ");
            Console.WriteLine("F - Press F to run  Is  A vowel Or Didgit.");
            Console.WriteLine("Z - Press Z to exit the program.");
        }

        private static ConsoleKey ReadMenu()
        {
            ConsoleKeyInfo key = Console.ReadKey();
            Console.WriteLine("-------------");
            return key.Key;
        }

        private static void RunAssignment(ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.D1:
                    WriteHelloAndNameInNewLine();
                    break;
                case ConsoleKey.D2:
                    DisplayReverseLetter();
                    break;
                case ConsoleKey.D3:
                    DisplaysTriangle();
                    break;
                case ConsoleKey.D4:
                    CheckUserAccount();
                    break;
                case ConsoleKey.D5:
                    PerformAnOperation();
                    break;
                case ConsoleKey.D6:
                    CalculateThePerimeter();
                    break;
                case ConsoleKey.D7:
                    ValuesOftheFunction();
                    break;
                case ConsoleKey.D8:
                    DisplaySpeedInKilometer();
                    break;
                case ConsoleKey.D9:
                    IsAvowelOrDidgit();
                    break;
                case ConsoleKey.A:
                    EvenOrOddNumbers();
                    break;
                case ConsoleKey.B:
                    ConvertToBinary();
                    break;
                case ConsoleKey.C:

                    break;
                case ConsoleKey.D:

                    break;
                case ConsoleKey.E:

                    break;
                case ConsoleKey.F:

                    break;
                case ConsoleKey.G:

                    break;
                case ConsoleKey.H:

                    break;

                case ConsoleKey.Z:
                    Console.WriteLine("Bye bye");
                    break;
                default:
                    break;
            }
        }

        private static void WriteHelloAndNameInNewLine()
        {
            Console.WriteLine("Hello");
            Console.WriteLine("Maryam Kalsoom");
        }

        private static void DisplayReverseLetter()
        {

            char char1, char2, char3;

            Console.WriteLine("enter first letter");
            char1 = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("enter second letter");
            char2 = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("enterthird letter");
            char3 = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Reverse Letter is : {0} {1} {2}", char3, char2, char1);

        }

        private static void DisplaysTriangle()
        {
            Console.Write("Input a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the desired width: ");
            int width = Convert.ToInt32(Console.ReadLine());

            int height = width;
            for (int row = 0; row < height; row++)
            {
                for (int column = 0; column < width; column++)
                {
                    Console.Write(num);
                }

                Console.WriteLine();
                width--;
            }
        }


        private static void CheckUserAccount()
        {

            string username, password;
            int ctr = 0, dd = 0;
            Console.Write("\n\nCheck username and password :\n");
            Console.Write("N.B. : Defaule username and password is : username and password\n");
            Console.Write("---------------------------------\n");
            do
            {
                Console.Write("Input a username: ");
                username = Console.ReadLine();

                Console.Write("Input a password: ");
                password = Console.ReadLine();
                if (username == "username" && password == "password")
                {
                    dd = 1;
                    ctr = 3;
                }
                else
                {
                    dd = 0;
                    ctr++;
                }
            }
            while ((username != "username" || password != "password")
        && (ctr != 3));
            if (dd == 0)
            {
                Console.Write("\nLogin attemp more than three times. Try later!\n\n");
            }
            else
            if (dd == 1)
            {
                Console.Write("\nPassword entered successfull!\n\n");
            }
        }


        private static void PerformAnOperation()
        {
            int x, y;
            char operation;
            Console.Write("Input first number: ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input operation: ");
            operation = Convert.ToChar(Console.ReadLine());

            Console.Write("Input second number: ");
            y = Convert.ToInt32(Console.ReadLine());

            if (operation == '+')
                Console.WriteLine("{0} + {1} = {2}", x, y, x + y);

            else if (operation == '-')
                Console.WriteLine("{0} - {1} = {2}", x, y, x - y);

            else if ((operation == 'x') || (operation == '*'))
                Console.WriteLine("{0} * {1} = {2}", x, y, x * y);

            else if (operation == '/')
                Console.WriteLine("{0} / {1} = {2}", x, y, x / y);
            else
                Console.WriteLine("Wrong Character");
        }

        private static void CalculateThePerimeter()
        {
            double r, per_cir;
            double PI = 3.14;
            Console.WriteLine("input the radious of circle");
            r = Convert.ToDouble(Console.ReadLine());

            per_cir = 2 * PI * r;
            Console.WriteLine("perimeter of circle {0}", per_cir);


        }

        private static void ValuesOftheFunction()
        {
            int x, y;
            Console.WriteLine("x = y² - 2y +1");
            Console.WriteLine();
            for (y = -5; y < 5; y++)
            {
                x = y * y - 2 * y + 1;
                Console.WriteLine("y = {0};x=({0})2-2*({0})+1 = {1}", x, y);
            }
        }

        private static void DisplaySpeedInKilometer()
        {
            float distance, hour, mins, sec;

            float timesec, mph, kph, mps;

            Console.WriteLine("input distance");
            distance = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("timeSec(hour):");
            hour = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("timeSec(minutes):");
            mins = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("timeSec(seconds):");
            sec = Convert.ToSingle(Console.ReadLine());

            timesec = (hour * 3600) + (mins * 60) + sec;
            mps = distance / timesec;
            kph = (distance / 1000.0f) / (timesec / 3600.0f);
            mph = kph / 1.609f;
            Console.WriteLine("Your speed in meters/sec is {0}", mps);
            Console.WriteLine("Your speed in km/h is {0}", kph);
            Console.WriteLine("Your speed in miles/h is {0}", mph);

        }




        private static void IsAvowelOrDidgit()
        {
            char symbol;
            Console.WriteLine("input a symbol");
            symbol = Convert.ToChar(Console.ReadLine());

            if ((symbol == 'a') || (symbol == 'i') || (symbol == 'o') || (symbol == 'u'))
                Console.WriteLine("its a lower case vowle");

            else if ((symbol >= '0') && (symbol <= '9'))
                Console.WriteLine("its a digit");

            else
                Console.WriteLine("it's another symbol");
        }

        private static void EvenOrOddNumbers()
        {
            int num1, num2;
            bool botheven;
            Console.WriteLine("Check numbers even or odd");
            Console.WriteLine("entre first number");
            num1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("entre first number");
            num2 = Int32.Parse(Console.ReadLine());

            botheven = ((num1 % 2 == 0) && (num2 % 2 != 0)) ? true : false;
            Console.WriteLine(botheven ?
        "there're numbers bothEven" :
        "there's a number odd");
        }

        private static void ConvertToBinary()
        {
            string ans, result;
            Console.WriteLine("input number:");
            ans = Console.ReadLine();

            int num = Convert.ToInt32(ans);
            result = "";

            while (num > 1)
            {
                int remainder = num % 2;
                result = Convert.ToString(remainder) + result;
                num /= 2;
            }
            result = Convert.ToString(num) + result;
            Console.WriteLine("Binary: {0}", result);

        }


    }
}
