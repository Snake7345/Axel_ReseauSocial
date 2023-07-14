using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Axel_ReseauSocial.Api.Domains.Migrations
{
    public partial class AddContenu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contenu",
                columns: table => new
                {
                    IdContenu = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWSEQUENTIALID()"),
                    Texte = table.Column<string>(type: "NVARCHAR(3000)", nullable: false),
                    DateCreation = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    CommentaireId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PublicationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PvId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contenu", x => x.IdContenu);
                    table.ForeignKey(
                        name: "FK_Contenu_Commentaire_CommentaireId",
                        column: x => x.CommentaireId,
                        principalTable: "Commentaire",
                        principalColumn: "IdCommentaire");
                    table.ForeignKey(
                        name: "FK_Contenu_Publication_PublicationId",
                        column: x => x.PublicationId,
                        principalTable: "Publication",
                        principalColumn: "IdPublication");
                    table.ForeignKey(
                        name: "FK_Contenu_Pv_PvId",
                        column: x => x.PvId,
                        principalTable: "Pv",
                        principalColumn: "IdPv");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contenu_CommentaireId",
                table: "Contenu",
                column: "CommentaireId");

            migrationBuilder.CreateIndex(
                name: "IX_Contenu_PublicationId",
                table: "Contenu",
                column: "PublicationId");

            migrationBuilder.CreateIndex(
                name: "IX_Contenu_PvId",
                table: "Contenu",
                column: "PvId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contenu");
        }
    }
}
