using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace dlily_project.Migrations
{
    /// <inheritdoc />
    public partial class AddEgyptianTouristPlaces : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TouristPlaces",
                columns: new[] { "Id", "Article", "Category", "CloseAt", "Description", "EntryFee", "ImageUrl", "Location", "Name", "OpenAt", "Rating" },
                values: new object[,]
                {
                    { 4, "The Giza pyramid complex includes the Great Pyramid of Giza...", "Ancient Monument", new TimeSpan(0, 17, 0, 0, 0), "Ancient pyramids and the last surviving Wonder of the Ancient World", 200.0, "https://upload.wikimedia.org/wikipedia/commons/a/af/Giza_pyramid_complex_%28edited%29.jpg", "https://www.google.com/maps/place/The+Great+Pyramid+of+Giza/@29.9792345,31.1342019,15z/", "Great Pyramids of Giza", new TimeSpan(0, 8, 0, 0, 0), (byte)5 },
                    { 5, "Built approximately 1400 BCE, this temple was dedicated to the Theban Triad...", "Archaeological Site", new TimeSpan(0, 22, 0, 0, 0), "Massive Ancient Egyptian temple complex on the east bank of the Nile", 160.0, "https://upload.wikimedia.org/wikipedia/commons/4/49/Luxor_Temple_18.jpg", "https://www.google.com/maps/place/Luxor+Temple/@25.6996147,32.6366406,17z/", "Luxor Temple", new TimeSpan(0, 6, 0, 0, 0), (byte)5 },
                    { 6, "Commissioned by Pharaoh Ramesses II to commemorate his victory...", "Historical Site", new TimeSpan(0, 18, 0, 0, 0), "Twin rock-cut temples dating back to the 13th century BCE", 240.0, "https://upload.wikimedia.org/wikipedia/commons/8/8e/Abu_Simbel_Temple_%288488942077%29.jpg", "https://www.google.com/maps/place/Abu+Simbel+Temples/@22.3369232,31.6254713,17z/", "Abu Simbel Temples", new TimeSpan(0, 5, 0, 0, 0), (byte)5 },
                    { 7, "Contains over 120,000 items including the treasures of Tutankhamun...", "Museum", new TimeSpan(0, 17, 0, 0, 0), "Home to the world's most extensive collection of Pharaonic antiquities", 300.0, "https://live.staticflickr.com/65535/53609865504_1c1a8d7c0e_b.jpg", "https://www.google.com/maps/place/The+Egyptian+Museum/@30.0478085,31.2335643,17z/", "The Egyptian Museum", new TimeSpan(0, 9, 0, 0, 0), (byte)5 },
                    { 8, "Contains 63 magnificent royal tombs from the New Kingdom period...", "Archaeological Site", new TimeSpan(0, 17, 0, 0, 0), "Ancient burial ground for Egyptian royalty", 240.0, "https://upload.wikimedia.org/wikipedia/commons/4/4a/Valley_of_the_Kings_Overview.jpg", "https://www.google.com/maps/place/Valley+of+the+Kings/@25.7401865,32.6015273,17z/", "Valley of the Kings", new TimeSpan(0, 6, 0, 0, 0), (byte)5 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TouristPlaces",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TouristPlaces",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "TouristPlaces",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "TouristPlaces",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "TouristPlaces",
                keyColumn: "Id",
                keyValue: 8);
        }
    }
}
