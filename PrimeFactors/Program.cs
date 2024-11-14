namespace PrimeFactors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number for prime factorization: ");
            int input = int.Parse(Console.ReadLine());
            Console.Write($"\nPrime factorization of {input} is: ");

            //**************************************************************//


            while (input % 2 == 0) // check if divisible by 2 (Only even prime)
            {
                Console.Write("2 ");
                input /= 2;
            }

            //**************************************************************//

            int divisor = 3; // start at 3 (first odd prime)
            while (divisor * divisor <= input) // Check all numbers for divisability from 3 to the square root of input
            {
                while (input % divisor == 0)
                {
                    Console.Write(divisor + " ");
                    input /= divisor;
                }
                divisor += 2; // Skip even numbers
            }
            //**************************************************************//

            if (input > 1) // If there's any remaining prime factor
            {
                Console.Write(input);
            }
            Console.ReadLine();
        }
    }
}
