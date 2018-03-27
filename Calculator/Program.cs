using System;
using System.Collections.Generic;
using System.Windows;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
///  Add and subtract small int values - limited to two values as of 3/26
///  1) Be able to dispay the name of the program and what it can do
///  2) Be able to successfully add and subtract two values that were provided by two separate inputs
///  3) Ask if you want to subtract or add the values that were provided
///  
///  3/27 update:
///  4) Display the mathematical equation on-screen along with the answer
///  5) TryCatch blocks for uncertain code (user input for a string rather than int)
/// </summary>

namespace Calculator
{
    class Program
    {
        static void PauseClose()
        {
            Console.WriteLine("Program has ended, enter any key to close this window.");
            Console.ReadKey();
            System.Environment.Exit(1);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Calculator project \nDescription of this as of 3/26 is to just add or subtract two integers");

            Int32 First = 0;
            Int32 Second = 0;

            Console.WriteLine("Enter the first number:");
            try
            {
                 First = System.Convert.ToInt32(Console.ReadLine());
                // var FirstInt = Console.ReadLine();
                // int First = Int32.Parse(FirstInt);
            }
            catch (System.FormatException)
            {
                /// Setting an integer to compare against for the GetType function
                // Int32 i = Int32.MinValue; 
                // if (First.GetType() != i.GetType() )
               // Console.WriteLine("You need to enter a number instead, exiting program...");

                Program.PauseClose();
            }


            Console.WriteLine("Enter the second number:");
            try
            {
                // var SecondInt = Console.ReadLine();
                // int Second = Int32.Parse(SecondInt);
                Second = System.Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                // close it down if the input is incorrect
                Int32 i = Int32.MinValue;
                if (First.GetType() != i.GetType())
                    Console.WriteLine("You need to enter a number instead, exiting program...");

                Program.PauseClose();
            }


            Console.WriteLine("Would you like to add or subtract these values?");
            // Expecting either "add" or "subtract" strings here
            string Operator = Console.ReadLine();
            var add = "add";

            if (Operator == add)
            {
                int Answer = First + Second;
                Console.WriteLine("{0} + {1} = {2}", First, Second, Answer);
            }
             
                else 
                {
                    int SecondAnswer = First - Second;
                    Console.WriteLine("{0} - {1} = {2}", First, Second, SecondAnswer);
                }

            Program.PauseClose();

        }
    }
}
