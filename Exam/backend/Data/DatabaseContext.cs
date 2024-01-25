using Exam.Models;
using Microsoft.EntityFrameworkCore;

namespace Exam.Data
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Test> Tests { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Participant> Participants { get; set; }
        public DbSet<EventParticipantRelation> EventParticipantRelations { get; set; }

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<EventParticipantRelation>()
                .HasKey(epr => new { epr.IdEvent, epr.IdParticipant });

            modelBuilder.Entity<EventParticipantRelation>()
                .HasOne(epr => epr.Event)
                .WithMany(e => e.EventParticipantRelations)
                .HasForeignKey(epr => epr.IdEvent);

            modelBuilder.Entity<EventParticipantRelation>()
                .HasOne(epr => epr.Participant)
                .WithMany(p => p.EventParticipantRelations)
                .HasForeignKey(epr => epr.IdParticipant);

            base.OnModelCreating(modelBuilder);
        }
    }
}
