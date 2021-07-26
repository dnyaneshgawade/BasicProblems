using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProgram
{
    public class FlipCoin
    {
        public static int count_heads = 0;
        public static int count_tails = 0;
        public static double result = 0.0;
        public static double check;
        public static void Flip()
        {
            Console.WriteLine("Enter the number of times you want to flip a coin.");
            double flip_number = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= flip_number; i++)
            {
                Random random = new Random();
                check = random.NextDouble();
                if (check < 0.5)
                {
                    Console.WriteLine("TAILS");
                    count_tails++;

                }
                else
                {
                    Console.WriteLine("HEADS");
                    count_heads++;
                }
            }
            result = (count_heads / flip_number) * 100.0;
            Console.WriteLine("Percentage of HEADS IS : " + result);
            result = (count_tails / flip_number) * 100.0;
            Console.WriteLine("Percentage of TAILS IS : " + result);

        }
    }
}
