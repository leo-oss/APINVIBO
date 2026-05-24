using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APINVIBO.Migrations
{
    /// <inheritdoc />
    public partial class Inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Invitados",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false),
                    Apellido = table.Column<string>(type: "TEXT", nullable: false),
                    Asistira = table.Column<bool>(type: "INTEGER", nullable: false),
                    LlevaAcompanante = table.Column<bool>(type: "INTEGER", nullable: false),
                    NombreAcompanante = table.Column<string>(type: "TEXT", nullable: true),
                    TipoInvitado = table.Column<string>(type: "TEXT", nullable: true),
                    CantidadNinos = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invitados", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Invitados");
        }
    }
}
