namespace CoinCombo.Models
{
  public class Change
  {
    public float Banker {get; }
    
    public Change(float amount)
    {
      Banker = amount;
    }
  }
}