using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace dlily_project.Migrations
{
    /// <inheritdoc />
    public partial class addrooms : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Room_Hotels_HotelId",
                table: "Room");

            migrationBuilder.RenameColumn(
                name: "Type",
                table: "Room",
                newName: "View");

            migrationBuilder.RenameColumn(
                name: "Number",
                table: "Room",
                newName: "Services");

            migrationBuilder.AlterColumn<int>(
                name: "HotelId",
                table: "Room",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BedType",
                table: "Room",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Days",
                table: "Room",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Facilities",
                table: "Room",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "OfferPresentage",
                table: "Room",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "OldPrice",
                table: "Room",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "Room",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "RoomDescription",
                table: "Room",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "RoomNumber",
                table: "Room",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "RoomSize",
                table: "Room",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "RoomType",
                table: "Room",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Room",
                columns: new[] { "Id", "BedType", "Days", "Facilities", "HotelId", "Images", "OfferPresentage", "OldPrice", "Price", "RoomDescription", "RoomNumber", "RoomSize", "RoomType", "Services", "View" },
                values: new object[,]
                {
                    { 1, "4 full beds, 1 king bed", 5, "Balcony;Air conditioning;Private bathroom;Flat-screen TV;Minibar;Free Wifi;Soundproof;Safe;Tea/Coffee maker", 4, "https://cf.bstatic.com/xdata/images/hotel/max1024x768/426630869.jpg,https://cf.bstatic.com/xdata/images/hotel/max1024x768/426630853.jpg", 2, 10525.0, 6885.0, "A spacious and comfortable room with modern amenities.", "Room 1", "73 m²", "Two-Bedroom Apartment", "Free Wifi;fas fa-wifi;Air Conditioning;fas fa-snowflake;Private Bathroom;fas fa-bath;Minibar;fas fa-wine-glass-alt;Flat-screen TV;fas fa-tv;Balcony;fas fa-umbrella-beach;Soundproof;fas fa-volume-mute;Safe;fas fa-lock;Tea/Coffee maker;fas fa-coffee", "City view" },
                    { 2, "2 twin beds, 1 king bed", 5, "Balcony;Air conditioning;Private bathroom;Flat-screen TV;Minibar;Free Wifi;Soundproof;Safe;Tea/Coffee maker", 2, "https://cf.bstatic.com/xdata/images/hotel/max1024x768/426630853.jpg,https://cf.bstatic.com/xdata/images/hotel/max1024x768/426630853.jpg", 29, 8494.0, 17586.0, "A spacious and comfortable room with modern amenities.", "Room 2", "41 m²", "One Bedroom Apartment", "Free Wifi;fas fa-wifi;Air Conditioning;fas fa-snowflake;Private Bathroom;fas fa-bath;Minibar;fas fa-wine-glass-alt;Flat-screen TV;fas fa-tv;Balcony;fas fa-umbrella-beach;Soundproof;fas fa-volume-mute;Safe;fas fa-lock;Tea/Coffee maker;fas fa-coffee", "Sea view" },
                    { 3, "2 twin beds, 1 king bed", 9, "Balcony;Air conditioning;Private bathroom;Flat-screen TV;Minibar;Free Wifi;Soundproof;Safe;Tea/Coffee maker", 1, "https://cf.bstatic.com/xdata/images/hotel/max1024x768/426630845.jpg,https://cf.bstatic.com/xdata/images/hotel/max1024x768/426630845.jpg", 15, 6826.0, 17314.0, "A spacious and comfortable room with modern amenities.", "Room 3", "86 m²", "Stand Alone Villa", "Free Wifi;fas fa-wifi;Air Conditioning;fas fa-snowflake;Private Bathroom;fas fa-bath;Minibar;fas fa-wine-glass-alt;Flat-screen TV;fas fa-tv;Balcony;fas fa-umbrella-beach;Soundproof;fas fa-volume-mute;Safe;fas fa-lock;Tea/Coffee maker;fas fa-coffee", "Garden view" },
                    { 4, "1 king bed", 9, "Balcony;Air conditioning;Private bathroom;Flat-screen TV;Minibar;Free Wifi;Soundproof;Safe;Tea/Coffee maker", 1, "https://cf.bstatic.com/xdata/images/hotel/max1024x768/426630873.jpg,https://cf.bstatic.com/xdata/images/hotel/max1024x768/426630869.jpg", 8, 10692.0, 16429.0, "A spacious and comfortable room with modern amenities.", "Room 4", "44 m²", "Stand Alone Villa", "Free Wifi;fas fa-wifi;Air Conditioning;fas fa-snowflake;Private Bathroom;fas fa-bath;Minibar;fas fa-wine-glass-alt;Flat-screen TV;fas fa-tv;Balcony;fas fa-umbrella-beach;Soundproof;fas fa-volume-mute;Safe;fas fa-lock;Tea/Coffee maker;fas fa-coffee", "Garden view" },
                    { 5, "1 king bed", 5, "Balcony;Air conditioning;Private bathroom;Flat-screen TV;Minibar;Free Wifi;Soundproof;Safe;Tea/Coffee maker", 1, "https://cf.bstatic.com/xdata/images/hotel/max1024x768/426630873.jpg,https://cf.bstatic.com/xdata/images/hotel/max1024x768/426630845.jpg", 19, 22284.0, 10174.0, "A spacious and comfortable room with modern amenities.", "Room 5", "79 m²", "One Bedroom Apartment", "Free Wifi;fas fa-wifi;Air Conditioning;fas fa-snowflake;Private Bathroom;fas fa-bath;Minibar;fas fa-wine-glass-alt;Flat-screen TV;fas fa-tv;Balcony;fas fa-umbrella-beach;Soundproof;fas fa-volume-mute;Safe;fas fa-lock;Tea/Coffee maker;fas fa-coffee", "City view" },
                    { 6, "4 full beds, 1 king bed", 8, "Balcony;Air conditioning;Private bathroom;Flat-screen TV;Minibar;Free Wifi;Soundproof;Safe;Tea/Coffee maker", 3, "https://cf.bstatic.com/xdata/images/hotel/max1024x768/426630845.jpg,https://cf.bstatic.com/xdata/images/hotel/max1024x768/426630845.jpg", 14, 16024.0, 11026.0, "A spacious and comfortable room with modern amenities.", "Room 6", "56 m²", "One Bedroom Apartment", "Free Wifi;fas fa-wifi;Air Conditioning;fas fa-snowflake;Private Bathroom;fas fa-bath;Minibar;fas fa-wine-glass-alt;Flat-screen TV;fas fa-tv;Balcony;fas fa-umbrella-beach;Soundproof;fas fa-volume-mute;Safe;fas fa-lock;Tea/Coffee maker;fas fa-coffee", "City view" },
                    { 7, "4 full beds, 1 king bed", 1, "Balcony;Air conditioning;Private bathroom;Flat-screen TV;Minibar;Free Wifi;Soundproof;Safe;Tea/Coffee maker", 3, "https://cf.bstatic.com/xdata/images/hotel/max1024x768/426630853.jpg,https://cf.bstatic.com/xdata/images/hotel/max1024x768/426630869.jpg", 16, 23695.0, 14714.0, "A spacious and comfortable room with modern amenities.", "Room 7", "56 m²", "Stand Alone Villa", "Free Wifi;fas fa-wifi;Air Conditioning;fas fa-snowflake;Private Bathroom;fas fa-bath;Minibar;fas fa-wine-glass-alt;Flat-screen TV;fas fa-tv;Balcony;fas fa-umbrella-beach;Soundproof;fas fa-volume-mute;Safe;fas fa-lock;Tea/Coffee maker;fas fa-coffee", "Sea view" },
                    { 8, "1 king bed", 2, "Balcony;Air conditioning;Private bathroom;Flat-screen TV;Minibar;Free Wifi;Soundproof;Safe;Tea/Coffee maker", 1, "https://cf.bstatic.com/xdata/images/hotel/max1024x768/426630873.jpg,https://cf.bstatic.com/xdata/images/hotel/max1024x768/426630853.jpg", 8, 14133.0, 18429.0, "A spacious and comfortable room with modern amenities.", "Room 8", "30 m²", "Stand Alone Villa", "Free Wifi;fas fa-wifi;Air Conditioning;fas fa-snowflake;Private Bathroom;fas fa-bath;Minibar;fas fa-wine-glass-alt;Flat-screen TV;fas fa-tv;Balcony;fas fa-umbrella-beach;Soundproof;fas fa-volume-mute;Safe;fas fa-lock;Tea/Coffee maker;fas fa-coffee", "Sea view" },
                    { 9, "4 full beds, 1 king bed", 9, "Balcony;Air conditioning;Private bathroom;Flat-screen TV;Minibar;Free Wifi;Soundproof;Safe;Tea/Coffee maker", 2, "https://cf.bstatic.com/xdata/images/hotel/max1024x768/426630869.jpg,https://cf.bstatic.com/xdata/images/hotel/max1024x768/426630873.jpg", 25, 24578.0, 10315.0, "A spacious and comfortable room with modern amenities.", "Room 9", "95 m²", "Stand Alone Villa", "Free Wifi;fas fa-wifi;Air Conditioning;fas fa-snowflake;Private Bathroom;fas fa-bath;Minibar;fas fa-wine-glass-alt;Flat-screen TV;fas fa-tv;Balcony;fas fa-umbrella-beach;Soundproof;fas fa-volume-mute;Safe;fas fa-lock;Tea/Coffee maker;fas fa-coffee", "City view" },
                    { 10, "4 full beds, 1 king bed", 5, "Balcony;Air conditioning;Private bathroom;Flat-screen TV;Minibar;Free Wifi;Soundproof;Safe;Tea/Coffee maker", 1, "https://cf.bstatic.com/xdata/images/hotel/max1024x768/426630853.jpg,https://cf.bstatic.com/xdata/images/hotel/max1024x768/426630845.jpg", 0, 11449.0, 11693.0, "A spacious and comfortable room with modern amenities.", "Room 10", "37 m²", "Stand Alone Villa", "Free Wifi;fas fa-wifi;Air Conditioning;fas fa-snowflake;Private Bathroom;fas fa-bath;Minibar;fas fa-wine-glass-alt;Flat-screen TV;fas fa-tv;Balcony;fas fa-umbrella-beach;Soundproof;fas fa-volume-mute;Safe;fas fa-lock;Tea/Coffee maker;fas fa-coffee", "Garden view" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Room_Hotels_HotelId",
                table: "Room",
                column: "HotelId",
                principalTable: "Hotels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Room_Hotels_HotelId",
                table: "Room");

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DropColumn(
                name: "BedType",
                table: "Room");

            migrationBuilder.DropColumn(
                name: "Days",
                table: "Room");

            migrationBuilder.DropColumn(
                name: "Facilities",
                table: "Room");

            migrationBuilder.DropColumn(
                name: "OfferPresentage",
                table: "Room");

            migrationBuilder.DropColumn(
                name: "OldPrice",
                table: "Room");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Room");

            migrationBuilder.DropColumn(
                name: "RoomDescription",
                table: "Room");

            migrationBuilder.DropColumn(
                name: "RoomNumber",
                table: "Room");

            migrationBuilder.DropColumn(
                name: "RoomSize",
                table: "Room");

            migrationBuilder.DropColumn(
                name: "RoomType",
                table: "Room");

            migrationBuilder.RenameColumn(
                name: "View",
                table: "Room",
                newName: "Type");

            migrationBuilder.RenameColumn(
                name: "Services",
                table: "Room",
                newName: "Number");

            migrationBuilder.AlterColumn<int>(
                name: "HotelId",
                table: "Room",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Room_Hotels_HotelId",
                table: "Room",
                column: "HotelId",
                principalTable: "Hotels",
                principalColumn: "Id");
        }
    }
}
