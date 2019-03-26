﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ScheduleSqlite;

namespace ScheduleSqlite.Migrations
{
    [DbContext(typeof(ScheduleDbContext))]
    partial class ScheduleDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854");

            modelBuilder.Entity("ScheduleModel.MessageTemplate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Template");

                    b.HasKey("Id");

                    b.ToTable("MessageTempaltes");
                });

            modelBuilder.Entity("ScheduleModel.Schedule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Schedules");
                });

            modelBuilder.Entity("ScheduleModel.ScheduleItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("MessageId");

                    b.Property<int?>("ScheduleId");

                    b.HasKey("Id");

                    b.HasIndex("MessageId");

                    b.HasIndex("ScheduleId");

                    b.ToTable("ScheduleItems");
                });

            modelBuilder.Entity("ScheduleModel.ScheduleItem", b =>
                {
                    b.HasOne("ScheduleModel.MessageTemplate", "Message")
                        .WithMany("ScheduleItems")
                        .HasForeignKey("MessageId");

                    b.HasOne("ScheduleModel.Schedule", "Schedule")
                        .WithMany("ScheduleItems")
                        .HasForeignKey("ScheduleId");
                });
#pragma warning restore 612, 618
        }
    }
}
