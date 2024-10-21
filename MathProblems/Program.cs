using System.Net.NetworkInformation;
using System.Runtime;
using System.Security.Cryptography.X509Certificates;

namespace MathProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool validAnswer = false;

            while (!validAnswer)
            {
                Console.Clear();
                Console.WriteLine("Please select one of the following options: ");
                Console.WriteLine("1. Prime Number Check");
                Console.WriteLine("2. LCM");
                Console.WriteLine("3. Mods");
                Console.WriteLine("4. Exit");

                string menuInput = Console.ReadLine().ToLower();

                switch (menuInput)
                {
                    case "1":
                    case "one":
                        PrimeNums();
                        break;
                    case "2":
                    case "two":
                        LCM();
                        break;
                    case "3":
                    case "three":
                        Mods();
                        break;
                    case "4":
                    case "four":
                        Console.Clear();
                        Console.WriteLine("Quitting..");
                        Thread.Sleep(1000);
                        validAnswer = true;
                        break;
                    default:
                        Console.WriteLine("Invalid Input, please enter a valid number.");
                        Thread.Sleep(1000);
                        break;
                }

                if (!validAnswer)
                {
                    StatusCheck(ref validAnswer);
                }
            }
        }

        public static void PrimeNums()
        {
            Console.WriteLine("You launched Prime Number Check.");
        }

        public static void LCM()
        {
            Console.WriteLine("You launched LCM.");
        }

        public static void Mods()
        {
            Console.WriteLine("You launched Mods.");
        }

        public static void StatusCheck(ref bool quit)
        {
            while (true)
            {
                Console.WriteLine("\nPress 'Q' to quit or any other key to continue.");
                var inputKey = Console.ReadKey().Key;
                if (inputKey == ConsoleKey.Q)
                {
                    Console.WriteLine("\nQuitting...");
                    quit = true;
                    break;
                }
                else
                {
                    Console.Clear();
                    break;
                }
            }
        }
    }
}
