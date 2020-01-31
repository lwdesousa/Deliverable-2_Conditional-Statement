/*
    Author: Leticia W de Sousa
    Date: 1/30/2020
    Comments: This C# Console application code demonstrates the use of
              condition statements after getting input from users. 
*/
using System;

namespace Deliverable_2_Conditional_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            //Requires the user to enter an input
            Console.WriteLine("Enter your number grade for ISM 4300!");

            /* Use try catch to make sure the input is valid
             * If the user provides an invalidninput, the catach block 
             * should handle the error and displyed a message
             */
            try
            {
                // This variable will collect data from the user input
                String input = Console.ReadLine();

                /* This variable will be used to store grades and parsed to int
                 */
                int grade = int.Parse(input);

                /* This conditional IF/ELSE statement is used to test the user input
                 * Depending on the value of the user (1-100), a different output will be displayed.
                 */

                // Conditional to A+
                if ((grade >= 98) && (grade <= 100))
                {
                    Console.WriteLine("You got an A+ in ISM 4300!");
                }
                //Conditional to A
                else if ((grade >= 92) && (grade <= 97))
                {
                    Console.WriteLine("You got an A! in ISM 4300!");
                }
                //Conditional to A-
                else if ((grade >= 90) && (grade <= 91))
                {
                    Console.WriteLine("You got an A- in ISM 4300!");
                }
                //Conditional to B+
                else if ((grade >= 88) && (grade <= 89))
                {
                    Console.WriteLine("You got a B+ in ISM 4300!");
                }
                //Conditional  B 
                else if ((grade >= 82) && (grade <= 87))
                {
                    Console.WriteLine("You got a B in ISM 4300!");
                }
                //Condional to B-
                else if ((grade >= 80) && (grade <= 81))
                {
                    Console.WriteLine("You got a B- in ISM 4300!");
                }
                //Conditional C+
                else if ((grade >= 78) && (grade <= 79))
                {
                    Console.WriteLine("You got a C+ in ISM 4300!");
                }
                //Conditional C
                else if ((grade >= 72) && (grade <= 77))
                {
                    Console.WriteLine("You got a C in ISM 4300!");
                }
                //Conditional  C-
                else if ((grade >= 70) && (grade <= 71))
                {
                    Console.WriteLine("You got a C- in ISM 4300!");
                }
                //Conditional D+
                else if ((grade >= 68) && (grade <= 69))
                {
                    Console.WriteLine("You got a D+ in ISM 4300!");
                }
                //Conditional D
                else if ((grade >= 62) && (grade <= 67))
                {
                    Console.WriteLine("You got a D in ISM 4300!");
                }
                //Conditional D-
                else if ((grade >= 60) && (grade <= 61))
                {
                    Console.WriteLine("You got a D- in ISM 4300!");
                }

                //Conditional of fail!
                else if ((grade < 60) && (grade >= 0))
                {
                    Console.WriteLine("You Failed ISM 4300, Try Again!");
                }

                //Display Message if the input is out of the range
                else
                {
                    Console.WriteLine("**Enter a number between 1 and 100**");
                }
            }

            //end of try
            catch
            {

                Console.WriteLine("Please enter a number between 1-100");
                Console.ReadKey(true);



            }

        
        }
    }
}

        
    
