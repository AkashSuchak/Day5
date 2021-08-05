using System;
using System.Collections.Generic;
using System.Text;

namespace Day5
{
    class Program6
    {
        public static void Display()
        {
            Console.WriteLine("Welcome To Problem Number 6 :");
            //variables
            int divideNumber = 10;
            int dividerNumber = 5;
            double quotient, reminder;

            //Operation
            quotient = divideNumber / dividerNumber;
            reminder = divideNumber % dividerNumber;

            //Display Reminder and Quotient
            Console.WriteLine(divideNumber + " / " + dividerNumber);
            Console.WriteLine("Quotient : " +quotient);
            Console.WriteLine("Reminder : " + reminder);
        }
    }
}
