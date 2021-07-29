using System;
using System.Collections.Generic;
using System.Text;

namespace CorePrograms
{
    class LargestOfThreeNums
    {
        public void calcLargest(int num1, int num2, int num3)
        {
            if(num1>num2 && num1>num3)
            {
                Console.WriteLine(" {0} is greater than others.",num1);
            }
            else if(num2>num1 && num2>num3)
            {
                Console.WriteLine(" {0} is greater than others.",num2);
            }
            else
            {
                Console.WriteLine(" {0} is greater than others.",num3);
            }
        }

        public void TakeInput()
        {
            Console.Write(" Enter First number : ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write(" Enter Second number : ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write(" Enter Third number : ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            calcLargest(num1, num2, num3);
        }
    }
}
