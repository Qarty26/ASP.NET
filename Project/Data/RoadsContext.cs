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
        public DbSet<UserTrackRelation> TrackRelations { get; set; }
        public DbSet<TrackHashtagRelation> TrackHashtagRelations { get; set; }
        public DbSet<TrackCarRelation> TrackCarRelations { get; set; }


        public RoadsContext(DbContextOptions<RoadsContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // one to many
            modelBuilder.Entity<User>()
                .HasMany(u => u.Cars)
                .WithOne(c => c.User);


            //many to many

            modelBuilder.Entity<UserTrackRelation>().HasKey(tr => new { tr.IdUser, tr.IdTrack });

            modelBuilder.Entity<UserTrackRelation>()
                .HasOne(tr => tr.Track)
                .WithMany(t => t.UserTrackRelations)
                .HasForeignKey(tr => tr.IdTrack);


            modelBuilder.Entity<UserTrackRelation>()
                .HasOne(tr => tr.User)
                .WithMany(u => u.UserTrackRelations)
                .HasForeignKey(tr => tr.IdUser);


            //----------------------------

            modelBuilder.Entity<TrackHashtagRelation>().HasKey(thr => new { thr.IdHashtag, thr.IdTrack });

            modelBuilder.Entity<TrackHashtagRelation>()
                .HasOne(thr => thr.Track)
                .WithMany(t => t.TrackHashtagRelations)
                .HasForeignKey(thr => thr.IdTrack);


            modelBuilder.Entity<TrackHashtagRelation>()
                .HasOne(thr => thr.Hashtag)
                .WithMany(h => h.TrackHashtagRelations)
                .HasForeignKey(thr => thr.IdHashtag);

            //-------------------------------

            modelBuilder.Entity<TrackCarRelation>().HasKey(tcr => new { tcr.IdCar, tcr.IdTrack });

            modelBuilder.Entity<TrackCarRelation>()
                .HasOne (tcr => tcr.Car)
                .WithMany(c => c.TrackCarRelations)
                .HasForeignKey (tcr => tcr.IdCar);

            modelBuilder.Entity<TrackCarRelation>()
                .HasOne(tcr => tcr.Track)
                .WithMany(t => t.TrackCarRelations)
                .HasForeignKey(tcr => tcr.IdTrack);

            base.OnModelCreating(modelBuilder);
        }
    }
}
