using Microsoft.EntityFrameworkCore;


namespace HotelListing.API.Data
{


    public class HotelListingDbContext : DbContext
    {
        public HotelListingDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Country> Countries { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasData(
                new Country
                {
                    Id = 1,
                    Name = "Jamaica",
                    ShortName = "JM",
                },
                new Country
                {
                    Id = 2,
                    Name = "Bahamas",
                    ShortName = "BS",
                },
                new Country
                {
                    Id = 3,
                    Name = "Brazil",
                    ShortName = "BR",
                },
                new Country
                {
                    Id = 4,
                    Name = "Cayman Island",
                    ShortName = "CI",
                }
            );
            modelBuilder.Entity<Hotel>().HasData(
                new Hotel
                {
                    Id= 1,
                    Name = "Sandals Resort",
                    Address = "Negril",
                    Rating = 4.5,
                    CountryId = 1
                },
                new Hotel
                {
                    Id = 2,
                    Name = "Comfort Suites",
                    Address = "George Town",
                    Rating = 4.3,
                    CountryId = 3
                },
                new Hotel
                {
                    Id = 3,
                    Name = "Grand Palladium",
                    Address = "Nassua",
                    Rating = 4,
                    CountryId = 2
                },
                new Hotel
                {
                    Id = 4,
                    Name = "Copacabana Pallace",
                    Address = "Copacabana",
                    Rating = 5,
                    CountryId = 4
                } 
            );
        }
    }

}