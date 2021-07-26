using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProgram
{
    class Largest
    {
        public int number1, number2, number3;
        public Largest(int number1, int number2, int number3)
        {
            this.number1 = number1;
            this.number2 = number2;
            this.number3 = number3;
        }
        public void Max()
        {
            if (number1 > number2 && number1 > number3)
                Console.WriteLine("Largest number is:" + number1);
            if (number2 > number1 && number2 > number3)
                Console.WriteLine("Largest number is:" + number2);
            if (number3 > number1 && number3 > number2)
                Console.WriteLine("Largest number is:" + number3);
        }
    }
}
