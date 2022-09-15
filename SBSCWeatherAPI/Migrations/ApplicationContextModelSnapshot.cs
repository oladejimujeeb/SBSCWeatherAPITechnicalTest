﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SBSCWeatherAPI.Context;

namespace SBSCWeatherAPI.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    partial class ApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.29")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("SBSCWeatherAPI.Entities.WeatherReport", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Cloud")
                        .HasColumnType("int");

                    b.Property<string>("Country")
                        .HasColumnType("text");

                    b.Property<string>("Date")
                        .HasColumnType("text");

                    b.Property<int>("Humidity")
                        .HasColumnType("int");

                    b.Property<string>("Last_updated")
                        .HasColumnType("text");

                    b.Property<float>("Latitude")
                        .HasColumnType("float");

                    b.Property<string>("LocalTime")
                        .HasColumnType("text");

                    b.Property<float>("Longtude")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Region")
                        .HasColumnType("text");

                    b.Property<float>("Temprature_Celsius")
                        .HasColumnType("float");

                    b.Property<float>("Temprature_Fahrenheit")
                        .HasColumnType("float");

                    b.Property<string>("WeatherCondition")
                        .HasColumnType("text");

                    b.Property<string>("WindDirection")
                        .HasColumnType("text");

                    b.Property<float>("WindSpeed")
                        .HasColumnType("float");

                    b.HasKey("id");

                    b.ToTable("WeatherReports");
                });
#pragma warning restore 612, 618
        }
    }
}