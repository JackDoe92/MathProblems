using System.Security.Cryptography.X509Certificates;

namespace LogicGates
{
    internal class Program

    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int menuInput;
            string checkInput;

            while (true)
            {
                Console.WriteLine("Please enter the first number");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the second number");
                num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please confirm the following inputs:");
                Console.WriteLine($"Num1 = {num1}");
                Console.WriteLine($"num2 - {num2}");
                Console.WriteLine("Y/N...");
                checkInput = Console.ReadLine();

                if (checkInput == "y")
                {
                    break;
                }
                if (checkInput == "n")
                {
                    Console.WriteLine("Restarting..");
                    Thread.Sleep(2000);
                }
            }

            Console.WriteLine("Which logic gate do you want to use?");
            Console.WriteLine("1. AND (A · B)");
            Console.WriteLine("2. OR (A + B)");
            Console.WriteLine("3. NOT (¬A or A’)");
            Console.WriteLine("4. NANA ((A · B)')");
            Console.WriteLine("5. NOR");
            Console.WriteLine("6. XOR");
            Console.WriteLine("7. XNOR");

            menuInput = Convert.ToInt32(Console.ReadLine());

            switch (menuInput)
            {
                case 1:
                    And(num1,num2);
                    break;
            }
        }

        public static void And(int num1, int num2)
        {
            if (num1 == 1 && num2 == 1)
            {
                Console.WriteLine($"AND Gate input: {num1} & {num2}");
                Console.WriteLine("AND Gate output: 1");
            }
            else
            {
                Console.WriteLine($"AND Gate input: {num1} & {num2}");

                Console.WriteLine($"AND Gate output: 0");

            }

        }
    }
}
