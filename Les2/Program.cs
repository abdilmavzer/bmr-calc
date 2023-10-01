using System;
using System.ComponentModel;
using System.Diagnostics;

namespace Les2
{
    public class Program
    {
        static void Main(string[] args)
        {
            //console app bevraging met fout checks
            
            
            while (true)
            {
                try
                {
                    Console.WriteLine("what is your gender (m/f)?: ");
                    string ingender = Console.ReadLine();
                    
                    Console.WriteLine("How much do you weigh in (kg)?: ");
                    double inweigh = Convert.ToDouble(Console.ReadLine());
                    
                    Console.WriteLine("What's your length in (cm)?: ");
                    double inlength = Convert.ToDouble(Console.ReadLine());
                    
                    Console.WriteLine("How old are you in (years)?: ");
                    int inage = Convert.ToInt32(Console.ReadLine());
                    
                    Person calc;
                    if (ingender.Equals("m",StringComparison.Ordinal))
                    {
                        calc = new MannenBMR(ingender,inweigh,inlength,inage);
                    }else if (ingender.Equals("f", StringComparison.Ordinal))
                    {
                        calc = new VrouwenBMR(ingender,inweigh,inlength,inage);
                    }
                    else
                    {
                        throw new Exception("invalid gender, choose between m or f");
                    }
                
                    calc.BmrDisplay();
                    
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    
                }
                
                
            }
        }
    }
    
    
    //hoofdklasse
    public abstract class Person
    {
        //velden met getters en setters
        protected string gender { get; set; }
        protected double weigh { get; set; }
        protected double length { get; set; }
        protected int age { get; set; }
        
        //constructor
        public Person(string gender, double weigh, double length, int age)
        {
            gender = gender;
            weigh = weigh;
            length = length;
            age = age;
        }
        
        //Nu omdat yusuf override vraagt moeten we een klasse voor mannen en vrouwen maken 
        //En een display methode om bmr te weergeven
        
        //met een abstracte klasse kunde klassen of methodes maken die onvolledig zijn in abstracte klassen nodig voor overerving
        public abstract double berekening();
        
        //display
        public void BmrDisplay()
        {
            double bmr = berekening();
            Console.WriteLine($"Jouw bmr is {bmr} ");
        }

        
        
    }
    
    //nevenklassen
    //Als je override doet moet je ook de constructor en methode van bovenklasse implementeren
    public class MannenBMR : Person
    {
        public MannenBMR(string gender, double weigh, double length, int age) : base(gender, weigh, length, age)
        {
        }

        public override double berekening()
        {
            //velden in protected zetter en niet in private
            return 88.362 + ((13.397 * weigh) + (4.799 * length) - (5.677 * age));
        }
    }
    
    public class VrouwenBMR : Person
    {
        public VrouwenBMR(string gender, double weigh, double length, int age) : base(gender, weigh, length, age)
        {
        }

        public override double berekening()
        {
            return 447.593 + ((9.247 * weigh) + (3.098 * length) - (4.330 * age));
        }
    }
}

//GELEERD 

// als je override gebrukt maak je klasse abstract en velden protected en implementeer in nevenklassen de methodes en constructor van de hoofdklasse 
// maak in u hoofklasse de methodes abstract en void voor display 
// met een abstracte klasse kunde klassen of methodes maken die onvolledig zijn in abstracte klassen nodig voor overerving
// .equal("String". vergelijken)
//  alleen toegankelijk vanuit de klasse en degenen die deze uitbreiden (zoals private, maar plus toegang vanuit overervende klassen)
