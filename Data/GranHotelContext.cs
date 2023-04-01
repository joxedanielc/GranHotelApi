using Microsoft.EntityFrameworkCore;
using GranHotelApi.Models;

namespace GranHotelApi.Data
{
    public class GranHotelContext : DbContext
    {
        public GranHotelContext(DbContextOptions<GranHotelContext> options) : base(options) { }

        public DbSet<Huesped> Huespedes { get; set; }
        public DbSet<Habitacion> Habitaciones { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Huesped>()
                .HasOne(h => h.Habitacion)
                .WithMany(r => r.Huespedes)
                .HasForeignKey(h => h.HabitacionId);

            modelBuilder.Entity<Huesped>(entity =>
            {
                entity.HasKey(h => h.Id);
                entity.Property(h => h.Id).ValueGeneratedOnAdd(); 
                entity.Property(h => h.Salida).IsRequired(false);
            });

            modelBuilder.Entity<Habitacion>(entity =>
            {
                entity.HasKey(h => h.Id);
                entity.Property(h => h.Id).ValueGeneratedOnAdd(); 
            });

        }
    }
}
