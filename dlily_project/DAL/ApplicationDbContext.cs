using dlily_project.DAL.Models;
using dlily_project.DAL.Models.Offers;
using dlily_project.DAL.Models.Reviews;
namespace dlily_project.DAL
{
    public class ApplicationDbContext : DbContext
    {
        private readonly IWebHostEnvironment _hostingEnvironment;

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options, IWebHostEnvironment hostingEnvironment)
            : base(options)
        {
            _hostingEnvironment = hostingEnvironment;
        }

        private static void SeedTourgides(ModelBuilder modelBuilder, IWebHostEnvironment hostingEnvironment)
        {
            modelBuilder.Entity<Tourgide>().HasData(
      new Tourgide
      {
          Id = 1,
          Name = "Ahmed Aly Ahmed",
          Gender = Gender.Male,
          Phone = "01019273234",
          Email = "ahmed.alyy@gmail.com",
          Address = "10 Karnak Temple Street, Luxor, Luxor Governorate",
          Rating = 3,
          Description = "Italian-speaking guide",
          Price = 55.0,
          SpokenLanguage = "Italian",
          ProfilePicture = GetImageBytes("Assets/Images/AhmedAlyAhmed.jpeg", hostingEnvironment)
      },
      new Tourgide
      {
          Id = 2,
          Name = "Ahmed Ramadan",
          Gender = Gender.Male,
          Phone = "01065502465",
          Email = "ahmed.ramadann@gmail.com",
          Address = "30 Zamalek Street, Cairo, Cairo Governorate",
          Rating = 3,
          Description = "German-speaking guide",
          Price = 52.0,
          SpokenLanguage = "German",
          ProfilePicture = GetImageBytes("Assets/Images/AhmedRamadan.jpeg", hostingEnvironment)
      },
      new Tourgide
      {
          Id = 3,
          Name = "Amr Fouad",
          Gender = Gender.Male,
          Phone = "01146146691",
          Email = "amr.fouadd@gmail.com",
          Address = "25 Sharia Al Muizz Li-Din Allah, Cairo, Cairo Governorate",
          Rating = 5,
          Description = "English-speaking tour guide",
          Price = 42.0,
          SpokenLanguage = "English",
          ProfilePicture = GetImageBytes("Assets/Images/AmrFouad.jpeg", hostingEnvironment)
      },
      new Tourgide
      {
          Id = 4,
          Name = "Ibrahim Ghalwash",
          Gender = Gender.Male,
          Phone = "01033823595",
          Email = "ibrahim.ghalwashh@gmail.com",
          Address = "18 Luxor Temple Street, Luxor, Luxor Governorate",
          Rating = 4,
          Description = "German-speaking guide",
          Price = 50.0,
          SpokenLanguage = "German",
          ProfilePicture = GetImageBytes("Assets/Images/IbrahimGhalwash.jpeg", hostingEnvironment)
      },
      new Tourgide
      {
          Id = 5,
          Name = "Mariam Ali",
          Gender = Gender.Female,
          Phone = "01065502465",
          Email = "mariam.alii@gmail.com",
          Address = "7 Philae Temple Road, Aswan, Aswan Governorate",
          Rating = 5,
          Description = "German-speaking guide",
          Price = 48.0,
          SpokenLanguage = "German",
          ProfilePicture = GetImageBytes("Assets/Images/MariamAli.jpeg", hostingEnvironment)
      },
      new Tourgide
      {
          Id = 6,
          Name = "Ahmed",
          Gender = Gender.Male,
          Phone = "01104682219",
          Email = "ahmed.guidee@gmail.com",
          Address = "20 Al Azhar Street, Islamic Cairo, Cairo Governorate",
          Rating = 3,
          Description = "Italian-speaking guide",
          Price = 55.0,
          SpokenLanguage = "Italian",
          ProfilePicture = GetImageBytes("Assets/Images/SignorAhmedElAlily.jpeg", hostingEnvironment)
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
          ProfilePicture = GetImageBytes("Assets/Images/EbramMelles.jpeg", hostingEnvironment)
      },
      new Tourgide
      {
          Id = 8,
          Name = "Mohamed Gomaa",
          Gender = Gender.Male,
          Phone = "01022510710",
          Email = "mohamed.gomaaa@gmail.com",
          Address = "12 Corniche El Nile Street, Aswan, Aswan Governorate",
          Rating = 5,
          Description = "English & Russian-speaking guide",
          Price = 50.0,
          SpokenLanguage = "English, Russian",
          ProfilePicture = GetImageBytes("Assets/Images/MohamedFriday.jpeg", hostingEnvironment)
      },
      new Tourgide
      {
          Id = 9,
          Name = "Mostafa Medhat",
          Gender = Gender.Male,
          Phone = "01101099035",
          Email = "testguide618@gmail.com",
          Address = "12 Corniche El Nile Street, Aswan, Aswan Governorate",
          Rating = 5,
          Description = "English & Russian-speaking guide",
          Price = 1000.0,
          SpokenLanguage = "English, Russian",
          ProfilePicture = GetImageBytes("Assets/Images/mostafa.jpg", hostingEnvironment)
      }

  );
        }

        private static byte[] GetImageBytes(string imagePath, IWebHostEnvironment hostingEnvironment)
    {
        // Resolve the full path for relative paths
        string fullPath;

        if (Path.IsPathRooted(imagePath))
        {
            // If the path is already absolute, use it as-is
            fullPath = imagePath;
        }
        else
        {
            // Combine the relative path with the wwwroot folder
            fullPath = Path.Combine(hostingEnvironment.WebRootPath, imagePath);
        }

        // Check if the file exists and return its bytes
        if (File.Exists(fullPath))
        {
            return File.ReadAllBytes(fullPath);
        }
        else
        {
            // Log or handle the case where the file doesn't exist
            Console.WriteLine($"File not found: {fullPath}");
            return Array.Empty<byte>();
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ReviewCompany>().HasKey(x => new {x.CompanyId,x.TouristId });
            modelBuilder.Entity<ReviewHotel>().HasKey(x => new { x.HotelId, x.TouristId });

            modelBuilder.Entity<TouristPlaces>().HasData(
                new TouristPlaces
                {
                    Id = 1,
                    Name = "Pyramids of Giza",
                    Description = "The Pyramids of Giza, including the Great Pyramid, are ancient monumental tombs built for pharaohs and stand as a testament to Egypt's historical grandeur.",
                    Article = "These structures are among the most iconic symbols of ancient Egypt, reflecting advanced engineering and serving as royal tombs.",
                    Location = "Giza, Egypt",
                    OpenAt = new TimeSpan(8, 0, 0),
                    CloseAt = new TimeSpan(17, 0, 0),
                    Rating = 5,
                    Category = "Historical Monument",
                    EntryFee = 200,
                    ImageUrl = "https://egyptianstreets.com/wp-content/uploads/2012/10/pyramids-with-giza.jpg"
                },
                new TouristPlaces
                {
                    Id = 2,
                    Name = "Karnak Temple",
                    Description = "A vast open-air museum and the largest ancient religious site in the world, dedicated to Theban gods.",
                    Article = "The temple complex showcases impressive columns and sanctuaries, reflecting the grandeur of ancient Egyptian architecture.",
                    Location = "Luxor, Egypt",
                    OpenAt = new TimeSpan(6, 0, 0),
                    CloseAt = new TimeSpan(17, 30, 0),
                    Rating = 5,
                    Category = "Temple Complex",
                    EntryFee = 150,
                    ImageUrl = "https://www.expeditions.com/globalassets/expedition-stories/exploring-egypt-5-must-see-sights-at-karnak-temple-complex/karnak-temple-complex-main-image.jpg"
                },
                new TouristPlaces
                {
                    Id = 3,
                    Name = "Valley of the Kings",
                    Description = "A royal burial ground for pharaohs, including the tomb of Tutankhamun, adorned with intricate wall paintings.",
                    Article = "This valley contains the tombs of pharaohs and nobles, offering insights into ancient Egyptian beliefs about the afterlife.",
                    Location = "Luxor, Egypt",
                    OpenAt = new TimeSpan(6, 0, 0),
                    CloseAt = new TimeSpan(16, 0, 0),
                    Rating = 5,
                    Category = "Archaeological Site",
                    EntryFee = 240,
                    ImageUrl = "https://s27363.pcdn.co/wp-content/uploads/2020/01/Valley-of-the-Kings-Overview.jpg.optimal.jpg"
                },
                new TouristPlaces
                {
                    Id = 4,
                    Name = "Abu Simbel Temples",
                    Description = "Massive rock-cut temples built by Ramses II, featuring colossal statues and intricate interiors.",
                    Article = "These temples are renowned for their impressive architecture and the relocation efforts to preserve them from flooding.",
                    Location = "Aswan Governorate, Egypt",
                    OpenAt = new TimeSpan(5, 0, 0),
                    CloseAt = new TimeSpan(18, 0, 0),
                    Rating = 5,
                    Category = "Historical Monument",
                    EntryFee = 255,
                    ImageUrl = "https://humanoriginproject.com/wp-content/uploads/2019/07/Abu-Simbel-Temple-Egypt.jpg"
                },
                new TouristPlaces
                {
                    Id = 5,
                    Name = "Egyptian Museum",
                    Description = "Houses an extensive collection of ancient Egyptian artifacts, including the treasures of Tutankhamun.",
                    Article = "The museum offers a comprehensive overview of ancient Egypt's history through its vast array of artifacts.",
                    Location = "Cairo, Egypt",
                    OpenAt = new TimeSpan(9, 0, 0),
                    CloseAt = new TimeSpan(17, 0, 0),
                    Rating = 5,
                    Category = "Museum",
                    EntryFee = 200,
                    ImageUrl = "https://egyptianstreets.com/wp-content/uploads/2021/04/museum2.jpg"
                },
                new TouristPlaces
                {
                    Id = 6,
                    Name = "Siwa Oasis",
                    Description = "A remote oasis known for its lush palm groves, natural springs, and rich cultural heritage.",
                    Article = "Siwa offers a tranquil retreat with its unique landscapes and traditional Berber culture.",
                    Location = "Siwa, Egypt",
                    OpenAt = new TimeSpan(0, 0, 0),
                    CloseAt = new TimeSpan(23, 59, 59),
                    Rating = 4,
                    Category = "Natural Attraction",
                    EntryFee = 0,
                    ImageUrl = "https://www.mediterraholidays.com/photos/tour/191/banner.jpg"
                },
                new TouristPlaces
                {
                    Id = 7,
                    Name = "Luxor Temple",
                    Description = "A large Ancient Egyptian temple complex located on the east bank of the Nile River, known for its well-preserved structures and grand architecture.",
                    Article = "Luxor Temple was constructed approximately 3,400 years ago during the New Kingdom period and was dedicated to the rejuvenation of kingship.",
                    Location = "Luxor, Egypt",
                    OpenAt = new TimeSpan(6, 0, 0),
                    CloseAt = new TimeSpan(21, 0, 0),
                    Rating = 4,
                    Category = "Historical Monument",
                    EntryFee = 160,
                    ImageUrl = "https://i.pinimg.com/originals/fe/b2/e9/feb2e9a88d11b9c4f6520c4d94159377.jpg"
                },
                new TouristPlaces
                {
                    Id = 8,
                    Name = "Temple of Hatshepsut",
                    Description = "A mortuary temple built for Pharaoh Hatshepsut, showcasing unique terraced architecture set against limestone cliffs.",
                    Article = "This temple is considered one of the incomparable monuments of ancient Egypt, reflecting the grandeur of the pharaoh it was built to honor.",
                    Location = "Deir el-Bahari, Luxor, Egypt",
                    OpenAt = new TimeSpan(6, 0, 0),
                    CloseAt = new TimeSpan(17, 0, 0),
                    Rating = 4,
                    Category = "Historical Monument",
                    EntryFee = 140,
                    ImageUrl = "https://www.egyptpyramidstours.com/wp-content/uploads/2020/05/Temple-of-Queen-Hatshepsut.jpg"
                },
                new TouristPlaces
                {
                    Id = 9,
                    Name = "Philae Temple",
                    Description = "An island temple complex dedicated to the goddess Isis, known for its beautiful architecture and scenic location.",
                    Article = "The Philae Temple complex was relocated to Agilkia Island to preserve it from the rising waters of the Nile due to the Aswan High Dam construction.",
                    Location = "Aswan, Egypt",
                    OpenAt = new TimeSpan(7, 0, 0),
                    CloseAt = new TimeSpan(16, 0, 0),
                    Rating = 4,
                    Category = "Historical Monument",
                    EntryFee = 180,
                    ImageUrl = "https://www.tripsavvy.com/thmb/xpMXo-XFKdCy2a6Rp75kLaXb1rk=/3648x2428/filters:fill(auto,1)/GettyImages-500053303-5c80e80b46e0fb0001a5f168.jpg"
                }
            );

            SeedTourgides(modelBuilder, _hostingEnvironment);

            modelBuilder.Entity<Hotel>().HasData(
         new Hotel
         {
             Id = 1,
             Name = "Luxury Paradise Resort",
             Rating = 5,
             Location = "Maldives",
             Services = "Spa,fas fa-spa;Pool,fas fa-swimming-pool;Gym,fas fa-dumbbell;Free Wi-Fi,fas fa-wifi;Restaurant,fas fa-utensils",
             Description = "A luxurious resort located in the heart of the Maldives, offering breathtaking views and world-class amenities.",
             HomeImage = "https://www.hilton.com/im/en/CAIRHTW/16763081/exterior-night-shot.jpg?impolicy=crop&cw=5000&ch=2799&gravity=NorthWest&xposition=0&yposition=267&rw=768&rh=430",
             OtherImages = "https://www.hilton.com/im/en/CAIRHTW/11151445/ramses-hilton-swimming-pool-day.jpg?impolicy=crop&cw=5606&ch=3138&gravity=NorthWest&xposition=0&yposition=265&rw=768&rh=430,https://www.hilton.com/im/en/CAIRHTW/15957512/ramses-hilton-terrace-cafe-day.jpg?impolicy=crop&cw=4800&ch=2688&gravity=NorthWest&xposition=99&yposition=0&rw=768&rh=430,https://www.hilton.com/im/en/CAIRHTW/17407096/0pia8214.jpg?impolicy=crop&cw=5000&ch=2799&gravity=NorthWest&xposition=0&yposition=266&rw=768&rh=430,https://www.hilton.com/im/en/CAIRHTW/5072255/cairh-fitness-center-.jpg?impolicy=crop&cw=4827&ch=2702&gravity=NorthWest&xposition=0&yposition=257&rw=768&rh=430,https://www.hilton.com/im/en/CAIRHTW/21832862/ballroom-wedding.jpg?impolicy=crop&cw=5000&ch=2799&gravity=NorthWest&xposition=0&yposition=267&rw=768&rh=430",
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
             HomeImage = "https://cache.marriott.com/content/dam/marriott-renditions/CAIMD/caimd-exterior-9993-hor-wide.jpg?output-quality=70&interpolation=progressive-bilinear&downsize=375px:*",
             OtherImages = "https://cache.marriott.com/content/dam/marriott-renditions/CAIMD/caimd-restaurant-2202-hor-wide.jpg?output-quality=70&interpolation=progressive-bilinear&downsize=750px:*,https://cache.marriott.com/content/dam/marriott-renditions/CAIMD/caimd-restaurant-2206-hor-wide.jpg?output-quality=70&interpolation=progressive-bilinear&downsize=375px:*,https://cache.marriott.com/content/dam/marriott-renditions/CAIMD/caimd-club-8312-hor-wide.jpg?output-quality=70&interpolation=progressive-bilinear&downsize=375px:*,https://cache.marriott.com/content/dam/marriott-renditions/CAIMD/caimd-pool-2215-hor-wide.jpg?output-quality=70&interpolation=progressive-bilinear&downsize=750px:*,https://cache.marriott.com/content/dam/marriott-renditions/CAIMD/caimd-spa-8322-hor-wide.jpg?output-quality=70&interpolation=progressive-bilinear&downsize=750px:*",

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
             HomeImage = "https://tse2.mm.bing.net/th?id=OIP.N0Zg8i_R2qUOwblYRgrMDQHaE8&pid=Api",
             OtherImages = "https://www.fourseasons.com/alt/img-opt/~80.1860.0,0000-119,5189-3000,0000-1687,5000/publish/content/dam/fourseasons/images/web/CAI/CAI_1271_original.jpg,https://www.fourseasons.com/alt/img-opt/~80.1860.0,0000-208,6785-3000,0000-1687,5000/publish/content/dam/fourseasons/images/web/CAI/CAI_1257_original.jpg,https://www.fourseasons.com/alt/img-opt/~80.1860.0,0000-0,0000-3840,0000-2160,0000/publish/content/dam/fourseasons/images/web/CAI/CAI_463_3840x2160.jpg,https://www.fourseasons.com/alt/img-opt/~80.1860.0,0000-312,5000-3000,0000-1687,5000/publish/content/dam/fourseasons/images/web/CAI/CAI_206_original.jpg,https://www.fourseasons.com/alt/img-opt/~80.1860.0,0000-550,0104-1378,0000-775,1250/publish/content/dam/fourseasons/images/web/CAI/CAI_464_original.jpg",
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
             HomeImage = "https://jewelhotels.net/uploads/0000/22/2022/01/03/279280588.jpg",
             OtherImages = "https://jewelhotels.net/uploads/0000/22/2022/01/03/dsc-2799.JPG,https://jewelhotels.net/uploads/0000/22/2022/01/03/279280496.jpg,https://jewelhotels.net/uploads/0000/22/2022/01/03/279280534.jpg,https://jewelhotels.net/uploads/0000/22/2022/01/03/279280513.jpg,https://jewelhotels.net/uploads/0000/22/2022/01/03/2792805311.jpg",
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
             HomeImage = "https://www.rehanaplazahotel.com/sites/rehanaplazahotel/files/photos/30.jpg",
             OtherImages = "https://www.rehanaplazahotel.com/includes/image.php?image=./sites/rehanaplazahotel/files/photos/4.jpg&nwidth=350&imgq=70,https://www.rehanaplazahotel.com/includes/image.php?image=./sites/rehanaplazahotel/files/photos/3.jpg&nwidth=350&imgq=70,https://www.rehanaplazahotel.com/includes/image.php?image=./sites/rehanaplazahotel/files/photos/48.jpg&nwidth=350&imgq=70,https://www.rehanaplazahotel.com/includes/image.php?image=./sites/rehanaplazahotel/files/photos/35.jpg&nwidth=350&imgq=70,https://www.rehanaplazahotel.com/includes/image.php?image=./sites/rehanaplazahotel/files/photos/106.jpg&nwidth=350&imgq=70",
             Price = 500.00
         }
     );

            var rooms = new List<Room>
{
    new Room { Id = 1, RoomNumber = "Room 1", Images = "https://images.unsplash.com/photo-1618773928121-c32242e63f39,https://images.unsplash.com/photo-1564501049412-61c2a3083791,https://images.unsplash.com/photo-1566073771259-6a8506099945", OfferPresentage = 10, RoomType = "One Bedroom Apartment", BedType = "1 king bed", Days = 5, Price = 10000, OldPrice = 12000, Services = "Free Wifi,fas fa-wifi;Air Conditioning,fas fa-snowflake;Private Bathroom,fas fa-bath;Minibar,fas fa-wine-glass-alt;Flat-screen TV,fas fa-tv", RoomSize = "50 m²", RoomDescription = "A spacious and comfortable room with modern amenities.", View = "Sea view", Facilities = "Balcony;Air conditioning;Private bathroom;Flat-screen TV;Minibar;Free Wifi", HotelId = 1 },
    new Room { Id = 2, RoomNumber = "Room 2", Images = "https://images.unsplash.com/photo-1618773928121-c32242e63f39,https://images.unsplash.com/photo-1564501049412-61c2a3083791,https://images.unsplash.com/photo-1566073771259-6a8506099945", OfferPresentage = 15, RoomType = "Two-Bedroom Apartment", BedType = "2 twin beds", Days = 7, Price = 15000, OldPrice = 18000, Services = "Free Wifi,fas fa-wifi;Kitchenette,fas fa-utensils;Jacuzzi,fas fa-hot-tub;Safe,fas fa-lock;Work desk,fas fa-laptop", RoomSize = "80 m²", RoomDescription = "A luxurious apartment with a stunning view and excellent facilities.", View = "Garden view", Facilities = "Walk-in closet;Tea/Coffee maker;Kitchenette;Soundproof;Dining area;Washing machine", HotelId = 2 },
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
