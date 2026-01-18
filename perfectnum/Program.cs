using System;

namespace perfectnum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Perfect Number calculator");

            int count = 0;
            long number = 2;

            while (count < 5)
            {
                long sum = 1;

                for (long i = 2; i * i <= number; i++)
                {
                    if (number % i == 0)
                    {
                        sum += i;

                        long otherFactor = number / i;
                        if (otherFactor != i)
                        {
                            sum += otherFactor;
                        }
                    }
                }

                if (sum == number && number != 1)
                {
                    Console.WriteLine("Perfect Number: " + number);
                    count++;
                }

                number++;
            }
        }
    }
}
