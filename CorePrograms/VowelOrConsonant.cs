using System;
using System.Collections.Generic;
using System.Text;

namespace CorePrograms
{
    class VowelOrConsonant
    {
        public void TakeInput()
        {
            Console.Write(" Type an alphabet letter : ");
            string alpha = Console.ReadLine();
            if (alpha.Length == 1 && !Char.IsDigit(Convert.ToChar(alpha)))
            {
                if (alpha == "a" || alpha == "A" || alpha == "e" || alpha == "E" || alpha == "i" || alpha == "I" || alpha == "o" || alpha == "O" || alpha == "u" || alpha == "U")
                {
                    Console.WriteLine(" Alphabet is Vowel.");
                }
                else
                {
                    Console.WriteLine(" Alphabet is consonant. ");
                }
            }
            else
            {
                Console.WriteLine(" Enter only 1 valid charcter/letter. ");
            }
        }
    }
}
