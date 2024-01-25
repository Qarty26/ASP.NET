using Exam.Models;
using Microsoft.EntityFrameworkCore;

namespace Exam.Data
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Test> Tests { get; set; }

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
