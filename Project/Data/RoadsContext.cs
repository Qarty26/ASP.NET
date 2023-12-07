using Microsoft.EntityFrameworkCore;
using Roads.Models;

namespace Roads.Data
{
    public class RoadsContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public RoadsContext(DbContextOptions<RoadsContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
