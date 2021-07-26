using Microsoft.EntityFrameworkCore.Migrations;

namespace YoutubeMovie.Entities.Migrations
{
    public partial class YoutubeMovie16Mayis20211 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AlternativePosterLowQuality",
                table: "Video",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BannerLowQuality",
                table: "Video",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PosterLowQuality",
                table: "Video",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AlternativePosterLowQuality",
                table: "Video");

            migrationBuilder.DropColumn(
                name: "BannerLowQuality",
                table: "Video");

            migrationBuilder.DropColumn(
                name: "PosterLowQuality",
                table: "Video");
        }
    }
}
