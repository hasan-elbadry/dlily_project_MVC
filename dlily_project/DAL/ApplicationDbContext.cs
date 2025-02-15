
using dlily_project.DAL.Models.Offers;
using dlily_project.DAL.Models.Reviews;
using dlily_project.DAL.Models.Users;
using System;

namespace dlily_project.DAL
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        private static byte[] GetImageBytes(string imagePath)
        {
            return File.Exists(imagePath) ? File.ReadAllBytes(imagePath) : Array.Empty<byte>();
        }
    
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ReviewCompany>().HasKey(x => new {x.CompanyId,x.TouristId });
            modelBuilder.Entity<ReviewHotel>().HasKey(x => new { x.HotelId, x.TouristId });

            modelBuilder.Entity<TouristPlaces>().HasData(
    new TouristPlaces
    {
        Id = 4,
        Name = "Great Pyramids of Giza",
        Description = "Ancient pyramids and the last surviving Wonder of the Ancient World",
        Article = "The Giza pyramid complex includes the Great Pyramid of Giza...",
        Location = "https://www.google.com/maps/place/The+Great+Pyramid+of+Giza/@29.9792345,31.1342019,15z/",
        OpenAt = new TimeSpan(8, 0, 0),
        CloseAt = new TimeSpan(17, 0, 0),
        Rating = 5,
        Category = "Ancient Monument",
        EntryFee = 200.00,
        ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/a/af/Giza_pyramid_complex_%28edited%29.jpg"
    },
    new TouristPlaces
    {
        Id = 5,
        Name = "Luxor Temple",
        Description = "Massive Ancient Egyptian temple complex on the east bank of the Nile",
        Article = "Built approximately 1400 BCE, this temple was dedicated to the Theban Triad...",
        Location = "https://www.google.com/maps/place/Luxor+Temple/@25.6996147,32.6366406,17z/",
        OpenAt = new TimeSpan(6, 0, 0),
        CloseAt = new TimeSpan(22, 0, 0),
        Rating = 5,
        Category = "Archaeological Site",
        EntryFee = 160.00,
        ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/4/49/Luxor_Temple_18.jpg"
    },
    new TouristPlaces
    {
        Id = 6,
        Name = "Abu Simbel Temples",
        Description = "Twin rock-cut temples dating back to the 13th century BCE",
        Article = "Commissioned by Pharaoh Ramesses II to commemorate his victory...",
        Location = "https://www.google.com/maps/place/Abu+Simbel+Temples/@22.3369232,31.6254713,17z/",
        OpenAt = new TimeSpan(5, 0, 0),
        CloseAt = new TimeSpan(18, 0, 0),
        Rating = 5,
        Category = "Historical Site",
        EntryFee = 240.00,
        ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/8/8e/Abu_Simbel_Temple_%288488942077%29.jpg"
    },
    new TouristPlaces
    {
        Id = 7,
        Name = "The Egyptian Museum",
        Description = "Home to the world's most extensive collection of Pharaonic antiquities",
        Article = "Contains over 120,000 items including the treasures of Tutankhamun...",
        Location = "https://www.google.com/maps/place/The+Egyptian+Museum/@30.0478085,31.2335643,17z/",
        OpenAt = new TimeSpan(9, 0, 0),
        CloseAt = new TimeSpan(17, 0, 0),
        Rating = 5,
        Category = "Museum",
        EntryFee = 300.00,
        ImageUrl = "https://live.staticflickr.com/65535/53609865504_1c1a8d7c0e_b.jpg"
    },
    new TouristPlaces
    {
        Id = 8,
        Name = "Valley of the Kings",
        Description = "Ancient burial ground for Egyptian royalty",
        Article = "Contains 63 magnificent royal tombs from the New Kingdom period...",
        Location = "https://www.google.com/maps/place/Valley+of+the+Kings/@25.7401865,32.6015273,17z/",
        OpenAt = new TimeSpan(6, 0, 0),
        CloseAt = new TimeSpan(17, 0, 0),
        Rating = 5,
        Category = "Archaeological Site",
        EntryFee = 240.00,
        ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/4/4a/Valley_of_the_Kings_Overview.jpg"
    }
);

            modelBuilder.Entity<Tourgide>().HasData(
                new Tourgide
                {
                    Id = 1,
                    Name = "Ahmed Aly Ahmed",
                    Gender = Gender.Male,
                    Phone = "01019273234",
                    Email = "ahmed.aly@gmail.com",
                    Address = "10 Karnak Temple Street, Luxor, Luxor Governorate",
                    Rating = 3,
                    Description = "Italian-speaking guide",
                    Price = 55.0,
                    SpokenLanguage = "Italian",
                    ProfilePicture = GetImageBytes("Images/AhmedAlyAhmed.jpeg")
                },
                new Tourgide
                {
                    Id = 2,
                    Name = "Ahmed Ramadan",
                    Gender = Gender.Male,
                    Phone = "01065502465",
                    Email = "ahmed.ramadan@gmail.com",
                    Address = "30 Zamalek Street, Cairo, Cairo Governorate",
                    Rating = 3,
                    Description = "German-speaking guide",
                    Price = 52.0,
                    SpokenLanguage = "German",
                    ProfilePicture = GetImageBytes("Images/AhmedRamadan.jpeg")
                },
                new Tourgide
                {
                    Id = 3,
                    Name = "Amr Fouad",
                    Gender = Gender.Male,
                    Phone = "01146146691",
                    Email = "amr.fouad@gmail.com",
                    Address = "25 Sharia Al Muizz Li-Din Allah, Cairo, Cairo Governorate",
                    Rating = 5,
                    Description = "English-speaking tour guide",
                    Price = 42.0,
                    SpokenLanguage = "English",
                    ProfilePicture = GetImageBytes("Images/AmrFouad.jpeg")
                },
                new Tourgide
                {
                    Id = 4,
                    Name = "Ibrahim Ghalwash",
                    Gender = Gender.Male,
                    Phone = "01033823595",
                    Email = "ibrahim.ghalwash@gmail.com",
                    Address = "18 Luxor Temple Street, Luxor, Luxor Governorate",
                    Rating = 4,
                    Description = "German-speaking guide",
                    Price = 50.0,
                    SpokenLanguage = "German",
                    ProfilePicture = GetImageBytes("Images/IbrahimGhalwash.jpeg")
                },
                new Tourgide
                {
                    Id = 5,
                    Name = "Mariam Ali",
                    Gender = Gender.Female,
                    Phone = "01065502465",
                    Email = "mariam.ali@gmail.com",
                    Address = "7 Philae Temple Road, Aswan, Aswan Governorate",
                    Rating = 5,
                    Description = "German-speaking guide",
                    Price = 48.0,
                    SpokenLanguage = "German",
                    ProfilePicture = GetImageBytes("Images/MariamAli.jpeg")
                },
                new Tourgide
                {
                    Id = 6,
                    Name = "Ahmed",
                    Gender = Gender.Male,
                    Phone = "01104682219",
                    Email = "ahmed.guide@gmail.com",
                    Address = "20 Al Azhar Street, Islamic Cairo, Cairo Governorate",
                    Rating = 3,
                    Description = "Italian-speaking guide",
                    Price = 55.0,
                    SpokenLanguage = "Italian",
                    ProfilePicture = GetImageBytes("Images/SignorAhmedElAlily.jpeg")
                },
                new Tourgide
                {
                    Id = 7,
                    Name = "Ebram Melles",
                    Gender = Gender.Male,
                    Phone = "01220801758",
                    Email = "ebram_melles.guide@gmail.com",
                    Address = "20 Al Azhar Street, Islamic Cairo, Cairo Governorate",
                    Rating = 3,
                    Description = "Speaking English and Japanese",
                    Price = 55.0,
                    SpokenLanguage = "English",
                    ProfilePicture = GetImageBytes("Images/EbramMelles.jpeg")
                },
                new Tourgide
                {
                    Id = 8,
                    Name = "Mohamed Gomaa",
                    Gender = Gender.Male,
                    Phone = "01022510710",
                    Email = "mohamed.gomaa@gmail.com",
                    Address = "12 Corniche El Nile Street, Aswan, Aswan Governorate",
                    Rating = 5,
                    Description = "English & Russian-speaking guide",
                    Price = 50.0,
                    SpokenLanguage = "English, Russian",
                    ProfilePicture = GetImageBytes("Images/MohamedFriday.jpeg")
                }
            );


            modelBuilder.Entity<Hotel>().HasData(
    new Hotel
    {
        Id = 1,
        Name = "Luxury Paradise Resort",
        Rating = 5,
        Location = "Maldives",
        Services = "Spa,fas fa-spa;Pool,fas fa-swimming-pool;Gym,fas fa-dumbbell;Free Wi-Fi,fas fa-wifi;Restaurant,fas fa-utensils",
        Description = "A luxurious resort located in the heart of the Maldives, offering breathtaking views and world-class amenities.",
        HomeImage = "https://images.unsplash.com/photo-1618773928121-c32242e63f39",
        OtherImages = "https://images.unsplash.com/photo-1564501049412-61c2a3083791,https://images.unsplash.com/photo-1566073771259-6a8506099945,https://images.unsplash.com/photo-1618773928121-c32242e63f39,https://images.unsplash.com/photo-1564501049412-61c2a3083791,https://images.unsplash.com/photo-1566073771259-6a8506099945",
        Price = 450.00,
    },
    new Hotel
    {
        Id = 2,
        Name = "Sunset Beach Hotel",
        Rating = 4,
        Location = "Bali, Indonesia",
        Services = "Beach Access,fas fa-umbrella-beach;Pool,fas fa-swimming-pool;Bar,fas fa-cocktail;Free Wi-Fi,fas fa-wifi;Restaurant,fas fa-utensils",
        Description = "A serene beachfront hotel with stunning sunset views and a relaxing atmosphere.",
        HomeImage = "https://images.unsplash.com/photo-1549989476-69a92fa57c36",
        OtherImages = "https://images.unsplash.com/photo-1549989476-69a92fa57c36,https://images.unsplash.com/photo-1549989476-69a92fa57c36,https://images.unsplash.com/photo-1549989476-69a92fa57c36,https://images.unsplash.com/photo-1549989476-69a92fa57c36,https://images.unsplash.com/photo-1549989476-69a92fa57c36",
        Price = 350.00
    },
    new Hotel
    {
        Id = 3,
        Name = "Mountain View Lodge",
        Rating = 4,
        Location = "Swiss Alps",
        Services = "Skiing,fas fa-skiing;Spa,fas fa-spa;Restaurant,fas fa-utensils;Free Wi-Fi,fas fa-wifi",
        Description = "A cozy lodge nestled in the Swiss Alps, perfect for winter sports and relaxation.",
        HomeImage = "https://images.unsplash.com/photo-1519681393784-d120267933ba",
        OtherImages = "https://images.unsplash.com/photo-1519681393784-d120267933ba,https://images.unsplash.com/photo-1519681393784-d120267933ba,https://images.unsplash.com/photo-1519681393784-d120267933ba,https://images.unsplash.com/photo-1519681393784-d120267933ba,https://images.unsplash.com/photo-1519681393784-d120267933ba",
        Price = 300.00
    },
    new Hotel
    {
        Id = 4,
        Name = "City Central Hotel",
        Rating = 3,
        Location = "New York, USA",
        Services = "Gym,fas fa-dumbbell;Free Wi-Fi,fas fa-wifi;Restaurant,fas fa-utensils;Conference Rooms,fas fa-users",
        Description = "A modern hotel located in the heart of New York City, ideal for business and leisure travelers.",
        HomeImage = "https://images.unsplash.com/photo-1499856871958-5b9627545d1a",
        OtherImages = "https://images.unsplash.com/photo-1499856871958-5b9627545d1a,https://images.unsplash.com/photo-1499856871958-5b9627545d1a,https://images.unsplash.com/photo-1499856871958-5b9627545d1a,https://images.unsplash.com/photo-1499856871958-5b9627545d1a,https://images.unsplash.com/photo-1499856871958-5b9627545d1a",
        Price = 250.00
    },
    new Hotel
    {
        Id = 5,
        Name = "Desert Oasis Resort",
        Rating = 5,
        Location = "Dubai, UAE",
        Services = "Pool,fas fa-swimming-pool;Spa,fas fa-spa;Free Wi-Fi,fas fa-wifi;Restaurant,fas fa-utensils;Camel Riding,fas fa-horse",
        Description = "A luxurious resort in the middle of the desert, offering a unique blend of tradition and modernity.",
        HomeImage = "https://images.unsplash.com/photo-1518684079-3c830dcef090",
        OtherImages = "https://images.unsplash.com/photo-1518684079-3c830dcef090,https://images.unsplash.com/photo-1518684079-3c830dcef090,https://images.unsplash.com/photo-1518684079-3c830dcef090,https://images.unsplash.com/photo-1518684079-3c830dcef090,https://images.unsplash.com/photo-1518684079-3c830dcef090",
        Price = 500.00
    }
);

            var rooms = new List<Room>
{
    new Room { Id = 1, RoomNumber = "Room 1", Images = "https://images.unsplash.com/photo-1618773928121-c32242e63f39,https://images.unsplash.com/photo-1564501049412-61c2a3083791,https://images.unsplash.com/photo-1566073771259-6a8506099945", OfferPresentage = 10, RoomType = "One Bedroom Apartment", BedType = "1 king bed", Days = 5, Price = 10000, OldPrice = 12000, Services = "Free Wifi,fas fa-wifi;Air Conditioning,fas fa-snowflake;Private Bathroom,fas fa-bath;Minibar,fas fa-wine-glass-alt;Flat-screen TV,fas fa-tv", RoomSize = "50 m²", RoomDescription = "A spacious and comfortable room with modern amenities.", View = "Sea view", Facilities = "Balcony;Air conditioning;Private bathroom;Flat-screen TV;Minibar;Free Wifi", HotelId = 1 },
    new Room { Id = 2, RoomNumber = "Room 2", Images = "https://images.unsplash.com/photo-1549989476-69a92fa57c36,https://images.unsplash.com/photo-1549989476-69a92fa57c36,https://images.unsplash.com/photo-1549989476-69a92fa57c36", OfferPresentage = 15, RoomType = "Two-Bedroom Apartment", BedType = "2 twin beds", Days = 7, Price = 15000, OldPrice = 18000, Services = "Free Wifi,fas fa-wifi;Kitchenette,fas fa-utensils;Jacuzzi,fas fa-hot-tub;Safe,fas fa-lock;Work desk,fas fa-laptop", RoomSize = "80 m²", RoomDescription = "A luxurious apartment with a stunning view and excellent facilities.", View = "Garden view", Facilities = "Walk-in closet;Tea/Coffee maker;Kitchenette;Soundproof;Dining area;Washing machine", HotelId = 2 },
    new Room { Id = 3, RoomNumber = "Room 3", Images = "https://images.unsplash.com/photo-1519681393784-d120267933ba,https://images.unsplash.com/photo-1519681393784-d120267933ba,https://images.unsplash.com/photo-1519681393784-d120267933ba", OfferPresentage = 20, RoomType = "Stand Alone Villa", BedType = "1 king bed", Days = 10, Price = 25000, OldPrice = 30000, Services = "Balcony,fas fa-umbrella-beach;Soundproof,fas fa-volume-mute;Fireplace,fas fa-fire;Ironing facilities,fas fa-iron;Sitting area,fas fa-couch", RoomSize = "120 m²", RoomDescription = "A spacious villa with private amenities and breathtaking views.", View = "Mountain view", Facilities = "Fireplace;Patio;Flat-screen TV;Safe;Dining area;Dryer", HotelId = 3 },
    new Room { Id = 4, RoomNumber = "Room 4", Images = "https://images.unsplash.com/photo-1499856871958-5b9627545d1a,https://images.unsplash.com/photo-1499856871958-5b9627545d1a,https://images.unsplash.com/photo-1499856871958-5b9627545d1a", OfferPresentage = 25, RoomType = "Deluxe Suite", BedType = "1 queen bed", Days = 8, Price = 20000, OldPrice = 25000, Services = "Private Bathroom,fas fa-bath;Minibar,fas fa-wine-glass-alt;Safe,fas fa-lock;Jacuzzi,fas fa-hot-tub;Work desk,fas fa-laptop", RoomSize = "70 m²", RoomDescription = "A deluxe suite with all modern amenities for a comfortable stay.", View = "City view", Facilities = "Flat-screen TV;Tea/Coffee maker;Ironing facilities;Soundproof;Patio;Dryer", HotelId = 4 },
    new Room { Id = 5, RoomNumber = "Room 5", Images = "https://images.unsplash.com/photo-1518684079-3c830dcef090,https://images.unsplash.com/photo-1518684079-3c830dcef090,https://images.unsplash.com/photo-1518684079-3c830dcef090", OfferPresentage = 5, RoomType = "Executive Room", BedType = "2 queen beds", Days = 6, Price = 13000, OldPrice = 16000, Services = "Free Wifi,fas fa-wifi;Balcony,fas fa-umbrella-beach;Kitchenette,fas fa-utensils;Dining area,fas fa-utensils;Sitting area,fas fa-couch", RoomSize = "60 m²", RoomDescription = "An executive room perfect for business travelers and leisure.", View = "Pool view", Facilities = "Walk-in closet;Flat-screen TV;Safe;Fireplace;Air conditioning;Washing machine", HotelId = 5 }
};

            for (int i = 6; i <= 15; i++)
            {
                rooms.Add(new Room
                {
                    Id = i,
                    RoomNumber = $"Room {i}",
                    Images = "https://images.unsplash.com/photo-1578683010236-d716f9a3f461",
                    OfferPresentage = i * 2,
                    RoomType = "Standard Room",
                    BedType = "1 king bed",
                    Days = i + 3,
                    Price = 10000 + (i * 1000),
                    OldPrice = 12000 + (i * 1000),
                    Services = "Free Wifi,fas fa-wifi;Air Conditioning,fas fa-snowflake;Private Bathroom,fas fa-bath;Minibar,fas fa-wine-glass-alt;Flat-screen TV,fas fa-tv",
                    RoomSize = "50 m²",
                    RoomDescription = "A comfortable room with essential amenities.",
                    View = "City view",
                    Facilities = "Balcony;Air conditioning;Private bathroom;Flat-screen TV;Minibar;Free Wifi",
                    HotelId = (i % 5) + 1
                });
            }

            modelBuilder.Entity<Room>().HasData(rooms);

            modelBuilder.Entity<CompanyOffer>().HasData(
            new CompanyOffer
            {
                Id = 1,
                Name = "MAXIM TOURS",
                Location = "Cairo",
                Price = 1800,
                WebSiteUrl = "https://www.maximtours.com/",
                Description = "Catch the opportunity and book your trip to Egypt. Enjoy the most beautiful days in Cairo, where the charming historical monuments, the picturesque Nile River, and various recreational activities, do not miss the opportunity.",
                ImageUrl = "https://maxim-tours.com/ar/wp-content/uploads/2024/01/cropped-Maxim-Logo-removebg-preview.png",
                Rating = 4
            },
            new CompanyOffer
            {
                Id = 2,
                Name = "TRAVEL CHOICE",
                Location = "Aswan",
                Price = 99.00,
                WebSiteUrl = "https://egypttravelchoice.com/to_book/private-tour-to-abu-simbel-from-aswan/",
                Description = "Welcome to Abu Simbel, a breathtaking monument that's a must-see on any trip to Aswan. On this day trip, you'll embark on a journey through time, traveling to the heart of ancient Egypt.",
                ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQXwZHuUsybMP-q5fE4lPhAFpM31BLjGSVoFA&s",
                Rating = 5
            },
            new CompanyOffer
            {
                Id = 4,
                Name = "SKY EGYPT TOURS",
                Location = "Hurghada",
                Price = 10585,
                WebSiteUrl = "https://skyegtours.com/eg/ar/Desert-rose-resort&offer=89",
                Description = "Relaxing massage treatments are offered at the Planet Beach Spa Centre, which includes a gym and a sauna. Children are entertained at the Kids Club, and snorkelling and windsurfing activities can be enjoyed at the beach.",
                ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSFHp_ZkB39hpKVaS9BZ4gt7z0GssaWUdowk3MaqjehrJMRHH3RE9dyOAPAvo7ZgdSfN58&usqp=CAU",
                Rating = 4
            },
            new CompanyOffer
            {
                Id = 5,
                Name = "Egypt Tour",
                Location = "Cairo and the Nile",
                Price = 125000,
                WebSiteUrl = "https://bit.ly/4hGWmqg",
                Description = "A 10-day tourist tour in Egypt, Cairo and Nile Cruise. We offer a 10-day Egyptian tour package in Cairo and Nile Cruise, including 4 nights Cairo, 4 nights Nile cruise, 1 night in Luxor, visit the Giza Pyramids and the Egyptian Museum, then travel to Aswan and enjoy a 5-star Nile Cruise.",
                ImageUrl = "https://www.egypttourpackages.com/ar/images/coloredLogo.png",
                Rating = 5
            }
        );
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<ReviewCompany> ReviewCompanies { get; set; }
        public DbSet<ReviewHotel> ReviewHotels { get; set; }
        public DbSet<Tourist> Tourists { get; set; }
        public DbSet<Tourgide> Tourgides { get; set; }
        public DbSet<TouristPlaces> TouristPlaces { get; set; }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<CompanyOffer> CompanyOffers { get; set; }
    }
}
