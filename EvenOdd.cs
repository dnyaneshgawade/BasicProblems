using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProgram
{
    public class EvenOdd
    {
        public int number = Convert.ToInt32(Console.ReadLine());
        public void Check()
        {
            Console.WriteLine("Enter the Number.");
            if (number % 2 == 0)
                Console.WriteLine(number + "," + "Is an even number.");
            else
                Console.WriteLine(number + "," + "Is an odd number.");
        }
    }
}
