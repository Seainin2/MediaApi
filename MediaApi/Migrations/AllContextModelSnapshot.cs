﻿// <auto-generated />
using System;
using MediaApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MediaApi.Migrations
{
    [DbContext(typeof(AllContext))]
    partial class AllContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("MediaApi.Models.CreatingProperty", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CreatingProperties");
                });

            modelBuilder.Entity("MediaApi.Models.Episode", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Length")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumberOfEpisode")
                        .HasColumnType("int");

                    b.Property<Guid?>("SeasonId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("SeasonId");

                    b.ToTable("Episode");
                });

            modelBuilder.Entity("MediaApi.Models.Genre", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("GenreName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("MediaId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("MediaId");

                    b.ToTable("Genre");
                });

            modelBuilder.Entity("MediaApi.Models.Media", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CreatingPropertyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumberofTimesSearched")
                        .HasColumnType("int");

                    b.Property<Guid?>("PersonId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("SeriesId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CreatingPropertyId");

                    b.HasIndex("PersonId");

                    b.HasIndex("SeriesId");

                    b.ToTable("Medias");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Media");
                });

            modelBuilder.Entity("MediaApi.Models.MultiplayerOption", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("GameId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MultiplayerOptionType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("GameId");

                    b.ToTable("MultiplayerOption");
                });

            modelBuilder.Entity("MediaApi.Models.Person", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("BookId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("BookId1")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DOB")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("MovieId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("MovieId1")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("MovieId2")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("SeasonId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("SeasonId1")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("SeasonId2")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.HasIndex("BookId1");

                    b.HasIndex("MovieId");

                    b.HasIndex("MovieId1");

                    b.HasIndex("MovieId2");

                    b.HasIndex("SeasonId");

                    b.HasIndex("SeasonId1");

                    b.HasIndex("SeasonId2");

                    b.ToTable("Persons");
                });

            modelBuilder.Entity("MediaApi.Models.Platform", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("GameId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("PlatformName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("GameId");

                    b.ToTable("Platform");
                });

            modelBuilder.Entity("MediaApi.Models.ReccomendingResource", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("MediaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MediaId");

                    b.ToTable("ReccomendingResources");
                });

            modelBuilder.Entity("MediaApi.Models.Seller", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("MediaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Price")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Subscription")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("MediaId");

                    b.ToTable("Sellers");
                });

            modelBuilder.Entity("MediaApi.Models.Series", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Finished")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Series");
                });

            modelBuilder.Entity("MediaApi.Models.Theme", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("MediaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ThemeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MediaId");

                    b.ToTable("Theme");
                });

            modelBuilder.Entity("MediaApi.Models.Book", b =>
                {
                    b.HasBaseType("MediaApi.Models.Media");

                    b.Property<int>("AmountOfTimesSearched")
                        .HasColumnType("int");

                    b.Property<string>("Length")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Book");
                });

            modelBuilder.Entity("MediaApi.Models.Game", b =>
                {
                    b.HasBaseType("MediaApi.Models.Media");

                    b.Property<string>("Studio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Game");
                });

            modelBuilder.Entity("MediaApi.Models.Movie", b =>
                {
                    b.HasBaseType("MediaApi.Models.Media");

                    b.Property<string>("Length")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Movie_Length");

                    b.HasDiscriminator().HasValue("Movie");
                });

            modelBuilder.Entity("MediaApi.Models.Season", b =>
                {
                    b.HasBaseType("MediaApi.Models.Media");

                    b.HasDiscriminator().HasValue("Season");
                });

            modelBuilder.Entity("MediaApi.Models.Episode", b =>
                {
                    b.HasOne("MediaApi.Models.Season", null)
                        .WithMany("Episode")
                        .HasForeignKey("SeasonId");
                });

            modelBuilder.Entity("MediaApi.Models.Genre", b =>
                {
                    b.HasOne("MediaApi.Models.Media", null)
                        .WithMany("Genre")
                        .HasForeignKey("MediaId");
                });

            modelBuilder.Entity("MediaApi.Models.Media", b =>
                {
                    b.HasOne("MediaApi.Models.CreatingProperty", null)
                        .WithMany("Media")
                        .HasForeignKey("CreatingPropertyId");

                    b.HasOne("MediaApi.Models.Person", null)
                        .WithMany("Media")
                        .HasForeignKey("PersonId");

                    b.HasOne("MediaApi.Models.Series", null)
                        .WithMany("Media")
                        .HasForeignKey("SeriesId");
                });

            modelBuilder.Entity("MediaApi.Models.MultiplayerOption", b =>
                {
                    b.HasOne("MediaApi.Models.Game", null)
                        .WithMany("MultiplayerOption")
                        .HasForeignKey("GameId");
                });

            modelBuilder.Entity("MediaApi.Models.Person", b =>
                {
                    b.HasOne("MediaApi.Models.Book", null)
                        .WithMany("Author")
                        .HasForeignKey("BookId");

                    b.HasOne("MediaApi.Models.Book", null)
                        .WithMany("OtherPerson")
                        .HasForeignKey("BookId1");

                    b.HasOne("MediaApi.Models.Movie", null)
                        .WithMany("Actor")
                        .HasForeignKey("MovieId");

                    b.HasOne("MediaApi.Models.Movie", null)
                        .WithMany("Director")
                        .HasForeignKey("MovieId1");

                    b.HasOne("MediaApi.Models.Movie", null)
                        .WithMany("OtherPerson")
                        .HasForeignKey("MovieId2");

                    b.HasOne("MediaApi.Models.Season", null)
                        .WithMany("Actor")
                        .HasForeignKey("SeasonId");

                    b.HasOne("MediaApi.Models.Season", null)
                        .WithMany("Director")
                        .HasForeignKey("SeasonId1");

                    b.HasOne("MediaApi.Models.Season", null)
                        .WithMany("OtherPerson")
                        .HasForeignKey("SeasonId2");
                });

            modelBuilder.Entity("MediaApi.Models.Platform", b =>
                {
                    b.HasOne("MediaApi.Models.Game", null)
                        .WithMany("Platform")
                        .HasForeignKey("GameId");
                });

            modelBuilder.Entity("MediaApi.Models.ReccomendingResource", b =>
                {
                    b.HasOne("MediaApi.Models.Media", null)
                        .WithMany("Rating")
                        .HasForeignKey("MediaId");
                });

            modelBuilder.Entity("MediaApi.Models.Seller", b =>
                {
                    b.HasOne("MediaApi.Models.Media", null)
                        .WithMany("Seller")
                        .HasForeignKey("MediaId");
                });

            modelBuilder.Entity("MediaApi.Models.Theme", b =>
                {
                    b.HasOne("MediaApi.Models.Media", null)
                        .WithMany("Theme")
                        .HasForeignKey("MediaId");
                });

            modelBuilder.Entity("MediaApi.Models.CreatingProperty", b =>
                {
                    b.Navigation("Media");
                });

            modelBuilder.Entity("MediaApi.Models.Media", b =>
                {
                    b.Navigation("Genre");

                    b.Navigation("Rating");

                    b.Navigation("Seller");

                    b.Navigation("Theme");
                });

            modelBuilder.Entity("MediaApi.Models.Person", b =>
                {
                    b.Navigation("Media");
                });

            modelBuilder.Entity("MediaApi.Models.Series", b =>
                {
                    b.Navigation("Media");
                });

            modelBuilder.Entity("MediaApi.Models.Book", b =>
                {
                    b.Navigation("Author");

                    b.Navigation("OtherPerson");
                });

            modelBuilder.Entity("MediaApi.Models.Game", b =>
                {
                    b.Navigation("MultiplayerOption");

                    b.Navigation("Platform");
                });

            modelBuilder.Entity("MediaApi.Models.Movie", b =>
                {
                    b.Navigation("Actor");

                    b.Navigation("Director");

                    b.Navigation("OtherPerson");
                });

            modelBuilder.Entity("MediaApi.Models.Season", b =>
                {
                    b.Navigation("Actor");

                    b.Navigation("Director");

                    b.Navigation("Episode");

                    b.Navigation("OtherPerson");
                });
#pragma warning restore 612, 618
        }
    }
}
