using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dlily_project.Migrations
{
    /// <inheritdoc />
    public partial class addfeedback : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FeedBack",
                table: "Tourists",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FeedBack",
                table: "Tourgides",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Tourgides",
                keyColumn: "Id",
                keyValue: 1,
                column: "FeedBack",
                value: "");

            migrationBuilder.UpdateData(
                table: "Tourgides",
                keyColumn: "Id",
                keyValue: 2,
                column: "FeedBack",
                value: "");

            migrationBuilder.UpdateData(
                table: "Tourgides",
                keyColumn: "Id",
                keyValue: 3,
                column: "FeedBack",
                value: "");

            migrationBuilder.UpdateData(
                table: "Tourgides",
                keyColumn: "Id",
                keyValue: 4,
                column: "FeedBack",
                value: "");

            migrationBuilder.UpdateData(
                table: "Tourgides",
                keyColumn: "Id",
                keyValue: 5,
                column: "FeedBack",
                value: "");

            migrationBuilder.UpdateData(
                table: "Tourgides",
                keyColumn: "Id",
                keyValue: 6,
                column: "FeedBack",
                value: "");

            migrationBuilder.UpdateData(
                table: "Tourgides",
                keyColumn: "Id",
                keyValue: 7,
                column: "FeedBack",
                value: "");

            migrationBuilder.UpdateData(
                table: "Tourgides",
                keyColumn: "Id",
                keyValue: 8,
                column: "FeedBack",
                value: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FeedBack",
                table: "Tourists");

            migrationBuilder.DropColumn(
                name: "FeedBack",
                table: "Tourgides");
        }
    }
}
