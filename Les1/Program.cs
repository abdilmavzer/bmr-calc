using System;
using System.Collections.Generic;
using System.Linq;

namespace Les1
{
    public class Program
    {
        public static void Main()
        {
            //Opdracht1.Start();
            Calculator calc = new Calculator();

            while (true)
            {
                try
                {
                    // user input
                    Console.WriteLine("geef het eerste getal: ");
                    string input1 = Console.ReadLine();

                    Console.WriteLine("geef het tweede getal: ");
                    string input2 = Console.ReadLine();

                    Console.WriteLine("geef de operatie ( +, -, * of  / ): ");
                    string input3 = Console.ReadLine();


                    //parsing
                    double getal1 = double.Parse(input1);
                    double getal2 = double.Parse(input2);

                    string answer = calc.Bereken(getal1, getal2, input3);
                    Console.WriteLine(answer);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                Console.WriteLine("type 1 voor historiek en enter to continue ");
                if (Console.ReadLine() == "1")
                {
                }
            }
        }
    }


    public class Calculator
    {
        private List<string> historiek = new List<string>();

        public string GetHistoriek()
        {
            string resultaat = "";

            foreach (string formule in historiek)
            {
                resultaat += $"{formule}\n";
            }

            return resultaat;
        }

        public string Bereken(double getal1, double getal2, string operatie)
        {
            bool add = operatie == "+";
            bool subtract = operatie == "-";
            bool multiple = operatie == "*";
            bool divide = operatie == "/";

            // validation check
            if (!(add || subtract || multiple || divide))
            {
                throw new ArgumentException("Operation is missing");
            }

            double totaal = 0;
            // Logic
            if (add)
                totaal = getal1 + getal2;

            if (subtract)
                totaal = getal1 - getal2;

            if (multiple)
                totaal = getal1 * getal2;

            if (divide)
                totaal = getal1 / getal2;

            string formule = $"{getal1}{operatie}{getal2}={totaal}";

            historiek.Add(formule);

            return formule;
        }
    }
}

