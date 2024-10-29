using System.Net.NetworkInformation;
using System.Runtime;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Xml;
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
                Console.WriteLine("2. Gib Prime Factorization");
                Console.WriteLine("3. Divisibility");
                Console.WriteLine("4. Check Digits: barcodes (UPC)");
                Console.WriteLine("5. Check Digits: ISBN");
                Console.WriteLine("6. LCM: Generate random number");
                Console.WriteLine("7. Mods! (X x Y) mod 9 = Z etc");
                Console.WriteLine("8. Caesar Cypher: code");
                Console.WriteLine("9. Caesar Cypher: decode");
                Console.WriteLine("10. Affine Cypher: code");
                Console.WriteLine("11. Affine Cypher: decode");
                Console.WriteLine("12. Hill Cypher: code");
                Console.WriteLine("13. Hill Cypher: decode");
                Console.WriteLine("14. RSA code");
                Console.WriteLine("15. RSA Decode");
                Console.WriteLine("16. Exit");


                string menuInput = Console.ReadLine().ToLower();

                switch (menuInput)
                {
                    case "1":
                    case "one":
                        PrimeNums(); // working
                        break;
                    case "2":
                    case "two":
                        PrimeFactorization();
                        break;
                    case "3":
                    case "three":
                        Divisibility();
                        break;
                    case "4":
                    case "four":
                        Barcodes();
                        break;
                    case "5":
                    case "five":
                        ISBN();
                        break;
                    case "6":
                    case "six":
                        LCM();
                        break;
                    case "7":
                    case "seven":
                        Mods();
                        break;
                    case "8":
                    case "eight":
                        CaeserCode();
                        break;
                    case "9":
                    case "nine":
                        CaeserDecode();
                        break;
                    case "10":
                    case "ten":
                        AffineCode();
                        break;
                    case "11":
                    case "eleven":
                        AffineDecode();
                        break;
                    case "12":
                    case "twelve":
                        HillCode();
                        break;
                    case "13":
                    case "thirteen":
                        HillDecode();
                        break;
                    case "14":
                    case "fourteen":
                        RSACode();
                        break;
                    case "15":
                    case "fifteen":
                        RSADecode();
                        break;
                    case "16":
                    case "Sixteen":
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

        public static void LCM()
        {
            // Sequence seed, a, c, m. 
            //Create an empty list to store the sequence. 
            //set currentValue to seed.
            //While currentValue is not in the list:
            // append currentValue to the list
            //Calc nextValue (A* currentValue +C) mod M
            //Current value = nextValue
            //Return the list.

            // Xn+1 = (A x Xn + C) Mod M
            

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Gib seed (or type 'exit' to return to the menu):");
                string seedInput = Console.ReadLine();
                if (seedInput.ToLower() == "exit") break;
                if (!int.TryParse(seedInput, out int seed))
                {
                    Console.WriteLine("Invalid input. Please enter a number for the seed.");
                    Thread.Sleep(1000);
                    continue;
                }
                Console.WriteLine("Enter the multiplier (a):");
                if (!int.TryParse(Console.ReadLine(), out int a))
                {
                    Console.WriteLine("Gib multiplier.");
                    Thread.Sleep(1000);
                    continue;
                }

                Console.WriteLine("Gib increment (c):");
                if (!int.TryParse(Console.ReadLine(), out int c))
                {
                    Console.WriteLine("Invalid input. Please enter a number for the increment.");
                    Thread.Sleep(1000);
                    continue;
                }

                Console.WriteLine("Gib modulus (m):");
                if (!int.TryParse(Console.ReadLine(), out int m) || m <= 0)
                {
                    Console.WriteLine("Invalid input. Please enter a positive number for the modulus.");
                    Thread.Sleep(1000);
                    continue;
                }
            }
        }

        public static void Mods()
        {
            Console.Clear();
            Console.WriteLine("You launched Mods....That is all..");
            Thread.Sleep(1000);
        }
        private static void Divisibility()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Enter the first number for a divisibility check (or type 'exit' to return to the menu): ");
                string input = Console.ReadLine().ToLower();

                if (input == "exit")
                {
                    break;
                }

                if (!int.TryParse(input, out int number) || number < 1) // check for valid input
                {
                    Console.WriteLine("Invalid input. Please enter a positive whole number.");
                    Thread.Sleep(1000);
                    continue;
                }

                Console.WriteLine($"Thanks, I have received the number {input}. Can you now provide me with the divisor:");
                string input2 = Console.ReadLine();

                if (!int.TryParse(input2, out int number2) || number2 < 1) // check for valid divisor input
                {
                    Console.WriteLine("Invalid input. Please enter a positive whole number.");
                    Thread.Sleep(1000);
                    continue;
                }

                if (number % number2 == 0)
                {
                    Console.WriteLine($"{number} is divisible by {number2}.");
                }
                else
                {
                    Console.WriteLine($"{number} is NOT divisible by {number2}.");
                }

                Console.WriteLine("\nPress any key to check another pair or type 'exit' to return to the menu.");
                if (Console.ReadLine().ToLower() == "exit")
                {
                    break;
                }
            }
        }
        private static void Barcodes()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Enter a 12-digit UPC code (or type 'exit' to return to the menu): ");
                string input = Console.ReadLine().ToLower();

                if (input == "exit")
                {
                    break;
                }
                if (input.Length != 12 || !long.TryParse(input, out _))
                {
                    Console.WriteLine("Invalid input. Please enter exactly 12 digits.");
                    Thread.Sleep(1000);
                    continue;
                }
                int[] digits = input.Select(c => int.Parse(c.ToString())).ToArray(); // Convert to array

                // Calculate the sum 
                int sum = 0;
                for (int i = 0; i < 11; i++)
                {
                    if (i % 2 == 0) // Odd position 
                        sum += 3 * digits[i];
                    else // Even position
                        sum += digits[i];
                }

                // Calc check num
                int calculatedCheckDigit = sum % 10 == 0 ? 0 : 10 - (sum % 10);

                // Compare 
                int actualCheckDigit = digits[11];
                if (calculatedCheckDigit == actualCheckDigit)
                {
                    Console.WriteLine("The UPC code has a correct check digit.");
                }
                else
                {
                    Console.WriteLine($"The UPC code has an incorrect check digit. It should be {calculatedCheckDigit}.");
                }

                Console.WriteLine("\nPress any key to check another barcode or type 'exit' to return to the menu.");
                if (Console.ReadLine().ToLower() == "exit")
                {
                    break;
                }
            }
        }
        private static void ISBN()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Enter a 10-digit or 13-digit ISBN (or type 'exit' to return to the menu): ");
                string input = Console.ReadLine().ToLower();

                if (input == "exit")
                {
                    break;
                }

                if ((input.Length != 10 && input.Length != 13) || !long.TryParse(input, out _))
                {
                    Console.WriteLine("Invalid input. Please enter exactly 10 or 13 digits.");
                    Thread.Sleep(1000);
                    continue;
                }

                bool isValid = false;

                if (input.Length == 10)
                {
                    // ISBN-10 
                    int sum = 0;
                    for (int i = 0; i < 9; i++)
                    {
                        sum += (input[i] - '0') * (i + 1); // X each of the first 9 digits by it's position 
                    }

                    // Mod 11
                    int checkDigit = sum % 11;
                    char expectedCheckDigit = checkDigit == 10 ? 'X' : (char)(checkDigit + '0');

                    // Compare 
                    isValid = input[9] == expectedCheckDigit;
                }
                else if (input.Length == 13)
                {
                    // ISBN-13 
                    int sum = 0;
                    for (int i = 0; i < 12; i++)
                    {
                        int multiplier = (i % 2 == 0) ? 1 : 3; // X each digit by 1 or 3 (odd or even).
                        sum += (input[i] - '0') * multiplier;
                    }

                    // Mod 10
                    int mod = sum % 10;
                    int checkDigit = mod == 0 ? 0 : 10 - mod;

                    // Compare 
                    isValid = input[12] - '0' == checkDigit;
                }

                if (isValid)
                {
                    Console.WriteLine("The ISBN code has a correct check digit.");
                }
                else
                {
                    Console.WriteLine("The ISBN code has an incorrect check digit.");
                }

                Console.WriteLine("\nPress any key to check another ISBN or type 'exit' to return to the menu.");
                if (Console.ReadLine().ToLower() == "exit")
                {
                    break;
                }
            }
        }
        private static void CaeserCode()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Enter the text to encode (or type 'exit' to return to the menu):");
                string input = Console.ReadLine().ToLower();

                if (input == "exit")
                {
                    break;
                }
                Console.WriteLine("Enter the shift amount (e.g., 3 for a shift of 3 positions:");
                if (!int.TryParse(Console.ReadLine(), out int shift))
                {
                    Console.WriteLine("Invalid input. Please enter a whole number.");
                    Thread.Sleep(1000);
                    continue;
                }

                char[] buffer = input.ToCharArray();
                for (int i = 0; i < buffer.Length; i++)
                {
                    char letter = buffer[i];

                    if (char.IsLetter(letter)) //Only shift letters
                    {
                        char offset = char.IsUpper(letter) ? 'A' : 'a';
                        letter = (char)(((letter + shift - offset) % 26) + offset); //test me. 
                    }

                    buffer[i] = letter;
                }

                string encodedText = new string(buffer);
                Console.WriteLine($"Encoded text: {encodedText}");

                Console.WriteLine("\nPress any key to encode another text or type 'exit' to return to the menu.");
                if (Console.ReadLine().ToLower() == "exit")
                {
                    break;
                }
            }
        }

        private static void CaeserDecode()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Enter the text to decode (or type 'exit' to return to the menu):");
                string input = Console.ReadLine().ToLower();

                if (input == "exit")
                {
                    break;
                }

                Console.WriteLine("Enter the shift amount used for encoding (e.g., 3):");
                if (!int.TryParse(Console.ReadLine(), out int shift))
                {
                    Console.WriteLine("Invalid input. Please enter a whole number.");
                    Thread.Sleep(1000);
                    continue;
                }

                char[] buffer = input.ToCharArray();
                for (int i = 0; i < buffer.Length; i++)
                {
                    char letter = buffer[i];

                    if (char.IsLetter(letter)) // Only shift letters
                    {
                        char offset = char.IsUpper(letter) ? 'A' : 'a';
                        letter = (char)(((letter - shift - offset + 26) % 26) + offset);
                    }

                    buffer[i] = letter;
                }

                string decodedText = new string(buffer);
                Console.WriteLine($"Decoded text: {decodedText}");

                Console.WriteLine("\nPress any key to decode another text or type 'exit' to return to the menu.");
                if (Console.ReadLine().ToLower() == "exit")
                {
                    break;
                }
            }
        }
        private static void AffineCode()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Enter the text to encode (or type 'exit' to return to the menu):");
                string input = Console.ReadLine().ToLower();
                if (input == "exit")
                {
                    break;
                }
                Console.WriteLine("Enter the value for 'a' (must be coprime with 26):");
                if (!int.TryParse(Console.ReadLine(), out int a) || GCD(a, 26) != 1) //check factors
                {
                    Console.WriteLine("'a' must be an integer and coprime with 26. Please try again.");
                    Thread.Sleep(1000);
                    continue;
                }

                Console.WriteLine("Enter the value for 'b' (integer key):");
                if (!int.TryParse(Console.ReadLine(), out int b))
                {
                    Console.WriteLine("'b' must be an integer. Please try again.");
                    Thread.Sleep(1000);
                    continue;
                }
                char[] buffer = input.ToCharArray(); // dump in array
                for (int i = 0; i < buffer.Length; i++)
                {
                    char letter = buffer[i];

                    if (char.IsLetter(letter))
                    {
                        int x = letter - 'a';
                        int encodedValue = (a * x + b) % 26;
                        letter = (char)(encodedValue + 'a');
                    }

                    buffer[i] = letter;
                }

                string encodedText = new string(buffer);
                Console.WriteLine($"Encoded text: {encodedText}");

                Console.WriteLine("\nPress any key to encode another text or type 'exit' to return to the menu.");
                if (Console.ReadLine().ToLower() == "exit")
                {
                    break;
                }
            }

            // ensuret hat 'a' is coprime
            int GCD(int x, int y)
            {
                while (y != 0)
                {
                    int temp = y;
                    y = x % y;
                    x = temp;
                }
                return Math.Abs(x);
            }
        }

        private static void AffineDecode()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Enter the text to decode (or type 'exit' to return to the menu):");
                string input = Console.ReadLine().ToUpper();

                if (input == "EXIT")
                {
                    break;
                }

                Console.WriteLine("Enter the value for 'a' (encoding key, e.g., 7):");
                if (!int.TryParse(Console.ReadLine(), out int a))
                {
                    Console.WriteLine("'a' must be an integer. Please try again.");
                    Thread.Sleep(1000);
                    continue;
                }

                Console.WriteLine("Enter the value for 'b' (encoding offset, e.g., 2):");
                if (!int.TryParse(Console.ReadLine(), out int b))
                {
                    Console.WriteLine("'b' must be an integer. Please try again.");
                    Thread.Sleep(1000);
                    continue;
                }

                int aInverse = -1;
                for (int i = 0; i < 26; i++)
                {
                    if ((a * i) % 26 == 1)
                    {
                        aInverse = i;
                        break;
                    }
                }

                if (aInverse == -1)
                {
                    Console.WriteLine("No valid inverse for 'a'. Ensure 'a' is coprime with 26.");
                    Thread.Sleep(1000);
                    continue;
                }
                char[] buffer = input.ToCharArray();
                for (int i = 0; i < buffer.Length; i++)
                {
                    char letter = buffer[i];

                    if (char.IsLetter(letter))
                    {
                        int c = letter - 'A'; // Convert to 0-25
                        int decodedValue = (aInverse * (c - b + 26)) % 26;
                        letter = (char)(decodedValue + 'A');
                    }

                    buffer[i] = letter;
                }

                string decodedText = new string(buffer);
                Console.WriteLine($"Decoded text: {decodedText}");

                Console.WriteLine("\nPress any key to decode another text or type 'exit' to return to the menu.");
                if (Console.ReadLine().ToLower() == "exit")
                {
                    break;
                }
            }
        }
        private static void HillCode()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Enter the text to encode (two-letter blocks, or type 'exit' to return to the menu):");
                string input = Console.ReadLine().ToLower();

                if (input == "exit") break;

                input = input.Replace(" ", "");
                if (input.Length % 2 != 0)
                {
                    input += "x";
                    Console.WriteLine("Input length was odd, padded with 'X'.");
                }

                Console.WriteLine("Enter the values for the 2x2 matrix (e.g., '4 3 5 9'):");
                string[] matrixInput = Console.ReadLine().Split();

                int a = int.Parse(matrixInput[0]);
                int b = int.Parse(matrixInput[1]);
                int c = int.Parse(matrixInput[2]);
                int d = int.Parse(matrixInput[3]);

                char[] encoded = new char[input.Length];

                for (int i = 0; i < input.Length; i += 2)
                {
                    int p1 = input[i] - 'a';
                    int p2 = input[i + 1] - 'a';

                    int c1 = (a * p1 + b * p2) % 26;
                    int c2 = (c * p1 + d * p2) % 26;

                    encoded[i] = (char)(c1 + 'A');
                    encoded[i + 1] = (char)(c2 + 'A');
                }

                string encodedText = new string(encoded);
                Console.WriteLine($"Encoded text: {encodedText}");

                Console.WriteLine("\nPress any key to encode another text or type 'exit' to return to the menu.");
                if (Console.ReadLine().ToLower() == "exit") break;
            }
        }

        private static void HillDecode()
        {
            Console.WriteLine("I cannot get this to work. Sorry future Jack, you are on your own");
        }

        private static void RSACode() // Still only doing one character! fix me before test 
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Enter a single character to encode (or type 'exit' to return to the menu):");
                string input = Console.ReadLine().ToUpper();

                if (input == "EXIT")
                {
                    break;
                }

                if (input.Length != 1 || !char.IsLetter(input[0]))
                {
                    Console.WriteLine("Invalid input. Please enter a single alphabetic character.");
                    Thread.Sleep(1000);
                    continue;
                }

                Console.WriteLine("Enter the key:");
                if (!int.TryParse(Console.ReadLine(), out int e))
                {
                    Console.WriteLine("Invalid input. Please enter a single number for the key.");
                    Thread.Sleep(1000);
                    continue;
                }

                Console.WriteLine("Enter the mod:");
                if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
                {
                    Console.WriteLine("Invalid input. Please enter a single number for the mod.");
                    Thread.Sleep(1000);
                    continue;
                }

                int letterValue = input[0] - 'A' + 1;

                int encodedValue = (int)Math.Pow(letterValue, e) % n;

                char encodedLetter = (char)((encodedValue - 1) + 'A');

                Console.WriteLine($"Encoded character: {encodedLetter}");
                Console.WriteLine("Press any key to encode another character or type 'exit' to return to the menu.");
                if (Console.ReadLine().ToLower() == "exit")
                {
                    break;
                }
            }
        }

        private static void RSADecode() // still only one character! Fix me before test.
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Enter a single character to decode (or type 'exit' to return to the menu):");
                string input = Console.ReadLine().ToUpper();

                if (input == "EXIT")
                {
                    break;
                }

                if (input.Length != 1 || !char.IsLetter(input[0]))
                {
                    Console.WriteLine("Invalid input. Please enter a single alphabetic character.");
                    Thread.Sleep(1000);
                    continue;
                }

                Console.WriteLine("Enter the decoding key:");
                if (!int.TryParse(Console.ReadLine(), out int d))
                {
                    Console.WriteLine("Invalid input. Please enter a single number for the decoding key.");
                    Thread.Sleep(1000);
                    continue;
                }

                Console.WriteLine("Enter the mod:");
                if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
                {
                    Console.WriteLine("Invalid input. Please enter a positive number for the mod.");
                    Thread.Sleep(1000);
                    continue;
                }

                int encodedValue = input[0] - 'A' + 1;

                int decodedValue = 1;
                for (int i = 0; i < d; i++)
                {
                    decodedValue = (decodedValue * encodedValue) % n;
                }

                char decodedLetter = (char)((decodedValue - 1) + 'A');

                Console.WriteLine($"Decoded character: {decodedLetter}");
                Console.WriteLine("Press any key to decode another character or type 'exit' to return to the menu.");
                if (Console.ReadLine().ToLower() == "exit")
                {
                    break;
                }
            }
        }

    }
}