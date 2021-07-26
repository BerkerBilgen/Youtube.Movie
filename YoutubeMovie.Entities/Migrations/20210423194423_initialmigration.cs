using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace YoutubeMovie.Entities.Migrations
{
    public partial class initialmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Category_DbBaseEntity_BaseEntityId",
                table: "Category");

            migrationBuilder.DropForeignKey(
                name: "FK_Category_DbBaseEntity_Id",
                table: "Category");

            migrationBuilder.DropForeignKey(
                name: "FK_Comment_DbBaseEntity_Id",
                table: "Comment");

            migrationBuilder.DropForeignKey(
                name: "FK_Slider_DbBaseEntity_BaseEntityId",
                table: "Slider");

            migrationBuilder.DropForeignKey(
                name: "FK_Slider_DbBaseEntity_Id",
                table: "Slider");

            migrationBuilder.DropForeignKey(
                name: "FK_User_DbBaseEntity_BaseEntityId",
                table: "User");

            migrationBuilder.DropForeignKey(
                name: "FK_User_DbBaseEntity_Id",
                table: "User");

            migrationBuilder.DropForeignKey(
                name: "FK_Video_DbBaseEntity_BaseEntityId",
                table: "Video");

            migrationBuilder.DropForeignKey(
                name: "FK_Video_DbBaseEntity_Id",
                table: "Video");

            migrationBuilder.DropTable(
                name: "DbBaseEntity");

            migrationBuilder.DropIndex(
                name: "IX_Video_BaseEntityId",
                table: "Video");

            migrationBuilder.DropIndex(
                name: "IX_User_BaseEntityId",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_Slider_BaseEntityId",
                table: "Slider");

            migrationBuilder.DropIndex(
                name: "IX_Category_BaseEntityId",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "BaseEntityId",
                table: "Video");

            migrationBuilder.DropColumn(
                name: "BaseEntityId",
                table: "User");

            migrationBuilder.DropColumn(
                name: "BaseEntityId",
                table: "Slider");

            migrationBuilder.DropColumn(
                name: "BaseEntityId",
                table: "Category");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "Video",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreateUserId",
                table: "Video",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedTime",
                table: "Video",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "User",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreateUserId",
                table: "User",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedTime",
                table: "User",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "Slider",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreateUserId",
                table: "Slider",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedTime",
                table: "Slider",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "Comment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreateUserId",
                table: "Comment",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedTime",
                table: "Comment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "Category",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreateUserId",
                table: "Category",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedTime",
                table: "Category",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "Video");

            migrationBuilder.DropColumn(
                name: "CreateUserId",
                table: "Video");

            migrationBuilder.DropColumn(
                name: "ModifiedTime",
                table: "Video");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "User");

            migrationBuilder.DropColumn(
                name: "CreateUserId",
                table: "User");

            migrationBuilder.DropColumn(
                name: "ModifiedTime",
                table: "User");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "Slider");

            migrationBuilder.DropColumn(
                name: "CreateUserId",
                table: "Slider");

            migrationBuilder.DropColumn(
                name: "ModifiedTime",
                table: "Slider");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "Comment");

            migrationBuilder.DropColumn(
                name: "CreateUserId",
                table: "Comment");

            migrationBuilder.DropColumn(
                name: "ModifiedTime",
                table: "Comment");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "CreateUserId",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "ModifiedTime",
                table: "Category");

            migrationBuilder.AddColumn<Guid>(
                name: "BaseEntityId",
                table: "Video",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BaseEntityId",
                table: "User",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BaseEntityId",
                table: "Slider",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BaseEntityId",
                table: "Category",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "DbBaseEntity",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DbBaseEntity", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Video_BaseEntityId",
                table: "Video",
                column: "BaseEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_User_BaseEntityId",
                table: "User",
                column: "BaseEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_Slider_BaseEntityId",
                table: "Slider",
                column: "BaseEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_Category_BaseEntityId",
                table: "Category",
                column: "BaseEntityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Category_DbBaseEntity_BaseEntityId",
                table: "Category",
                column: "BaseEntityId",
                principalTable: "DbBaseEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Category_DbBaseEntity_Id",
                table: "Category",
                column: "Id",
                principalTable: "DbBaseEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_DbBaseEntity_Id",
                table: "Comment",
                column: "Id",
                principalTable: "DbBaseEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Slider_DbBaseEntity_BaseEntityId",
                table: "Slider",
                column: "BaseEntityId",
                principalTable: "DbBaseEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Slider_DbBaseEntity_Id",
                table: "Slider",
                column: "Id",
                principalTable: "DbBaseEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_User_DbBaseEntity_BaseEntityId",
                table: "User",
                column: "BaseEntityId",
                principalTable: "DbBaseEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_User_DbBaseEntity_Id",
                table: "User",
                column: "Id",
                principalTable: "DbBaseEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Video_DbBaseEntity_BaseEntityId",
                table: "Video",
                column: "BaseEntityId",
                principalTable: "DbBaseEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Video_DbBaseEntity_Id",
                table: "Video",
                column: "Id",
                principalTable: "DbBaseEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
