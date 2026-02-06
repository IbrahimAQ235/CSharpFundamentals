using System;

namespace SGMS
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
        static void Displaymenu()
        {
            Console.WriteLine("===============================");
            Console.WriteLine("STUDENT GRADE MANAGEMENT SYSTEM");
            Console.WriteLine("===============================");
            Console.WriteLine("Please select an option:");
            Console.WriteLine("1. Add Student Information");
            Console.WriteLine("2. View Students Information");
            Console.WriteLine("3. Class Average Marks");
            Console.WriteLine("4. Generate reports");
            Console.WriteLine("5. Exit Application");

            string option = Console.readline();

            if (option == "1")
            {
                Add();
            }
            else if (option == "2")
            {
                View();
            }
            else if (option == "3")
            {
                Average();
            }
            else if (option == "4")
            {
                Report();
            }
            else if (option == "5")
            {
                Console.WriteLine("Thank you for your time");
                break;
            }
            else
            {
                Console.WriteLine("Invalid option. Try again");
            }
        }
    }
}
