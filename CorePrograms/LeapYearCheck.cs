using System;
using System.Collections.Generic;
using System.Text;

namespace CorePrograms
{
    class LeapYearCheck
    {
        public void isLeapYear(int year)
        {
            if ((year % 400 == 0) || ((year % 4 == 0) && (year % 100 != 0)))
            {
                Console.WriteLine(" {0} is a Leap Year.", year);
            }
            else
            {
                Console.WriteLine(" {0} is a not Leap Year.", year);
            }
        }

        public void ReadYear()
        {
            Console.Write(" Enter 4-digit Year : ");
            string year = Console.ReadLine();
            int yearLen = year.Length;
            int invalidYear=0;
            
            //checking input year contains only numbers
            foreach (char c in year)
            {
                if (!(c >= '0' && c <= '9'))
                {
                    invalidYear = 1;
                }
            }

            if (yearLen != 4 || invalidYear == 1)
            {
                Console.WriteLine(" Enter valid 4-digit year.");
            }
            else
            {
                isLeapYear(Convert.ToInt32(year));
            }
        }
    }
}
