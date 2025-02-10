using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace dlily_project.Migrations
{
    /// <inheritdoc />
    public partial class sui : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Tourgides",
                columns: new[] { "Id", "Address", "Description", "Email", "Gender", "Name", "Password", "Phone", "Price", "ProfilePicture", "Rating", "SpokenLanguage" },
                values: new object[,]
                {
                    { 1, "10 Karnak Temple Street, Luxor, Luxor Governorate", "Italian-speaking guide", "ahmed.aly@gmail.com", 0, "Ahmed Aly Ahmed", "", "01019273234", 55.0, new byte[0], (byte)3, "Italian" },
                    { 2, "30 Zamalek Street, Cairo, Cairo Governorate", "German-speaking guide", "ahmed.ramadan@gmail.com", 0, "Ahmed Ramadan", "", "01065502465", 52.0, new byte[0], (byte)3, "German" },
                    { 3, "25 Sharia Al Muizz Li-Din Allah, Cairo, Cairo Governorate", "English-speaking tour guide", "amr.fouad@gmail.com", 0, "Amr Fouad", "", "01146146691", 42.0, new byte[0], (byte)5, "English" },
                    { 4, "18 Luxor Temple Street, Luxor, Luxor Governorate", "German-speaking guide", "ibrahim.ghalwash@gmail.com", 0, "Ibrahim Ghalwash", "", "01033823595", 50.0, new byte[0], (byte)4, "German" },
                    { 5, "7 Philae Temple Road, Aswan, Aswan Governorate", "German-speaking guide", "mariam.ali@gmail.com", 1, "Mariam Ali", "", "01065502465", 48.0, new byte[0], (byte)5, "German" },
                    { 6, "20 Al Azhar Street, Islamic Cairo, Cairo Governorate", "Italian-speaking guide", "ahmed.guide@gmail.com", 0, "Ahmed", "", "01104682219", 55.0, new byte[0], (byte)3, "Italian" },
                    { 7, "20 Al Azhar Street, Islamic Cairo, Cairo Governorate", "Speaking English and Japanese", "ebram_melles.guide@gmail.com", 0, "Ebram Melles", "", "01220801758", 55.0, new byte[0], (byte)3, "English" },
                    { 8, "12 Corniche El Nile Street, Aswan, Aswan Governorate", "English & Russian-speaking guide", "mohamed.gomaa@gmail.com", 0, "Mohamed Gomaa", "", "01022510710", 50.0, new byte[0], (byte)5, "English, Russian" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tourgides",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tourgides",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tourgides",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Tourgides",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Tourgides",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Tourgides",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Tourgides",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Tourgides",
                keyColumn: "Id",
                keyValue: 8);
        }
    }
}
