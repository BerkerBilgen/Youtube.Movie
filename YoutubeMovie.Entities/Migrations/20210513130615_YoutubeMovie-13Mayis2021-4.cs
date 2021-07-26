using Microsoft.EntityFrameworkCore.Migrations;

namespace YoutubeMovie.Entities.Migrations
{
    public partial class YoutubeMovie13Mayis20214 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SortOrder",
                table: "Category",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SortOrder",
                table: "Category");
        }
    }
}
