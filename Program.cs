/*
    Author: Tyler Wildrick
    Date: September 15, 2020
    Comments: This C# Console application code, in accordance with the requirements of Tech Project #2
              uses iterative statements after getting users to input data. 
*/

using System;

namespace Tyler_Wildrick_TechProject2a
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user to input integer value. 
            Console.WriteLine("Enter an integer value between 1 and 25 to execute an iterative statement: ");

                // This will be used to gather input from the user.
                string input = Console.ReadLine();
                // Parses input from user into integer variable to be used for iterative statement. 
                int value_of_input = int.Parse(input);
                /* 
                   This conditional IF/ELSE statement is used to test the values of user input.
                   Depending on the value of the user input between 1 and 25, a different type of 
                   iterative statement will execute. 
                */
                // If the value of user input is between 1 and 25, execute a For Loop
                if ((value_of_input > 0) && (value_of_input <= 25))
                {
                    Console.WriteLine("Executing a For Loop!");
                    Console.WriteLine("The For Loop will iterate " + value_of_input.ToString() + " times.");
                    // Here is the For Loop
                    for (int i = 0; i < value_of_input; i++)
                    {
                        Console.WriteLine("You have entered " + value_of_input+". This is the current integer value in the loop: " + i.ToString());
                    }
                    Console.WriteLine("Press any key to exit the program ...");
                    // Pause the program and await the user to press a key to end the program
                    Console.ReadKey(true);
                }
                // If the user enters anything other than a value between 1 and 25, display this message to prompt re-entry. 
                else
                {
                    Console.WriteLine("Press any key to exit the program and try again, by entering an integer between 1 and 25...");
                    Console.WriteLine("");
                    Console.ReadKey(true);
                }
        }
    }
}
