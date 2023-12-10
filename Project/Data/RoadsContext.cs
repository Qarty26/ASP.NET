using Microsoft.EntityFrameworkCore;
using Roads.Models;

namespace Roads.Data
{
    public class RoadsContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Hashtag> Hashtags { get; set; }
        public DbSet<Track> Tracks { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<TrackRelation> TrackRelations { get; set; }


        public RoadsContext(DbContextOptions<RoadsContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // one to many
            modelBuilder.Entity<User>()
                .HasMany(u => u.Cars)
                .WithOne(c => c.User);

            modelBuilder.Entity<Track>()
                .HasMany(h => h.Hashtags)
                .WithOne(t => t.Track);

            //many to many

            modelBuilder.Entity<TrackRelation>().HasKey(tr => new { tr.IdUser, tr.IdTrack });

            modelBuilder.Entity<TrackRelation>()
                .HasOne(tr => tr.Track)
                .WithMany(t => t.TrackRelations)
                .HasForeignKey(tr => tr.IdTrack);


            modelBuilder.Entity<TrackRelation>()
                .HasOne(tr => tr.User)
                .WithMany(t => t.TrackRelations)
                .HasForeignKey(tr => tr.IdUser);

            base.OnModelCreating(modelBuilder);
        }
    }
}
