using Microsoft.VisualStudio.TestTools.UnitTesting;
using CoinCombo.Models;

namespace CoinCombo.Tests
{
  [TestClass]
  public class ChangeTest
  {
    [TestMethod]
    public void ChangeConstructor_CreatesInstanceOfChange_Change()
    {
      Change pocketChange = new Change(.01f);
      Assert.AreEqual(typeof(Change), pocketChange.GetType());
    }
    [TestMethod]
    public void GetAmount_ReturnsAmount_Float()
    {
      //Arrange
      float amount = .90f;
      Change pocketChange = new Change(amount);
      //Act
      float result = pocketChange.Banker;
      //Assert
      Assert.AreEqual(amount, result);
    }
    [TestMethod]
    public void SetAmount_SetAmount_Float()
    {
      //Arrange
      float amount = .50f;
      Change pocketChange = new Change(amount);
      //Act
      float updatedAmount = .55f;
      pocketChange.Banker = updatedAmount;
      float result = pocketChange.Banker;
      //Assert
      Assert.AreEqual(updatedAmount, result);
    }
    [TestMethod]
    public void QuarterCalculate_CalculatesQuarters_Int()
    {
      //Arrange
      float amount = .55f;
      Change pocketChange = new Change(amount);
      //Act
      float result = pocketChange.QuarterCalculate(amount);
      //Assert
      Assert.AreEqual(2, result);
    }
    [TestMethod]
    public void DimeCalculate_CalculatesDimes_Int()
    {
      //Arrange
      float round2 = .24f;
      Change pocketChange = new Change(round2);
      //Act
      float result = pocketChange.DimeCalculate(round2);
      //Assert
      Assert.AreEqual(2, result);
    }
    [TestMethod]
    public void NickelCalculate_CalculateNickels_Int()
    {
      //Arrange
      float round3 = .09f;
      Change pocketChange = new Change(round3);
      //Act
      float result = pocketChange.NickelCalculate(round3);
      //Assert
      Assert.AreEqual(1, result);
    }
  }
}