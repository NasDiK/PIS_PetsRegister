﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WinFormsApplication.Services.Database;
using ApplicationContext = WinFormsApplication.Services.Database.ApplicationContext;

#nullable disable

namespace WinFormsApplication.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20221113094132_createPetCategoryTable")]
    partial class createPetCategoryTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.0");

            modelBuilder.Entity("WinFormsApplication.Models.Entities.Roles", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("roles");
                });
#pragma warning restore 612, 618
        }
    }
}
