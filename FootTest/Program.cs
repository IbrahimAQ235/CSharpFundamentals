using System;

namespace FootTest
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("FOOTBALL TESTING");
                Console.WriteLine("1.Take test");
                Console.WriteLine("2.View Scores");                                           
                Console.WriteLine("3.Exit");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        TakeTest();
                        break;
                    case "2":
                        ViewScores();
                        break;
                    case "3":
                    Console.WriteLine("Exiting the program.");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }

        }
        static void TakeTest()
        {
            Console.WriteLine("Welcome user to the Football Test!");
            Console.WriteLine("Please enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}! Let's start the test.");
            Console.WriteLine("Question 1: Which country won the FIFA World Cup in 2018?");
            Console.WriteLine("a) Germany");
            Console.WriteLine("b) Brazil");
            Console.WriteLine("c) France");
            string answer1 = Console.ReadLine();
            if (answer1.ToLower() == "c")
            {
                Console.WriteLine("Correct!");
            }
            else
            {
                Console.WriteLine("Incorrect. The correct answer is c) France.");
            }
            Console.WriteLine("Question 2: Who Won the premier league last year'?");
            Console.WriteLine("a) Manchester City");
            Console.WriteLine("b) Liverpool");
            Console.WriteLine("c) Chelsea");
            string answer2 = Console.ReadLine();
            if (answer2.ToLower() == "a")
            {
                Console.WriteLine("Correct!");
            }
            else
            {
                Console.WriteLine("Incorrect. The correct answer is a) Manchester City.");
            }
        }
        static void ViewScores()
        {
            Console.WriteLine("Viewing scores...");
            // Placeholder for score-viewing logic
        }
    }
}
