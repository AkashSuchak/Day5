using System;
using System.Collections.Generic;
using System.Text;

namespace Day5
{
    class Program7
    {
        public static void SwapNumbers()
        {
            //variables
            int firstNumber, secondNumber;

            //User Input
            Console.WriteLine("Enter First Number to Swap With Second :: ");
            firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number to Swap With First :: ");
            secondNumber = int.Parse(Console.ReadLine());

            //Display message
            Console.WriteLine("Before Swaping Numbers :: " + "\n");
            Console.WriteLine("First Number = " + firstNumber + "\n");
            Console.WriteLine("Second Number = " + secondNumber + "\n");
            
            //Swaping Numbers
            firstNumber *= secondNumber; 
            secondNumber = firstNumber / secondNumber; 
            firstNumber /= secondNumber; 

            // Display Output after Swaping
            Console.WriteLine("After Swaping Numbers :: " + "\n");
            Console.WriteLine("First Number = " + firstNumber + "\n");
            Console.WriteLine("Second Number = " + secondNumber + "\n");
        }
    }
}
