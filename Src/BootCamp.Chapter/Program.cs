using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Your name:");
            var name = Console.ReadLine();

            Console.WriteLine("Your surname:");
            var surname = Console.ReadLine();

            Console.WriteLine("Your age:");
            var age = Console.ReadLine();

            Console.WriteLine("Your weight(kg):");
            var weight = float.Parse(Console.ReadLine());

            Console.WriteLine("Your height(cm):");
            var height = float.Parse(Console.ReadLine());

            var heightInMeter = height / 100;
            var bmi = weight / (heightInMeter * heightInMeter);

            Console.WriteLine($"BMI: {bmi:N1}");
        }
    }
}
