using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace dlily_project.Migrations
{
    /// <inheritdoc />
    public partial class m5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "HomeImage", "OtherImages", "Services" },
                values: new object[] { "https://images.unsplash.com/photo-1618773928121-c32242e63f39", "https://images.unsplash.com/photo-1564501049412-61c2a3083791,https://images.unsplash.com/photo-1566073771259-6a8506099945,https://images.unsplash.com/photo-1618773928121-c32242e63f39,https://images.unsplash.com/photo-1564501049412-61c2a3083791,https://images.unsplash.com/photo-1566073771259-6a8506099945", "Spa,fas fa-spa;Pool,fas fa-swimming-pool;Gym,fas fa-dumbbell;Free Wi-Fi,fas fa-wifi;Restaurant,fas fa-utensils" });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "HomeImage", "OtherImages", "Services" },
                values: new object[] { "https://images.unsplash.com/photo-1549989476-69a92fa57c36", "https://images.unsplash.com/photo-1549989476-69a92fa57c36,https://images.unsplash.com/photo-1549989476-69a92fa57c36,https://images.unsplash.com/photo-1549989476-69a92fa57c36,https://images.unsplash.com/photo-1549989476-69a92fa57c36,https://images.unsplash.com/photo-1549989476-69a92fa57c36", "Beach Access,fas fa-umbrella-beach;Pool,fas fa-swimming-pool;Bar,fas fa-cocktail;Free Wi-Fi,fas fa-wifi;Restaurant,fas fa-utensils" });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "HomeImage", "OtherImages", "Services" },
                values: new object[] { "https://images.unsplash.com/photo-1519681393784-d120267933ba", "https://images.unsplash.com/photo-1519681393784-d120267933ba,https://images.unsplash.com/photo-1519681393784-d120267933ba,https://images.unsplash.com/photo-1519681393784-d120267933ba,https://images.unsplash.com/photo-1519681393784-d120267933ba,https://images.unsplash.com/photo-1519681393784-d120267933ba", "Skiing,fas fa-skiing;Spa,fas fa-spa;Restaurant,fas fa-utensils;Free Wi-Fi,fas fa-wifi" });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "HomeImage", "OtherImages", "Services" },
                values: new object[] { "https://images.unsplash.com/photo-1499856871958-5b9627545d1a", "https://images.unsplash.com/photo-1499856871958-5b9627545d1a,https://images.unsplash.com/photo-1499856871958-5b9627545d1a,https://images.unsplash.com/photo-1499856871958-5b9627545d1a,https://images.unsplash.com/photo-1499856871958-5b9627545d1a,https://images.unsplash.com/photo-1499856871958-5b9627545d1a", "Gym,fas fa-dumbbell;Free Wi-Fi,fas fa-wifi;Restaurant,fas fa-utensils;Conference Rooms,fas fa-users" });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "HomeImage", "OtherImages", "Services" },
                values: new object[] { "https://images.unsplash.com/photo-1518684079-3c830dcef090", "https://images.unsplash.com/photo-1518684079-3c830dcef090,https://images.unsplash.com/photo-1518684079-3c830dcef090,https://images.unsplash.com/photo-1518684079-3c830dcef090,https://images.unsplash.com/photo-1518684079-3c830dcef090,https://images.unsplash.com/photo-1518684079-3c830dcef090", "Pool,fas fa-swimming-pool;Spa,fas fa-spa;Free Wi-Fi,fas fa-wifi;Restaurant,fas fa-utensils;Camel Riding,fas fa-horse" });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BedType", "Facilities", "HotelId", "Images", "OfferPresentage", "OldPrice", "Price", "RoomSize", "RoomType", "Services", "View" },
                values: new object[] { "1 king bed", "Balcony;Air conditioning;Private bathroom;Flat-screen TV;Minibar;Free Wifi", 1, "https://images.unsplash.com/photo-1618773928121-c32242e63f39,https://images.unsplash.com/photo-1564501049412-61c2a3083791,https://images.unsplash.com/photo-1566073771259-6a8506099945", 10, 12000.0, 10000.0, "50 m²", "One Bedroom Apartment", "Free Wifi,fas fa-wifi;Air Conditioning,fas fa-snowflake;Private Bathroom,fas fa-bath;Minibar,fas fa-wine-glass-alt;Flat-screen TV,fas fa-tv", "Sea view" });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BedType", "Days", "Facilities", "Images", "OfferPresentage", "OldPrice", "Price", "RoomDescription", "RoomSize", "RoomType", "Services", "View" },
                values: new object[] { "2 twin beds", 7, "Walk-in closet;Tea/Coffee maker;Kitchenette;Soundproof;Dining area;Washing machine", "https://images.unsplash.com/photo-1549989476-69a92fa57c36,https://images.unsplash.com/photo-1549989476-69a92fa57c36,https://images.unsplash.com/photo-1549989476-69a92fa57c36", 15, 18000.0, 15000.0, "A luxurious apartment with a stunning view and excellent facilities.", "80 m²", "Two-Bedroom Apartment", "Free Wifi,fas fa-wifi;Kitchenette,fas fa-utensils;Jacuzzi,fas fa-hot-tub;Safe,fas fa-lock;Work desk,fas fa-laptop", "Garden view" });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BedType", "Days", "Facilities", "HotelId", "Images", "OfferPresentage", "OldPrice", "Price", "RoomDescription", "RoomSize", "Services", "View" },
                values: new object[] { "1 king bed", 10, "Fireplace;Patio;Flat-screen TV;Safe;Dining area;Dryer", 3, "https://images.unsplash.com/photo-1519681393784-d120267933ba,https://images.unsplash.com/photo-1519681393784-d120267933ba,https://images.unsplash.com/photo-1519681393784-d120267933ba", 20, 30000.0, 25000.0, "A spacious villa with private amenities and breathtaking views.", "120 m²", "Balcony,fas fa-umbrella-beach;Soundproof,fas fa-volume-mute;Fireplace,fas fa-fire;Ironing facilities,fas fa-iron;Sitting area,fas fa-couch", "Mountain view" });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BedType", "Days", "Facilities", "HotelId", "Images", "OfferPresentage", "OldPrice", "Price", "RoomDescription", "RoomSize", "RoomType", "Services", "View" },
                values: new object[] { "1 queen bed", 8, "Flat-screen TV;Tea/Coffee maker;Ironing facilities;Soundproof;Patio;Dryer", 4, "https://images.unsplash.com/photo-1499856871958-5b9627545d1a,https://images.unsplash.com/photo-1499856871958-5b9627545d1a,https://images.unsplash.com/photo-1499856871958-5b9627545d1a", 25, 25000.0, 20000.0, "A deluxe suite with all modern amenities for a comfortable stay.", "70 m²", "Deluxe Suite", "Private Bathroom,fas fa-bath;Minibar,fas fa-wine-glass-alt;Safe,fas fa-lock;Jacuzzi,fas fa-hot-tub;Work desk,fas fa-laptop", "City view" });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BedType", "Days", "Facilities", "HotelId", "Images", "OfferPresentage", "OldPrice", "Price", "RoomDescription", "RoomSize", "RoomType", "Services", "View" },
                values: new object[] { "2 queen beds", 6, "Walk-in closet;Flat-screen TV;Safe;Fireplace;Air conditioning;Washing machine", 5, "https://images.unsplash.com/photo-1518684079-3c830dcef090,https://images.unsplash.com/photo-1518684079-3c830dcef090,https://images.unsplash.com/photo-1518684079-3c830dcef090", 5, 16000.0, 13000.0, "An executive room perfect for business travelers and leisure.", "60 m²", "Executive Room", "Free Wifi,fas fa-wifi;Balcony,fas fa-umbrella-beach;Kitchenette,fas fa-utensils;Dining area,fas fa-utensils;Sitting area,fas fa-couch", "Pool view" });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BedType", "Days", "Facilities", "HotelId", "Images", "OfferPresentage", "OldPrice", "Price", "RoomDescription", "RoomSize", "RoomType", "Services" },
                values: new object[] { "1 king bed", 9, "Balcony;Air conditioning;Private bathroom;Flat-screen TV;Minibar;Free Wifi", 2, "https://images.unsplash.com/photo-1578683010236-d716f9a3f461", 12, 18000.0, 16000.0, "A comfortable room with essential amenities.", "50 m²", "Standard Room", "Free Wifi,fas fa-wifi;Air Conditioning,fas fa-snowflake;Private Bathroom,fas fa-bath;Minibar,fas fa-wine-glass-alt;Flat-screen TV,fas fa-tv" });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BedType", "Days", "Facilities", "Images", "OfferPresentage", "OldPrice", "Price", "RoomDescription", "RoomSize", "RoomType", "Services", "View" },
                values: new object[] { "1 king bed", 10, "Balcony;Air conditioning;Private bathroom;Flat-screen TV;Minibar;Free Wifi", "https://images.unsplash.com/photo-1578683010236-d716f9a3f461", 14, 19000.0, 17000.0, "A comfortable room with essential amenities.", "50 m²", "Standard Room", "Free Wifi,fas fa-wifi;Air Conditioning,fas fa-snowflake;Private Bathroom,fas fa-bath;Minibar,fas fa-wine-glass-alt;Flat-screen TV,fas fa-tv", "City view" });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Days", "Facilities", "HotelId", "Images", "OfferPresentage", "OldPrice", "Price", "RoomDescription", "RoomSize", "RoomType", "Services", "View" },
                values: new object[] { 11, "Balcony;Air conditioning;Private bathroom;Flat-screen TV;Minibar;Free Wifi", 4, "https://images.unsplash.com/photo-1578683010236-d716f9a3f461", 16, 20000.0, 18000.0, "A comfortable room with essential amenities.", "50 m²", "Standard Room", "Free Wifi,fas fa-wifi;Air Conditioning,fas fa-snowflake;Private Bathroom,fas fa-bath;Minibar,fas fa-wine-glass-alt;Flat-screen TV,fas fa-tv", "City view" });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "BedType", "Days", "Facilities", "HotelId", "Images", "OfferPresentage", "OldPrice", "Price", "RoomDescription", "RoomSize", "RoomType", "Services" },
                values: new object[] { "1 king bed", 12, "Balcony;Air conditioning;Private bathroom;Flat-screen TV;Minibar;Free Wifi", 5, "https://images.unsplash.com/photo-1578683010236-d716f9a3f461", 18, 21000.0, 19000.0, "A comfortable room with essential amenities.", "50 m²", "Standard Room", "Free Wifi,fas fa-wifi;Air Conditioning,fas fa-snowflake;Private Bathroom,fas fa-bath;Minibar,fas fa-wine-glass-alt;Flat-screen TV,fas fa-tv" });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "BedType", "Days", "Facilities", "Images", "OfferPresentage", "OldPrice", "Price", "RoomDescription", "RoomSize", "RoomType", "Services", "View" },
                values: new object[] { "1 king bed", 13, "Balcony;Air conditioning;Private bathroom;Flat-screen TV;Minibar;Free Wifi", "https://images.unsplash.com/photo-1578683010236-d716f9a3f461", 20, 22000.0, 20000.0, "A comfortable room with essential amenities.", "50 m²", "Standard Room", "Free Wifi,fas fa-wifi;Air Conditioning,fas fa-snowflake;Private Bathroom,fas fa-bath;Minibar,fas fa-wine-glass-alt;Flat-screen TV,fas fa-tv", "City view" });

            migrationBuilder.InsertData(
                table: "Room",
                columns: new[] { "Id", "BedType", "Days", "Facilities", "HotelId", "Images", "OfferPresentage", "OldPrice", "Price", "RoomDescription", "RoomNumber", "RoomSize", "RoomType", "Services", "View" },
                values: new object[,]
                {
                    { 11, "1 king bed", 14, "Balcony;Air conditioning;Private bathroom;Flat-screen TV;Minibar;Free Wifi", 2, "https://images.unsplash.com/photo-1578683010236-d716f9a3f461", 22, 23000.0, 21000.0, "A comfortable room with essential amenities.", "Room 11", "50 m²", "Standard Room", "Free Wifi,fas fa-wifi;Air Conditioning,fas fa-snowflake;Private Bathroom,fas fa-bath;Minibar,fas fa-wine-glass-alt;Flat-screen TV,fas fa-tv", "City view" },
                    { 12, "1 king bed", 15, "Balcony;Air conditioning;Private bathroom;Flat-screen TV;Minibar;Free Wifi", 3, "https://images.unsplash.com/photo-1578683010236-d716f9a3f461", 24, 24000.0, 22000.0, "A comfortable room with essential amenities.", "Room 12", "50 m²", "Standard Room", "Free Wifi,fas fa-wifi;Air Conditioning,fas fa-snowflake;Private Bathroom,fas fa-bath;Minibar,fas fa-wine-glass-alt;Flat-screen TV,fas fa-tv", "City view" },
                    { 13, "1 king bed", 16, "Balcony;Air conditioning;Private bathroom;Flat-screen TV;Minibar;Free Wifi", 4, "https://images.unsplash.com/photo-1578683010236-d716f9a3f461", 26, 25000.0, 23000.0, "A comfortable room with essential amenities.", "Room 13", "50 m²", "Standard Room", "Free Wifi,fas fa-wifi;Air Conditioning,fas fa-snowflake;Private Bathroom,fas fa-bath;Minibar,fas fa-wine-glass-alt;Flat-screen TV,fas fa-tv", "City view" },
                    { 14, "1 king bed", 17, "Balcony;Air conditioning;Private bathroom;Flat-screen TV;Minibar;Free Wifi", 5, "https://images.unsplash.com/photo-1578683010236-d716f9a3f461", 28, 26000.0, 24000.0, "A comfortable room with essential amenities.", "Room 14", "50 m²", "Standard Room", "Free Wifi,fas fa-wifi;Air Conditioning,fas fa-snowflake;Private Bathroom,fas fa-bath;Minibar,fas fa-wine-glass-alt;Flat-screen TV,fas fa-tv", "City view" },
                    { 15, "1 king bed", 18, "Balcony;Air conditioning;Private bathroom;Flat-screen TV;Minibar;Free Wifi", 1, "https://images.unsplash.com/photo-1578683010236-d716f9a3f461", 30, 27000.0, 25000.0, "A comfortable room with essential amenities.", "Room 15", "50 m²", "Standard Room", "Free Wifi,fas fa-wifi;Air Conditioning,fas fa-snowflake;Private Bathroom,fas fa-bath;Minibar,fas fa-wine-glass-alt;Flat-screen TV,fas fa-tv", "City view" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "HomeImage", "OtherImages", "Services" },
                values: new object[] { "https://images.unsplash.com/photo-1566073771259-6a8506099945?ixlib=rb-1.2.1&auto=format&fit=crop&w=1350&q=80", "https://images.unsplash.com/photo-1564501049412-61c2a3083791?ixlib=rb-1.2.1&auto=format&fit=crop&w=1350&q=80,https://images.unsplash.com/photo-1566073771259-6a8506099945?ixlib=rb-1.2.1&auto=format&fit=crop&w=1350&q=80,https://images.unsplash.com/photo-1564501049412-61c2a3083791?ixlib=rb-1.2.1&auto=format&fit=crop&w=1350&q=80,https://images.unsplash.com/photo-1566073771259-6a8506099945?ixlib=rb-1.2.1&auto=format&fit=crop&w=1350&q=80,https://images.unsplash.com/photo-1564501049412-61c2a3083791?ixlib=rb-1.2.1&auto=format&fit=crop&w=1350&q=80", "Spa, Pool, Gym, Free Wi-Fi, Restaurant" });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "HomeImage", "OtherImages", "Services" },
                values: new object[] { "https://images.unsplash.com/photo-1549989476-69a92fa57c36?ixlib=rb-1.2.1&auto=format&fit=crop&w=1350&q=80", "https://images.unsplash.com/photo-1549989476-69a92fa57c36?ixlib=rb-1.2.1&auto=format&fit=crop&w=1350&q=80,https://images.unsplash.com/photo-1549989476-69a92fa57c36?ixlib=rb-1.2.1&auto=format&fit=crop&w=1350&q=80,https://images.unsplash.com/photo-1549989476-69a92fa57c36?ixlib=rb-1.2.1&auto=format&fit=crop&w=1350&q=80,https://images.unsplash.com/photo-1549989476-69a92fa57c36?ixlib=rb-1.2.1&auto=format&fit=crop&w=1350&q=80,https://images.unsplash.com/photo-1549989476-69a92fa57c36?ixlib=rb-1.2.1&auto=format&fit=crop&w=1350&q=80", "Beach Access, Pool, Bar, Free Wi-Fi, Restaurant" });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "HomeImage", "OtherImages", "Services" },
                values: new object[] { "https://images.unsplash.com/photo-1519681393784-d120267933ba?ixlib=rb-1.2.1&auto=format&fit=crop&w=1350&q=80", "https://images.unsplash.com/photo-1519681393784-d120267933ba?ixlib=rb-1.2.1&auto=format&fit=crop&w=1350&q=80,https://images.unsplash.com/photo-1519681393784-d120267933ba?ixlib=rb-1.2.1&auto=format&fit=crop&w=1350&q=80,https://images.unsplash.com/photo-1519681393784-d120267933ba?ixlib=rb-1.2.1&auto=format&fit=crop&w=1350&q=80,https://images.unsplash.com/photo-1519681393784-d120267933ba?ixlib=rb-1.2.1&auto=format&fit=crop&w=1350&q=80,https://images.unsplash.com/photo-1519681393784-d120267933ba?ixlib=rb-1.2.1&auto=format&fit=crop&w=1350&q=80", "Skiing, Spa, Restaurant, Free Wi-Fi" });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "HomeImage", "OtherImages", "Services" },
                values: new object[] { "https://images.unsplash.com/photo-1499856871958-5b9627545d1a?ixlib=rb-1.2.1&auto=format&fit=crop&w=1350&q=80", "https://images.unsplash.com/photo-1499856871958-5b9627545d1a?ixlib=rb-1.2.1&auto=format&fit=crop&w=1350&q=80,https://images.unsplash.com/photo-1499856871958-5b9627545d1a?ixlib=rb-1.2.1&auto=format&fit=crop&w=1350&q=80,https://images.unsplash.com/photo-1499856871958-5b9627545d1a?ixlib=rb-1.2.1&auto=format&fit=crop&w=1350&q=80,https://images.unsplash.com/photo-1499856871958-5b9627545d1a?ixlib=rb-1.2.1&auto=format&fit=crop&w=1350&q=80,https://images.unsplash.com/photo-1499856871958-5b9627545d1a?ixlib=rb-1.2.1&auto=format&fit=crop&w=1350&q=80", "Gym, Free Wi-Fi, Restaurant, Conference Rooms" });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "HomeImage", "OtherImages", "Services" },
                values: new object[] { "https://images.unsplash.com/photo-1518684079-3c830dcef090?ixlib=rb-1.2.1&auto=format&fit=crop&w=1350&q=80", "https://images.unsplash.com/photo-1518684079-3c830dcef090?ixlib=rb-1.2.1&auto=format&fit=crop&w=1350&q=80,https://images.unsplash.com/photo-1518684079-3c830dcef090?ixlib=rb-1.2.1&auto=format&fit=crop&w=1350&q=80,https://images.unsplash.com/photo-1518684079-3c830dcef090?ixlib=rb-1.2.1&auto=format&fit=crop&w=1350&q=80,https://images.unsplash.com/photo-1518684079-3c830dcef090?ixlib=rb-1.2.1&auto=format&fit=crop&w=1350&q=80,https://images.unsplash.com/photo-1518684079-3c830dcef090?ixlib=rb-1.2.1&auto=format&fit=crop&w=1350&q=80", "Pool, Spa, Free Wi-Fi, Restaurant, Camel Riding" });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BedType", "Facilities", "HotelId", "Images", "OfferPresentage", "OldPrice", "Price", "RoomSize", "RoomType", "Services", "View" },
                values: new object[] { "4 full beds, 1 king bed", "Balcony;Air conditioning;Private bathroom;Flat-screen TV;Minibar;Free Wifi;Soundproof;Safe;Tea/Coffee maker", 4, "https://cf.bstatic.com/xdata/images/hotel/max1024x768/426630869.jpg,https://cf.bstatic.com/xdata/images/hotel/max1024x768/426630853.jpg", 2, 10525.0, 6885.0, "73 m²", "Two-Bedroom Apartment", "Free Wifi;fas fa-wifi;Air Conditioning;fas fa-snowflake;Private Bathroom;fas fa-bath;Minibar;fas fa-wine-glass-alt;Flat-screen TV;fas fa-tv;Balcony;fas fa-umbrella-beach;Soundproof;fas fa-volume-mute;Safe;fas fa-lock;Tea/Coffee maker;fas fa-coffee", "City view" });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BedType", "Days", "Facilities", "Images", "OfferPresentage", "OldPrice", "Price", "RoomDescription", "RoomSize", "RoomType", "Services", "View" },
                values: new object[] { "2 twin beds, 1 king bed", 5, "Balcony;Air conditioning;Private bathroom;Flat-screen TV;Minibar;Free Wifi;Soundproof;Safe;Tea/Coffee maker", "https://cf.bstatic.com/xdata/images/hotel/max1024x768/426630853.jpg,https://cf.bstatic.com/xdata/images/hotel/max1024x768/426630853.jpg", 29, 8494.0, 17586.0, "A spacious and comfortable room with modern amenities.", "41 m²", "One Bedroom Apartment", "Free Wifi;fas fa-wifi;Air Conditioning;fas fa-snowflake;Private Bathroom;fas fa-bath;Minibar;fas fa-wine-glass-alt;Flat-screen TV;fas fa-tv;Balcony;fas fa-umbrella-beach;Soundproof;fas fa-volume-mute;Safe;fas fa-lock;Tea/Coffee maker;fas fa-coffee", "Sea view" });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BedType", "Days", "Facilities", "HotelId", "Images", "OfferPresentage", "OldPrice", "Price", "RoomDescription", "RoomSize", "Services", "View" },
                values: new object[] { "2 twin beds, 1 king bed", 9, "Balcony;Air conditioning;Private bathroom;Flat-screen TV;Minibar;Free Wifi;Soundproof;Safe;Tea/Coffee maker", 1, "https://cf.bstatic.com/xdata/images/hotel/max1024x768/426630845.jpg,https://cf.bstatic.com/xdata/images/hotel/max1024x768/426630845.jpg", 15, 6826.0, 17314.0, "A spacious and comfortable room with modern amenities.", "86 m²", "Free Wifi;fas fa-wifi;Air Conditioning;fas fa-snowflake;Private Bathroom;fas fa-bath;Minibar;fas fa-wine-glass-alt;Flat-screen TV;fas fa-tv;Balcony;fas fa-umbrella-beach;Soundproof;fas fa-volume-mute;Safe;fas fa-lock;Tea/Coffee maker;fas fa-coffee", "Garden view" });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BedType", "Days", "Facilities", "HotelId", "Images", "OfferPresentage", "OldPrice", "Price", "RoomDescription", "RoomSize", "RoomType", "Services", "View" },
                values: new object[] { "1 king bed", 9, "Balcony;Air conditioning;Private bathroom;Flat-screen TV;Minibar;Free Wifi;Soundproof;Safe;Tea/Coffee maker", 1, "https://cf.bstatic.com/xdata/images/hotel/max1024x768/426630873.jpg,https://cf.bstatic.com/xdata/images/hotel/max1024x768/426630869.jpg", 8, 10692.0, 16429.0, "A spacious and comfortable room with modern amenities.", "44 m²", "Stand Alone Villa", "Free Wifi;fas fa-wifi;Air Conditioning;fas fa-snowflake;Private Bathroom;fas fa-bath;Minibar;fas fa-wine-glass-alt;Flat-screen TV;fas fa-tv;Balcony;fas fa-umbrella-beach;Soundproof;fas fa-volume-mute;Safe;fas fa-lock;Tea/Coffee maker;fas fa-coffee", "Garden view" });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BedType", "Days", "Facilities", "HotelId", "Images", "OfferPresentage", "OldPrice", "Price", "RoomDescription", "RoomSize", "RoomType", "Services", "View" },
                values: new object[] { "1 king bed", 5, "Balcony;Air conditioning;Private bathroom;Flat-screen TV;Minibar;Free Wifi;Soundproof;Safe;Tea/Coffee maker", 1, "https://cf.bstatic.com/xdata/images/hotel/max1024x768/426630873.jpg,https://cf.bstatic.com/xdata/images/hotel/max1024x768/426630845.jpg", 19, 22284.0, 10174.0, "A spacious and comfortable room with modern amenities.", "79 m²", "One Bedroom Apartment", "Free Wifi;fas fa-wifi;Air Conditioning;fas fa-snowflake;Private Bathroom;fas fa-bath;Minibar;fas fa-wine-glass-alt;Flat-screen TV;fas fa-tv;Balcony;fas fa-umbrella-beach;Soundproof;fas fa-volume-mute;Safe;fas fa-lock;Tea/Coffee maker;fas fa-coffee", "City view" });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BedType", "Days", "Facilities", "HotelId", "Images", "OfferPresentage", "OldPrice", "Price", "RoomDescription", "RoomSize", "RoomType", "Services" },
                values: new object[] { "4 full beds, 1 king bed", 8, "Balcony;Air conditioning;Private bathroom;Flat-screen TV;Minibar;Free Wifi;Soundproof;Safe;Tea/Coffee maker", 3, "https://cf.bstatic.com/xdata/images/hotel/max1024x768/426630845.jpg,https://cf.bstatic.com/xdata/images/hotel/max1024x768/426630845.jpg", 14, 16024.0, 11026.0, "A spacious and comfortable room with modern amenities.", "56 m²", "One Bedroom Apartment", "Free Wifi;fas fa-wifi;Air Conditioning;fas fa-snowflake;Private Bathroom;fas fa-bath;Minibar;fas fa-wine-glass-alt;Flat-screen TV;fas fa-tv;Balcony;fas fa-umbrella-beach;Soundproof;fas fa-volume-mute;Safe;fas fa-lock;Tea/Coffee maker;fas fa-coffee" });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BedType", "Days", "Facilities", "Images", "OfferPresentage", "OldPrice", "Price", "RoomDescription", "RoomSize", "RoomType", "Services", "View" },
                values: new object[] { "4 full beds, 1 king bed", 1, "Balcony;Air conditioning;Private bathroom;Flat-screen TV;Minibar;Free Wifi;Soundproof;Safe;Tea/Coffee maker", "https://cf.bstatic.com/xdata/images/hotel/max1024x768/426630853.jpg,https://cf.bstatic.com/xdata/images/hotel/max1024x768/426630869.jpg", 16, 23695.0, 14714.0, "A spacious and comfortable room with modern amenities.", "56 m²", "Stand Alone Villa", "Free Wifi;fas fa-wifi;Air Conditioning;fas fa-snowflake;Private Bathroom;fas fa-bath;Minibar;fas fa-wine-glass-alt;Flat-screen TV;fas fa-tv;Balcony;fas fa-umbrella-beach;Soundproof;fas fa-volume-mute;Safe;fas fa-lock;Tea/Coffee maker;fas fa-coffee", "Sea view" });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Days", "Facilities", "HotelId", "Images", "OfferPresentage", "OldPrice", "Price", "RoomDescription", "RoomSize", "RoomType", "Services", "View" },
                values: new object[] { 2, "Balcony;Air conditioning;Private bathroom;Flat-screen TV;Minibar;Free Wifi;Soundproof;Safe;Tea/Coffee maker", 1, "https://cf.bstatic.com/xdata/images/hotel/max1024x768/426630873.jpg,https://cf.bstatic.com/xdata/images/hotel/max1024x768/426630853.jpg", 8, 14133.0, 18429.0, "A spacious and comfortable room with modern amenities.", "30 m²", "Stand Alone Villa", "Free Wifi;fas fa-wifi;Air Conditioning;fas fa-snowflake;Private Bathroom;fas fa-bath;Minibar;fas fa-wine-glass-alt;Flat-screen TV;fas fa-tv;Balcony;fas fa-umbrella-beach;Soundproof;fas fa-volume-mute;Safe;fas fa-lock;Tea/Coffee maker;fas fa-coffee", "Sea view" });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "BedType", "Days", "Facilities", "HotelId", "Images", "OfferPresentage", "OldPrice", "Price", "RoomDescription", "RoomSize", "RoomType", "Services" },
                values: new object[] { "4 full beds, 1 king bed", 9, "Balcony;Air conditioning;Private bathroom;Flat-screen TV;Minibar;Free Wifi;Soundproof;Safe;Tea/Coffee maker", 2, "https://cf.bstatic.com/xdata/images/hotel/max1024x768/426630869.jpg,https://cf.bstatic.com/xdata/images/hotel/max1024x768/426630873.jpg", 25, 24578.0, 10315.0, "A spacious and comfortable room with modern amenities.", "95 m²", "Stand Alone Villa", "Free Wifi;fas fa-wifi;Air Conditioning;fas fa-snowflake;Private Bathroom;fas fa-bath;Minibar;fas fa-wine-glass-alt;Flat-screen TV;fas fa-tv;Balcony;fas fa-umbrella-beach;Soundproof;fas fa-volume-mute;Safe;fas fa-lock;Tea/Coffee maker;fas fa-coffee" });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "BedType", "Days", "Facilities", "Images", "OfferPresentage", "OldPrice", "Price", "RoomDescription", "RoomSize", "RoomType", "Services", "View" },
                values: new object[] { "4 full beds, 1 king bed", 5, "Balcony;Air conditioning;Private bathroom;Flat-screen TV;Minibar;Free Wifi;Soundproof;Safe;Tea/Coffee maker", "https://cf.bstatic.com/xdata/images/hotel/max1024x768/426630853.jpg,https://cf.bstatic.com/xdata/images/hotel/max1024x768/426630845.jpg", 0, 11449.0, 11693.0, "A spacious and comfortable room with modern amenities.", "37 m²", "Stand Alone Villa", "Free Wifi;fas fa-wifi;Air Conditioning;fas fa-snowflake;Private Bathroom;fas fa-bath;Minibar;fas fa-wine-glass-alt;Flat-screen TV;fas fa-tv;Balcony;fas fa-umbrella-beach;Soundproof;fas fa-volume-mute;Safe;fas fa-lock;Tea/Coffee maker;fas fa-coffee", "Garden view" });
        }
    }
}
