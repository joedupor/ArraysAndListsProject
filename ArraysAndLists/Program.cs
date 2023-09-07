using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:

            // Create an int Array and populate numbers 1-10
            int[] myArray = new int[10] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};


            /* Create two Lists of type int.
             * Name one List "evens"
             * Name the other List "odds"
             */
            var myEvensList = new List<int>();
            var myOddsList = new List<int>();
            /* Using either a foreach or for loop,
             * nest an if statement to check to see
             *  if a number is even or odd. (USE MODULUS)
             * Then add those numbers to either the evens List
             * or the odds List
             */
            foreach (int number in myArray)
            {
                if (number % 2 == 0) 
                { 
                    myEvensList.Add(number);
                    
                }
                else if (number % 2 == 1) 
                { 
                    myOddsList.Add(number);
                    
                }
                //Console.WriteLine(myEvensList); WHY DOESN'T THIS WORK HERE on this line & WHY DOESN'T IT PRINT THE NUMBERS when using just the variable name ????????? Do printing arrays and lists behave differently ????
                //Console.WriteLine(myOddsList);
            }



            //NOW TRY IT USING A FOR LOOP:


            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] % 2 == 0)
                {
                    myEvensList.Add(myArray[i]);
                }
                else if (myArray[i] % 2 == 1)
                {
                    myOddsList.Add(myArray[i]);
                }
            }

            /* Now using foreach or for loops,
             * display each List of even and odd numbers
             *
             * Try to be creative in your display. (use string interpolation).
             */
            foreach (int number in myEvensList)
            {
                Console.WriteLine($"{number} is an even number. Precisely!");
            }

            foreach (int number in myOddsList)
            {
                Console.WriteLine($"How odd, {number} is an odd number!");
            }
            


        }   
    }
}
