using System;
using System.Collections.Generic;
using System.Text;

namespace CorePrograms
{
     class FlipCoinPercentage
    {
        int flipValue , flipTimes; string flipNumbers;  int headCount = 0;
        Random random = new Random();

        void findPercentage()
        {
            for (int i = 1; i <= flipTimes; i++)
            {
                flipValue = random.Next(0, 2);     // generates 0 and 1
                if (flipValue == 1)
                {
                    headCount++;
                }
            }
            Console.Write(" Heads Count : " + headCount);
            Console.WriteLine("  | Tails Count : " + (flipTimes - headCount));
            double headsPercent = ((double)headCount / flipTimes) * 100;
            double tailsPercent = 100 - headsPercent;
            Console.WriteLine(" Percentage of heads is {0}% and tails is {1}% .", headsPercent, tailsPercent);
        }

        public void FlipCoin()
        {
            Console.Write(" Type a number of times you want to Flip a Coin : ");
            flipNumbers = Console.ReadLine();
            int invalidNum = 0;
            foreach (char c in flipNumbers)
            {
                if (!Char.IsDigit(c))
                {
                    Console.WriteLine(" Please enter valid number. ");
                    invalidNum = 1;
                    break;
                }
            }

            if(invalidNum == 0)
            {
                flipTimes = Convert.ToInt32(flipNumbers);
                findPercentage();
            }
        }
        
    }
}
