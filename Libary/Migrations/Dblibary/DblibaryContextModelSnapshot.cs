﻿// <auto-generated />
using System;
using Libary.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Libary.Migrations.Dblibary
{
    [DbContext(typeof(DblibaryContext))]
    partial class DblibaryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Libary.Data.Autor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AutorName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Pseudonym")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("RegionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RegionId");

                    b.ToTable("Autors");
                });

            modelBuilder.Entity("Libary.Data.Delivery", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("PostOfficeAdress")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("PostOfficeNumber")
                        .HasColumnType("int");

                    b.Property<int?>("ReaderId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ReaderId");

                    b.ToTable("Deliveries");
                });

            modelBuilder.Entity("Libary.Data.Epoch", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("EpochName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Epoches");
                });

            modelBuilder.Entity("Libary.Data.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("GenreName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Genres");
                });

            modelBuilder.Entity("Libary.Data.LibaryCheck", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("DateTime")
                        .HasColumnType("datetime");

                    b.Property<int>("DeliveryId")
                        .HasColumnType("int");

                    b.Property<int>("PublicationId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DeliveryId");

                    b.HasIndex("PublicationId");

                    b.ToTable("LibaryChecks");
                });

            modelBuilder.Entity("Libary.Data.Publication", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Annotation")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("BookName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("EpochId")
                        .HasColumnType("int");

                    b.Property<int>("GenreId")
                        .HasColumnType("int");

                    b.Property<int?>("PageCout")
                        .HasColumnType("int");

                    b.Property<int?>("Price")
                        .HasColumnType("int");

                    b.Property<int?>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EpochId");

                    b.HasIndex("GenreId");

                    b.ToTable("Publications");
                });

            modelBuilder.Entity("Libary.Data.PublicationAutor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("PublicationId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PublicationId");

                    b.ToTable("PublicationAutors");
                });

            modelBuilder.Entity("Libary.Data.Reader", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("FirstName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("NickName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Readers");
                });

            modelBuilder.Entity("Libary.Data.Region", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("RegionName")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Regions");
                });

            modelBuilder.Entity("Libary.Data.Autor", b =>
                {
                    b.HasOne("Libary.Data.Region", "Region")
                        .WithMany("Autors")
                        .HasForeignKey("RegionId")
                        .IsRequired()
                        .HasConstraintName("FK_Autors_Regions");

                    b.Navigation("Region");
                });

            modelBuilder.Entity("Libary.Data.Delivery", b =>
                {
                    b.HasOne("Libary.Data.Reader", "Reader")
                        .WithMany("Deliveries")
                        .HasForeignKey("ReaderId")
                        .HasConstraintName("FK_Deliveries_Readers");

                    b.Navigation("Reader");
                });

            modelBuilder.Entity("Libary.Data.LibaryCheck", b =>
                {
                    b.HasOne("Libary.Data.Delivery", "Delivery")
                        .WithMany("LibaryChecks")
                        .HasForeignKey("DeliveryId")
                        .IsRequired()
                        .HasConstraintName("FK_LibaryChecks_Deliveries");

                    b.HasOne("Libary.Data.Publication", "Publication")
                        .WithMany("LibaryChecks")
                        .HasForeignKey("PublicationId")
                        .IsRequired()
                        .HasConstraintName("FK_LibaryChecks_Publications");

                    b.Navigation("Delivery");

                    b.Navigation("Publication");
                });

            modelBuilder.Entity("Libary.Data.Publication", b =>
                {
                    b.HasOne("Libary.Data.Epoch", "Epoch")
                        .WithMany("Publications")
                        .HasForeignKey("EpochId")
                        .IsRequired()
                        .HasConstraintName("FK_Publications_Epoches");

                    b.HasOne("Libary.Data.Genre", "Genre")
                        .WithMany("Publications")
                        .HasForeignKey("GenreId")
                        .IsRequired()
                        .HasConstraintName("FK_Publications_Genres");

                    b.Navigation("Epoch");

                    b.Navigation("Genre");
                });

            modelBuilder.Entity("Libary.Data.PublicationAutor", b =>
                {
                    b.HasOne("Libary.Data.Autor", "IdNavigation")
                        .WithOne("PublicationAutor")
                        .HasForeignKey("Libary.Data.PublicationAutor", "Id")
                        .IsRequired()
                        .HasConstraintName("FK_PublicationAutors_Autors");

                    b.HasOne("Libary.Data.Publication", "Publication")
                        .WithMany("PublicationAutors")
                        .HasForeignKey("PublicationId")
                        .IsRequired()
                        .HasConstraintName("FK_PublicationAutors_Publications");

                    b.Navigation("IdNavigation");

                    b.Navigation("Publication");
                });

            modelBuilder.Entity("Libary.Data.Autor", b =>
                {
                    b.Navigation("PublicationAutor");
                });

            modelBuilder.Entity("Libary.Data.Delivery", b =>
                {
                    b.Navigation("LibaryChecks");
                });

            modelBuilder.Entity("Libary.Data.Epoch", b =>
                {
                    b.Navigation("Publications");
                });

            modelBuilder.Entity("Libary.Data.Genre", b =>
                {
                    b.Navigation("Publications");
                });

            modelBuilder.Entity("Libary.Data.Publication", b =>
                {
                    b.Navigation("LibaryChecks");

                    b.Navigation("PublicationAutors");
                });

            modelBuilder.Entity("Libary.Data.Reader", b =>
                {
                    b.Navigation("Deliveries");
                });

            modelBuilder.Entity("Libary.Data.Region", b =>
                {
                    b.Navigation("Autors");
                });
#pragma warning restore 612, 618
        }
    }
}
