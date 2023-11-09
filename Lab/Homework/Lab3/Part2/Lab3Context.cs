using Microsoft.EntityFrameworkCore;

namespace Lab3_DB.Data
{
    public class Lab3Context : DbContext
    {

        public Lab3Context(DbContextOptions<Lab3Context> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
