using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProgram
{
    public class LeapYear
    {
        public static void Leap()
        {
            Console.WriteLine("Enter the Year");
        }
        int year = Convert.ToInt32(Console.ReadLine());
        
        public void FindLeap()
        {
            if (year % 400 == 0 || year % 4 == 0 && year % 100 != 0)
                Console.WriteLine(year +  " Is a Leap Year.");
            else
                Console.WriteLine(year +  " Is not a Leap Year.");
        }
    }
}
