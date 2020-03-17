using Microsoft.EntityFrameworkCore;

namespace VendorOrderTracker.Models
{
  public class TrackerContext : DbContext
  {
    // public virtual DbSet<Category> Categories { get; set; }
    // public DbSet<Item> Items { get; set; }

    public TrackerContext(DbContextOptions options) : base(options) { }
  }
}