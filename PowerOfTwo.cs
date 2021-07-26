using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProgram
{
    class PowerOfTwo
    {
        int power = 1;
        int n = Convert.ToInt32(Console.ReadLine());
        public void Print()
        {
            Console.WriteLine("Enter the value of n.");
            for (int i = 1; i <= n; i++)
            {
                power *= 2;
                Console.WriteLine(n + "*" + i + "=" + power);
            }
        }
    }
}
