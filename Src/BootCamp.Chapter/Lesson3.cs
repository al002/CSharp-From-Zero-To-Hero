using System;

namespace BootCamp.Chapter
{
    class Lesson3
    {
        public static void Demo()
        {
            var name = Checks.PromptString("Your name:");

            var surname = Checks.PromptString("Your surname:");

            var age = Checks.PromptInt("Your age:");

            var weight = Checks.PromptFloat("Your weight(kg):");

            var height = Checks.PromptFloat("Your height(cm):");

            var heightInMeter = height / 100;

            var bmi = Checks.CalculateBmi(weight, heightInMeter);

            Console.WriteLine($"BMI: {bmi:N1}");
        }
    }
}