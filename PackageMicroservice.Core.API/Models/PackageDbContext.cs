using Microsoft.EntityFrameworkCore;

namespace PackageMicroservice.Core.API.Models
{
    public class PackageDbContext : DbContext
    {
        public PackageDbContext(DbContextOptions<PackageDbContext> options) : base(options) { }

        public DbSet<Package> Packages { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<SubPackage> SubPackages { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Room> Rooms { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Categories -> Packages relationship
            modelBuilder.Entity<Category>()
                .HasMany(c => c.Packages)
                .WithOne(p => p.Category)
                .HasForeignKey(p => p.CategoryId);

            // Packages -> SubPackages relationship
            modelBuilder.Entity<Package>()
                .HasMany(p => p.SubPackages)
                .WithOne(sp => sp.Package)
                .HasForeignKey(sp => sp.PackageId);

            modelBuilder.Entity<SubPackage>(entity =>
            {
                entity.Property(e => e.PricePerAdult)
                    .HasPrecision(18, 2);
            });

            modelBuilder.Entity<City>()
                .HasMany(p => p.Hotels)
                .WithOne(p => p.City)
                .HasForeignKey(p => p.CityId);
         
            modelBuilder.Entity<Hotel>()
                .HasMany(p => p.Rooms)
                .WithOne(p => p.Hotel)
                .HasForeignKey(p => p.HotelId);

            modelBuilder.Entity<Room>(entity =>
            {
                entity.Property(e => e.PricePerNight)
                    .HasPrecision(18, 2);
            });

            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, CategoryName = "Adventure" },
                new Category { CategoryId = 2, CategoryName = "Nature" },
                new Category { CategoryId = 3, CategoryName = "Religious" },
                new Category { CategoryId = 4, CategoryName = "Village" },
                new Category { CategoryId = 5, CategoryName = "Wildlife" }
            );

            modelBuilder.Entity<Package>().HasData(
                // Domestic Packages
                new Package { IsInternationalPackage = false, PackageId = 1, PackageName = "Himalayan Trek", CategoryId = 1, Description = "Experience thrilling treks in the Himalayan region." },
                new Package { IsInternationalPackage = false, PackageId = 2, PackageName = "Goa Beach Bliss", CategoryId = 2, Description = "Relax on the serene beaches of Goa." },
                new Package { IsInternationalPackage = false, PackageId = 3, PackageName = "Spiritual Varanasi", CategoryId = 3, Description = "Discover the spiritual aura of Varanasi." },
                new Package { IsInternationalPackage = false, PackageId = 4, PackageName = "Rural Rajasthan", CategoryId = 4, Description = "Explore the vibrant rural culture of Rajasthan." },
                new Package { IsInternationalPackage = false, PackageId = 5, PackageName = "Kaziranga Safari", CategoryId = 5, Description = "Witness the majestic one-horned rhinos in their natural habitat." },

                // International Packages
                new Package { IsInternationalPackage = true, PackageId = 6, PackageName = "Swiss Alps Adventure", CategoryId = 1, Description = "Explore the snow-capped mountains of the Swiss Alps." },
                new Package { IsInternationalPackage = true, PackageId = 7, PackageName = "Maldives Paradise", CategoryId = 2, Description = "Unwind in the tropical beauty of Maldives." },
                new Package { IsInternationalPackage = true, PackageId = 8, PackageName = "Holy Jerusalem", CategoryId = 3, Description = "Walk through the sacred landmarks of Jerusalem." },
                new Package { IsInternationalPackage = true, PackageId = 9, PackageName = "Japanese Countryside", CategoryId = 4, Description = "Immerse yourself in the tranquil Japanese villages." },
                new Package { IsInternationalPackage = true, PackageId = 10, PackageName = "Amazon Rainforest", CategoryId = 5, Description = "Discover the incredible biodiversity of the Amazon." }
            );

            modelBuilder.Entity<SubPackage>().HasData(
                // SubPackages for Himalayan Trek
                new SubPackage { IsAccomodationAvailable = true, SubPackageId = 1, PackageId = 1, PlaceToVisit = "Manali", Description = "A serene valley with stunning views.", Days = 5, Nights = 4, PricePerAdult = 1200.00m },
                new SubPackage { IsAccomodationAvailable = true, SubPackageId = 2, PackageId = 1, PlaceToVisit = "Rohtang Pass", Description = "A high-altitude pass with breathtaking vistas.", Days = 3, Nights = 2, PricePerAdult = 1000.00m },

                // SubPackages for Goa Beach Bliss
                new SubPackage { IsAccomodationAvailable = true, SubPackageId = 3, PackageId = 2, PlaceToVisit = "Calangute Beach", Description = "A bustling beach with vibrant nightlife.", Days = 4, Nights = 3, PricePerAdult = 800.00m },
                new SubPackage { IsAccomodationAvailable = true, SubPackageId = 4, PackageId = 2, PlaceToVisit = "Dudhsagar Falls", Description = "Spectacular waterfalls surrounded by lush greenery.", Days = 2, Nights = 1, PricePerAdult = 700.00m },

                // SubPackages for Spiritual Varanasi
                new SubPackage { IsAccomodationAvailable = true, SubPackageId = 5, PackageId = 3, PlaceToVisit = "Kashi Vishwanath Temple", Description = "A sacred temple dedicated to Lord Shiva.", Days = 3, Nights = 2, PricePerAdult = 500.00m },
                new SubPackage { IsAccomodationAvailable = true, SubPackageId = 6, PackageId = 3, PlaceToVisit = "Ganga Ghats", Description = "Experience the spiritual Ganga Aarti.", Days = 2, Nights = 1, PricePerAdult = 400.00m },

                // SubPackages for Rural Rajasthan
                new SubPackage { IsAccomodationAvailable = true, SubPackageId = 7, PackageId = 4, PlaceToVisit = "Pushkar", Description = "Explore the famous Pushkar Camel Fair.", Days = 3, Nights = 2, PricePerAdult = 1000.00m },
                new SubPackage { IsAccomodationAvailable = true, SubPackageId = 8, PackageId = 4, PlaceToVisit = "Jodhpur Villages", Description = "Experience traditional Rajasthani hospitality.", Days = 4, Nights = 3, PricePerAdult = 1200.00m },

                // SubPackages for Kaziranga Safari
                new SubPackage { IsAccomodationAvailable = true, SubPackageId = 9, PackageId = 5, PlaceToVisit = "Kaziranga National Park", Description = "A UNESCO World Heritage site.", Days = 5, Nights = 4, PricePerAdult = 2000.00m },

                // SubPackages for Swiss Alps Adventure
                new SubPackage { IsAccomodationAvailable = true, SubPackageId = 10, PackageId = 6, PlaceToVisit = "Interlaken", Description = "A picturesque town surrounded by mountains.", Days = 4, Nights = 3, PricePerAdult = 3000.00m },
                new SubPackage { IsAccomodationAvailable = true, SubPackageId = 11, PackageId = 6, PlaceToVisit = "Zermatt", Description = "Home to the iconic Matterhorn peak.", Days = 5, Nights = 4, PricePerAdult = 3500.00m },

                // SubPackages for Maldives Paradise
                new SubPackage { IsAccomodationAvailable = true, SubPackageId = 12, PackageId = 7, PlaceToVisit = "Male City", Description = "Explore the capital city of Maldives.", Days = 3, Nights = 2, PricePerAdult = 2500.00m },
                new SubPackage { IsAccomodationAvailable = true, SubPackageId = 13, PackageId = 7, PlaceToVisit = "Resort Islands", Description = "Relax in luxurious overwater villas.", Days = 4, Nights = 3, PricePerAdult = 4000.00m },

                // SubPackages for Holy Jerusalem
                new SubPackage { IsAccomodationAvailable = true, SubPackageId = 14, PackageId = 8, PlaceToVisit = "Old City", Description = "Walk through the historic landmarks.", Days = 4, Nights = 3, PricePerAdult = 1800.00m },

                // SubPackages for Japanese Countryside
                new SubPackage { IsAccomodationAvailable = true, SubPackageId = 15, PackageId = 9, PlaceToVisit = "Shirakawa-go", Description = "A traditional Japanese village with iconic houses.", Days = 3, Nights = 2, PricePerAdult = 2200.00m },
                new SubPackage { IsAccomodationAvailable = true, SubPackageId = 16, PackageId = 9, PlaceToVisit = "Hakone", Description = "Known for hot springs and Mount Fuji views.", Days = 4, Nights = 3, PricePerAdult = 2400.00m },

                // SubPackages for Amazon Rainforest
                new SubPackage { IsAccomodationAvailable = true, SubPackageId = 17, PackageId = 10, PlaceToVisit = "Manaus", Description = "Gateway to the Amazon jungle.", Days = 5, Nights = 4, PricePerAdult = 2700.00m },
                new SubPackage { IsAccomodationAvailable = true, SubPackageId = 18, PackageId = 10, PlaceToVisit = "Amazon River Cruise", Description = "Discover the diverse wildlife of the Amazon.", Days = 6, Nights = 5, PricePerAdult = 3000.00m }
            );

            modelBuilder.Entity<PackageImage>().HasData(
                new PackageImage { Id = 1, PackageId = 1, ImageUrl = "images/himalayan_trek.jpg" },
                new PackageImage { Id = 2, PackageId = 1, ImageUrl = "images/himalayan_trek1.jpg" },
                new PackageImage { Id = 3, PackageId = 1, ImageUrl = "images/himalayan_trek2.jpg" },
                new PackageImage { Id = 4, PackageId = 1, ImageUrl = "images/himalayan_trek3.jpg" },
                new PackageImage { Id = 5, PackageId = 2, ImageUrl = "images/goa_beach.jpg" },
                new PackageImage { Id = 6, PackageId = 2, ImageUrl = "images/goa_beach1.jpg" },
                new PackageImage { Id = 7, PackageId = 2, ImageUrl = "images/goa_beach2.jpg" },
                new PackageImage { Id = 8, PackageId = 3, ImageUrl = "images/varanasi.jpg" },
                new PackageImage { Id = 9, PackageId = 3, ImageUrl = "images/varanasi1.jpg" },
                new PackageImage { Id = 10, PackageId = 3, ImageUrl = "images/varanasi2.jpg" },
                new PackageImage { Id = 11, PackageId = 4, ImageUrl = "images/rural_rajasthan.jpg" },
                new PackageImage { Id = 12, PackageId = 4, ImageUrl = "images/rural_rajasthan1.jpg" },
                new PackageImage { Id = 13, PackageId = 4, ImageUrl = "images/rural_rajasthan2.jpg" },
                new PackageImage { Id = 14, PackageId = 5, ImageUrl = "images/kaziranga_safari.jpg" },
                new PackageImage { Id = 15, PackageId = 5, ImageUrl = "images/kaziranga_safari1.jpg" },
                new PackageImage { Id = 16, PackageId = 5, ImageUrl = "images/kaziranga_safari2.jpg" },
                new PackageImage { Id = 17, PackageId = 6, ImageUrl = "images/swiss_alps.jpg" },
                new PackageImage { Id = 18, PackageId = 6, ImageUrl = "images/swiss_alps1.jpg" },
                new PackageImage { Id = 19, PackageId = 6, ImageUrl = "images/swiss_alps2.jpg" },
                new PackageImage { Id = 20, PackageId = 7, ImageUrl = "images/maldives.jpg" },
                new PackageImage { Id = 21, PackageId = 8, ImageUrl = "images/jerusalem.jpg" },
                new PackageImage { Id = 22, PackageId = 9, ImageUrl = "images/japanese_countryside.jpg" },
                new PackageImage { Id = 23, PackageId = 10, ImageUrl = "images/amazon.jpg" },
                //Left to add
                new PackageImage { Id = 24, PackageId = 7, ImageUrl = "images/maldives1.jpg" },
                new PackageImage { Id = 25, PackageId = 7, ImageUrl = "images/maldives2.jpg" },
                new PackageImage { Id = 26, PackageId = 8, ImageUrl = "images/jerusalem1.jpg" },
                new PackageImage { Id = 27, PackageId = 8, ImageUrl = "images/jerusalem2.jpg" },
                new PackageImage { Id = 28, PackageId = 9, ImageUrl = "images/japanese_countryside1.jpg" },
                new PackageImage { Id = 29, PackageId = 9, ImageUrl = "images/japanese_countryside2.jpg" },
                new PackageImage { Id = 30, PackageId = 10, ImageUrl = "images/amazon1.jpg" },
                new PackageImage { Id = 31, PackageId = 10, ImageUrl = "images/amazon2.jpg" }
            );

            modelBuilder.Entity<City>().HasData(
                new City { CityId = 1, Name = "Manali" },
                new City { CityId = 2, Name = "Goa" },
                new City { CityId = 3, Name = "Varanasi" },
                new City { CityId = 4, Name = "Rajasthan" },
                new City { CityId = 5, Name = "Kaziranga" },
                new City { CityId = 6, Name = "Swiss Alps" },
                new City { CityId = 7, Name = "Maldives" },
                new City { CityId = 8, Name = "Jerusalem" },
                new City { CityId = 9, Name = "Japanese Countryside" },
                new City { CityId = 10, Name = "Amazon Rainforest" }
            );

            modelBuilder.Entity<Hotel>().HasData(
                new Hotel { HotelId = 1, Name = "Hotel Manali Inn", Type = "5-star", CityId = 1 },
                new Hotel { HotelId = 2, Name = "Manali Budget Stay", Type = "2-star", CityId = 1 },
                new Hotel { HotelId = 3, Name = "Snowy Peaks Resort", Type = "4-star", CityId = 1 },
                new Hotel { HotelId = 4, Name = "Mountain View Lodge", Type = "3-star", CityId = 1 },
                new Hotel { HotelId = 5, Name = "Hotel Goa Inn", Type = "5-star", CityId = 2 },
                new Hotel { HotelId = 6, Name = "Goa Budget Stay", Type = "2-star", CityId = 2 },
                new Hotel { HotelId = 7, Name = "Snowy Peaks ResortGoa", Type = "4-star", CityId = 2 },
                new Hotel { HotelId = 8, Name = "Mountain View Lodge Goa", Type = "3-star", CityId = 2 }
            );


            modelBuilder.Entity<Room>().HasData(
                // Rooms for Hotel Manali Inn (5-Star)
                new Room { RoomId = 1, RoomType = "Single", PricePerNight = 2000.00m, HotelId = 1 },
                new Room { RoomId = 2, RoomType = "Double", PricePerNight = 3000.00m, HotelId = 1 },
                new Room { RoomId = 3, RoomType = "Deluxe", PricePerNight = 4000.00m, HotelId = 1 },
                new Room { RoomId = 4, RoomType = "Suite", PricePerNight = 5000.00m, HotelId = 1 },

                // Rooms for Manali Budget Stay (2-Star)
                new Room { RoomId = 5, RoomType = "Single", PricePerNight = 800.00m, HotelId = 2 },
                new Room { RoomId = 6, RoomType = "Double", PricePerNight = 1200.00m, HotelId = 2 },
                new Room { RoomId = 7, RoomType = "Deluxe", PricePerNight = 1500.00m, HotelId = 2 },
                new Room { RoomId = 8, RoomType = "Suite", PricePerNight = 2000.00m, HotelId = 2 },

                // Rooms for Snowy Peaks Resort (3-Star)
                new Room { RoomId = 9, RoomType = "Single", PricePerNight = 1200.00m, HotelId = 3 },
                new Room { RoomId = 10, RoomType = "Double", PricePerNight = 1800.00m, HotelId = 3 },
                new Room { RoomId = 11, RoomType = "Deluxe", PricePerNight = 2200.00m, HotelId = 3 },
                new Room { RoomId = 12, RoomType = "Suite", PricePerNight = 2500.00m, HotelId = 3 },

                // Rooms for Mountain View Lodge (4-Star)
                new Room { RoomId = 13, RoomType = "Single", PricePerNight = 1500.00m, HotelId = 4 },
                new Room { RoomId = 14, RoomType = "Double", PricePerNight = 2200.00m, HotelId = 4 },
                new Room { RoomId = 15, RoomType = "Deluxe", PricePerNight = 2800.00m, HotelId = 4 },
                new Room { RoomId = 16, RoomType = "Suite", PricePerNight = 3500.00m, HotelId = 4 },

                // Rooms for Hotel Manali Inn (5-Star)
                new Room { RoomId = 17, RoomType = "Single", PricePerNight = 2000.00m, HotelId = 5 },
                new Room { RoomId = 18, RoomType = "Double", PricePerNight = 3000.00m, HotelId = 5 },
                new Room { RoomId = 19, RoomType = "Deluxe", PricePerNight = 4000.00m, HotelId = 5 },
                new Room { RoomId = 20, RoomType = "Suite", PricePerNight = 5000.00m, HotelId = 5 },

                // Rooms for Manali Budget Stay (2-Star)
                new Room { RoomId = 21, RoomType = "Single", PricePerNight = 800.00m, HotelId = 6 },
                new Room { RoomId = 22, RoomType = "Double", PricePerNight = 1200.00m, HotelId = 6 },
                new Room { RoomId = 23, RoomType = "Deluxe", PricePerNight = 1500.00m, HotelId = 6 },
                new Room { RoomId = 24, RoomType = "Suite", PricePerNight = 2000.00m, HotelId = 6 },

                // Rooms for Snowy Peaks Resort (3-Star)
                new Room { RoomId = 25, RoomType = "Single", PricePerNight = 1200.00m, HotelId = 7 },
                new Room { RoomId = 26, RoomType = "Double", PricePerNight = 1800.00m, HotelId = 7 },
                new Room { RoomId = 27, RoomType = "Deluxe", PricePerNight = 2200.00m, HotelId = 7 },
                new Room { RoomId = 28, RoomType = "Suite", PricePerNight = 2500.00m, HotelId = 7 },

                // Rooms for Mountain View Lodge (4-Star)
                new Room { RoomId = 29, RoomType = "Single", PricePerNight = 1500.00m, HotelId = 8 },
                new Room { RoomId = 30, RoomType = "Double", PricePerNight = 2200.00m, HotelId = 8 },
                new Room { RoomId = 31, RoomType = "Deluxe", PricePerNight = 2800.00m, HotelId = 8 },
                new Room { RoomId = 32, RoomType = "Suite", PricePerNight = 3500.00m, HotelId = 8 }
            );

        }
    }
}
