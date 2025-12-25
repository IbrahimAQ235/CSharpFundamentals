using System;

namespace _105BitFlip
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("##### WELCOME TO BIT FLIP SYSTEM #####");
                Console.WriteLine("-------------------------------------");

                Console.WriteLine("1. Enter Binary String");
                Console.WriteLine("2. Exit");
                Console.Write("Enter your choice: ");

                string option = Console.ReadLine();

                if (option == "1")
                {
                    Console.Clear();
                    EnterBinaryString();
                }
                else if (option == "2")
                {
                    Console.WriteLine("Thank you, hope to see you soon!");
                    Console.ReadLine();
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid option. Please try again.");
                    Console.ReadLine();
                }
            }
        }

        static void EnterBinaryString()
        {
            while (true)
            {
                Console.Write("Please enter your 8-bit binary string: ");
                string binary = Console.ReadLine();

                // Check length
                if (binary.Length != 8)
                {
                    Console.WriteLine("Incorrect length, try again:");
                    continue;
                }

                // Check only 0s and 1s
                bool valid = true;

                for (int i = 0; i < binary.Length; i++)
                {
                    if (binary[i] != '0' && binary[i] != '1')
                    {
                        valid = false;
                        break;
                    }
                }

                if (valid == false)
                {
                    Console.WriteLine("Invalid input, try again:");
                    continue;
                }

                Console.Write("Flipped binary string: ");

                // Flip ALL bits (this is the correct "bit flip")
                for (int i = 0; i < binary.Length; i++)
                {
                    if (binary[i] == '0')
                    {
                        Console.Write('1');
                    }
                    else
                    {
                        Console.Write('0');
                    }
                }

                Console.WriteLine();
                Console.ReadLine();
                return;
            }
        }
    }
}
