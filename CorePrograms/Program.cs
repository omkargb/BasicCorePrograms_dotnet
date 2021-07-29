using System;

namespace CorePrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Welcome to the project of solving Basic Core programs \n");
            Console.WriteLine(" Here is the list of Programs : ");
            Console.WriteLine(" 1. Flip Coin and print percentage of Heads and Tails.\n" +
                " 2. Check year is a Leap Year or not. \n" +
                " 3. Print a table of the powers of 2. \n" +
                " 4. Print the Nth harmonic number: 1/1 + 1/2 + ... + 1/N \n" +
                " 5. Compute the prime factorization of number.\n" +
                " 6. Compute Quotient and Remainder \n" +
                " 7. Swap Two Numbers. \n" +
                " 8. Check Whether a Number is Even or Odd. \n" +
                " 9. Check Whether an Alphabet is Vowel or Consonant. \n" +
                " 10.Find the Largest Among Three Numbers. \n");

            Console.Write("Type option number to run a program : ");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                        FlipCoinPercentage flip = new FlipCoinPercentage();
                        flip.FlipCoin();
                        break;
                case "2":
                        LeapYearCheck leap = new LeapYearCheck();
                        leap.ReadYear();
                        break;
                case "3":
                        PowerOfTwo power = new PowerOfTwo();
                        power.takeInput();
                        break;
                case "4":
                        HarmonicNumber num = new HarmonicNumber();
                        num.TakeInput();
                        break;
                case "5":
                        PrimeFactors pf = new PrimeFactors();
                        pf.TakeInput();
                        break;
                case "6":
                        Division div = new Division();
                        div.TakeInput();
                        break;
                case "7":
                        SwapTwoNumbers swap = new SwapTwoNumbers();
                        swap.TakeInput();
                        break;
                case "8":
                        EvenOrOdd eod = new EvenOrOdd();
                        eod.TakeInput();
                        break;
                case "9":
                        VowelOrConsonant vc = new VowelOrConsonant();
                        vc.TakeInput();
                        break;
                case "10":
                        LargestOfThreeNums large = new LargestOfThreeNums();
                        large.TakeInput();
                        break;
                default:
                        Console.WriteLine(" Enter valid option number. ");
                        break;
            }
        }
    }
}
