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

        private static bool UseMetricSystem()
        {
            Console.WriteLine("Choose between metric or imperial system(m/i): ");
            string input = Console.ReadLine();
            if (input != "m" && input != "i" )
            {
                throw new Exception("invalid choice, choose between m or i");
            }

            return input == "m";
        }
        
        public static void Main()
        {
            while (true)
            {
                try
                {
                    bool useMetricSystem = UseMetricSystem();
                    bool isMale = IsMale();
                    double weight, length;
                    
                    if (useMetricSystem)
                    {
                        weight = GetInput("How much do you weigh in (kg)?: ", "invalid weight!");
                        length = GetInput("What's your length in (cm)?: ", "invalid length!");
                    }
                    else
                    {
                        weight = GetInput("How much do you weigh in (ibs)?: ", "invalid weight!");
                        length = GetInput("What's your length in (inches)?: ", "invalid length!");
                    }
                   
                    int age = (int)GetInput("How old are you in (years)?: ", "invalid age!");
                    
                    var calculator = new BmrCalculator(isMale, weight, length, age, useMetricSystem);
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

//public static class (klasse) = niet geinstantieerd en je kan geen objecten(instanties) van die klasse maken (gegevens worden benaderd via klassenmaam)
//public static void (methode) = static" binnen een klasse, betekent dit dat de methode behoort tot de klasse zelf in plaats van een specifieke instantie van de klasse.
//public static (in een veld) = gedeeld tussen alle instanties van de klasse. geassocieerd met de klasse zelf i.p.v object. 
//static naam (constructor) = statische leden van klasse initialiseren

// Kort : static wordt gebruikt om elementen (klassen,methoden,enz) die zijn geassocieerd met de klasse zelf i.p.v instaties van die klasse.
// worden opgeroepen zonder objecten van de klasse te maken
