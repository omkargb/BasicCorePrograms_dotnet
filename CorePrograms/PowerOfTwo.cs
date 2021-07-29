using System;
using System.Collections.Generic;
using System.Text;

namespace CorePrograms
{
    class PowerOfTwo
    {
        public void CalcPower(int number)
        {
            for (int i = 0; i <=number; i++)
                {
                Console.WriteLine(" 2^{0} =\t {1}", i, Math.Pow(2, i));
                }
        }
    
        public void takeInput()
        {
            Console.Write(" Enter a number to calculate 2's power : ");
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
            if ( number>30 || invalidNum==1)
            {
                Console.WriteLine(" Please enter valid number (below 31) : ");
                return;
            }
            else
            {
                CalcPower(number);
            }
        }
    }
}
