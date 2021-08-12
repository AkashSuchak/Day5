using System;
using System.Collections.Generic;
using System.Text;

namespace Day5
{
    class Program5
    {
        public static void PrimeFactorization()
        {
            //Display Message and User Input
            Console.WriteLine("Enter Your Number for Prime Factorization : ");
            int n = int.Parse(Console.ReadLine());

            //Loop to get factors
            for (int i = 2;  i <= n; i++)
            {
                while (n % i == 0)
                {
                    n /= i;
                    Console.WriteLine(i);
                }
            }
        }
    }
}
