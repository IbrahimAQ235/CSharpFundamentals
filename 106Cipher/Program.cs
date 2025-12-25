using System; // Allows us to use Console commands

namespace _106Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            // This loop keeps the program running until the user exits
            while (true)
            {
                Console.Clear();
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("##### WELCOME TO CIPHER SYSTEM #####");
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("Select an option:");
                Console.WriteLine("1.Cipher Text");
                Console.WriteLine("2.De-cipher Text");
                Console.WriteLine("3.exit program");

                // Reads the user's menu choice
                string option = Console.ReadLine();

                // If user chooses to cipher text
                if (option == "1")
                {
                    Console.Clear();
                    cipher();
                }
                // If user chooses to de-cipher text
                else if (option == "2")
                {
                    Console.Clear();
                    decipher();
                }
                // Exit the program
                else if (option == "3")
                {
                    Console.WriteLine("Thank you, hope to see you soon!");
                    Console.ReadLine();
                    break;
                }
                // If user enters an invalid option
                else
                {
                    Console.WriteLine("Invalid option. Please try again.");
                    Console.ReadLine();
                }
            }
        }

        // This method ciphers (encrypts) the text
        static void cipher()
        {
            // Stores the alphabet
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            // Gets the text from the user and converts it to uppercase
            Console.Write("Enter text to cipher: ");
            string input = Console.ReadLine().ToUpper();

            // Gets the number of letters to shift
            Console.Write("Enter number of letters to shift: ");
            int shift = int.Parse(Console.ReadLine());

            Console.Write("Ciphered text: ");

            // Goes through each character in the input
            for (int i = 0; i < input.Length; i++)
            {
                char current = input[i];
                int index = -1;

                // Finds the position of the letter in the alphabet
                for (int j = 0; j < alphabet.Length; j++)
                {
                    if (alphabet[j] == current)
                    {
                        index = j;
                    }
                }

                // If the character is a letter
                if (index != -1)
                {
                    int newIndex = index + shift;

                    // Wraps around if it goes past Z
                    if (newIndex >= alphabet.Length)
                    {
                        newIndex = newIndex - alphabet.Length;
                    }

                    Console.Write(alphabet[newIndex]);
                }
                // If it is not a letter (space or symbol)
                else
                {
                    Console.Write(current);
                }
            }

            Console.ReadLine();
        }

        // This method de-ciphers (decrypts) the text
        static void decipher()
        {
            // Stores the alphabet
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            // Gets the ciphered text and converts it to uppercase
            Console.Write("Enter text to de-cipher: ");
            string input = Console.ReadLine().ToUpper();

            // Gets the number of letters to shift back
            Console.Write("Enter number of letters to shift: ");
            int shift = int.Parse(Console.ReadLine());

            Console.Write("De-ciphered text: ");

            // Goes through each character in the input
            for (int i = 0; i < input.Length; i++)
            {
                char current = input[i];
                int index = -1;

                // Finds the position of the letter in the alphabet
                for (int j = 0; j < alphabet.Length; j++)
                {
                    if (alphabet[j] == current)
                    {
                        index = j;
                    }
                }

                // If the character is a letter
                if (index != -1)
                {
                    int newIndex = index - shift;

                    // Wraps around if it goes before A
                    if (newIndex < 0)
                    {
                        newIndex = newIndex + alphabet.Length;
                    }

                    Console.Write(alphabet[newIndex]);
                }
                // If it is not a letter (space or symbol)
                else
                {
                    Console.Write(current);
                }
            }

            Console.ReadLine();
        }
    }
}
