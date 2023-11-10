using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace assignment.Models
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model15")
        {
        }

        public virtual DbSet<Attractions> Attractions { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Attractions>()
                .Property(e => e.CityName)
                .IsUnicode(false);

            modelBuilder.Entity<Attractions>()
                .Property(e => e.AttractionName)
                .IsUnicode(false);

            modelBuilder.Entity<Attractions>()
                .Property(e => e.Price)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Attractions>()
                .Property(e => e.ImageUrl)
                .IsUnicode(false);

            modelBuilder.Entity<Attractions>()
                .Property(e => e.Description)
                .IsUnicode(false);
        }
    }
}
