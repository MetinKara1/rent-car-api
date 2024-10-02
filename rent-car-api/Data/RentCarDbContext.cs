using System;
using Microsoft.EntityFrameworkCore;
using rent_car_api.Models;
namespace rent_car_api.Data
{
	public class RentCarDbContext : DbContext
	{
		public RentCarDbContext(DbContextOptions<RentCarDbContext> options)
			: base(options)
		{
		}

		public DbSet<Car> Cars { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Filter> Filters { get; set; }
        public DbSet<FilterType> FilterTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>()
                .HasMany(c => c.Images)
                .WithOne(i => i.Car)
                .HasForeignKey(i => i.CarId);

            modelBuilder.Entity<Car>()
                .HasMany(c => c.Reviews) // Car ve Review arasındaki ilişkiyi tanımla
                .WithOne(r => r.Car)
                .HasForeignKey(r => r.CarId); // Review için dış anahtar

            modelBuilder.Entity<Filter>()
                .HasMany(c => c.FilterTypes) // Car ve Review arasındaki ilişkiyi tanımla
                .WithOne(r => r.Filter)
                .HasForeignKey(r => r.FilterId); // Review için dış anahtar
        }
    }
}

