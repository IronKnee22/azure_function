﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Ppt.Api.Data;

#nullable disable

namespace Ppt.Api.Migrations
{
    [DbContext(typeof(PptDbContext))]
    [Migration("20230521143947_uprava ukonu")]
    partial class upravaukonu
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.5");

            modelBuilder.Entity("Ppt.Api.Data.Revize", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("VybaveniId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("VybaveniId");

                    b.ToTable("Revizes");
                });

            modelBuilder.Entity("Ppt.Api.Data.Ukony", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("RxecutionDate")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("VybaveniId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("VybaveniId");

                    b.ToTable("Ukonys");
                });

            modelBuilder.Entity("Ppt.Api.Data.Vybaveni", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("BuyDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("Cena")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Vybavenis");
                });

            modelBuilder.Entity("Ppt.Api.Data.Revize", b =>
                {
                    b.HasOne("Ppt.Api.Data.Vybaveni", "Vybaveni")
                        .WithMany("Revizes")
                        .HasForeignKey("VybaveniId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Vybaveni");
                });

            modelBuilder.Entity("Ppt.Api.Data.Ukony", b =>
                {
                    b.HasOne("Ppt.Api.Data.Vybaveni", "Vybaveni")
                        .WithMany()
                        .HasForeignKey("VybaveniId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Vybaveni");
                });

            modelBuilder.Entity("Ppt.Api.Data.Vybaveni", b =>
                {
                    b.Navigation("Revizes");
                });
#pragma warning restore 612, 618
        }
    }
}
