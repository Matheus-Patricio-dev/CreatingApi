using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ApiCars.Migrations
{
    /// <inheritdoc />
    public partial class VinculoCarroFabricante : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Car",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Model = table.Column<string>(type: "text", nullable: false),
                    Type = table.Column<string>(type: "text", nullable: false),
                    FabricationYear = table.Column<int>(type: "integer", nullable: false),


                },

                constraints: table =>
                {
                    table.PrimaryKey("PK_Car", x => x.Id);
                });
            migrationBuilder.AddColumn<int>
                (
                    name: "FabricanteId",
                    table: "Car",
                    type: "int",
                    nullable: false
                );
            migrationBuilder.CreateIndex
                (
                    name: "IX_Car_FabricanteId",
                    table: "Car",
                    column: "FabricanteId"
                );
            migrationBuilder.AddForeignKey
                (
                    name: "FK_Car_Fabricante_FabricanteID",
                    table: "Car",
                    column: "FabricanteId",
                    principalTable: "Fabricante",
                    principalColumn: "Id"
                );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey
                (
                    name: "FK_Car_Fabricante_FabricanteId",
                    table: "Car"
                );
            migrationBuilder.DropIndex
                (
                    name: "IX_Car_FabricanteId",
                    table: "Car"
                );
        }
    }
}
