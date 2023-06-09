﻿// <auto-generated />
using DAL.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DAL.Migrations
{
    [DbContext(typeof(RestaurantDbContext))]
    partial class RestaurantDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Formation.Models.Restaurant", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CuisinId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Restaurants");

                    b.HasData(
                        new
                        {
                            Id = "2",
                            Address = "456 Second St",
                            CuisinId = "2",
                            Description = "A classic French bistro",
                            Name = "French Bistro",
                            PhoneNumber = "0698765432"
                        },
                        new
                        {
                            Id = "3",
                            Address = "789 Third St",
                            CuisinId = "3",
                            Description = "A trendy Japanese sushi bar",
                            Name = "Sushi Bar",
                            PhoneNumber = "0601234567"
                        });
                });

            modelBuilder.Entity("FormationMVC.Models.DTO.Cuisin", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RestaurantId")
                        .HasColumnType("int");

                    b.Property<string>("RestaurantId1")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RestaurantId1");

                    b.ToTable("Cuisines");

                    b.HasData(
                        new
                        {
                            Id = "1",
                            Country = "Italy",
                            Description = "Traditional Italian dishes",
                            Name = "Italian",
                            RestaurantId = 0
                        },
                        new
                        {
                            Id = "2",
                            Country = "France",
                            Description = "French cuisine with a modern twist",
                            Name = "French",
                            RestaurantId = 0
                        },
                        new
                        {
                            Id = "3",
                            Country = "Japan",
                            Description = "Fresh sushi and sashimi",
                            Name = "Japanese",
                            RestaurantId = 0
                        });
                });

            modelBuilder.Entity("FormationMVC.Models.DTO.Cuisin", b =>
                {
                    b.HasOne("Formation.Models.Restaurant", "Restaurant")
                        .WithMany("Cuisines")
                        .HasForeignKey("RestaurantId1");

                    b.Navigation("Restaurant");
                });

            modelBuilder.Entity("Formation.Models.Restaurant", b =>
                {
                    b.Navigation("Cuisines");
                });
#pragma warning restore 612, 618
        }
    }
}
