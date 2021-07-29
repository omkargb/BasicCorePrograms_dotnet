using System;
using System.Collections.Generic;
using System.Text;

namespace CorePrograms
{
    class EvenOrOdd
    {
        public void EvenOdd(int number)
        {
            if(number%2==0)
            {
                Console.WriteLine(" {0} : Even Number",number);
            }
            else
            {
                Console.WriteLine(" {0} : Odd Number", number);
            }
        }

        public void TakeInput()
        {
            Console.WriteLine(" Enter a number to check even or odd : ");
            int number = Convert.ToInt32(Console.Read());
            EvenOdd(number);
        }
    }
}
