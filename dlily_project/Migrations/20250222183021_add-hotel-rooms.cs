using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dlily_project.Migrations
{
    /// <inheritdoc />
    public partial class addhotelrooms : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "HomeImage", "OtherImages" },
                values: new object[] { "https://www.hilton.com/im/en/CAIRHTW/16763081/exterior-night-shot.jpg?impolicy=crop&cw=5000&ch=2799&gravity=NorthWest&xposition=0&yposition=267&rw=768&rh=430", "https://www.hilton.com/im/en/CAIRHTW/11151445/ramses-hilton-swimming-pool-day.jpg?impolicy=crop&cw=5606&ch=3138&gravity=NorthWest&xposition=0&yposition=265&rw=768&rh=430,https://www.hilton.com/im/en/CAIRHTW/15957512/ramses-hilton-terrace-cafe-day.jpg?impolicy=crop&cw=4800&ch=2688&gravity=NorthWest&xposition=99&yposition=0&rw=768&rh=430,https://www.hilton.com/im/en/CAIRHTW/17407096/0pia8214.jpg?impolicy=crop&cw=5000&ch=2799&gravity=NorthWest&xposition=0&yposition=266&rw=768&rh=430,https://www.hilton.com/im/en/CAIRHTW/5072255/cairh-fitness-center-.jpg?impolicy=crop&cw=4827&ch=2702&gravity=NorthWest&xposition=0&yposition=257&rw=768&rh=430,https://www.hilton.com/im/en/CAIRHTW/21832862/ballroom-wedding.jpg?impolicy=crop&cw=5000&ch=2799&gravity=NorthWest&xposition=0&yposition=267&rw=768&rh=430" });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "HomeImage", "OtherImages" },
                values: new object[] { "https://cache.marriott.com/content/dam/marriott-renditions/CAIMD/caimd-exterior-9993-hor-wide.jpg?output-quality=70&interpolation=progressive-bilinear&downsize=375px:*", "https://cache.marriott.com/content/dam/marriott-renditions/CAIMD/caimd-restaurant-2202-hor-wide.jpg?output-quality=70&interpolation=progressive-bilinear&downsize=750px:*,https://cache.marriott.com/content/dam/marriott-renditions/CAIMD/caimd-restaurant-2206-hor-wide.jpg?output-quality=70&interpolation=progressive-bilinear&downsize=375px:*,https://cache.marriott.com/content/dam/marriott-renditions/CAIMD/caimd-club-8312-hor-wide.jpg?output-quality=70&interpolation=progressive-bilinear&downsize=375px:*,https://cache.marriott.com/content/dam/marriott-renditions/CAIMD/caimd-pool-2215-hor-wide.jpg?output-quality=70&interpolation=progressive-bilinear&downsize=750px:*,https://cache.marriott.com/content/dam/marriott-renditions/CAIMD/caimd-spa-8322-hor-wide.jpg?output-quality=70&interpolation=progressive-bilinear&downsize=750px:*" });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "HomeImage", "OtherImages" },
                values: new object[] { "https://tse2.mm.bing.net/th?id=OIP.N0Zg8i_R2qUOwblYRgrMDQHaE8&pid=Api", "https://www.fourseasons.com/alt/img-opt/~80.1860.0,0000-119,5189-3000,0000-1687,5000/publish/content/dam/fourseasons/images/web/CAI/CAI_1271_original.jpg,https://www.fourseasons.com/alt/img-opt/~80.1860.0,0000-208,6785-3000,0000-1687,5000/publish/content/dam/fourseasons/images/web/CAI/CAI_1257_original.jpg,https://www.fourseasons.com/alt/img-opt/~80.1860.0,0000-0,0000-3840,0000-2160,0000/publish/content/dam/fourseasons/images/web/CAI/CAI_463_3840x2160.jpg,https://www.fourseasons.com/alt/img-opt/~80.1860.0,0000-312,5000-3000,0000-1687,5000/publish/content/dam/fourseasons/images/web/CAI/CAI_206_original.jpg,https://www.fourseasons.com/alt/img-opt/~80.1860.0,0000-550,0104-1378,0000-775,1250/publish/content/dam/fourseasons/images/web/CAI/CAI_464_original.jpg" });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "HomeImage", "OtherImages" },
                values: new object[] { "https://jewelhotels.net/uploads/0000/22/2022/01/03/279280588.jpg", "https://jewelhotels.net/uploads/0000/22/2022/01/03/dsc-2799.JPG,https://jewelhotels.net/uploads/0000/22/2022/01/03/279280496.jpg,https://jewelhotels.net/uploads/0000/22/2022/01/03/279280534.jpg,https://jewelhotels.net/uploads/0000/22/2022/01/03/279280513.jpg,https://jewelhotels.net/uploads/0000/22/2022/01/03/2792805311.jpg" });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "HomeImage", "OtherImages" },
                values: new object[] { "https://www.rehanaplazahotel.com/sites/rehanaplazahotel/files/photos/30.jpg", "https://www.rehanaplazahotel.com/includes/image.php?image=./sites/rehanaplazahotel/files/photos/4.jpg&nwidth=350&imgq=70,https://www.rehanaplazahotel.com/includes/image.php?image=./sites/rehanaplazahotel/files/photos/3.jpg&nwidth=350&imgq=70,https://www.rehanaplazahotel.com/includes/image.php?image=./sites/rehanaplazahotel/files/photos/48.jpg&nwidth=350&imgq=70,https://www.rehanaplazahotel.com/includes/image.php?image=./sites/rehanaplazahotel/files/photos/35.jpg&nwidth=350&imgq=70,https://www.rehanaplazahotel.com/includes/image.php?image=./sites/rehanaplazahotel/files/photos/106.jpg&nwidth=350&imgq=70" });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 2,
                column: "Images",
                value: "https://images.unsplash.com/photo-1618773928121-c32242e63f39,https://images.unsplash.com/photo-1564501049412-61c2a3083791,https://images.unsplash.com/photo-1566073771259-6a8506099945");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "HomeImage", "OtherImages" },
                values: new object[] { "https://images.unsplash.com/photo-1618773928121-c32242e63f39", "https://images.unsplash.com/photo-1564501049412-61c2a3083791,https://images.unsplash.com/photo-1566073771259-6a8506099945,https://images.unsplash.com/photo-1618773928121-c32242e63f39,https://images.unsplash.com/photo-1564501049412-61c2a3083791,https://images.unsplash.com/photo-1566073771259-6a8506099945" });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "HomeImage", "OtherImages" },
                values: new object[] { "https://images.unsplash.com/photo-1549989476-69a92fa57c36", "https://images.unsplash.com/photo-1549989476-69a92fa57c36,https://images.unsplash.com/photo-1549989476-69a92fa57c36,https://images.unsplash.com/photo-1549989476-69a92fa57c36,https://images.unsplash.com/photo-1549989476-69a92fa57c36,https://images.unsplash.com/photo-1549989476-69a92fa57c36" });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "HomeImage", "OtherImages" },
                values: new object[] { "https://images.unsplash.com/photo-1519681393784-d120267933ba", "https://images.unsplash.com/photo-1519681393784-d120267933ba,https://images.unsplash.com/photo-1519681393784-d120267933ba,https://images.unsplash.com/photo-1519681393784-d120267933ba,https://images.unsplash.com/photo-1519681393784-d120267933ba,https://images.unsplash.com/photo-1519681393784-d120267933ba" });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "HomeImage", "OtherImages" },
                values: new object[] { "https://images.unsplash.com/photo-1499856871958-5b9627545d1a", "https://images.unsplash.com/photo-1499856871958-5b9627545d1a,https://images.unsplash.com/photo-1499856871958-5b9627545d1a,https://images.unsplash.com/photo-1499856871958-5b9627545d1a,https://images.unsplash.com/photo-1499856871958-5b9627545d1a,https://images.unsplash.com/photo-1499856871958-5b9627545d1a" });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "HomeImage", "OtherImages" },
                values: new object[] { "https://images.unsplash.com/photo-1518684079-3c830dcef090", "https://images.unsplash.com/photo-1518684079-3c830dcef090,https://images.unsplash.com/photo-1518684079-3c830dcef090,https://images.unsplash.com/photo-1518684079-3c830dcef090,https://images.unsplash.com/photo-1518684079-3c830dcef090,https://images.unsplash.com/photo-1518684079-3c830dcef090" });

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "Id",
                keyValue: 2,
                column: "Images",
                value: "https://images.unsplash.com/photo-1549989476-69a92fa57c36,https://images.unsplash.com/photo-1549989476-69a92fa57c36,https://images.unsplash.com/photo-1549989476-69a92fa57c36");
        }
    }
}
