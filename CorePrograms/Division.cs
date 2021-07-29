using System;
using System.Collections.Generic;
using System.Text;

namespace CorePrograms
{
    class Division
    {

        public void CalcValues(int dividend, int divisor)
        {
            int quotient = dividend / divisor;
            int remainder = dividend % divisor;

            Console.WriteLine(" Quotient : {0}  and  Remainder : {1} ", quotient, remainder);
        }

        public void TakeInput()
        {
            Console.WriteLine(" Provide dividend and divisor");
            Console.Write(" Enter Dividend number : ");
            int dividend = Convert.ToInt32(Console.ReadLine());

            Console.Write(" Enter divisor number : ");
            int divisor = Convert.ToInt32(Console.ReadLine());

            CalcValues(dividend, divisor);
        }
    }
}
