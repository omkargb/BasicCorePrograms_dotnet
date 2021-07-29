using System;
using System.Collections.Generic;
using System.Text;

namespace CorePrograms
{
    class PrimeFactors
    {

        public void CalcFactors(int number)
        {
            //check input number is divisable and find factors
            for (int i = 2; i <= number; i++)
            {
                if (number % i == 0)
                {
                    int isPrime = 1;
                    for (int d = 2; d <= Math.Sqrt(i); d++)
                    {
                        if (i % d == 0)
                        {
                            isPrime = 0;
                        }
                    }
                    // If i is Prime number
                    if (isPrime == 1)
                    {
                        Console.Write(" {0} ",i);
                    }
                }
            }
        }
        public void TakeInput()
        {
            Console.Write(" Enter a number to calculate prime factors : ");
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
            if (number < 2 || invalidNum == 1)
            {
                Console.WriteLine(" Please enter valid or positive number. ");
                return;
            }
            else
            {
                Console.Write(" Prime factors are : ");
                CalcFactors(number);
            }
        }
    }
}
