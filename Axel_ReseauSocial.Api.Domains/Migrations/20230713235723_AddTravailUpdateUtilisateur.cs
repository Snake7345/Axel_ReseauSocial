﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Axel_ReseauSocial.Api.Domains.Migrations
{
    public partial class AddTravailUpdateUtilisateur : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "Actif",
                table: "Utilisateur",
                type: "BIT",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "BIT");

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
                    Denomination = table.Column<string>(type: "NVARCHAR(255)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Travail", x => x.IdTravail);
                });

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

            migrationBuilder.AlterColumn<bool>(
                name: "Actif",
                table: "Utilisateur",
                type: "BIT",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "BIT",
                oldDefaultValue: true);
        }
    }
}
