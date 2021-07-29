using System;
using System.Collections.Generic;
using System.Text;

namespace CorePrograms
{
    class HarmonicNumber
    {
        public void CalcValue(int number)
        {
            double harmonic=1;
            Console.WriteLine(" Harmonic Series : ");
            Console.Write(" 1");
            for (int i = 2; i <= number; i++)
            {
                Console.Write(" + 1/{0}", i);
                harmonic = harmonic + (1.0 / i);   
            }
            Console.WriteLine("\n Harmonic number at {0} : {1} ",number, harmonic);
        }

        public void TakeInput()
        {
            Console.Write(" Enter a number(N) to display Nth harmonic number : ");
            string N = Console.ReadLine();
            int invalidNum = 0;
            //checking input year contains only numbers
            foreach (char c in N)
            {
                if (!(c >= '0' && c <= '9'))
                {
                    invalidNum = 1;
                }
            }
            int number = Convert.ToInt32(N);
            if (number < 1 || invalidNum==1)
            {
                Console.WriteLine(" Please enter valid or positive number. ");
                return;
            }
            else
            {
                CalcValue(number);
            }
        }
    }
}
