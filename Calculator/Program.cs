using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
///  Add and subtract small int values - limited to two values as of 3/26
///  1) Be able to dispay the name of the program and what it can do
///  2) Be able to successfully add and subtract two values that were provided by two separate inputs
///  3) Ask if you want to subtract or add the values that were provided
/// </summary>

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number:");
            var FirstInt = Console.ReadLine();
            int First = Int32.Parse(FirstInt);

            Console.WriteLine("Enter the second number:");
            var SecondInt = Console.ReadLine();
            int Second = Int32.Parse(SecondInt);

            Console.WriteLine("Would you like to add or subtract these values?");
            // Expecting either "add" or "subtract" strings here
            string Operator = Console.ReadLine();
            var add = "add";

            if (Operator == add)
            {
                int Answer = First + Second;
                Console.WriteLine(Answer);
            }
             
                else 
                {
                    int SecondAnswer = First - Second;
                    Console.WriteLine(SecondAnswer);
                }
            

        }
    }
}
