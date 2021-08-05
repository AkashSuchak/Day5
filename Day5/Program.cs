using System;

namespace Day5
{
    class Program
    {
        static double FindPercentageOfHeads(int numberOfTimesCoinsTossed)
        {
            Random rand = new Random();
            int coinTossed;
            int headsCount = 0;
            double percentageOfHeads;

            for (int i = 0; i < numberOfTimesCoinsTossed; i++)
            {
                coinTossed = rand.Next(0, 2);
                if (coinTossed == 0)
                    headsCount++;                        
            }
            percentageOfHeads = (numberOfTimesCoinsTossed * headsCount) / 100;            
            return percentageOfHeads;
        }
        static double FindPercentageOfTails(int numberOfTimesCoinsTossed)
        {
            Random rand = new Random();
            int coinTossed;
            int  tailsCount = 0;
            double percentageOfTails;

            for (int i = 0; i < numberOfTimesCoinsTossed; i++)
            {
                coinTossed = rand.Next(0, 2);
                if (coinTossed == 1)
                    tailsCount++;
            }
            
            percentageOfTails = (numberOfTimesCoinsTossed * tailsCount) / 100;
            return percentageOfTails;
        }
       
        static void Main(string[] args)
        {
            /*Console.WriteLine("Enter Number You Want to Flip a Coin : ");
            int numberOfTimesCoinsTossed = int.Parse(Console.ReadLine());
            double headsPercentage = FindPercentageOfHeads(numberOfTimesCoinsTossed);
            double tailsPercentage = FindPercentageOfTails(numberOfTimesCoinsTossed);

            Console.WriteLine("Heads Percentage : " + headsPercentage);
            Console.WriteLine("Tails Percentage : " + tailsPercentage);*/

            //Program2.leapYear();
            //Program3.powerTable();
            //Program6.Display();
            //Program7.SwapNumbers();
            //Program8.EvenOdd();
            //Program9.Alphabet();
            //Program10.LargestNumber();
            Program4.HarmonicNumber();
        }
    }
}
