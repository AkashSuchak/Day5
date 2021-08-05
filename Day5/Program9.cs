using System;
using System.Collections.Generic;
using System.Text;

namespace Day5
{
    class Program9
    {
        public static void Alphabet()
        {
            //Variable
            char ch;

            //User Input
            Console.WriteLine("Enter any character: ");
            ch = Convert.ToChar(Console.ReadLine());

            // Condition for vowel checking
            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' || ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
                Console.WriteLine(ch + " is Vowel.");            
            else 
                Console.WriteLine(ch + " is Consonant.");           
        }
    }
}
