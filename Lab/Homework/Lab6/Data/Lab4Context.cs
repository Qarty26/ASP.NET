using Lab3_2.Models;
using Lab3_2.Models.Many_to_Many;
using Lab3_2.Models.One_to_Many;
using Lab3_2.Models.One_to_One;
using Microsoft.EntityFrameworkCore;

namespace Lab3_2.Data
{
    public class Lab4Context : DbContext
    {
        public DbSet<Student2> Students2 { get; set; }

        //One to many
        public DbSet<Model1> Models1 { get; set; }
        public DbSet<Model2> Models2 { get; set; }

        // One to One

        public DbSet<Model3> Models3 { get; set; }
        public DbSet<Model4> Models4 { get; set; }

        //many to many

        public DbSet<Model5> Models5 { get; set; }
        public DbSet<Model6> Models6 { get; set; }
        public DbSet<ModelsRelation> ModelsRelation { get; set; }

        public DbSet<User> Users { get; set; }  


        public Lab4Context(DbContextOptions<Lab4Context>options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //one to many
            modelBuilder.Entity<Model1>()
                    .HasMany(m1 => m1.Models2)
                    .WithOne(m2 => m2.Model1);

            /*            modelBuilder.Entity<Model2>()
                                .HasOne(m2 => m2.Model1)
                                .WithMany(m1 => m1.Models2);*/

            //one to one
            modelBuilder.Entity<Model3>()
                .HasOne(m3 => m3.Model4)
                .WithOne(m4 => m4.Model3)
                .HasForeignKey<Model4>(m6 => m6.Model3Id);


            //many to many

            modelBuilder.Entity<ModelsRelation>().HasKey(mr => new { mr.Model5Id, mr.Model6Id });

            modelBuilder.Entity<ModelsRelation>()
                .HasOne(mr => mr.Model5)
                .WithMany(m5 => m5.ModelsRelations)
                .HasForeignKey(mr => mr.Model5Id);

            modelBuilder.Entity<ModelsRelation>()
                .HasOne(mr => mr.Model6)
                .WithMany(m6 => m6.ModelsRelations)
                .HasForeignKey(mr => mr.Model6Id);

            base.OnModelCreating(modelBuilder);
        }

    }
}
