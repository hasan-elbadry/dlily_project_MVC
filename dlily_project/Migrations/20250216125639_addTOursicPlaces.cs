using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace dlily_project.Migrations
{
    /// <inheritdoc />
    public partial class addTOursicPlaces : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TouristPlaces",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Article", "Category", "CloseAt", "Description", "EntryFee", "ImageUrl", "Location", "Name", "OpenAt" },
                values: new object[] { "These temples are renowned for their impressive architecture and the relocation efforts to preserve them from flooding.", "Historical Monument", new TimeSpan(0, 18, 0, 0, 0), "Massive rock-cut temples built by Ramses II, featuring colossal statues and intricate interiors.", 255.0, "https://humanoriginproject.com/wp-content/uploads/2019/07/Abu-Simbel-Temple-Egypt.jpg", "Aswan Governorate, Egypt", "Abu Simbel Temples", new TimeSpan(0, 5, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "TouristPlaces",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Article", "Category", "CloseAt", "Description", "EntryFee", "ImageUrl", "Location", "Name", "OpenAt" },
                values: new object[] { "The museum offers a comprehensive overview of ancient Egypt's history through its vast array of artifacts.", "Museum", new TimeSpan(0, 17, 0, 0, 0), "Houses an extensive collection of ancient Egyptian artifacts, including the treasures of Tutankhamun.", 200.0, "https://egyptianstreets.com/wp-content/uploads/2021/04/museum2.jpg", "Cairo, Egypt", "Egyptian Museum", new TimeSpan(0, 9, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "TouristPlaces",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Article", "Category", "CloseAt", "Description", "EntryFee", "ImageUrl", "Location", "Name", "OpenAt", "Rating" },
                values: new object[] { "Siwa offers a tranquil retreat with its unique landscapes and traditional Berber culture.", "Natural Attraction", new TimeSpan(0, 23, 59, 59, 0), "A remote oasis known for its lush palm groves, natural springs, and rich cultural heritage.", 0.0, "https://www.mediterraholidays.com/photos/tour/191/banner.jpg", "Siwa, Egypt", "Siwa Oasis", new TimeSpan(0, 0, 0, 0, 0), (byte)4 });

            migrationBuilder.UpdateData(
                table: "TouristPlaces",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Article", "Category", "CloseAt", "Description", "EntryFee", "ImageUrl", "Location", "Name", "OpenAt", "Rating" },
                values: new object[] { "Luxor Temple was constructed approximately 3,400 years ago during the New Kingdom period and was dedicated to the rejuvenation of kingship.", "Historical Monument", new TimeSpan(0, 21, 0, 0, 0), "A large Ancient Egyptian temple complex located on the east bank of the Nile River, known for its well-preserved structures and grand architecture.", 160.0, "https://i.pinimg.com/originals/fe/b2/e9/feb2e9a88d11b9c4f6520c4d94159377.jpg", "Luxor, Egypt", "Luxor Temple", new TimeSpan(0, 6, 0, 0, 0), (byte)4 });

            migrationBuilder.UpdateData(
                table: "TouristPlaces",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Article", "Category", "Description", "EntryFee", "ImageUrl", "Location", "Name", "Rating" },
                values: new object[] { "This temple is considered one of the incomparable monuments of ancient Egypt, reflecting the grandeur of the pharaoh it was built to honor.", "Historical Monument", "A mortuary temple built for Pharaoh Hatshepsut, showcasing unique terraced architecture set against limestone cliffs.", 140.0, "https://www.egyptpyramidstours.com/wp-content/uploads/2020/05/Temple-of-Queen-Hatshepsut.jpg", "Deir el-Bahari, Luxor, Egypt", "Temple of Hatshepsut", (byte)4 });

            migrationBuilder.InsertData(
                table: "TouristPlaces",
                columns: new[] { "Id", "Article", "Category", "CloseAt", "Description", "EntryFee", "ImageUrl", "Location", "Name", "OpenAt", "Rating" },
                values: new object[,]
                {
                    { 1, "These structures are among the most iconic symbols of ancient Egypt, reflecting advanced engineering and serving as royal tombs.", "Historical Monument", new TimeSpan(0, 17, 0, 0, 0), "The Pyramids of Giza, including the Great Pyramid, are ancient monumental tombs built for pharaohs and stand as a testament to Egypt's historical grandeur.", 200.0, "https://egyptianstreets.com/wp-content/uploads/2012/10/pyramids-with-giza.jpg", "Giza, Egypt", "Pyramids of Giza", new TimeSpan(0, 8, 0, 0, 0), (byte)5 },
                    { 2, "The temple complex showcases impressive columns and sanctuaries, reflecting the grandeur of ancient Egyptian architecture.", "Temple Complex", new TimeSpan(0, 17, 30, 0, 0), "A vast open-air museum and the largest ancient religious site in the world, dedicated to Theban gods.", 150.0, "https://www.expeditions.com/globalassets/expedition-stories/exploring-egypt-5-must-see-sights-at-karnak-temple-complex/karnak-temple-complex-main-image.jpg", "Luxor, Egypt", "Karnak Temple", new TimeSpan(0, 6, 0, 0, 0), (byte)5 },
                    { 3, "This valley contains the tombs of pharaohs and nobles, offering insights into ancient Egyptian beliefs about the afterlife.", "Archaeological Site", new TimeSpan(0, 16, 0, 0, 0), "A royal burial ground for pharaohs, including the tomb of Tutankhamun, adorned with intricate wall paintings.", 240.0, "https://s27363.pcdn.co/wp-content/uploads/2020/01/Valley-of-the-Kings-Overview.jpg.optimal.jpg", "Luxor, Egypt", "Valley of the Kings", new TimeSpan(0, 6, 0, 0, 0), (byte)5 },
                    { 9, "The Philae Temple complex was relocated to Agilkia Island to preserve it from the rising waters of the Nile due to the Aswan High Dam construction.", "Historical Monument", new TimeSpan(0, 16, 0, 0, 0), "An island temple complex dedicated to the goddess Isis, known for its beautiful architecture and scenic location.", 180.0, "https://www.tripsavvy.com/thmb/xpMXo-XFKdCy2a6Rp75kLaXb1rk=/3648x2428/filters:fill(auto,1)/GettyImages-500053303-5c80e80b46e0fb0001a5f168.jpg", "Aswan, Egypt", "Philae Temple", new TimeSpan(0, 7, 0, 0, 0), (byte)4 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TouristPlaces",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TouristPlaces",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TouristPlaces",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TouristPlaces",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.UpdateData(
                table: "TouristPlaces",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Article", "Category", "CloseAt", "Description", "EntryFee", "ImageUrl", "Location", "Name", "OpenAt" },
                values: new object[] { "The Giza pyramid complex includes the Great Pyramid of Giza...", "Ancient Monument", new TimeSpan(0, 17, 0, 0, 0), "Ancient pyramids and the last surviving Wonder of the Ancient World", 200.0, "https://upload.wikimedia.org/wikipedia/commons/a/af/Giza_pyramid_complex_%28edited%29.jpg", "https://www.google.com/maps/place/The+Great+Pyramid+of+Giza/@29.9792345,31.1342019,15z/", "Great Pyramids of Giza", new TimeSpan(0, 8, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "TouristPlaces",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Article", "Category", "CloseAt", "Description", "EntryFee", "ImageUrl", "Location", "Name", "OpenAt" },
                values: new object[] { "Built approximately 1400 BCE, this temple was dedicated to the Theban Triad...", "Archaeological Site", new TimeSpan(0, 22, 0, 0, 0), "Massive Ancient Egyptian temple complex on the east bank of the Nile", 160.0, "https://upload.wikimedia.org/wikipedia/commons/4/49/Luxor_Temple_18.jpg", "https://www.google.com/maps/place/Luxor+Temple/@25.6996147,32.6366406,17z/", "Luxor Temple", new TimeSpan(0, 6, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "TouristPlaces",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Article", "Category", "CloseAt", "Description", "EntryFee", "ImageUrl", "Location", "Name", "OpenAt", "Rating" },
                values: new object[] { "Commissioned by Pharaoh Ramesses II to commemorate his victory...", "Historical Site", new TimeSpan(0, 18, 0, 0, 0), "Twin rock-cut temples dating back to the 13th century BCE", 240.0, "https://upload.wikimedia.org/wikipedia/commons/8/8e/Abu_Simbel_Temple_%288488942077%29.jpg", "https://www.google.com/maps/place/Abu+Simbel+Temples/@22.3369232,31.6254713,17z/", "Abu Simbel Temples", new TimeSpan(0, 5, 0, 0, 0), (byte)5 });

            migrationBuilder.UpdateData(
                table: "TouristPlaces",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Article", "Category", "CloseAt", "Description", "EntryFee", "ImageUrl", "Location", "Name", "OpenAt", "Rating" },
                values: new object[] { "Contains over 120,000 items including the treasures of Tutankhamun...", "Museum", new TimeSpan(0, 17, 0, 0, 0), "Home to the world's most extensive collection of Pharaonic antiquities", 300.0, "https://live.staticflickr.com/65535/53609865504_1c1a8d7c0e_b.jpg", "https://www.google.com/maps/place/The+Egyptian+Museum/@30.0478085,31.2335643,17z/", "The Egyptian Museum", new TimeSpan(0, 9, 0, 0, 0), (byte)5 });

            migrationBuilder.UpdateData(
                table: "TouristPlaces",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Article", "Category", "Description", "EntryFee", "ImageUrl", "Location", "Name", "Rating" },
                values: new object[] { "Contains 63 magnificent royal tombs from the New Kingdom period...", "Archaeological Site", "Ancient burial ground for Egyptian royalty", 240.0, "https://upload.wikimedia.org/wikipedia/commons/4/4a/Valley_of_the_Kings_Overview.jpg", "https://www.google.com/maps/place/Valley+of+the+Kings/@25.7401865,32.6015273,17z/", "Valley of the Kings", (byte)5 });
        }
    }
}
