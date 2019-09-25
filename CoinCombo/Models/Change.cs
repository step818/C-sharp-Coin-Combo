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
      float dimeNickPenn = inQuarters - decimalQuarters;
      DimeCalculate(dimeNickPenn);
      return inQuarters;
    }
    public int DimeCalculate(float round2)
    {
      int inDimes = Convert.ToInt32(round2/0.10);
      float decimalDimes = round2/0.10f;
      Console.WriteLine(decimalDimes);
      float nickPenn = inDimes - decimalDimes;
      // NickelCalculate(nickPenn);
      return inDimes;
    }
  }
}