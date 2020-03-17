using System.Collections.Generic;

namespace VendorOrderTracker.Models
{
  public class Vendor
  {
    // public Vendor()
    // {
    //   this.Orders = new HashSet<Order>();
    // }
    // private static string[] Breads = new string[] { "baguette", "challah", "brioche", "cornbread", "focaccia", "pumpernickel", "rye" };

    // private static string[] Pastries = new string[] { "eclair", "bearclaw", "baklava", "danish", "macaron", "strudel" };
    // private static List<Vendor> _vendors = new List<Vendor>();
    // private static int AssignId { get; set; }
    // private List<Order> _orders = new List<Order>();

    public Vendor()
    {
      this.Orders = new HashSet<Order>();
    }
    // [Key]
    public int VendorId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Type { get; set; }

    // public List<Order> Orders { get; set; }
    public virtual ICollection<Order> Orders { get; set; }
    // public int PriceForGood { get; }
    // public List<BakedGood> BakedGoods = new List<BakedGood>();



    // public Vendor(string name, string type, string description)
    // {
    //   Random random = new Random();
    //   PriceForGood = random.Next(3, 5);
    //   Id = AssignId++;
    //   Name = name;
    //   Description = description;
    //   switch (type)
    //   {
    //     case "bread":
    //       BakedGoods.Add(GenerateRandomBreadProduct());
    //       break;
    //     case "pastry":
    //       BakedGoods.Add(GenerateRandomPastryProduct());
    //       break;
    //     case "both":
    //       BakedGoods.Add(GenerateRandomBreadProduct());
    //       BakedGoods.Add(GenerateRandomPastryProduct());
    //       break;
    //     default:
    //       break;
    //   }
    //   _vendors.Add(this);
    // }

    // public Bread GenerateRandomBreadProduct()
    // {
    //   Random random = new Random();
    //   int randomNumber = random.Next(0, Breads.Length - 1);
    //   int randomPrice = random.Next(3, 4);
    //   Bread bread = new Bread(Breads[randomNumber], randomPrice);
    //   return bread;
    // }
    // public Pastry GenerateRandomPastryProduct()
    // {
    //   Random random = new Random();
    //   int randomNumber = random.Next(0, Pastries.Length - 1);
    //   int randomPrice = random.Next(1, 3);
    //   Pastry pastry = new Pastry(Pastries[randomNumber], randomPrice);
    //   return pastry;
    // }
    // public Order GetOrder(int id)
    // {
    //   return _orders.Find(x => x.Id == id);
    // }
    // public static List<Vendor> GetAllVendors()
    // {
    //   return _vendors;
    // }
    // public static Vendor Find(int id)
    // {
    //   return _vendors.Find(x => x.Id == id);
    // }
    // public List<Order> GetOrders()
    // {
    //   return _orders;
    // }
    // public void AddOrder(Order order)
    // {
    //   _orders.Add(order);
    // }

    // public void DeleteOrder(int id)
    // {
    //   _orders.Remove(_orders.Find(x => x.Id == id));
    // }
  }
}