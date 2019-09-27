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
      Console.WriteLine("Please type in a decimal change amount to be calculated: ");
      float uAmount = float.Parse(Console.ReadLine());
      Console.WriteLine("The list below will make " + uAmount);
      Console.Write("--------------------------------------------\n");
      pocketChange.QuarterCalculate(uAmount);
    }
  }
}