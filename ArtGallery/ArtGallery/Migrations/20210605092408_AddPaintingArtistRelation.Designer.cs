﻿// <auto-generated />
using ArtGallery.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ArtGallery.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210605092408_AddPaintingArtistRelation")]
    partial class AddPaintingArtistRelation
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ArtGallery.Models.ArtistModel", b =>
                {
                    b.Property<int>("ArtId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ArtBio")
                        .HasColumnType("text");

                    b.Property<string>("ArtImg")
                        .HasColumnType("text");

                    b.Property<string>("ArtName")
                        .HasColumnType("text");

                    b.HasKey("ArtId");

                    b.ToTable("Artists");
                });

            modelBuilder.Entity("ArtGallery.Models.BuyerModel", b =>
                {
                    b.Property<int>("ByrID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ByrMail")
                        .HasColumnType("text");

                    b.Property<string>("ByrName")
                        .HasColumnType("text");

                    b.Property<int>("ByrPhone")
                        .HasColumnType("int");

                    b.HasKey("ByrID");

                    b.ToTable("Buyers");
                });

            modelBuilder.Entity("ArtGallery.Models.GalleryModel", b =>
                {
                    b.Property<int>("GlrId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("GlrImg")
                        .HasColumnType("text");

                    b.Property<string>("GlrLocation")
                        .HasColumnType("text");

                    b.Property<string>("GlrName")
                        .HasColumnType("text");

                    b.HasKey("GlrId");

                    b.ToTable("Galleries");
                });

            modelBuilder.Entity("ArtGallery.Models.PaintingModel", b =>
                {
                    b.Property<int>("PntId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ArtistId")
                        .HasColumnType("int");

                    b.Property<int>("GalleryId")
                        .HasColumnType("int");

                    b.Property<string>("PntImg")
                        .HasColumnType("text");

                    b.Property<string>("PntName")
                        .HasColumnType("text");

                    b.Property<string>("PntOverview")
                        .HasColumnType("text");

                    b.Property<double>("PntPrice")
                        .HasColumnType("double");

                    b.HasKey("PntId");

                    b.HasIndex("ArtistId");

                    b.HasIndex("GalleryId")
                        .IsUnique();

                    b.ToTable("Paintings");
                });

            modelBuilder.Entity("ArtGallery.Models.PaintingModel", b =>
                {
                    b.HasOne("ArtGallery.Models.ArtistModel", "Artist")
                        .WithMany("Paintings")
                        .HasForeignKey("ArtistId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ArtGallery.Models.GalleryModel", "Gallery")
                        .WithOne("Painting")
                        .HasForeignKey("ArtGallery.Models.PaintingModel", "GalleryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
