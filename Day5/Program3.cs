using System;
using System.Collections.Generic;
using System.Text;

namespace Day5
{
    class Program3
    {
        public static void powerTable()
        {
            //Constant Variable
            int POWER_OF = 2;

            //variable
            double result;
            
            //Display Line for Input
            Console.WriteLine("Enter Number to make table Power of 2 : ");
            double number = double.Parse(Console.ReadLine());

            //Table till Number is reached
            for (int i = 0; i < number; i++)
            {
                //Operation
                result = Math.Pow((i+1), POWER_OF);
                //Display output
                Console.WriteLine((i + 1) + " ^ " + POWER_OF + " = " + result);
            }
        }
    }
}
