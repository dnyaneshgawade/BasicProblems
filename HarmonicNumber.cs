using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProgram
{
    public class HarmonicNumber
    {
        public float sum = 0;
        public int n = Convert.ToInt32(Console.ReadLine());
        public void Pattern()
        {
            Console.WriteLine("Enter the value of n ");
            for (int i = 1; i <= n; i++)
            {
                sum += (float)(1 / i);
                Console.Write(" " + "+" + "1/" + i);
            }
            Console.WriteLine();
            Console.WriteLine("Nth number is : " + sum);
        }
    }
}
