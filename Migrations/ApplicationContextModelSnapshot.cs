﻿// <auto-generated />
using System;
using ConsoleApp21.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ConsoleApp21.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    partial class ApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.2");

            modelBuilder.Entity("ConsoleApp21.Models.Passanger", b =>
                {
                    b.Property<int>("IdPassanger")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("IdPassanger");

                    b.ToTable("Passangers");
                });

            modelBuilder.Entity("ConsoleApp21.Models.Point", b =>
                {
                    b.Property<int>("IdPoint")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Value")
                        .HasColumnType("INTEGER");

                    b.HasKey("IdPoint");

                    b.ToTable("Points");
                });

            modelBuilder.Entity("ConsoleApp21.Models.Ticket", b =>
                {
                    b.Property<Guid>("IdTicket")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateArrive")
                        .HasColumnType("TEXT");

                    b.Property<int>("PassangerIdPassanger")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PointArrivalIdPoint")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PointDepartureIdPoint")
                        .HasColumnType("INTEGER");

                    b.HasKey("IdTicket");

                    b.HasIndex("PassangerIdPassanger");

                    b.HasIndex("PointArrivalIdPoint");

                    b.HasIndex("PointDepartureIdPoint");

                    b.ToTable("Tickets");
                });

            modelBuilder.Entity("ConsoleApp21.Models.Ticket", b =>
                {
                    b.HasOne("ConsoleApp21.Models.Passanger", "Passanger")
                        .WithMany()
                        .HasForeignKey("PassangerIdPassanger")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ConsoleApp21.Models.Point", "PointArrival")
                        .WithMany()
                        .HasForeignKey("PointArrivalIdPoint")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ConsoleApp21.Models.Point", "PointDeparture")
                        .WithMany()
                        .HasForeignKey("PointDepartureIdPoint")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Passanger");

                    b.Navigation("PointArrival");

                    b.Navigation("PointDeparture");
                });
#pragma warning restore 612, 618
        }
    }
}
