using System;

namespace Vectors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Which function do you wish to do?");
            Console.WriteLine("1. Length of Vector");
            Console.WriteLine("2. Add Two Vectors");
            Console.WriteLine("3. Subtract Two Vectors");
            Console.WriteLine("4. Scalar Multiplication");
            int menuChoice = int.Parse(Console.ReadLine());

            switch (menuChoice)
            {
                case 1:
                    VectorLength();
                    break;
                case 2:
                    AddVectors();
                    break;
                case 3:
                    SubtractVectors();
                    break;
                case 4:
                    ScalarMultiply();
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    Thread.Sleep(2000);
                    break;
            }
        }

        public static void VectorLength()
        {
            Console.WriteLine("Enter the x-coordinate of the vector:");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the y-coordinate of the vector:");
            double y = double.Parse(Console.ReadLine());

            double length = Math.Sqrt(x * x + y * y); // Length = √(x² + y²)
            Console.WriteLine($"The length of the vector is: {length}");
            Console.ReadLine();
        }

        public static void AddVectors()
        {
            Console.WriteLine("Enter the x-coordinate of the first vector:");
            double x1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the y-coordinate of the first vector:");
            double y1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the x-coordinate of the second vector:");
            double x2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the y-coordinate of the second vector:");
            double y2 = double.Parse(Console.ReadLine());

            double sumX = x1 + x2; // Literally just add them together
            double sumY = y1 + y2;

            Console.WriteLine($"Vector A + Vector B = : ({sumX}, {sumY})");
            Console.ReadLine();
        }

        public static void SubtractVectors()
        {
            Console.WriteLine("Enter the x-coordinate of the first vector:");
            double x1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the y-coordinate of the first vector:");
            double y1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the x-coordinate of the second vector:");
            double x2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the y-coordinate of the second vector:");
            double y2 = double.Parse(Console.ReadLine());

            double diffX = x1 - x2; // Literally just subtract them
            double diffY = y1 - y2;

            Console.WriteLine($"Vector A - Vector B = : ({diffX}, {diffY})");
            Console.ReadLine();
        }

        public static void ScalarMultiply()
        {
            Console.WriteLine("Enter the x-coordinate of the vector:");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the y-coordinate of the vector:");
            double y = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the scalar value:");
            double scalar = double.Parse(Console.ReadLine());

            double resultX = x * scalar; // Multiply x-component by scalar
            double resultY = y * scalar; // Multiply y-component by scalar

            Console.WriteLine($"The resulting vector after scalar multiplication is: ({resultX}, {resultY})");
            Console.ReadLine();
        }
    }
}
