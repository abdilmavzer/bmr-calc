using System;
//imperial of metrix system keuze 
//verschil tussen static en niet static object uitleggen morgen
namespace Les2
{
  public sealed class BmrCalculator
  {
    private bool IsMale { get; set; }
    private double Weight { get; set; }
    private double Length { get; set; }
    private int Age { get; set; }
    private bool UseMetricSystem { get; set; }

    public BmrCalculator(bool isMale, double weight, double length, int age, bool useMetricSystem)
    {
      IsMale = isMale;
      Weight = weight;
      Length = length;
      Age = age;
      UseMetricSystem = useMetricSystem;
    }

    public double Calculate()
    {
      if (UseMetricSystem)
      {
        if (IsMale)
        {
          return 88.362 + (13.397 * Weight + 4.799 * Length - 5.677 * Age);
        }
        return 447.593 + (9.247 * Weight + 3.098 * Length - 4.330 * Age);
      }else 
      {
        if (IsMale)
        {
          return 66.5 + (6.23 * Weight + 12.7 * Length - 6.8 * Age);
        }
        return 655 + (4.35 * Weight + 4.7 * Length - 4.7 * Age);
      }
    }

     public override string ToString()
     {
       return $"Your bmr is {Calculate()}";
     }
  }
}