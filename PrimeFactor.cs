using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProgram
{
    class PrimeFactor
    {
        public int number;
        public void Factor()
        {
            int i;
            Console.WriteLine("Enter a number");
            number = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    Console.WriteLine(i + " is a factor of " + number);
                }
            }
        }
    }
}
