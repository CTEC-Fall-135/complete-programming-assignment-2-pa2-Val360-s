/* 
Author: Valentina Bocharnikova
Date: 10/01/2025
Assignment: Assignment 2
*/

namespace ConsoleApp
{
    internal class Program
    {
        static void Main()
        {
            // Create a region titled "Task2 Part 1"
            #region Task2 Part 1
            // Declare an int variable and set it to the max value
            int maxValue = int.MaxValue;

            //Print the value both as a normal int and in its Hex format as shown below
            Console.WriteLine($"Integer max value: {maxValue}");
            Console.WriteLine($"Integer max value (Hex): {maxValue:x}");

            // Increment the variable by one. Print the value again.
            maxValue++;
            Console.WriteLine($"\nAfter increment by one: ");
            Console.WriteLine($"Iteger max value: {maxValue}");
            Console.WriteLine($"Integer max value (Hex): {maxValue:x}");

            //Set the variable to 0 and print its value
            maxValue = 0;
            Console.WriteLine($"\nSet to 0: ");
            Console.WriteLine($"Integer max value: {maxValue}");
            Console.WriteLine($"Integer max value (Hex): {maxValue:x}");

            // Decrement the variable by one and print its value.
            maxValue--;
            Console.WriteLine($"\nAfter decreacing by 1: ");
            Console.WriteLine($"Integer max value: {maxValue}");
            Console.WriteLine($"Integer max value (Hex): {maxValue:x}");
            #endregion

            // Create a new region named "Casting" for this section.
            #region Casting
            // Assign the max value to your int variable.
            int intValue = int.MaxValue;

            // Declare a short variable initialize its value to the int variable.
            short shortValue = (short)intValue;

            // Print the int variable as a number and in the hexadecimal format.
            Console.WriteLine($"\nCasting section: ");
            Console.WriteLine($"Int max value: {intValue}");
            Console.WriteLine($"Int max value (Hex): {intValue:x}");

            // Print the short variable as a number and in the hexadecimal format.
            Console.WriteLine($"Short value after casting: {shortValue}");
            Console.WriteLine($"Short value (Hex): {shortValue:x}");
            #endregion

            // Create a new region named "Loops".
            #region Loops
            // Declare an array of ints of size 5.
            int[] numbers = new int[5];

            // Use a for loop to initialize the values in the range of 1 to 5.
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i + 1;
            }

            // Use a foreach loop to print the array values on a single line.
            foreach (int i in numbers)
            {
                Console.WriteLine(numbers + " ");
            }
            #endregion

            // Create a new region named "Loop bonus".
            #region Loop bonus
            // Create and print a multiplication table.
            Console.WriteLine($"\n Multiplication table (1 to 5): ");
            for (int i = 1;i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    Console.Write($"{i * j}\t");
                }
                Console.WriteLine();
            }
            #endregion

            // Create a region named "Printer troubleshooter".
            #region Printer troubleshooter
            // Declare a string variable to hold the condition information. Initial value is an empty string.
            string condition = "";

            // Ask the first question and based on the answer update the condition variable
            Console.WriteLine("\nDoes the printer print (Y/N)? ");
            string answer1 = Console.ReadLine();
            condition += answer1.ToUpper() == "Y" ? "Y" : "N";

            // Ask the next question and based on the answer update the condition variable
            Console.WriteLine("\nIs the red light flashing (Y/N)? ");
            string answer2 = Console.ReadLine();
            condition += answer2.ToUpper() == "Y" ? "Y" : "N";

            // Ask the last question and based on the answer update the condition variable.
            Console.WriteLine("\nIs the printer recognized by the conputer (Y/N)? ");
            string answer3 = Console.ReadLine();
            condition += answer3.ToUpper() == "Y" ? "Y" : "N";

            // Test to see if you code works by printing out the value of the condition variable.
            //Console.WriteLine($"\nCondition String: {condition}"); //comment out this statement.

            // Create the switch statement with all 8 possibilities.
            switch (condition)
            {
                case "YYY":
                    Console.WriteLine($"\nNo problems are detected");
                    break;
                case "YYN":
                    Console.WriteLine($"\nCheck the printer-computer cable");
                    break;
                case "YNY":
                    Console.WriteLine($"\nCheck the power cable");
                    break;
                case "NYY":
                    Console.WriteLine($"\nEnsure printer software is installed");
                    break;
                case "YNN":
                    Console.WriteLine($"\nCheck the power cable");
                    Console.WriteLine("Check the printer-computer cable");
                    break;
                case "NNY":
                    Console.WriteLine($"\nEnsure printer software is installed");
                    Console.WriteLine("Check the power cable");
                    break;
                case "NYN":
                    Console.WriteLine($"\nEnsure printer software is installed");
                    Console.WriteLine("Check the printer-computer cable");
                    break;
                case "NNN":
                    Console.WriteLine($"\nEnsure printer software is installed");
                    Console.WriteLine("Check the power cable");
                    Console.WriteLine("Check the printer-computer cable");
                    break;
                default:
                    Console.WriteLine("\tTry again");
                    break;
            }
            #endregion
        }
    }
}