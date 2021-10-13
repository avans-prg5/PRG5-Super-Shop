﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Super_Shop.Dal;

namespace Super_Shop.Migrations
{
    [DbContext(typeof(SupershopContext))]
    partial class SupershopContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:Collation", "Latin1_General_CI_AS")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HeroTeam", b =>
                {
                    b.Property<int>("HeroesId")
                        .HasColumnType("int");

                    b.Property<int>("TeamsId")
                        .HasColumnType("int");

                    b.HasKey("HeroesId", "TeamsId");

                    b.HasIndex("TeamsId");

                    b.ToTable("HeroTeam");

                    b.HasData(
                        new
                        {
                            HeroesId = 1,
                            TeamsId = 1
                        },
                        new
                        {
                            HeroesId = 2,
                            TeamsId = 1
                        },
                        new
                        {
                            HeroesId = 3,
                            TeamsId = 1
                        },
                        new
                        {
                            HeroesId = 2,
                            TeamsId = 2
                        },
                        new
                        {
                            HeroesId = 3,
                            TeamsId = 2
                        },
                        new
                        {
                            HeroesId = 4,
                            TeamsId = 2
                        },
                        new
                        {
                            HeroesId = 3,
                            TeamsId = 3
                        },
                        new
                        {
                            HeroesId = 4,
                            TeamsId = 3
                        },
                        new
                        {
                            HeroesId = 5,
                            TeamsId = 3
                        });
                });

            modelBuilder.Entity("Super_Shop.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ImageUri")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(512)")
                        .HasDefaultValue("~/img/employees/default_employee.png");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nchar(64)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nchar(64)")
                        .HasDefaultValue("unknown");

                    b.HasKey("Id");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ImageUri = "~/img/employees/eric.jfif",
                            Name = "Eric Kuijpers",
                            Role = "CEO"
                        },
                        new
                        {
                            Id = 2,
                            ImageUri = "~/img/employees/carron.jfif",
                            Name = "Carron Schilders",
                            Role = "CTO"
                        },
                        new
                        {
                            Id = 3,
                            ImageUri = "~/img/employees/stijn.jfif",
                            Name = "Stijn Smulders",
                            Role = "Service desk"
                        },
                        new
                        {
                            Id = 4,
                            ImageUri = "~/img/interns/adam.jpg",
                            Name = "Adam Sandler",
                            Role = "Intern"
                        });
                });

            modelBuilder.Entity("Super_Shop.Models.Hero", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("Date")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<string>("ImageUri")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(512)")
                        .HasDefaultValue("~/img/default_hero.png");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<int>("PowerLevel")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Heroes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImageUri = "~/img/iron_man.png",
                            Name = "Iron Man",
                            PowerLevel = 9001
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImageUri = "~/img/kermit.png",
                            Name = "Kermit the frog",
                            PowerLevel = 5
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImageUri = "~/img/batman.png",
                            Name = "Batman",
                            PowerLevel = 1
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImageUri = "~/img/deadpool.png",
                            Name = "Deadpool",
                            PowerLevel = 200
                        },
                        new
                        {
                            Id = 5,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImageUri = "~/img/wolverine.png",
                            Name = "Wolverine",
                            PowerLevel = 150
                        });
                });

            modelBuilder.Entity("Super_Shop.Models.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ImageUri")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(512)")
                        .HasDefaultValue("~/img/employees/default_employee.png");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nchar(256)");

                    b.HasKey("Id");

                    b.ToTable("Teams");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ImageUri = "",
                            Name = "The dream team"
                        },
                        new
                        {
                            Id = 2,
                            ImageUri = "",
                            Name = "The unbrella accademy"
                        },
                        new
                        {
                            Id = 3,
                            ImageUri = "",
                            Name = "Dharma Initiative"
                        });
                });

            modelBuilder.Entity("HeroTeam", b =>
                {
                    b.HasOne("Super_Shop.Models.Hero", null)
                        .WithMany()
                        .HasForeignKey("HeroesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Super_Shop.Models.Team", null)
                        .WithMany()
                        .HasForeignKey("TeamsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}