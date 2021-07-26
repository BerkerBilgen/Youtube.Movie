using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace YoutubeMovie.Entities.Migrations
{
    public partial class YoutubeMovie10Mayis20211 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "CategoryId",
                table: "Video",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "VideoCategory",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VideoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VideoCategory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VideoCategory_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VideoCategory_Video_VideoId",
                        column: x => x.VideoId,
                        principalTable: "Video",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Video_CategoryId",
                table: "Video",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_VideoCategory_CategoryId",
                table: "VideoCategory",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_VideoCategory_VideoId",
                table: "VideoCategory",
                column: "VideoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Video_Category_CategoryId",
                table: "Video",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Video_Category_CategoryId",
                table: "Video");

            migrationBuilder.DropTable(
                name: "VideoCategory");

            migrationBuilder.DropIndex(
                name: "IX_Video_CategoryId",
                table: "Video");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Video");
        }
    }
}
