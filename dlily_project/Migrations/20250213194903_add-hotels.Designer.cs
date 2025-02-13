﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using dlily_project.DAL;

#nullable disable

namespace dlily_project.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20250213194903_add-hotels")]
    partial class addhotels
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("dlily_project.DAL.Models.Offers.CompanyOffer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<byte>("Rating")
                        .HasColumnType("tinyint");

                    b.Property<string>("WebSiteUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CompanyOffers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Catch the opportunity and book your trip to Egypt. Enjoy the most beautiful days in Cairo, where the charming historical monuments, the picturesque Nile River, and various recreational activities, do not miss the opportunity.",
                            ImageUrl = "https://maxim-tours.com/ar/wp-content/uploads/2024/01/cropped-Maxim-Logo-removebg-preview.png",
                            Location = "Cairo",
                            Name = "MAXIM TOURS",
                            Price = 1800.0,
                            Rating = (byte)4,
                            WebSiteUrl = "https://www.maximtours.com/"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Welcome to Abu Simbel, a breathtaking monument that's a must-see on any trip to Aswan. On this day trip, you'll embark on a journey through time, traveling to the heart of ancient Egypt.",
                            ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQXwZHuUsybMP-q5fE4lPhAFpM31BLjGSVoFA&s",
                            Location = "Aswan",
                            Name = "TRAVEL CHOICE",
                            Price = 99.0,
                            Rating = (byte)5,
                            WebSiteUrl = "https://egypttravelchoice.com/to_book/private-tour-to-abu-simbel-from-aswan/"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Relaxing massage treatments are offered at the Planet Beach Spa Centre, which includes a gym and a sauna. Children are entertained at the Kids Club, and snorkelling and windsurfing activities can be enjoyed at the beach.",
                            ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSFHp_ZkB39hpKVaS9BZ4gt7z0GssaWUdowk3MaqjehrJMRHH3RE9dyOAPAvo7ZgdSfN58&usqp=CAU",
                            Location = "Hurghada",
                            Name = "SKY EGYPT TOURS",
                            Price = 10585.0,
                            Rating = (byte)4,
                            WebSiteUrl = "https://skyegtours.com/eg/ar/Desert-rose-resort&offer=89"
                        },
                        new
                        {
                            Id = 5,
                            Description = "A 10-day tourist tour in Egypt, Cairo and Nile Cruise. We offer a 10-day Egyptian tour package in Cairo and Nile Cruise, including 4 nights Cairo, 4 nights Nile cruise, 1 night in Luxor, visit the Giza Pyramids and the Egyptian Museum, then travel to Aswan and enjoy a 5-star Nile Cruise.",
                            ImageUrl = "https://www.egypttourpackages.com/ar/images/coloredLogo.png",
                            Location = "Cairo and the Nile",
                            Name = "Egypt Tour",
                            Price = 125000.0,
                            Rating = (byte)5,
                            WebSiteUrl = "https://bit.ly/4hGWmqg"
                        });
                });

            modelBuilder.Entity("dlily_project.DAL.Models.Offers.Hotel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HomeImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OtherImages")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<string>("Services")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Hotels");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "A luxurious resort located in the heart of the Maldives, offering breathtaking views and world-class amenities.",
                            HomeImage = "https://images.unsplash.com/photo-1566073771259-6a8506099945?ixlib=rb-1.2.1&auto=format&fit=crop&w=1350&q=80",
                            Location = "Maldives",
                            Name = "Luxury Paradise Resort",
                            OtherImages = "https://images.unsplash.com/photo-1564501049412-61c2a3083791?ixlib=rb-1.2.1&auto=format&fit=crop&w=1350&q=80,https://images.unsplash.com/photo-1566073771259-6a8506099945?ixlib=rb-1.2.1&auto=format&fit=crop&w=1350&q=80,https://images.unsplash.com/photo-1564501049412-61c2a3083791?ixlib=rb-1.2.1&auto=format&fit=crop&w=1350&q=80,https://images.unsplash.com/photo-1566073771259-6a8506099945?ixlib=rb-1.2.1&auto=format&fit=crop&w=1350&q=80,https://images.unsplash.com/photo-1564501049412-61c2a3083791?ixlib=rb-1.2.1&auto=format&fit=crop&w=1350&q=80",
                            Price = 450.0,
                            Rating = 5,
                            Services = "Spa, Pool, Gym, Free Wi-Fi, Restaurant"
                        },
                        new
                        {
                            Id = 2,
                            Description = "A serene beachfront hotel with stunning sunset views and a relaxing atmosphere.",
                            HomeImage = "https://images.unsplash.com/photo-1549989476-69a92fa57c36?ixlib=rb-1.2.1&auto=format&fit=crop&w=1350&q=80",
                            Location = "Bali, Indonesia",
                            Name = "Sunset Beach Hotel",
                            OtherImages = "https://images.unsplash.com/photo-1549989476-69a92fa57c36?ixlib=rb-1.2.1&auto=format&fit=crop&w=1350&q=80,https://images.unsplash.com/photo-1549989476-69a92fa57c36?ixlib=rb-1.2.1&auto=format&fit=crop&w=1350&q=80,https://images.unsplash.com/photo-1549989476-69a92fa57c36?ixlib=rb-1.2.1&auto=format&fit=crop&w=1350&q=80,https://images.unsplash.com/photo-1549989476-69a92fa57c36?ixlib=rb-1.2.1&auto=format&fit=crop&w=1350&q=80,https://images.unsplash.com/photo-1549989476-69a92fa57c36?ixlib=rb-1.2.1&auto=format&fit=crop&w=1350&q=80",
                            Price = 350.0,
                            Rating = 4,
                            Services = "Beach Access, Pool, Bar, Free Wi-Fi, Restaurant"
                        },
                        new
                        {
                            Id = 3,
                            Description = "A cozy lodge nestled in the Swiss Alps, perfect for winter sports and relaxation.",
                            HomeImage = "https://images.unsplash.com/photo-1519681393784-d120267933ba?ixlib=rb-1.2.1&auto=format&fit=crop&w=1350&q=80",
                            Location = "Swiss Alps",
                            Name = "Mountain View Lodge",
                            OtherImages = "https://images.unsplash.com/photo-1519681393784-d120267933ba?ixlib=rb-1.2.1&auto=format&fit=crop&w=1350&q=80,https://images.unsplash.com/photo-1519681393784-d120267933ba?ixlib=rb-1.2.1&auto=format&fit=crop&w=1350&q=80,https://images.unsplash.com/photo-1519681393784-d120267933ba?ixlib=rb-1.2.1&auto=format&fit=crop&w=1350&q=80,https://images.unsplash.com/photo-1519681393784-d120267933ba?ixlib=rb-1.2.1&auto=format&fit=crop&w=1350&q=80,https://images.unsplash.com/photo-1519681393784-d120267933ba?ixlib=rb-1.2.1&auto=format&fit=crop&w=1350&q=80",
                            Price = 300.0,
                            Rating = 4,
                            Services = "Skiing, Spa, Restaurant, Free Wi-Fi"
                        },
                        new
                        {
                            Id = 4,
                            Description = "A modern hotel located in the heart of New York City, ideal for business and leisure travelers.",
                            HomeImage = "https://images.unsplash.com/photo-1499856871958-5b9627545d1a?ixlib=rb-1.2.1&auto=format&fit=crop&w=1350&q=80",
                            Location = "New York, USA",
                            Name = "City Central Hotel",
                            OtherImages = "https://images.unsplash.com/photo-1499856871958-5b9627545d1a?ixlib=rb-1.2.1&auto=format&fit=crop&w=1350&q=80,https://images.unsplash.com/photo-1499856871958-5b9627545d1a?ixlib=rb-1.2.1&auto=format&fit=crop&w=1350&q=80,https://images.unsplash.com/photo-1499856871958-5b9627545d1a?ixlib=rb-1.2.1&auto=format&fit=crop&w=1350&q=80,https://images.unsplash.com/photo-1499856871958-5b9627545d1a?ixlib=rb-1.2.1&auto=format&fit=crop&w=1350&q=80,https://images.unsplash.com/photo-1499856871958-5b9627545d1a?ixlib=rb-1.2.1&auto=format&fit=crop&w=1350&q=80",
                            Price = 250.0,
                            Rating = 3,
                            Services = "Gym, Free Wi-Fi, Restaurant, Conference Rooms"
                        },
                        new
                        {
                            Id = 5,
                            Description = "A luxurious resort in the middle of the desert, offering a unique blend of tradition and modernity.",
                            HomeImage = "https://images.unsplash.com/photo-1518684079-3c830dcef090?ixlib=rb-1.2.1&auto=format&fit=crop&w=1350&q=80",
                            Location = "Dubai, UAE",
                            Name = "Desert Oasis Resort",
                            OtherImages = "https://images.unsplash.com/photo-1518684079-3c830dcef090?ixlib=rb-1.2.1&auto=format&fit=crop&w=1350&q=80,https://images.unsplash.com/photo-1518684079-3c830dcef090?ixlib=rb-1.2.1&auto=format&fit=crop&w=1350&q=80,https://images.unsplash.com/photo-1518684079-3c830dcef090?ixlib=rb-1.2.1&auto=format&fit=crop&w=1350&q=80,https://images.unsplash.com/photo-1518684079-3c830dcef090?ixlib=rb-1.2.1&auto=format&fit=crop&w=1350&q=80,https://images.unsplash.com/photo-1518684079-3c830dcef090?ixlib=rb-1.2.1&auto=format&fit=crop&w=1350&q=80",
                            Price = 500.0,
                            Rating = 5,
                            Services = "Pool, Spa, Free Wi-Fi, Restaurant, Camel Riding"
                        });
                });

            modelBuilder.Entity("dlily_project.DAL.Models.Offers.Room", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("HotelId")
                        .HasColumnType("int");

                    b.Property<string>("Images")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("HotelId");

                    b.ToTable("Room");
                });

            modelBuilder.Entity("dlily_project.DAL.Models.Reviews.ReviewCompany", b =>
                {
                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<int>("TouristId")
                        .HasColumnType("int");

                    b.Property<int>("CompanyOfferId")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("CompanyId", "TouristId");

                    b.HasIndex("CompanyOfferId");

                    b.HasIndex("TouristId");

                    b.ToTable("ReviewCompanies");
                });

            modelBuilder.Entity("dlily_project.DAL.Models.Reviews.ReviewHotel", b =>
                {
                    b.Property<int>("HotelId")
                        .HasColumnType("int");

                    b.Property<int>("TouristId")
                        .HasColumnType("int");

                    b.Property<int?>("CompanyOfferId")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("HotelId", "TouristId");

                    b.HasIndex("CompanyOfferId");

                    b.HasIndex("TouristId");

                    b.ToTable("ReviewHotels");
                });

            modelBuilder.Entity("dlily_project.DAL.Models.TouristPlaces", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Article")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<TimeSpan>("CloseAt")
                        .HasColumnType("time");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<double>("EntryFee")
                        .HasColumnType("float");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<TimeSpan>("OpenAt")
                        .HasColumnType("time");

                    b.Property<byte>("Rating")
                        .HasColumnType("tinyint");

                    b.HasKey("Id");

                    b.ToTable("TouristPlaces");

                    b.HasData(
                        new
                        {
                            Id = 4,
                            Article = "The Giza pyramid complex includes the Great Pyramid of Giza...",
                            Category = "Ancient Monument",
                            CloseAt = new TimeSpan(0, 17, 0, 0, 0),
                            Description = "Ancient pyramids and the last surviving Wonder of the Ancient World",
                            EntryFee = 200.0,
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/a/af/Giza_pyramid_complex_%28edited%29.jpg",
                            Location = "https://www.google.com/maps/place/The+Great+Pyramid+of+Giza/@29.9792345,31.1342019,15z/",
                            Name = "Great Pyramids of Giza",
                            OpenAt = new TimeSpan(0, 8, 0, 0, 0),
                            Rating = (byte)5
                        },
                        new
                        {
                            Id = 5,
                            Article = "Built approximately 1400 BCE, this temple was dedicated to the Theban Triad...",
                            Category = "Archaeological Site",
                            CloseAt = new TimeSpan(0, 22, 0, 0, 0),
                            Description = "Massive Ancient Egyptian temple complex on the east bank of the Nile",
                            EntryFee = 160.0,
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/4/49/Luxor_Temple_18.jpg",
                            Location = "https://www.google.com/maps/place/Luxor+Temple/@25.6996147,32.6366406,17z/",
                            Name = "Luxor Temple",
                            OpenAt = new TimeSpan(0, 6, 0, 0, 0),
                            Rating = (byte)5
                        },
                        new
                        {
                            Id = 6,
                            Article = "Commissioned by Pharaoh Ramesses II to commemorate his victory...",
                            Category = "Historical Site",
                            CloseAt = new TimeSpan(0, 18, 0, 0, 0),
                            Description = "Twin rock-cut temples dating back to the 13th century BCE",
                            EntryFee = 240.0,
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/8/8e/Abu_Simbel_Temple_%288488942077%29.jpg",
                            Location = "https://www.google.com/maps/place/Abu+Simbel+Temples/@22.3369232,31.6254713,17z/",
                            Name = "Abu Simbel Temples",
                            OpenAt = new TimeSpan(0, 5, 0, 0, 0),
                            Rating = (byte)5
                        },
                        new
                        {
                            Id = 7,
                            Article = "Contains over 120,000 items including the treasures of Tutankhamun...",
                            Category = "Museum",
                            CloseAt = new TimeSpan(0, 17, 0, 0, 0),
                            Description = "Home to the world's most extensive collection of Pharaonic antiquities",
                            EntryFee = 300.0,
                            ImageUrl = "https://live.staticflickr.com/65535/53609865504_1c1a8d7c0e_b.jpg",
                            Location = "https://www.google.com/maps/place/The+Egyptian+Museum/@30.0478085,31.2335643,17z/",
                            Name = "The Egyptian Museum",
                            OpenAt = new TimeSpan(0, 9, 0, 0, 0),
                            Rating = (byte)5
                        },
                        new
                        {
                            Id = 8,
                            Article = "Contains 63 magnificent royal tombs from the New Kingdom period...",
                            Category = "Archaeological Site",
                            CloseAt = new TimeSpan(0, 17, 0, 0, 0),
                            Description = "Ancient burial ground for Egyptian royalty",
                            EntryFee = 240.0,
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/4/4a/Valley_of_the_Kings_Overview.jpg",
                            Location = "https://www.google.com/maps/place/Valley+of+the+Kings/@25.7401865,32.6015273,17z/",
                            Name = "Valley of the Kings",
                            OpenAt = new TimeSpan(0, 6, 0, 0, 0),
                            Rating = (byte)5
                        });
                });

            modelBuilder.Entity("dlily_project.DAL.Models.Users.Tourgide", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<byte[]>("ProfilePicture")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<byte>("Rating")
                        .HasColumnType("tinyint");

                    b.Property<string>("SpokenLanguage")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Tourgides");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "10 Karnak Temple Street, Luxor, Luxor Governorate",
                            Description = "Italian-speaking guide",
                            Email = "ahmed.aly@gmail.com",
                            Gender = 0,
                            Name = "Ahmed Aly Ahmed",
                            Password = "",
                            Phone = "01019273234",
                            Price = 55.0,
                            ProfilePicture = new byte[0],
                            Rating = (byte)3,
                            SpokenLanguage = "Italian"
                        },
                        new
                        {
                            Id = 2,
                            Address = "30 Zamalek Street, Cairo, Cairo Governorate",
                            Description = "German-speaking guide",
                            Email = "ahmed.ramadan@gmail.com",
                            Gender = 0,
                            Name = "Ahmed Ramadan",
                            Password = "",
                            Phone = "01065502465",
                            Price = 52.0,
                            ProfilePicture = new byte[0],
                            Rating = (byte)3,
                            SpokenLanguage = "German"
                        },
                        new
                        {
                            Id = 3,
                            Address = "25 Sharia Al Muizz Li-Din Allah, Cairo, Cairo Governorate",
                            Description = "English-speaking tour guide",
                            Email = "amr.fouad@gmail.com",
                            Gender = 0,
                            Name = "Amr Fouad",
                            Password = "",
                            Phone = "01146146691",
                            Price = 42.0,
                            ProfilePicture = new byte[0],
                            Rating = (byte)5,
                            SpokenLanguage = "English"
                        },
                        new
                        {
                            Id = 4,
                            Address = "18 Luxor Temple Street, Luxor, Luxor Governorate",
                            Description = "German-speaking guide",
                            Email = "ibrahim.ghalwash@gmail.com",
                            Gender = 0,
                            Name = "Ibrahim Ghalwash",
                            Password = "",
                            Phone = "01033823595",
                            Price = 50.0,
                            ProfilePicture = new byte[0],
                            Rating = (byte)4,
                            SpokenLanguage = "German"
                        },
                        new
                        {
                            Id = 5,
                            Address = "7 Philae Temple Road, Aswan, Aswan Governorate",
                            Description = "German-speaking guide",
                            Email = "mariam.ali@gmail.com",
                            Gender = 1,
                            Name = "Mariam Ali",
                            Password = "",
                            Phone = "01065502465",
                            Price = 48.0,
                            ProfilePicture = new byte[0],
                            Rating = (byte)5,
                            SpokenLanguage = "German"
                        },
                        new
                        {
                            Id = 6,
                            Address = "20 Al Azhar Street, Islamic Cairo, Cairo Governorate",
                            Description = "Italian-speaking guide",
                            Email = "ahmed.guide@gmail.com",
                            Gender = 0,
                            Name = "Ahmed",
                            Password = "",
                            Phone = "01104682219",
                            Price = 55.0,
                            ProfilePicture = new byte[0],
                            Rating = (byte)3,
                            SpokenLanguage = "Italian"
                        },
                        new
                        {
                            Id = 7,
                            Address = "20 Al Azhar Street, Islamic Cairo, Cairo Governorate",
                            Description = "Speaking English and Japanese",
                            Email = "ebram_melles.guide@gmail.com",
                            Gender = 0,
                            Name = "Ebram Melles",
                            Password = "",
                            Phone = "01220801758",
                            Price = 55.0,
                            ProfilePicture = new byte[0],
                            Rating = (byte)3,
                            SpokenLanguage = "English"
                        },
                        new
                        {
                            Id = 8,
                            Address = "12 Corniche El Nile Street, Aswan, Aswan Governorate",
                            Description = "English & Russian-speaking guide",
                            Email = "mohamed.gomaa@gmail.com",
                            Gender = 0,
                            Name = "Mohamed Gomaa",
                            Password = "",
                            Phone = "01022510710",
                            Price = 50.0,
                            ProfilePicture = new byte[0],
                            Rating = (byte)5,
                            SpokenLanguage = "English, Russian"
                        });
                });

            modelBuilder.Entity("dlily_project.DAL.Models.Users.Tourist", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<byte[]>("ProfilePicture")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("SpokenLanguage")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("TourgideId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TourgideId");

                    b.ToTable("Tourists");
                });

            modelBuilder.Entity("dlily_project.DAL.Models.Offers.Room", b =>
                {
                    b.HasOne("dlily_project.DAL.Models.Offers.Hotel", null)
                        .WithMany("Rooms")
                        .HasForeignKey("HotelId");
                });

            modelBuilder.Entity("dlily_project.DAL.Models.Reviews.ReviewCompany", b =>
                {
                    b.HasOne("dlily_project.DAL.Models.Offers.CompanyOffer", "CompanyOffer")
                        .WithMany()
                        .HasForeignKey("CompanyOfferId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("dlily_project.DAL.Models.Users.Tourist", "Tourist")
                        .WithMany("ReviewCompanies")
                        .HasForeignKey("TouristId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CompanyOffer");

                    b.Navigation("Tourist");
                });

            modelBuilder.Entity("dlily_project.DAL.Models.Reviews.ReviewHotel", b =>
                {
                    b.HasOne("dlily_project.DAL.Models.Offers.CompanyOffer", null)
                        .WithMany("ReviewHotels")
                        .HasForeignKey("CompanyOfferId");

                    b.HasOne("dlily_project.DAL.Models.Offers.Hotel", "Hotel")
                        .WithMany("ReviewHotels")
                        .HasForeignKey("HotelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("dlily_project.DAL.Models.Users.Tourist", "Tourist")
                        .WithMany("ReviewHotels")
                        .HasForeignKey("TouristId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hotel");

                    b.Navigation("Tourist");
                });

            modelBuilder.Entity("dlily_project.DAL.Models.Users.Tourist", b =>
                {
                    b.HasOne("dlily_project.DAL.Models.Users.Tourgide", "Tourgide")
                        .WithMany("Tourists")
                        .HasForeignKey("TourgideId");

                    b.Navigation("Tourgide");
                });

            modelBuilder.Entity("dlily_project.DAL.Models.Offers.CompanyOffer", b =>
                {
                    b.Navigation("ReviewHotels");
                });

            modelBuilder.Entity("dlily_project.DAL.Models.Offers.Hotel", b =>
                {
                    b.Navigation("ReviewHotels");

                    b.Navigation("Rooms");
                });

            modelBuilder.Entity("dlily_project.DAL.Models.Users.Tourgide", b =>
                {
                    b.Navigation("Tourists");
                });

            modelBuilder.Entity("dlily_project.DAL.Models.Users.Tourist", b =>
                {
                    b.Navigation("ReviewCompanies");

                    b.Navigation("ReviewHotels");
                });
#pragma warning restore 612, 618
        }
    }
}
