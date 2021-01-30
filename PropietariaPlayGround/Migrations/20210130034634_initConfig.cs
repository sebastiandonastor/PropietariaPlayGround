using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PropietariaPlayGround.Migrations
{
    public partial class initConfig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TiposMovimientos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposMovimientos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Asientos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumeroAsiento = table.Column<int>(type: "int", nullable: false),
                    IdTipoMovimiento = table.Column<int>(type: "int", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaEntrega = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Cuenta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MontoMovimiento = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Asientos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Asientos_TiposMovimientos_IdTipoMovimiento",
                        column: x => x.IdTipoMovimiento,
                        principalTable: "TiposMovimientos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "TiposMovimientos",
                columns: new[] { "Id", "Nombre" },
                values: new object[] { 1, "DB" });

            migrationBuilder.InsertData(
                table: "TiposMovimientos",
                columns: new[] { "Id", "Nombre" },
                values: new object[] { 2, "CR" });

            migrationBuilder.CreateIndex(
                name: "IX_Asientos_IdTipoMovimiento",
                table: "Asientos",
                column: "IdTipoMovimiento");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Asientos");

            migrationBuilder.DropTable(
                name: "TiposMovimientos");
        }
    }
}
