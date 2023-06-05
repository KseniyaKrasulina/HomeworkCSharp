﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Museum.Infrastructure;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using System;

#nullable disable

namespace Museum.Infrastructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230510132016_InitialMigration")]
    partial class InitialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Museum.Api.Entities.Exhibit", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<long>("HallID")
                        .HasColumnType("bigint");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("HallID");

                    b.ToTable("Exhibits");
                });

            modelBuilder.Entity("Museum.Api.Entities.Hall", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Halls");
                });

            modelBuilder.Entity("Museum.Api.Entities.Exhibit", b =>
                {
                    b.HasOne("Museum.Api.Entities.Hall", "Hall")
                        .WithMany("Exhibits")
                        .HasForeignKey("HallID");

                    b.Navigation("Hall");
                });

            modelBuilder.Entity("Museum.Api.Entities.Hall", b =>
                {
                    b.Navigation("Exhibits");
                });
            modelBuilder.Entity("Museum.Api.Entities.Worker", b =>
            {
                b.Property<long>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("bigint");

                NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                b.Property<long>("HallID")
                    .HasColumnType("bigint");

                b.Property<string>("Name")
                    .IsRequired()
                    .HasColumnType("text");

                b.Property<string>("LastName")
                    .HasColumnType("text");

                b.Property<DateTime>("Birth")
                   .HasColumnType("timestamp with time zone");

                b.HasKey("Id");

                b.HasIndex("HallID");

                b.ToTable("Workers");
            });

            modelBuilder.Entity("Museum.Api.Entities.Worker", b =>
            {
                b.HasOne("Museum.Api.Entities.Hall", "Hall")
                    .WithMany("Workers")
                    .HasForeignKey("HallID");

                b.Navigation("Hall");
            });

            modelBuilder.Entity("Museum.Api.Entities.Hall", b =>
            {
                b.Navigation("Workers");
            });

            modelBuilder.Entity("Museum.Api.Entities.Position", b =>
            {
                b.Property<long>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("bigint");

                NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                b.Property<string>("Title")
                    .IsRequired()
                    .HasColumnType("text");

                b.HasKey("Id");

                b.ToTable("Positions");
            });

            modelBuilder.Entity("Museum.Api.Entities.Position_of_worker", b =>
            {
                b.Property<long>("Id")
                   .ValueGeneratedOnAdd()
                   .HasColumnType("bigint");

                NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));
                b.Property<int>("WorkerID")
                    .IsRequired()
                    .HasColumnType("bigint");
                b.Property<int>("PositionID")
                    .IsRequired()
                    .HasColumnType("bigint");
                b.HasKey("Id");
                b.ToTable("Positions_of_workers");
            });

            modelBuilder.Entity("Museum.Api.Entities.Position_of_worker", b =>
            {
                b.HasOne("Museum.Api.Entities.Worker", "Worker")
                    .WithMany("Positions_of_workers")
                    .HasForeignKey("WorkerID");

                b.Navigation("Worker");
            });

            modelBuilder.Entity("Museum.Api.Entities.Position_of_worker", b =>
            {
                b.HasOne("Museum.Api.Entities.Position", "Position")
                    .WithMany("Positions_of_workers")
                    .HasForeignKey("PositionID");

                b.Navigation("Worker");
            });

            modelBuilder.Entity("Museum.Api.Entities.Level_of_education", b =>
            {
                b.Property<long>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("bigint");

                NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                b.Property<long>("WorkerID")
                    .IsRequired()
                    .HasColumnType("bigint");

                b.Property<string>("Level")
                    .IsRequired()
                    .HasColumnType("text");

                b.ToTable("Levels_of_education");
            });

            modelBuilder.Entity("Museum.Api.Entities.Level_of_education", b =>
            {
                b.HasOne("Museum.Api.Entities.Worker", "Worker")
                    .WithMany("Levels_of_education")
                    .HasForeignKey("WorkerID");

                b.Navigation("Worker");
            });
#pragma warning restore 612, 618
        }
    }
}