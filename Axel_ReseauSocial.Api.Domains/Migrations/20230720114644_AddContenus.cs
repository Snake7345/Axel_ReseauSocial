using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Axel_ReseauSocial.Api.Domains.Migrations
{
    public partial class AddContenus : Migration
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

            migrationBuilder.CreateTable(
                name: "Publication",
                columns: table => new
                {
                    IdPublication = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWSEQUENTIALID()"),
                    DateCreation = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    Texte = table.Column<string>(type: "NVARCHAR(2000)", nullable: false),
                    UtilisateurId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Publication", x => x.IdPublication);
                    table.ForeignKey(
                        name: "FK_Publication_Utilisateur_UtilisateurId",
                        column: x => x.UtilisateurId,
                        principalTable: "Utilisateur",
                        principalColumn: "IdUtilisateur");
                });

            migrationBuilder.CreateTable(
                name: "Pv",
                columns: table => new
                {
                    IdPv = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWSEQUENTIALID()"),
                    DateCreation = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    Texte = table.Column<string>(type: "NVARCHAR(2000)", nullable: false),
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

            migrationBuilder.CreateTable(
                name: "Commentaire",
                columns: table => new
                {
                    IdCommentaire = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWSEQUENTIALID()"),
                    DateCreation = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    Texte = table.Column<string>(type: "NVARCHAR(2000)", nullable: false),
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
                name: "IX_Amitie_DestinataireId",
                table: "Amitie",
                column: "DestinataireId");

            migrationBuilder.CreateIndex(
                name: "IX_Amitie_DestinateurId",
                table: "Amitie",
                column: "DestinateurId");

            migrationBuilder.CreateIndex(
                name: "IX_Commentaire_PublicationId",
                table: "Commentaire",
                column: "PublicationId");

            migrationBuilder.CreateIndex(
                name: "IX_Commentaire_UtilisateurId",
                table: "Commentaire",
                column: "UtilisateurId");

            migrationBuilder.CreateIndex(
                name: "IX_Publication_UtilisateurId",
                table: "Publication",
                column: "UtilisateurId");

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
                name: "Amitie");

            migrationBuilder.DropTable(
                name: "Commentaire");

            migrationBuilder.DropTable(
                name: "Pv");

            migrationBuilder.DropTable(
                name: "Publication");
        }
    }
}
