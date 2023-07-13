using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Axel_ReseauSocial.Api.Domains.Migrations
{
    public partial class AddTravailUpdateUtilisateur : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TravailId",
                table: "Utilisateur",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Travail",
                columns: table => new
                {
                    IdTravail = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Denomination = table.Column<string>(type: "NVARCHAR(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Travail", x => x.IdTravail);
                });

            migrationBuilder.InsertData(
                table: "Travail",
                columns: new[] { "IdTravail", "Denomination" },
                values: new object[] { 1, "Programmeur Web" });

            migrationBuilder.CreateIndex(
                name: "IX_Utilisateur_TravailId",
                table: "Utilisateur",
                column: "TravailId");

            migrationBuilder.AddForeignKey(
                name: "FK_Utilisateur_Travail_TravailId",
                table: "Utilisateur",
                column: "TravailId",
                principalTable: "Travail",
                principalColumn: "IdTravail");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Utilisateur_Travail_TravailId",
                table: "Utilisateur");

            migrationBuilder.DropTable(
                name: "Travail");

            migrationBuilder.DropIndex(
                name: "IX_Utilisateur_TravailId",
                table: "Utilisateur");

            migrationBuilder.DropColumn(
                name: "TravailId",
                table: "Utilisateur");
        }
    }
}
