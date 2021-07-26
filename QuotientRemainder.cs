using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProgram
{
    class QuotientRemainder
    {
        public void Find()
        {

            int divisor, divident;
            double remainder = 0.0, quotient = 0.0;
            Console.WriteLine("Enter divisor");
            divisor = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter dividend");
            divident = Convert.ToInt32(Console.ReadLine());
            quotient = divisor % divident;
            remainder = divisor / divident;
            Console.WriteLine("Quotient is :" + quotient);
            Console.WriteLine("Remainder is " + remainder);

        }
    }
}
