using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Axel_ReseauSocial.Api.Domains.Migrations
{
    public partial class CorrectionAmitie : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Accepte",
                table: "Amitie");

            migrationBuilder.DropColumn(
                name: "Refuse",
                table: "Amitie");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Accepte",
                table: "Amitie",
                type: "BIT",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Refuse",
                table: "Amitie",
                type: "BIT",
                nullable: false,
                defaultValue: false);
        }
    }
}
