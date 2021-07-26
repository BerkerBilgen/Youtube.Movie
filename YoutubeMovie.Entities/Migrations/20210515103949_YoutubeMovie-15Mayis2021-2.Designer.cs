﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using YoutubeMovie.Entities.Data;

namespace YoutubeMovie.Entities.Migrations
{
    [DbContext(typeof(MovieContext))]
    [Migration("20210515103949_YoutubeMovie-15Mayis2021-2")]
    partial class YoutubeMovie15Mayis20212
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("YoutubeMovie.Entities.Models.Admin", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CreateUserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Admin");
                });

            modelBuilder.Entity("YoutubeMovie.Entities.Models.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("ColumnCount")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CreateUserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ExtraClass")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("ShowCategoryMenu")
                        .HasColumnType("bit");

                    b.Property<bool>("ShowMainPage")
                        .HasColumnType("bit");

                    b.Property<int>("SortOrder")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("YoutubeMovie.Entities.Models.Comment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CommentDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CreateUserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("ModifiedTime")
                        .HasColumnType("datetime2");

                    b.Property<short>("Status")
                        .HasColumnType("smallint");

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Comment");
                });

            modelBuilder.Entity("YoutubeMovie.Entities.Models.Slider", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CreateUserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("ModifiedTime")
                        .HasColumnType("datetime2");

                    b.Property<short>("Status")
                        .HasColumnType("smallint");

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Slider");
                });

            modelBuilder.Entity("YoutubeMovie.Entities.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CreateUserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<short>("Status")
                        .HasColumnType("smallint");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("YoutubeMovie.Entities.Models.Video", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AlternativePoster")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Banner")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CreateUserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImbdId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Poster")
                        .HasColumnType("nvarchar(max)");

                    b.Property<short>("Status")
                        .HasColumnType("smallint");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("YoutubeId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Video");
                });

            modelBuilder.Entity("YoutubeMovie.Entities.Models.VideoCategory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CreateUserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("ModifiedTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("VideoId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("VideoId");

                    b.ToTable("VideoCategory");
                });

            modelBuilder.Entity("YoutubeMovie.Entities.Models.Comment", b =>
                {
                    b.HasOne("YoutubeMovie.Entities.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("YoutubeMovie.Entities.Models.Video", b =>
                {
                    b.HasOne("YoutubeMovie.Entities.Models.Category", null)
                        .WithMany("Videos")
                        .HasForeignKey("CategoryId");
                });

            modelBuilder.Entity("YoutubeMovie.Entities.Models.VideoCategory", b =>
                {
                    b.HasOne("YoutubeMovie.Entities.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("YoutubeMovie.Entities.Models.Video", "Video")
                        .WithMany("Categories")
                        .HasForeignKey("VideoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Video");
                });

            modelBuilder.Entity("YoutubeMovie.Entities.Models.Category", b =>
                {
                    b.Navigation("Videos");
                });

            modelBuilder.Entity("YoutubeMovie.Entities.Models.Video", b =>
                {
                    b.Navigation("Categories");
                });
#pragma warning restore 612, 618
        }
    }
}