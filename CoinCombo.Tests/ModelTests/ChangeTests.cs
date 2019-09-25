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
  }
}