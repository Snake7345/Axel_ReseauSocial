using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Axel_ReseauSocial.Api.Domains.Migrations
{
    public partial class AddAmitie : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Amitie",
                columns: table => new
                {
                    IdAmitie = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWSEQUENTIALID()"),
                    Accepte = table.Column<bool>(type: "BIT", nullable: false, defaultValue: false),
                    Refuse = table.Column<bool>(type: "BIT", nullable: false, defaultValue: false),
                    Attente = table.Column<bool>(type: "BIT", nullable: false, defaultValue: true),
                    DestinataireId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DestinateurId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Amitie", x => x.IdAmitie);
                    table.ForeignKey(
                        name: "FK_Amitie_Utilisateur_DestinataireId",
                        column: x => x.DestinataireId,
                        principalTable: "Utilisateur",
                        principalColumn: "IdUtilisateur");
                    table.ForeignKey(
                        name: "FK_Amitie_Utilisateur_DestinateurId",
                        column: x => x.DestinateurId,
                        principalTable: "Utilisateur",
                        principalColumn: "IdUtilisateur");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Amitie_DestinataireId",
                table: "Amitie",
                column: "DestinataireId");

            migrationBuilder.CreateIndex(
                name: "IX_Amitie_DestinateurId",
                table: "Amitie",
                column: "DestinateurId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Amitie");
        }
    }
}
