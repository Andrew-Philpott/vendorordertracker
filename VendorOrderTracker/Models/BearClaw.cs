namespace VendorOrderTracker.Models
{
  public class BearClaw : Pastry
  {
    public static int Count { get; private set; } = 0;

    public BearClaw() { }
    public BearClaw(string name) : base(name)
    {
      Count++;
    }

    ~BearClaw()
    {
      Count--;
    }
  }
}