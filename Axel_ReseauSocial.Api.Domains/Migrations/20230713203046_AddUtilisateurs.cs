using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Axel_ReseauSocial.Api.Domains.Migrations
{
    public partial class AddUtilisateurs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Utilisateur",
                columns: table => new
                {
                    IdUtilisateur = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWSEQUENTIALID()"),
                    Nom = table.Column<string>(type: "NVARCHAR(75)", nullable: false),
                    Prenom = table.Column<string>(type: "NVARCHAR(75)", nullable: false),
                    Email = table.Column<string>(type: "NVARCHAR(384)", nullable: false),
                    Passwd = table.Column<byte[]>(type: "BINARY(64)", nullable: false),
                    Sexe = table.Column<string>(type: "NVARCHAR(10)", nullable: false),
                    Date = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    Actif = table.Column<bool>(type: "BIT", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    LocaliteId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Utilisateur", x => x.IdUtilisateur);
                    table.ForeignKey(
                        name: "FK_Utilisateur_Localite_LocaliteId",
                        column: x => x.LocaliteId,
                        principalTable: "Localite",
                        principalColumn: "IdLocalite");
                    table.ForeignKey(
                        name: "FK_Utilisateur_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "IdRole");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Utilisateur_Email",
                table: "Utilisateur",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Utilisateur_LocaliteId",
                table: "Utilisateur",
                column: "LocaliteId");

            migrationBuilder.CreateIndex(
                name: "IX_Utilisateur_RoleId",
                table: "Utilisateur",
                column: "RoleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Utilisateur");
        }
    }
}
