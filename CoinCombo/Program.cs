using System;
using System.Collections.Generic;
using CoinCombo.Models;

namespace CoinCombo
{
  public class Program
  {
    public static void Main()
    {
      Change pocketChange = new Change(89);
      //  Intro and prompt
      Console.WriteLine("This program is designed to return the least amount of coins that add up to any amount you want.");
      Console.WriteLine("--------------------------------------------");
      Console.WriteLine("Please type in a deccimal change amount to be calculated: ");
      float uAmount = float.Parse(Console.ReadLine());
      Console.WriteLine("Quarters: " + pocketChange.QuarterCalculate(uAmount));
      Console.WriteLine("Dimes: " + pocketChange.DimeCalculate(uAmount));
    }
  }
}