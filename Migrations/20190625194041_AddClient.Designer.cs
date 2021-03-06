﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using empresaapp.Db;

namespace empresaapp.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20190625194041_AddClient")]
    partial class AddClient
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity("empresaapp.Models.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<DateTime>("Birthday");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Clients");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Rua lalalal 100",
                            Birthday = new DateTime(2019, 6, 25, 16, 40, 40, 951, DateTimeKind.Local).AddTicks(3201),
                            Name = "Zezinho"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
