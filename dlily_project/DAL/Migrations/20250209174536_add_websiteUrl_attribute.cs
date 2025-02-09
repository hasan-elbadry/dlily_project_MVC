using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dlily_project.Migrations
{
    /// <inheritdoc />
    public partial class add_websiteUrl_attribute : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "WebSiteUrl",
                table: "HotelOffers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "WebSiteUrl",
                table: "CompanyOffers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "WebSiteUrl",
                table: "HotelOffers");

            migrationBuilder.DropColumn(
                name: "WebSiteUrl",
                table: "CompanyOffers");
        }
    }
}
