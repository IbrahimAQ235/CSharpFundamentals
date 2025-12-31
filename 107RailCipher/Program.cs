using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Rail Cipher Program
namespace Rail_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine(" ----------------------------------------");
                Console.WriteLine(" W E L C O M E  T O  R A I L  C I P H E R");
                Console.WriteLine(" ----------------------------------------");

                Console.WriteLine("Select one of the following options:");
                Console.WriteLine("1.Rail Cipher");
                Console.WriteLine("2.Exit Program");

                string option = Console.ReadLine();

                if(option == "1")
                {
                    Rail();
                }
                else if(option == "2")
                {
                    Console.WriteLine("Thank you for your Time");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid option Try again");
                }
            }
        }
        static void Rail()
        {
            Console.Clear();
            Console.WriteLine(" ------------------------");
            Console.WriteLine(" E N C R Y P T   M O D E ");
            Console.WriteLine(" ------------------------");

            Console.WriteLine("How Many Rails would you like");
            int r = int.Parse(Console.ReadLine());
            Console.WriteLine("This is number of Rails we are using :" + r );
            Console.WriteLine("Enter Your De-Crypted message");
            string mess = Console.ReadLine();
            Console.WriteLine("Your De-Crypted message is :" + mess);

            for (int i = 0; i < r; i++)
            {
                Console.WriteLine("Rail " + (i + 1));
                for (int j = i; j < mess.Length; j += r)
                {
                    Console.Write(mess[j] + " ");
                }
                Console.WriteLine();

            }
            string result = "";

                for (int i = 0; i < r; i++)
                {
                    for (int j = i; j < mess.Length; j += r)
                    {
                        result += mess[j];
                    }
                }

                Console.WriteLine();
                Console.WriteLine("Encrypted result: " + result);

            Console.ReadLine();

        }
    }
}
