using Microsoft.EntityFrameworkCore;
using Roads.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;


namespace Roads.Data
{
    public class RoadsContext : IdentityDbContext<User, IdentityRole<Guid>, Guid>
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Hashtag> Hashtags { get; set; }
        public DbSet<Track> Tracks { get; set; }
        public DbSet<Map> Maps { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<UserTrackCarRelation> UserTrackCarRelations { get; set; }
        public DbSet<TrackHashtagRelation> TrackHashtagRelations { get; set; }



        public RoadsContext(DbContextOptions<RoadsContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // one to one

            modelBuilder.Entity<Track>()
                .HasOne(m => m.Map)
                .WithOne(t => t.Track)
                .HasForeignKey<Map>(a => a.IdTrack)
                .OnDelete(DeleteBehavior.Cascade);


            // one to many

            modelBuilder.Entity<User>()
                .HasMany(u => u.Cars)
                .WithOne(c => c.User)
                .HasForeignKey(a => a.IdUser)
                .OnDelete(DeleteBehavior.Cascade);


            //many to many
            modelBuilder.Entity<UserTrackCarRelation>().HasAlternateKey(tr => new { tr.IdUser, tr.IdTrack, tr.IdCar });

            modelBuilder.Entity<UserTrackCarRelation>()
                .HasOne(tr => tr.Track)
                .WithMany(t => t.UserTrackCarRelations)
                .HasForeignKey(tr => tr.IdTrack)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<UserTrackCarRelation>()
                .HasOne(tr => tr.User)
                .WithMany(u => u.UserTrackCarRelations)
                .HasForeignKey(tr => tr.IdUser)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<UserTrackCarRelation>()
                .HasOne(tr => tr.Car)
                .WithMany(u => u.UserTrackCarRelations)
                .HasForeignKey(tr => tr.IdCar)
                .OnDelete(DeleteBehavior.NoAction);


            //----------------------------

            modelBuilder.Entity<TrackHashtagRelation>().HasKey(thr => new { thr.IdHashtag, thr.IdTrack });

            modelBuilder.Entity<TrackHashtagRelation>()
                .HasOne(thr => thr.Track)
                .WithMany(t => t.TrackHashtagRelations)
                .HasForeignKey(thr => thr.IdTrack)
                .OnDelete(DeleteBehavior.Cascade);


            modelBuilder.Entity<TrackHashtagRelation>()
                .HasOne(thr => thr.Hashtag)
                .WithMany(h => h.TrackHashtagRelations)
                .HasForeignKey(thr => thr.IdHashtag)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}