using System;
using System.Collections.Generic;

namespace Les1
{
    public class Opdracht1
    {
        public static void Start()
        {
            List<string> history = new List<string>();
            while (true)
            {
                // decarlatie variablen
                double getal1, getal2, totaal = 0;
                bool add, subtract, multiple, divide;
                string input1, input2, input3 = null;
                string optie;
                
                // user input
                Console.WriteLine("geef het eerste getal: ");
                input1 = Console.ReadLine();

                Console.WriteLine("geef het tweede getal: ");
                input2 = Console.ReadLine();

                Console.WriteLine("geef de operatie ( +, -, * of  / ): ");
                input3 = Console.ReadLine();

                try
                {
                    //parsing
                    getal1 = double.Parse(input1);
                    getal2 = double.Parse(input2);

                    add = input3 == "+";
                    subtract = input3 == "-";
                    multiple = input3 == "*";
                    divide = input3 == "/";

                    // validation check
                    if (!(add || subtract || multiple || divide))
                    {
                        throw new ArgumentException("Operation is missing");
                    }

                    // Logic
                    if (add)
                    {
                        totaal = getal1 + getal2;
                    }

                    if (subtract)
                    {
                        totaal = getal1 - getal2;
                    }

                    if (multiple)
                    {
                        totaal = getal1 * getal2;
                    }

                    if (divide)
                    {
                        totaal = getal1 / getal2;
                    }

                    // results
                    history.Add($"{getal1}{input3}{getal2}={totaal}");
                    Console.WriteLine($"Het totaal is {totaal}");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                
                Console.Write("type 1 voor historiek en enter to continue ");
                optie = Console.ReadLine();
                if (optie == "1")
                {
                    foreach (var formule in history)
                    {
                        Console.WriteLine(formule);
                    }
                }
            }
        }
    }
}