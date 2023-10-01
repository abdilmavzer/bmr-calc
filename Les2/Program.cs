using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;

namespace Les2
{
    public class Program
    {
        private static bool IsMale()
        {
            Console.WriteLine("what is your gender (m/f)?: ");
            string input = Console.ReadLine();
            if (input != "m" && input != "f")
            {
                throw new Exception("invalid gender, choose between m or f");
            }
            return input == "m";
        }
        private static double GetInput(string requestMessage, string errorMessage)
        {
            Console.WriteLine(requestMessage);
            if (!Double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture,
                    out double value))
            {
                throw new Exception(errorMessage); 
            }
            return value;
        }
        public static void Main()
        {
            while (true)
            {
                try
                {
                    bool isMale = IsMale();
                    double weight = GetInput("How much do you weigh in (kg)?: ", "invalid weight!");
                    double length = GetInput("What's your length in (cm)?: ", "invalid length!");
                    int age = (int)GetInput("How old are you in (years)?: ", "invalid age!");
                    
                    var calculator = new BmrCalculator(isMale, weight, length, age);
                    Console.WriteLine(calculator.ToString());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
