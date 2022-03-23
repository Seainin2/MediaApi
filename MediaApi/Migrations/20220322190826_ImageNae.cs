using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MediaApi.Migrations
{
    public partial class ImageNae : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageName",
                table: "Series",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageName",
                table: "Sellers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageName",
                table: "Seasons",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageName",
                table: "ReccomendingResources",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageName",
                table: "Persons",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageName",
                table: "Movies",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageName",
                table: "Games",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageName",
                table: "CreatingProperties",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageName",
                table: "Books",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageName",
                table: "Series");

            migrationBuilder.DropColumn(
                name: "ImageName",
                table: "Sellers");

            migrationBuilder.DropColumn(
                name: "ImageName",
                table: "Seasons");

            migrationBuilder.DropColumn(
                name: "ImageName",
                table: "ReccomendingResources");

            migrationBuilder.DropColumn(
                name: "ImageName",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "ImageName",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "ImageName",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "ImageName",
                table: "CreatingProperties");

            migrationBuilder.DropColumn(
                name: "ImageName",
                table: "Books");
        }
    }
}
