using System;
using System.Collections.Generic;
using System.Text;

namespace CorePrograms
{
    class SwapTwoNumbers
    {
        public void Swapnum(int num1, int num2)
        {
            num1 = num1 + num2;
            num2 = num1 - num2;
            num1 = num1 - num2;
            Console.WriteLine(" After swapping \n First number : {0} and Second number : {1}",num1, num2);
        }

        public void TakeInput()
        {
            Console.WriteLine(" Before Swapping numbers ");
            Console.Write( " Enter First number : ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write( " Enter Second number : ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Swapnum(num1, num2);
        }
    }
}
