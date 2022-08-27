using Microsoft.EntityFrameworkCore;

namespace HotelListingAPI.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Country>().HasData(

                new Country
                {
                    Id = 1,
                    Name = "Germany",
                    ShortName = "GER"
                },
                new Country
                {
                     Id = 2,
                     Name = "Jamaica",
                     ShortName = "JAM"
                },
                new Country
                {
                    Id = 3,
                    Name = "Nigeria",
                    ShortName = "NIG"
                }
                );
            builder.Entity<Hotel>().HasData(

                new Hotel
                {
                    Id = 1,
                    Name = "Sandala Resort and Spa",
                    Address = "Nugril",
                    CountryId = 1,
                    Rating = 4.5
                },
                new Hotel
                {
                    Id = 2,
                    Name = "Grand Resort",
                    Address = "Natasha",
                    CountryId = 2,
                    Rating = 4
                },
                new Hotel
                {
                    Id = 3,
                    Name = "Eko Hotels",
                    Address = "Lagos",
                    CountryId = 3,
                    Rating = 6
                }
                );
        }
        public DbSet<Country> Countries { get; set; }

        public DbSet<Hotel> Hotels { get; set; }
    }
}
