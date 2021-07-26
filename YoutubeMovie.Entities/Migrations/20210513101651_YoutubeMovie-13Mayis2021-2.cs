using Microsoft.EntityFrameworkCore.Migrations;

namespace YoutubeMovie.Entities.Migrations
{
    public partial class YoutubeMovie13Mayis20212 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "ShowMainPage",
                table: "Category",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ShowMainPage",
                table: "Category");
        }
    }
}
