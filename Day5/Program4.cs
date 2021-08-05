using System;
using System.Collections.Generic;
using System.Text;

namespace Day5
{
    class Program4
    {
        public static void HarmonicNumber()
        {
            //Variables
            int i, number;
            double sum = 0.0;

            //Take user Input
            Console.Write("Calculate the harmonic series and their sum:\n");
            Console.Write("----------------------------------------------");
            Console.Write("\n");

            Console.Write("Enter the number For Harmonic Series : ");
            number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("H"+ number + "=");
            for (i = 1; i <= number; i++)
            {
                Console.Write("1/{0} + ", i);
                sum += 1 / (float)i;
            }
            Console.Write("\nSum of Harmonic Series : {0} ", sum);
        }
    }
}
