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
      int inQuarters = Convert.ToInt32(Math.Floor(amount/0.25));
      float decimalQuarters = amount/0.25f;
      float dimeNickPenn = inQuarters - decimalQuarters;
      DimeCalculate(dimeNickPenn);
      return inQuarters;
    }
    public int DimeCalculate(float round2)
    {
      int inDimes = Convert.ToInt32(Math.Floor(round2/0.10));
      float decimalDimes = round2/0.10f;
      float nickPenn = inDimes - decimalDimes;
      NickelCalculate(nickPenn);
      return inDimes;
    }
    public int NickelCalculate(float round3)
    {
      int inNickels = Convert.ToInt32(Math.Floor(round3/0.05));
      float decimalNicks = round3/0.05f;
      float pennies = inNickels - decimalNicks;
      PennyCalculate(pennies);
      return inNickels;
    }
    public int PennyCalculate(float round4)
    {
      int inPennies = Convert.ToInt32(Math.Floor(round4/0.01));
      return inPennies;
    }
  }
}