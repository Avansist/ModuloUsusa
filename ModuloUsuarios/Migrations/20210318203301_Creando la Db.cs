using Microsoft.EntityFrameworkCore.Migrations;

namespace ModuloUsuarios.Migrations
{
    public partial class CreandolaDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    rolId = table.Column<string>(nullable: false),
                    Mombre = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.rolId);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    usuarioId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(nullable: true),
                    correo = table.Column<string>(nullable: true),
                    telefono = table.Column<int>(nullable: false),
                    contraseña = table.Column<string>(nullable: true),
                    ConfirmarContraseña = table.Column<string>(nullable: true),
                    estado = table.Column<string>(nullable: true),
                    rolId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.usuarioId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
