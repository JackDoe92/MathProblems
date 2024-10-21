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
                        Console.WriteLine("Exiting the program...");
                        Thread.Sleep(1000);
                        validAnswer = true;
                        break;
                    default:
                        Console.WriteLine("Invalid input. Please select a valid number.");
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
            bool continueChecking = true;

            while (continueChecking)
            {
                Console.Clear();
                Console.WriteLine("Please enter a whole number (or type 'exit' to go back to the menu): ");
                string input = Console.ReadLine().ToLower();

                if (input == "exit")
                {
                    break;  
                }

                if (!int.TryParse(input, out int primeInput))  
                {
                    Console.WriteLine("Invalid input. Please enter a valid whole number.");
                    Thread.Sleep(1000);
                    continue;
                }

                
                Console.Clear();

                if (primeInput <= 1) // check if num is 1 or less.
                {
                    Console.WriteLine($"{primeInput} is NOT a prime number.");
                }
                else if (primeInput == 2) // check if num is 2
                {
                    Console.WriteLine($"{primeInput} is a prime number.");
                }
                else if (primeInput % 2 == 0) // check is num is even number
                {
                    Console.WriteLine($"{primeInput} is NOT a prime number.");
                }
                else
                {
                    bool isPrime = true;
                    for (int i = 3; i <= Math.Sqrt(primeInput); i += 2) // check if num is divisible by 3 upto square root of num
                    {
                        if (primeInput % i == 0)
                        {
                            Console.WriteLine($"{primeInput} is NOT a prime number.");
                            isPrime = false;
                            break;
                        }
                    }

                    if (isPrime) // is prime
                    {
                        Console.WriteLine($"{primeInput} is a prime number.");
                    }
                }

                Console.WriteLine("\nDo you want to check another number? (type 'yes' to continue or 'exit' to return to the menu)");
                string continueInput = Console.ReadLine().ToLower();

                if (continueInput != "yes")
                {
                    break; 
                }
            }
        }

        public static void LCM()
        {
            Console.Clear();
            Console.WriteLine("You launched LCM.");
            Thread.Sleep(1000);
        }

        public static void Mods()
        {
            Console.Clear();
            Console.WriteLine("You launched Mods.");
            Thread.Sleep(1000);
        }

        public static void StatusCheck(ref bool quit)
        {
            while (true)
            {
                Console.WriteLine("\nPress 'Q' to quit or any other key to continue to the menu.");
                var inputKey = Console.ReadKey().Key;
                if (inputKey == ConsoleKey.Q)
                {
                    Console.Clear();
                    Console.WriteLine("\nQuitting the program...");
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
