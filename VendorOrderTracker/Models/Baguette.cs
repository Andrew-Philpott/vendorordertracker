namespace VendorOrderTracker.Models
{
  public class Baguette : Bread
  {
    public static int Count { get; private set; } = 0;

    public Baguette() { }
    public Baguette(string name) : base(name)
    {
      Count++;
    }
    ~Baguette()
    {
      Count--;
    }
  }
}