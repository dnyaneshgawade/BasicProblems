using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProgram
{
    class Swap
    {
        int temp;
        int firstNumber = Convert.ToInt32(Console.ReadLine());
        int secondNumber = Convert.ToInt32(Console.ReadLine());
        public void SwapNumber()
        {
            Console.WriteLine("Enter the First Number and Second Number");
            Console.WriteLine("First number before swap:" + firstNumber);
            Console.WriteLine("Second number before swap:" + secondNumber);
            temp = firstNumber;
            firstNumber = secondNumber;
            secondNumber = temp;
            Console.WriteLine("First number after swap:" + firstNumber);
            Console.WriteLine("Second number after swap:" + secondNumber);
        }
    }
}
