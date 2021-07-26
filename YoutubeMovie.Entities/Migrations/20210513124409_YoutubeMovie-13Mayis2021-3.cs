using Microsoft.EntityFrameworkCore.Migrations;

namespace YoutubeMovie.Entities.Migrations
{
    public partial class YoutubeMovie13Mayis20213 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ExtraClass",
                table: "Category",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExtraClass",
                table: "Category");
        }
    }
}
