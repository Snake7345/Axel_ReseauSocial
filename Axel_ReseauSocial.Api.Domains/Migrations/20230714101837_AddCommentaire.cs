using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Axel_ReseauSocial.Api.Domains.Migrations
{
    public partial class AddCommentaire : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Commentaire",
                columns: table => new
                {
                    IdCommentaire = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWSEQUENTIALID()"),
                    UtilisateurId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PublicationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Commentaire", x => x.IdCommentaire);
                    table.ForeignKey(
                        name: "FK_Commentaire_Publication_PublicationId",
                        column: x => x.PublicationId,
                        principalTable: "Publication",
                        principalColumn: "IdPublication");
                    table.ForeignKey(
                        name: "FK_Commentaire_Utilisateur_UtilisateurId",
                        column: x => x.UtilisateurId,
                        principalTable: "Utilisateur",
                        principalColumn: "IdUtilisateur");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Commentaire_PublicationId",
                table: "Commentaire",
                column: "PublicationId");

            migrationBuilder.CreateIndex(
                name: "IX_Commentaire_UtilisateurId",
                table: "Commentaire",
                column: "UtilisateurId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Commentaire");
        }
    }
}
