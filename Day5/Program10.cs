using System;
using System.Collections.Generic;
using System.Text;

namespace Day5
{
    class Program10
    {
        public static void LargestNumber()
        {
            //variables
            int number1, number2, number3;
            
            // Display Message
            Console.Write("Find the largest Among Three numbers:\n");
            Console.Write("------------------------------------");
            Console.Write("\n\n");

            // Taking User Input
            Console.Write("Enter the 1st number :");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the 2nd number :");
            number2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the 3rd  number :");
            number3 = Convert.ToInt32(Console.ReadLine());

            if (number1 > number2)
            {
                if (number1 > number3)                
                    Console.Write(number1 + " is the Largest among three. \n");                
                else                
                    Console.Write(number3 + " is the Largest among three. \n");               
            }
            else if (number2 > number3)
                Console.Write(number2 + " is the Largest among three \n");
            else
                Console.Write(number3 + " is the Largest among three \n");

        }
    }
}
