namespace PrimeFactors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Goodbye, World!");
            PrimeFactorization();
        }
        public static void PrimeFactorization()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Enter a number for prime factorization (or type 'exit' to return to the menu): ");
                string input = Console.ReadLine().ToLower();

                if (input == "exit")
                {
                    break;
                }

                if (!int.TryParse(input, out int number) || number < 1) //check for valid input
                {
                    Console.WriteLine("Invalid input. Please enter a positive whole number.");
                    Thread.Sleep(1000);
                    continue;
                }

                Console.Write($"\nPrime factorization of {number} is: ");

                while (number % 2 == 0) //hardcode for 2
                {
                    Console.Write("2 ");
                    number /= 2;
                }

                int divisor = 3;
                while (divisor * divisor <= number) // check up to square root of number (big brain)
                {
                    while (number % divisor == 0)
                    {
                        Console.Write(divisor + " ");
                        number /= divisor;
                    }
                    divisor += 2; //  next odd number
                }

                if (number > 1)
                {
                    Console.Write(number);
                }

                Console.WriteLine("\n\nPress any key to factorize another number or type 'exit' to return to the menu.");
                if (Console.ReadLine().ToLower() == "exit")
                {
                    break;
                }
            }
        }
    }
}
