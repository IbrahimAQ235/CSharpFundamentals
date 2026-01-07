using System;
namespace Hypothesis
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("====  HYPOTHESIS TEST CALCULATOR  ====");
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("please choose one of following options:");
                Console.WriteLine("1.Program Explaination ");
                Console.WriteLine("2.Spearemans rank ");
                Console.WriteLine("3.Exit the program ");

                string option = Console.ReadLine();

                if (option == "1")
                {
                    Console.Clear();
                    Console.WriteLine("In Progress");
                    Console.WriteLine("Calculator made by Ibrahim Dar");
                    Console.ReadLine();
                }
                else if (option == "2")
                {
                    SR();
                }
                else if (option == "3")
                {
                    Console.WriteLine("Thank you for using the calculator");
                    Console.ReadLine();
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please try again");
                    Console.ReadLine();
                }
            }
        }

        static void SR()
        {
            Console.Clear();
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("====  HYPOTHESIS TEST CALCULATOR  ====");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("please choose one of following options:");
            Console.WriteLine("1.Spearemans rank ");
            Console.WriteLine("2.Spearemans rank Hypothesis test");

            string optio = Console.ReadLine();

            if (optio == "1")
            {
                Console.Clear();
                rank();
            }
            else if (optio == "2")
            {
                Console.Clear();
                hyp();
            }
            else
            {
                Console.WriteLine("Invalid option please try again");
                Console.ReadLine();
            }
        }

        static void rank()
        {
            Console.Clear();
            Console.WriteLine("------------------------------------");
            Console.WriteLine("==== SPEARMAN'S RANK CALCULATOR ====");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Formulas is rs = 1 - (6 * D) / (n * (n * n - 1))");
            Console.WriteLine("Please enter the sum of D^2 value");
            double D = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter N value");
            double n = double.Parse(Console.ReadLine());

            double rs = 1 - (6 * D) / (n * (n * n - 1));

            string correlation = "";

            if (rs > 1 || rs < -1)
            {
                Console.WriteLine("Error please recheck your values");
                Console.ReadLine();
                return;
            }
            else if (rs == 1)
                correlation = "Perfect positive correlation";
            else if (rs == -1)
                correlation = "Perfect negative correlation";
            else if (rs == 0)
                correlation = "No correlation";
            else if (rs > 0 && rs < 0.3)
                correlation = "Weak positive correlation";
            else if (rs < 0 && rs > -0.3)
                correlation = "Weak negative correlation";
            else if (rs >= 0.3 && rs < 0.7)
                correlation = "Moderate positive correlation";
            else if (rs <= -0.3 && rs > -0.7)
                correlation = "Moderate negative correlation";
            else if (rs >= 0.7 && rs < 0.9)
                correlation = "Strong positive correlation";
            else if (rs >= 0.9 && rs < 1)
                correlation = "Very strong positive correlation";
            else if (rs <= -0.9 && rs > -1)
                correlation = "Very strong negative correlation";

            Console.WriteLine();
            Console.WriteLine("Your rs value is: " + rs);
            Console.WriteLine("Your correlation is: " + correlation);

            Console.WriteLine();
            Console.WriteLine("Press ENTER to return to menu...");
            Console.ReadLine();
        }

        static void hyp()
        {
            Console.Clear();
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("==== SPEARMAN'S HYP CALCULATOR ====");
            Console.WriteLine("-----------------------------------");


            Console.WriteLine("What Your First Variable name:");
            string var1 = Console.ReadLine();
            Console.WriteLine("What Your Second Variable name:");
            string var2 = Console.ReadLine();
            Console.WriteLine("H0: There is no correlation between " + var1 + " and " + var2);
            Console.WriteLine("Is there a positive or negative correlation or Any correlation?");
            string corr = Console.ReadLine().ToLower();
            while(true)
            {
                if (corr == "positive")
                {
                    Console.WriteLine("H1: There is a positive correlation between " + var1 + " and " + var2);  
                    Console.WriteLine("One tailed test");          
                }
                else if (corr == "negative")
                {
                    Console.WriteLine("H1: There is a negative correlation between " + var1 + " and " + var2);
                    Console.WriteLine("One tailed test");      
                }
                else if (corr == "any")
                {
                    Console.WriteLine("H1: There is a correlation between " + var1 + " and " + var2);
                    Console.WriteLine("Two tailed test");
                }
                else
                {
                    Console.WriteLine("Invalid option please try again");
                    Console.ReadLine();
                    return;
                }
            }
            Console.WriteLine("What is your rs value:");
            double ran = double.Parse(Console.ReadLine());
            Console.WriteLine("What is your n value:");
            int ns = int.Parse(Console.ReadLine());
            Console.WriteLine("What is your significance level (Percentage) :");
            int sig = int.Parse(Console.ReadLine());
            Console.WriteLine("Is this a One or Two tailed test:");
            string tailed = Console.ReadLine().ToLower();
            if (tailed == "one")
            {
                Console.WriteLine("One tailed test selected");
                one();
            }
            else if (tailed == "two")
            {
                Console.WriteLine("Two tailed test selected");
                two();
            }
            else
            {
                Console.WriteLine("Invalid option please try again");
                Console.ReadLine();
                return;
            }
        }
        static void one()
        {
            Console.WriteLine("In Progress");
            Console.ReadLine();
        }
        static void two()
        {
            Console.WriteLine("In Progress");
            Console.ReadLine();
        }
    }
}


