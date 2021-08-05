using System;
using System.Collections.Generic;
using System.Text;

namespace Day5
{
    class Program8
    {
        public static void EvenOdd()
        {
            //Welcome Message
            Console.WriteLine("Welcome To Program 7");

            //Constant Variable
            int DIVIDER = 2;

            //user input
            Console.WriteLine("Enter Number To Check Even Or Odd");
            int number = int.Parse(Console.ReadLine());

            //Check Even or Odd
            if ((number/DIVIDER) == 0)
                Console.WriteLine(number+ " is Even");
            else
                Console.WriteLine(number + " is Odd");
        }
    }
}
