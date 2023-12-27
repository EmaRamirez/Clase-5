using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Clase5.Migrations
{
    /// <inheritdoc />
    public partial class tercerMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Patente",
                table: "Cars",
                newName: "color");

            migrationBuilder.RenameColumn(
                name: "Modelo",
                table: "Cars",
                newName: "Plate");

            migrationBuilder.RenameColumn(
                name: "Marca",
                table: "Cars",
                newName: "Model");

            migrationBuilder.RenameColumn(
                name: "Año",
                table: "Cars",
                newName: "Year");

            migrationBuilder.AddColumn<string>(
                name: "Make",
                table: "Cars",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Make",
                table: "Cars");

            migrationBuilder.RenameColumn(
                name: "color",
                table: "Cars",
                newName: "Patente");

            migrationBuilder.RenameColumn(
                name: "Year",
                table: "Cars",
                newName: "Año");

            migrationBuilder.RenameColumn(
                name: "Plate",
                table: "Cars",
                newName: "Modelo");

            migrationBuilder.RenameColumn(
                name: "Model",
                table: "Cars",
                newName: "Marca");
        }
    }
}
