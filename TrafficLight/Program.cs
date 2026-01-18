
using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficLight
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                while (true)
                {
                    Console.Clear();
                    DrawTopLight1();
                    DrawTopLight6();
                    Thread.Sleep(3000);

                    Console.Clear();
                    DrawTopLight1();
                    DrawTopLight2();
                    DrawTopLight6();
                    Thread.Sleep(2000);

                    Console.Clear();
                    DrawTopLight3();
                    DrawTopLight4();
                    Thread.Sleep(3000);

                    Console.Clear();
                    DrawTopLight3();
                    DrawTopLight4();
                    DrawTopLight5();
                    Thread.Sleep(2000);
                }
            }
        }
        static void DrawTopLight1()
        {
            int xpos = 5;
            int ypos = 2;
            Console.BackgroundColor = ConsoleColor.Red;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.SetCursorPosition(xpos + i, ypos + j);
                    Console.Write(" ");
                }
            }
            Console.BackgroundColor = ConsoleColor.Black;
        }
        static void DrawTopLight2()
        {
            int xpos = 5;
            int ypos = 10;
            Console.BackgroundColor = ConsoleColor.Yellow;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.SetCursorPosition(xpos + i, ypos + j);
                    Console.Write(" ");
                }
            }
            Console.BackgroundColor = ConsoleColor.Black;
        }
        static void DrawTopLight3()
        {
            int xpos = 5;
            int ypos = 18;
            Console.BackgroundColor = ConsoleColor.Green;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.SetCursorPosition(xpos + i, ypos + j);
                    Console.Write(" ");
                }
            }
            Console.BackgroundColor = ConsoleColor.Black;
        }
        static void DrawTopLight4()
        {
            int xpos = 25;
            int ypos = 2;
            Console.BackgroundColor = ConsoleColor.Red;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.SetCursorPosition(xpos + i, ypos + j);
                    Console.Write(" ");
                }
            }
            Console.BackgroundColor = ConsoleColor.Black;
        }
        static void DrawTopLight5()
        {
            int xpos = 25;
            int ypos = 10;
            Console.BackgroundColor = ConsoleColor.Yellow;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.SetCursorPosition(xpos + i, ypos + j);
                    Console.Write(" ");
                }
            }
            Console.BackgroundColor = ConsoleColor.Black;
        }
        static void DrawTopLight6()
        {
            int xpos = 25;
            int ypos = 18;
            Console.BackgroundColor = ConsoleColor.Green;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.SetCursorPosition(xpos + i, ypos + j);
                    Console.Write(" ");
                }
            }
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
}
