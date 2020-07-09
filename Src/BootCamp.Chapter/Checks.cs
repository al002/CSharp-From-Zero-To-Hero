using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    /// <summary>
    /// Test class is used to test your implementation.
    /// Each homework will have a set of steps that you will have to do.
    /// You can name your functions however you want, but to validate your solution, place them here.
    /// DO NOT CALL FUNCTIONS FROM TESTS CLASS
    /// DO NOT IMPLEMENT FUNCTIONS IN TESTS CLASS
    /// TESTS CLASS FUNCTIONS SHOULD ALL HAVE 1 LINE OF CODE
    /// </summary>
    public static class Checks
    {
        public static int PromptInt(string message)
        {
            Console.WriteLine(message);
            var input = Console.ReadLine();
            if (String.IsNullOrEmpty(input)) {
                return 0;
            }
            int n;
            var isNumberic = int.TryParse(input, out n);
            if (!isNumberic)
            {
                Console.Write($"\"{input}\" is not a valid number.");
                return -1;
            }
            return n;
        }

        public static string PromptString(string message)
        {
            Console.WriteLine(message);
            var input = Console.ReadLine();

            if (String.IsNullOrEmpty(input))
            {
                Console.Write("Name cannot be empty.");
                return "-";
            }

            return input;
        }

        public static float PromptFloat(string message)
        {
            Console.WriteLine(message);
            var input = Console.ReadLine();
            if (String.IsNullOrEmpty(input)) {
                return 0;
            }
            float n;
            var isNumberic = float.TryParse(input, out n);
            if (!isNumberic)
            {
                Console.Write($"\"{input}\" is not a valid number.");
                return -1;
            }
            return n;
        }

        public static float CalculateBmi(float weight, float height)
        {
            if (weight <= 0 || height <= 0) {
                Console.WriteLine("Failed calculating BMI. Reason:");
                if (weight <= 0)
                {
                    Console.WriteLine($"Weight cannot be equal or less than zero, but was {weight}.");
                }

                if (height <= 0)
                {
                    string equalOr = weight <= 0 ? "" : " equal or";
                    Console.WriteLine($"Height cannot be{equalOr} less than zero, but was {height}.");

                }
                return -1;
            }
            return weight / (height * height);
        }
    }
}
