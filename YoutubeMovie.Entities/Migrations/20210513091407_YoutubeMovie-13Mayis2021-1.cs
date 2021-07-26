using Microsoft.EntityFrameworkCore.Migrations;

namespace YoutubeMovie.Entities.Migrations
{
    public partial class YoutubeMovie13Mayis20211 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ColumnCount",
                table: "Category",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "ShowCategoryMenu",
                table: "Category",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ColumnCount",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "ShowCategoryMenu",
                table: "Category");
        }
    }
}
