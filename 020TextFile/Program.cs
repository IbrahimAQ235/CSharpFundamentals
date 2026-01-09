using System;
using System.IO; //Necessary for file operations

namespace _020TextFile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter your age:");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter your Subject:");
            string subject = Console.ReadLine();

            Console.WriteLine("Enter your Marks in test:");
            int mark = int.Parse(Console.ReadLine());

            using (StreamWriter writer = new StreamWriter("example.txt"))
            {
                writer.WriteLine("This is an example text file.");
                writer.WriteLine("Your name is " + name);
                writer.WriteLine("Your age is " + age);
                writer.WriteLine("Your Subject is " + subject);
                writer.WriteLine("Your Marks in test is " + mark);
            }
        }
    }
}
