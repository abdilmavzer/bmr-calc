using System;

namespace Les2
{
  public sealed class BmrCalculator
  {
    private bool IsMale { get; set; }
    private double Weight { get; set; }
    private double Length { get; set; }
    private int Age { get; set; }

    public BmrCalculator(bool isMale, double weight, double length, int age)
    {
      IsMale = isMale;
      Weight = weight;
      Length = length;
      Age = age;
    }

    public double Calculate()
    {
      if (IsMale)
      {
        return 88.362 + (13.397 * Weight + 4.799 * Length - 5.677 * Age);
      }
      return 447.593 + (9.247 * Weight + 3.098 * Length - 4.330 * Age);
    }

     public override string ToString()
     {
       return $"Your bmr is {Calculate()}";
     }
  }
}