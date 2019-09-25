using System.Collections.Generic;
using System;

namespace CoinCombo.Models
{
  public class Change
  {
    public float Banker {get; set;}
    
    public Change(float amount)
    {
      Banker = amount;
    }
    public int QuarterCalculate(float amount)
    {
      int inQuarters = Convert.ToInt32(amount/0.25);
      float decimalQuarters = amount/0.25f;
      Console.WriteLine(decimalQuarters);
      //DimeCalculate(inQuarters - decimalQuarters);
      return inQuarters;
    }
  }
}