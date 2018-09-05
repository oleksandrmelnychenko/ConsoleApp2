﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using car.id.server.DbConfig;

namespace car.id.server.Migrations
{
    [DbContext(typeof(CarIdDataContext))]
    [Migration("20180905155717_AddedSeparateTablesPerYear")]
    partial class AddedSeparateTablesPerYear
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.2-rtm-30932")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("car.id.server.Models.CarInfo", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Body")
                        .HasMaxLength(250);

                    b.Property<string>("Brand")
                        .HasMaxLength(250);

                    b.Property<string>("Capacity")
                        .HasMaxLength(250);

                    b.Property<string>("Color")
                        .HasMaxLength(250);

                    b.Property<string>("DReg")
                        .HasMaxLength(250);

                    b.Property<string>("Dep")
                        .HasMaxLength(250);

                    b.Property<string>("DepCode")
                        .HasMaxLength(250);

                    b.Property<string>("Fuel")
                        .HasMaxLength(250);

                    b.Property<string>("Kind")
                        .HasMaxLength(250);

                    b.Property<string>("MakeYear")
                        .HasMaxLength(250);

                    b.Property<string>("ModelName")
                        .HasMaxLength(250);

                    b.Property<string>("NRegNew")
                        .HasMaxLength(50);

                    b.Property<string>("OperCode")
                        .HasMaxLength(250);

                    b.Property<string>("OperName")
                        .HasMaxLength(250);

                    b.Property<string>("OwnWeight")
                        .HasMaxLength(250);

                    b.Property<string>("Person")
                        .HasMaxLength(250);

                    b.Property<string>("Purpose")
                        .HasMaxLength(250);

                    b.Property<string>("RegAddrKoatuu")
                        .HasMaxLength(250);

                    b.Property<string>("TotalWeight")
                        .HasMaxLength(250);

                    b.HasKey("Id");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("car.id.server.Models.CarInfo2013", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Body")
                        .HasMaxLength(250);

                    b.Property<string>("Brand")
                        .HasMaxLength(250);

                    b.Property<string>("Capacity")
                        .HasMaxLength(250);

                    b.Property<string>("Color")
                        .HasMaxLength(250);

                    b.Property<string>("DReg")
                        .HasMaxLength(250);

                    b.Property<string>("Dep")
                        .HasMaxLength(250);

                    b.Property<string>("DepCode")
                        .HasMaxLength(250);

                    b.Property<string>("Fuel")
                        .HasMaxLength(250);

                    b.Property<string>("Kind")
                        .HasMaxLength(250);

                    b.Property<string>("MakeYear")
                        .HasMaxLength(250);

                    b.Property<string>("ModelName")
                        .HasMaxLength(250);

                    b.Property<string>("NRegNew")
                        .HasMaxLength(50);

                    b.Property<string>("OperCode")
                        .HasMaxLength(250);

                    b.Property<string>("OperName")
                        .HasMaxLength(250);

                    b.Property<string>("OwnWeight")
                        .HasMaxLength(250);

                    b.Property<string>("Person")
                        .HasMaxLength(250);

                    b.Property<string>("Purpose")
                        .HasMaxLength(250);

                    b.Property<string>("RegAddrKoatuu")
                        .HasMaxLength(250);

                    b.Property<string>("TotalWeight")
                        .HasMaxLength(250);

                    b.HasKey("Id");

                    b.ToTable("Posts2013");
                });

            modelBuilder.Entity("car.id.server.Models.CarInfo2014", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Body")
                        .HasMaxLength(250);

                    b.Property<string>("Brand")
                        .HasMaxLength(250);

                    b.Property<string>("Capacity")
                        .HasMaxLength(250);

                    b.Property<string>("Color")
                        .HasMaxLength(250);

                    b.Property<string>("DReg")
                        .HasMaxLength(250);

                    b.Property<string>("Dep")
                        .HasMaxLength(250);

                    b.Property<string>("DepCode")
                        .HasMaxLength(250);

                    b.Property<string>("Fuel")
                        .HasMaxLength(250);

                    b.Property<string>("Kind")
                        .HasMaxLength(250);

                    b.Property<string>("MakeYear")
                        .HasMaxLength(250);

                    b.Property<string>("ModelName")
                        .HasMaxLength(250);

                    b.Property<string>("NRegNew")
                        .HasMaxLength(50);

                    b.Property<string>("OperCode")
                        .HasMaxLength(250);

                    b.Property<string>("OperName")
                        .HasMaxLength(250);

                    b.Property<string>("OwnWeight")
                        .HasMaxLength(250);

                    b.Property<string>("Person")
                        .HasMaxLength(250);

                    b.Property<string>("Purpose")
                        .HasMaxLength(250);

                    b.Property<string>("RegAddrKoatuu")
                        .HasMaxLength(250);

                    b.Property<string>("TotalWeight")
                        .HasMaxLength(250);

                    b.HasKey("Id");

                    b.ToTable("Posts2014");
                });

            modelBuilder.Entity("car.id.server.Models.CarInfo2015", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Body")
                        .HasMaxLength(250);

                    b.Property<string>("Brand")
                        .HasMaxLength(250);

                    b.Property<string>("Capacity")
                        .HasMaxLength(250);

                    b.Property<string>("Color")
                        .HasMaxLength(250);

                    b.Property<string>("DReg")
                        .HasMaxLength(250);

                    b.Property<string>("Dep")
                        .HasMaxLength(250);

                    b.Property<string>("DepCode")
                        .HasMaxLength(250);

                    b.Property<string>("Fuel")
                        .HasMaxLength(250);

                    b.Property<string>("Kind")
                        .HasMaxLength(250);

                    b.Property<string>("MakeYear")
                        .HasMaxLength(250);

                    b.Property<string>("ModelName")
                        .HasMaxLength(250);

                    b.Property<string>("NRegNew")
                        .HasMaxLength(50);

                    b.Property<string>("OperCode")
                        .HasMaxLength(250);

                    b.Property<string>("OperName")
                        .HasMaxLength(250);

                    b.Property<string>("OwnWeight")
                        .HasMaxLength(250);

                    b.Property<string>("Person")
                        .HasMaxLength(250);

                    b.Property<string>("Purpose")
                        .HasMaxLength(250);

                    b.Property<string>("RegAddrKoatuu")
                        .HasMaxLength(250);

                    b.Property<string>("TotalWeight")
                        .HasMaxLength(250);

                    b.HasKey("Id");

                    b.ToTable("Posts2015");
                });

            modelBuilder.Entity("car.id.server.Models.CarInfo2016", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Body")
                        .HasMaxLength(250);

                    b.Property<string>("Brand")
                        .HasMaxLength(250);

                    b.Property<string>("Capacity")
                        .HasMaxLength(250);

                    b.Property<string>("Color")
                        .HasMaxLength(250);

                    b.Property<string>("DReg")
                        .HasMaxLength(250);

                    b.Property<string>("Dep")
                        .HasMaxLength(250);

                    b.Property<string>("DepCode")
                        .HasMaxLength(250);

                    b.Property<string>("Fuel")
                        .HasMaxLength(250);

                    b.Property<string>("Kind")
                        .HasMaxLength(250);

                    b.Property<string>("MakeYear")
                        .HasMaxLength(250);

                    b.Property<string>("ModelName")
                        .HasMaxLength(250);

                    b.Property<string>("NRegNew")
                        .HasMaxLength(50);

                    b.Property<string>("OperCode")
                        .HasMaxLength(250);

                    b.Property<string>("OperName")
                        .HasMaxLength(250);

                    b.Property<string>("OwnWeight")
                        .HasMaxLength(250);

                    b.Property<string>("Person")
                        .HasMaxLength(250);

                    b.Property<string>("Purpose")
                        .HasMaxLength(250);

                    b.Property<string>("RegAddrKoatuu")
                        .HasMaxLength(250);

                    b.Property<string>("TotalWeight")
                        .HasMaxLength(250);

                    b.HasKey("Id");

                    b.ToTable("Posts2016");
                });

            modelBuilder.Entity("car.id.server.Models.CarInfo2017", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Body")
                        .HasMaxLength(250);

                    b.Property<string>("Brand")
                        .HasMaxLength(250);

                    b.Property<string>("Capacity")
                        .HasMaxLength(250);

                    b.Property<string>("Color")
                        .HasMaxLength(250);

                    b.Property<string>("DReg")
                        .HasMaxLength(250);

                    b.Property<string>("Dep")
                        .HasMaxLength(250);

                    b.Property<string>("DepCode")
                        .HasMaxLength(250);

                    b.Property<string>("Fuel")
                        .HasMaxLength(250);

                    b.Property<string>("Kind")
                        .HasMaxLength(250);

                    b.Property<string>("MakeYear")
                        .HasMaxLength(250);

                    b.Property<string>("ModelName")
                        .HasMaxLength(250);

                    b.Property<string>("NRegNew")
                        .HasMaxLength(50);

                    b.Property<string>("OperCode")
                        .HasMaxLength(250);

                    b.Property<string>("OperName")
                        .HasMaxLength(250);

                    b.Property<string>("OwnWeight")
                        .HasMaxLength(250);

                    b.Property<string>("Person")
                        .HasMaxLength(250);

                    b.Property<string>("Purpose")
                        .HasMaxLength(250);

                    b.Property<string>("RegAddrKoatuu")
                        .HasMaxLength(250);

                    b.Property<string>("TotalWeight")
                        .HasMaxLength(250);

                    b.HasKey("Id");

                    b.ToTable("Posts2017");
                });

            modelBuilder.Entity("car.id.server.Models.CarInfo2018", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Body")
                        .HasMaxLength(250);

                    b.Property<string>("Brand")
                        .HasMaxLength(250);

                    b.Property<string>("Capacity")
                        .HasMaxLength(250);

                    b.Property<string>("Color")
                        .HasMaxLength(250);

                    b.Property<string>("DReg")
                        .HasMaxLength(250);

                    b.Property<string>("Dep")
                        .HasMaxLength(250);

                    b.Property<string>("DepCode")
                        .HasMaxLength(250);

                    b.Property<string>("Fuel")
                        .HasMaxLength(250);

                    b.Property<string>("Kind")
                        .HasMaxLength(250);

                    b.Property<string>("MakeYear")
                        .HasMaxLength(250);

                    b.Property<string>("ModelName")
                        .HasMaxLength(250);

                    b.Property<string>("NRegNew")
                        .HasMaxLength(50);

                    b.Property<string>("OperCode")
                        .HasMaxLength(250);

                    b.Property<string>("OperName")
                        .HasMaxLength(250);

                    b.Property<string>("OwnWeight")
                        .HasMaxLength(250);

                    b.Property<string>("Person")
                        .HasMaxLength(250);

                    b.Property<string>("Purpose")
                        .HasMaxLength(250);

                    b.Property<string>("RegAddrKoatuu")
                        .HasMaxLength(250);

                    b.Property<string>("TotalWeight")
                        .HasMaxLength(250);

                    b.HasKey("Id");

                    b.ToTable("Posts2018");
                });
#pragma warning restore 612, 618
        }
    }
}
