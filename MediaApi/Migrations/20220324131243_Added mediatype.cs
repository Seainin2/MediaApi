using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MediaApi.Migrations
{
    public partial class Addedmediatype : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MediaType",
                table: "Series",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MediaType",
                table: "Seasons",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MediaType",
                table: "Movies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MediaType",
                table: "Games",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MediaType",
                table: "Books",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MediaType",
                table: "Series");

            migrationBuilder.DropColumn(
                name: "MediaType",
                table: "Seasons");

            migrationBuilder.DropColumn(
                name: "MediaType",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "MediaType",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "MediaType",
                table: "Books");
        }
    }
}
