namespace VendorOrderTracker.Models
{
  public abstract class BakedGood
  {
    public string Name { get; set; }

    public BakedGood(string name)
    {
      Name = name;
    }
  }
}
