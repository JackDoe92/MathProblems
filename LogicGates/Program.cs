namespace LogicGates
{
    internal class Program
    {
        public static int input1;
        public static int input2;

        static void Main(string[] args)
        {
            Console.WriteLine("Please provide the first input: ");
            input1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please provide the second input: ");
            input2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Which gate logic do you wish to use?");
            Console.WriteLine("1. AND gate");
            Console.WriteLine("2. OR gate");
            Console.WriteLine("3. NAND gate");
            Console.WriteLine("4. NOR gate");
            Console.WriteLine("5. XOR gate");
            Console.WriteLine("6. XNOR gate");
            int menuChoice = int.Parse(Console.ReadLine());

            switch (menuChoice)
            {
                case 1:
                    AND(input1, input2);
                    break;
                case 2:
                    OR(input1, input2);
                    break;
                case 3:
                    NAND(input1, input2);
                    break;
                case 4:
                    NOR(input1, input2);
                    break;
                case 5:
                    XOR(input1, input2);
                    break;
                case 6:
                    XNOR(input1, input2);
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }
        }

        public static void AND(int input1, int input2)
        {
            int output = input1 & input2;
            Console.WriteLine($"AND gate output: {output}");
        }

        public static void OR(int input1, int input2)
        {
            int output = input1 | input2;
            Console.WriteLine($"OR gate output: {output}");
        }

        public static void NAND(int input1, int input2)
        {
            int output = ~(input1 & input2) & 1;
            Console.WriteLine($"NAND gate output: {output}");
        }

        public static void NOR(int input1, int input2)
        {
            int output = ~(input1 | input2) & 1;
            Console.WriteLine($"NOR gate output: {output}");
        }

        public static void XOR(int input1, int input2)
        {
            int output = input1 ^ input2;
            Console.WriteLine($"XOR gate output: {output}");
        }

        public static void XNOR(int input1, int input2)
        {
            int output = ~(input1 ^ input2) & 1;
            Console.WriteLine($"XNOR gate output: {output}");
        }
    }
}
