using System;
using System.Collections.Generic;
using System.Text;

namespace Day5
{
    class Program2
    {
        public static void leapYear()
        {
            //Constant Variable
            int LENGTH_OF_YEAR_REQUIRED = 4;

            //Display Message
            Console.WriteLine("Enter 4 digit Number To Check Leap Year : ");
            
            //Taking Year From user
            int year = int.Parse(Console.ReadLine());
            double lengthOfYear = Math.Floor(Math.Log10(year) + 1);
            //Console.WriteLine("Digits of Year : " + lengthOfYear);
            
            //To Check Leap Year or Not
            if (lengthOfYear == LENGTH_OF_YEAR_REQUIRED)
            {
                if ( ((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0)) 
                    Console.WriteLine(year + " is a Leap Year");
                else 
                    Console.WriteLine(year + " is not a Leap Year.");
            }
            else Console.WriteLine("Please Enter 4 Digit year");
        }
    }
}
