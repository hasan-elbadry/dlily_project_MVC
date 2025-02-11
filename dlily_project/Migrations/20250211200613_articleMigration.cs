using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dlily_project.Migrations
{
    /// <inheritdoc />
    public partial class articleMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Article",
                table: "TouristPlaces",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Article",
                table: "TouristPlaces");
        }
    }
}
