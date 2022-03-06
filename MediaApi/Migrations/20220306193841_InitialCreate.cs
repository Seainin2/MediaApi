using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MediaApi.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CreatingProperties",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CreatingProperties", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Series",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Finished = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Series", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Episode",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NumberOfEpisode = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Length = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeasonId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Episode", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genre",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GenreName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MediaId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genre", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Medias",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumberofTimesSearched = table.Column<int>(type: "int", nullable: false),
                    CreatingPropertyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersonId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SeriesId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Length = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AmountOfTimesSearched = table.Column<int>(type: "int", nullable: true),
                    Studio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Movie_Length = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Medias_CreatingProperties_CreatingPropertyId",
                        column: x => x.CreatingPropertyId,
                        principalTable: "CreatingProperties",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Medias_Series_SeriesId",
                        column: x => x.SeriesId,
                        principalTable: "Series",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MultiplayerOption",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MultiplayerOptionType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GameId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MultiplayerOption", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MultiplayerOption_Medias_GameId",
                        column: x => x.GameId,
                        principalTable: "Medias",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DOB = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BookId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BookId1 = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    MovieId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    MovieId1 = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    MovieId2 = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SeasonId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SeasonId1 = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SeasonId2 = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Persons_Medias_BookId",
                        column: x => x.BookId,
                        principalTable: "Medias",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Persons_Medias_BookId1",
                        column: x => x.BookId1,
                        principalTable: "Medias",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Persons_Medias_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Medias",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Persons_Medias_MovieId1",
                        column: x => x.MovieId1,
                        principalTable: "Medias",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Persons_Medias_MovieId2",
                        column: x => x.MovieId2,
                        principalTable: "Medias",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Persons_Medias_SeasonId",
                        column: x => x.SeasonId,
                        principalTable: "Medias",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Persons_Medias_SeasonId1",
                        column: x => x.SeasonId1,
                        principalTable: "Medias",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Persons_Medias_SeasonId2",
                        column: x => x.SeasonId2,
                        principalTable: "Medias",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Platform",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PlatformName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GameId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Platform", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Platform_Medias_GameId",
                        column: x => x.GameId,
                        principalTable: "Medias",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ReccomendingResources",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rating = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MediaId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReccomendingResources", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReccomendingResources_Medias_MediaId",
                        column: x => x.MediaId,
                        principalTable: "Medias",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Sellers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Subscription = table.Column<bool>(type: "bit", nullable: false),
                    MediaId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sellers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sellers_Medias_MediaId",
                        column: x => x.MediaId,
                        principalTable: "Medias",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Theme",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ThemeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MediaId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Theme", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Theme_Medias_MediaId",
                        column: x => x.MediaId,
                        principalTable: "Medias",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Episode_SeasonId",
                table: "Episode",
                column: "SeasonId");

            migrationBuilder.CreateIndex(
                name: "IX_Genre_MediaId",
                table: "Genre",
                column: "MediaId");

            migrationBuilder.CreateIndex(
                name: "IX_Medias_CreatingPropertyId",
                table: "Medias",
                column: "CreatingPropertyId");

            migrationBuilder.CreateIndex(
                name: "IX_Medias_PersonId",
                table: "Medias",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Medias_SeriesId",
                table: "Medias",
                column: "SeriesId");

            migrationBuilder.CreateIndex(
                name: "IX_MultiplayerOption_GameId",
                table: "MultiplayerOption",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_BookId",
                table: "Persons",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_BookId1",
                table: "Persons",
                column: "BookId1");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_MovieId",
                table: "Persons",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_MovieId1",
                table: "Persons",
                column: "MovieId1");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_MovieId2",
                table: "Persons",
                column: "MovieId2");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_SeasonId",
                table: "Persons",
                column: "SeasonId");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_SeasonId1",
                table: "Persons",
                column: "SeasonId1");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_SeasonId2",
                table: "Persons",
                column: "SeasonId2");

            migrationBuilder.CreateIndex(
                name: "IX_Platform_GameId",
                table: "Platform",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_ReccomendingResources_MediaId",
                table: "ReccomendingResources",
                column: "MediaId");

            migrationBuilder.CreateIndex(
                name: "IX_Sellers_MediaId",
                table: "Sellers",
                column: "MediaId");

            migrationBuilder.CreateIndex(
                name: "IX_Theme_MediaId",
                table: "Theme",
                column: "MediaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Episode_Medias_SeasonId",
                table: "Episode",
                column: "SeasonId",
                principalTable: "Medias",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Genre_Medias_MediaId",
                table: "Genre",
                column: "MediaId",
                principalTable: "Medias",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Medias_Persons_PersonId",
                table: "Medias",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Persons_Medias_BookId",
                table: "Persons");

            migrationBuilder.DropForeignKey(
                name: "FK_Persons_Medias_BookId1",
                table: "Persons");

            migrationBuilder.DropForeignKey(
                name: "FK_Persons_Medias_MovieId",
                table: "Persons");

            migrationBuilder.DropForeignKey(
                name: "FK_Persons_Medias_MovieId1",
                table: "Persons");

            migrationBuilder.DropForeignKey(
                name: "FK_Persons_Medias_MovieId2",
                table: "Persons");

            migrationBuilder.DropForeignKey(
                name: "FK_Persons_Medias_SeasonId",
                table: "Persons");

            migrationBuilder.DropForeignKey(
                name: "FK_Persons_Medias_SeasonId1",
                table: "Persons");

            migrationBuilder.DropForeignKey(
                name: "FK_Persons_Medias_SeasonId2",
                table: "Persons");

            migrationBuilder.DropTable(
                name: "Episode");

            migrationBuilder.DropTable(
                name: "Genre");

            migrationBuilder.DropTable(
                name: "MultiplayerOption");

            migrationBuilder.DropTable(
                name: "Platform");

            migrationBuilder.DropTable(
                name: "ReccomendingResources");

            migrationBuilder.DropTable(
                name: "Sellers");

            migrationBuilder.DropTable(
                name: "Theme");

            migrationBuilder.DropTable(
                name: "Medias");

            migrationBuilder.DropTable(
                name: "CreatingProperties");

            migrationBuilder.DropTable(
                name: "Persons");

            migrationBuilder.DropTable(
                name: "Series");
        }
    }
}
