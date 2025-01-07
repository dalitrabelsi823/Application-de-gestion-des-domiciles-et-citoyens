using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Examen.Infrastructure.Migrations
{
    public partial class InitBDD : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Batiments",
                columns: table => new
                {
                    Code = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adresse = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Superficie = table.Column<int>(type: "int", nullable: false),
                    SuperficieVente = table.Column<int>(type: "int", nullable: false),
                    Gouvernorat = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ville = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Batiments", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "Citoyens",
                columns: table => new
                {
                    Code = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CIN = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    NomPrenom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MySexe = table.Column<int>(type: "int", nullable: false),
                    DateNaissance = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MyEducation = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Citoyens", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "Domiciles",
                columns: table => new
                {
                    Code = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NbrChambre = table.Column<int>(type: "int", nullable: false),
                    Superficie = table.Column<int>(type: "int", nullable: false),
                    Etage = table.Column<int>(type: "int", nullable: false),
                    BatimentFK = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Domiciles", x => x.Code);
                    table.ForeignKey(
                        name: "FK_Domiciles_Batiments_BatimentFK",
                        column: x => x.BatimentFK,
                        principalTable: "Batiments",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Domicilaitions",
                columns: table => new
                {
                    CitoyenCode = table.Column<int>(type: "int", nullable: false),
                    DomicileCode = table.Column<int>(type: "int", nullable: false),
                    MyTypeDommiciliation = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Domicilaitions", x => new { x.CitoyenCode, x.DomicileCode });
                    table.ForeignKey(
                        name: "FK_Domicilaitions_Citoyens_CitoyenCode",
                        column: x => x.CitoyenCode,
                        principalTable: "Citoyens",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Domicilaitions_Domiciles_DomicileCode",
                        column: x => x.DomicileCode,
                        principalTable: "Domiciles",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Domicilaitions_DomicileCode",
                table: "Domicilaitions",
                column: "DomicileCode");

            migrationBuilder.CreateIndex(
                name: "IX_Domiciles_BatimentFK",
                table: "Domiciles",
                column: "BatimentFK");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Domicilaitions");

            migrationBuilder.DropTable(
                name: "Citoyens");

            migrationBuilder.DropTable(
                name: "Domiciles");

            migrationBuilder.DropTable(
                name: "Batiments");
        }
    }
}
