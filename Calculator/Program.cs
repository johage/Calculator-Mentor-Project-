using System;
using System.Collections.Generic;
using System.Windows;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
///  Add and subtract small int values - limited to two values as of 3/26
///  1) Be able to dispay the name of the program and what it can do - Done
///  2) Be able to successfully add and subtract two values that were provided by two separate inputs - Done
///  3) Ask if you want to subtract or add the values that were provided - Done
///  
///  3/27 update:
///  4) Display the mathematical equation on-screen along with the answer - Done
///  5) TryCatch blocks for uncertain code (user input for a string rather than int) - Done
/// </summary>
/// 
///  3/29 update:
///  6) Add Enumerator functionality, also adding in multiplication and division for eventual scaling out of operations - Done
///  7) Add in functionality to handle Int64 so we don't just flat-out break when we exceed Int32 range - Done
///  8) Allow use of '+' or '-' instead of string-based response - Done
///  9) Reformat the script to utilize a single function for the requesting of integers and reduce the number of required try/catch - Done
///  10) Loop the program if the user enters the incorrect value for the First or Second integers - Done (David did this)
namespace Calculator
{
    class Program
    {
        enum Operation { Add=1, Subtract, Multiply, Divide };

        const string VersionDate = "3/29/2018";

        static int GetDataFromLine(string sDisplay)
        {
            int iResult = new int();
            Console.WriteLine(sDisplay);
            string sLine = Console.ReadLine();

            try
            {
                iResult = System.Convert.ToInt32(sLine);
            }
            catch (System.FormatException)
            {
                Console.WriteLine("You need to enter a number instead, please enter a number");
                iResult = GetDataFromLine(sDisplay);
            }
            catch (System.OverflowException)
            {
                string MaxInt = Convert.ToString(Int32.MaxValue);
                Console.WriteLine("You entered a number that is too large for this calculator to handle, enter a number smaller than {0}", MaxInt);
                iResult = GetDataFromLine(sDisplay);
            }
            return iResult;
        }
        static void PauseClose()
        {
            Console.WriteLine("Program has ended, enter any key to close this window.");
            Console.ReadKey();
            System.Environment.Exit(1);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Calculator project \nDescription of this current as of {0} \nis to add, subtract, multiply, and divide integers", VersionDate);

            Int32 First = GetDataFromLine("Enter the first number:");
            Int32 Second = GetDataFromLine("Enter the second number:");
            

            /*
            /// We don't need this anymore since we designed the GetDataFromLine Function for it
            Console.WriteLine("Enter the first number:");
            try
            {
                /// This wasn't necessary since we can just convert the response at the time it's input
                // var SecondInt = Console.ReadLine();
                // int Second = Int32.Parse(SecondInt);
                First = System.Convert.ToInt32(Console.ReadLine());
            }
            catch (System.FormatException)
            {
                ///Josh: This is the old way of doing it. It would actually be best to update the readline try catch into its own function. 
                ///This way you can make one change and it applies it to both times you are reading a line the same. KEEP in mind how you are doing the logic determine 
                ///if we are wanting to add or subtract and later doing multiply and divide. 
                ///Josh: Challenge - try to make the code in a loop and not close out of the program because of user ERR 
                ///and come back to the correct location of the program till user puts in the correct information. 
                // close it down if the input is incorrect
                Console.WriteLine("You need to enter a number instead, please enter a number");
                First = System.Convert.ToInt32(Console.ReadLine());
                // Program.PauseClose();
            }
            catch (System.OverflowException)
            {
                string MaxInt = Convert.ToString(Int32.MaxValue);
                Console.WriteLine("You entered a number that is too large for this calculator to handle, enter a number smaller than {0}", MaxInt);
                First = System.Convert.ToInt32(Console.ReadLine());
            }

            
            Console.WriteLine("Enter the second number:");

            
            try
            {
                /// This wasn't necessary since we can just convert the response at the time it's input
                // var SecondInt = Console.ReadLine();
                // int Second = Int32.Parse(SecondInt);
                Second = System.Convert.ToInt32(Console.ReadLine());
            }
            catch (System.FormatException)
            {
                ///Josh: This is the old way of doing it. It would actually be best to update the readline try catch into its own function. 
                ///This way you can make one change and it applies it to both times you are reading a line the same. KEEP in mind how you are doing the logic determine 
                ///if we are wanting to add or subtract and later doing multiply and divide. 
                ///Josh: Challenge - try to make the code in a loop and not close out of the program because of user ERR 
                ///and come back to the correct location of the program till user puts in the correct information. 
                // close it down if the input is incorrect
                Console.WriteLine("You need to enter a number instead, please enter a number");
                Second = System.Convert.ToInt32(Console.ReadLine());
                // Program.PauseClose();
            }
            catch (System.OverflowException)
            {
                string MaxInt = Convert.ToString(Int32.MaxValue);
                Console.WriteLine("You entered a number that is too large for this calculator to handle, enter a number smaller than {0}", MaxInt);
                Second = System.Convert.ToInt32(Console.ReadLine());
            }
            */
            /// No longer require these as we're moving to use of enum to utilize the Switch statement instead of stringing together Else-If
            // string add = "  add";
            // string adding = "+";
            // string subtract = "  subtract";
            // string subtracting = "-";

            Console.WriteLine("Would you like to Add, Subtract, Multiply, or Divide these values? Choose a number:\n 1) {0}\n 2) {1}\n 3) {2}\n 4) {3}", Operation.Add, Operation.Subtract, Operation.Multiply, Operation.Divide);
            // Expecting either "add" or "subtract" strings here
            Int32 Operator = Convert.ToInt32(Console.ReadLine());
            
            
            /// Need to reference the enum options (Operator) while converting the string to the expected Case in the subsequent switch
            switch (Operator)
            {
                case 1:
                    // Operation.Add
                    int AddAnswer = First + Second;
                    Console.WriteLine("{0} + {1} = {2}", First, Second, AddAnswer);
                    Console.ReadKey();
                    break;
                case 2:
                    // Operation.Subtract
                    int SubtractAnswer = First - Second;
                    Console.WriteLine("{0} - {1} = {2}", First, Second, SubtractAnswer);
                    Console.ReadKey();
                    break;
                case 3:
                    // Operation.Multiply
                    int MultiplyAnswer = First * Second;
                    Console.WriteLine("{0} * {1} = {2}", First, Second, MultiplyAnswer);
                    Console.ReadKey();
                    break;
                case 4:
                    // Operation.Divide
                    int DivideAnswer = First / Second;
                    Console.WriteLine("{0} / {1} = {2}", First, Second, DivideAnswer);
                    Console.ReadKey();
                    break;
                default:
                    Console.WriteLine("You didn't enter an expected parameter, exiting program.");
                    Console.ReadKey();
                    break;
                    
            }
            Program.PauseClose();
            

            /// We don't need this logic anymore since we're using the Switch above

            // if (Operator == add)
            // {
            //    int Answer = First + Second;
            //    Console.WriteLine("{0} + {1} = {2}", First, Second, Answer);
            // }

            //else if (Operator == adding)
            // {
            //    int Answer = First + Second;
            //    Console.WriteLine("{0} + {1} = {2}", First, Second, Answer);
            // }

            // else if (Operator == subtracting)
            // {
            //    int Answer = First - Second;
            //    Console.WriteLine("{0} - {1} = {2}", First, Second, Answer);
            // }

            // else
            // {
            //    int Answer = First - Second;
            //    Console.WriteLine("{0} - {1} = {2}", First, Second, Answer);
            // }
            // Program.PauseClose();
        }
        
    }
}
