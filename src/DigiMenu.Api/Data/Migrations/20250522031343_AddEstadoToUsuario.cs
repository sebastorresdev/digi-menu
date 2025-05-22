using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DigiMenu.Api.Migrations
{
    /// <inheritdoc />
    public partial class AddEstadoToUsuario : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Estado",
                table: "usuarios",
                type: "boolean",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Estado",
                table: "usuarios");
        }
    }
}
