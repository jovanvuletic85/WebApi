namespace WebApiVehicle.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class VehicleContext : DbContext
    {
        public VehicleContext()
            : base("DefaultConnection")
        {
        }

        public virtual DbSet<Brand> Brands { get; set; }
        public virtual DbSet<Model> Models { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Brand>()
                .HasMany(e => e.Models)
                .WithRequired(e => e.Brand)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Model>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);
        }
    }
}
