using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Axel_ReseauSocial.Api.Domains.Migrations
{
    public partial class AddPv : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pv",
                columns: table => new
                {
                    IdPv = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWSEQUENTIALID()"),
                    DestinataireId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DestinateurId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pv", x => x.IdPv);
                    table.ForeignKey(
                        name: "FK_Pv_Utilisateur_DestinataireId",
                        column: x => x.DestinataireId,
                        principalTable: "Utilisateur",
                        principalColumn: "IdUtilisateur");
                    table.ForeignKey(
                        name: "FK_Pv_Utilisateur_DestinateurId",
                        column: x => x.DestinateurId,
                        principalTable: "Utilisateur",
                        principalColumn: "IdUtilisateur");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pv_DestinataireId",
                table: "Pv",
                column: "DestinataireId");

            migrationBuilder.CreateIndex(
                name: "IX_Pv_DestinateurId",
                table: "Pv",
                column: "DestinateurId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pv");
        }
    }
}
