using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProgram
{
    public class Vovels
    {
        public char character = Convert.ToChar(Console.ReadLine().ToLower());
        public void CheckVowel()
        {
            Console.WriteLine("Enter the Character");
            if (character == 'a' || character == 'e' || character == 'i' || character == 'o' || character == 'u')
                Console.WriteLine("Character " + character + " is Vowel.");
            else
                Console.WriteLine("Chracter is Consonant.");
        }
    }
}
