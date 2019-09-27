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
      int inQuarters = Convert.ToInt32(Math.Floor(amount/0.250));
      float multipleQuart = (float)inQuarters * 0.250f;
      float leftOver = amount - multipleQuart;
      Console.WriteLine("Quarters: " + inQuarters);
      DimeCalculate(leftOver);
      return inQuarters;
    }
    public int DimeCalculate(float round2)
    {
      int inDimes = Convert.ToInt32(Math.Floor(round2/0.100));
      float multipleDimes = (float)inDimes * 0.100f;
      float leftOver = round2 - multipleDimes;
      Console.WriteLine("Dimes: " + inDimes);
      NickelCalculate(leftOver);
      return inDimes;
    }
    public int NickelCalculate(float round3)
    {
      int inNickels = Convert.ToInt32(Math.Floor(round3/0.050));
      float multipleNicks = (float)inNickels * 0.050f;
      float leftOver = round3 - multipleNicks;
      Console.WriteLine("Nickels: " + inNickels);
      PennyCalculate(leftOver);
      return inNickels;
    }
    public int PennyCalculate(float round4)
    {
      int inPennies = Convert.ToInt32((round4/0.010));
      Console.WriteLine("Pennies: " + inPennies);
      return inPennies;
    }
  }
}