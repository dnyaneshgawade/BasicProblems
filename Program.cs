using System;

namespace BasicProgram
{
    class Program
    {
        public static int choice;
        public const int IS_FLIP_COIN = 1;
        public const int IS_LEAP_YEAR = 2;
        public const int IS_POWER_OF_TWO = 3;
        public const int IS_HARMONIC_NUMBER = 4;
        public const int IS_PRIME_FACTOR = 5;
        public const int IS_Q_AND_R = 6;
        public const int IS_SWAP_NUMBER = 7;
        public const int IS_EVEN_ODD = 8;
        public const int IS_VOVELS = 9;
        public const int IS_LARGEST = 10;

        static void Main(string[] args)
        {
            Console.WriteLine("Wellcome to Basic problems!");
            Console.WriteLine("1. Flip Coin\n2. Leap Year\n3. Power of Two\n4.Harmonic Number\n5. Prime_Factor\n6. Quotient_And_Remainder\n7. Swap_Numbers\n8. Even or Odd\n9. Vowel Or Constant\n10. Largest Among Three Numbers\n");
            
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case IS_FLIP_COIN:
                    Console.WriteLine("Flip_Coin");
                    FlipCoin flip = new FlipCoin();
                    FlipCoin.Flip();
                    break;

                case IS_LEAP_YEAR:
                    Console.WriteLine("Leap Year!");
                    LeapYear leap = new LeapYear();
                    LeapYear.Leap();
                    break;
                case IS_POWER_OF_TWO:
                    Console.WriteLine("Power of 2!");
                    PowerOfTwo power = new PowerOfTwo();
                    power.Print();
                    break;
                case IS_HARMONIC_NUMBER:
                    Console.WriteLine("Harmonic Number!");
                    HarmonicNumber harmonicNumber = new HarmonicNumber();
                    harmonicNumber.Pattern();
                    break;
                case IS_PRIME_FACTOR:
                    Console.WriteLine("Prime Factors");
                    PrimeFactor primeFactor = new PrimeFactor();
                    primeFactor.Factor();
                    break;

                case IS_Q_AND_R:
                    Console.WriteLine("Quotient and Remainder");
                    QuotientRemainder quotientRemainder = new QuotientRemainder();
                    quotientRemainder.Find();
                    break;
                case IS_SWAP_NUMBER:
                    Console.WriteLine("Swap Two Numbers");
                    Swap swap = new Swap();
                    swap.SwapNumber();
                    break;

                case IS_EVEN_ODD:
                    Console.WriteLine("Even Or Odd");
                    EvenOdd evenOdd = new EvenOdd();
                    evenOdd.Check();
                    break;
                case IS_VOVELS:
                    Console.WriteLine("Vowel Or Consonant");
                    Vovels vovels = new Vovels();
                    vovels.CheckVowel();
                    break;
                case IS_LARGEST:
                    Console.WriteLine("Largest_Among_Three_Numbers");
                    Largest largest = new Largest(30,20,40);
                    largest.Max();
                    break;
                default:
                    Console.WriteLine("You Enter Wrong Input!");
                    break;

            }
        }
    }
}
