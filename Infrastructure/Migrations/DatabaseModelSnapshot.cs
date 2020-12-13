﻿// <auto-generated />

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace DatabaseEntity.Migrations
{
    [DbContext(typeof(Database))]
    internal class DatabaseModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("DatabaseEntity.Autorole", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                b.Property<ulong>("RoleId")
                    .HasColumnType("bigint unsigned");

                b.Property<ulong>("ServerId")
                    .HasColumnType("bigint unsigned");

                b.HasKey("Id");

                b.ToTable("Autoroles");
            });

            modelBuilder.Entity("DatabaseEntity.Rank", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                b.Property<ulong>("RoleId")
                    .HasColumnType("bigint unsigned");

                b.Property<ulong>("ServerId")
                    .HasColumnType("bigint unsigned");

                b.HasKey("Id");

                b.ToTable("Ranks");
            });

            modelBuilder.Entity("DatabaseEntity.Server", b =>
            {
                b.Property<ulong>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("bigint unsigned");

                b.Property<bool>("BadWordToggle")
                    .HasColumnType("tinyint(1)");

                b.Property<ulong>("EventLogChannel")
                    .HasColumnType("bigint unsigned");

                b.Property<bool>("InviteToggle")
                    .HasColumnType("tinyint(1)");

                b.Property<string>("LeaveMessage")
                    .HasColumnType("longtext CHARACTER SET utf8mb4");

                b.Property<ulong>("LeftChannel")
                    .HasColumnType("bigint unsigned");

                b.Property<ulong>("LogMessageChannel")
                    .HasColumnType("bigint unsigned");

                b.Property<string>("Prefix")
                    .HasColumnType("longtext CHARACTER SET utf8mb4");

                b.Property<ulong>("UserUpdateChannel")
                    .HasColumnType("bigint unsigned");

                b.Property<ulong>("WelcomeChannel")
                    .HasColumnType("bigint unsigned");

                b.Property<string>("WelcomeMessage")
                    .HasColumnType("longtext CHARACTER SET utf8mb4");

                b.Property<ulong>("WelcomeUrl")
                    .HasColumnType("bigint unsigned");

                b.HasKey("Id");

                b.ToTable("Servers");
            });

            modelBuilder.Entity("DatabaseEntity.User", b =>
            {
                b.Property<ulong>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("bigint unsigned");

                b.Property<ulong>("Exp")
                    .HasColumnType("bigint unsigned");

                b.Property<ulong>("Level")
                    .HasColumnType("bigint unsigned");

                b.Property<long>("OpenDotaId")
                    .HasColumnType("bigint");

                b.Property<ulong>("SteamId")
                    .HasColumnType("bigint unsigned");

                b.Property<string>("UserName")
                    .HasColumnType("longtext CHARACTER SET utf8mb4");

                b.HasKey("Id");

                b.ToTable("Users");
            });
#pragma warning restore 612, 618
        }
    }
}