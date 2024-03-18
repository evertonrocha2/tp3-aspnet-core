using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tp3.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "computadores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Marca = table.Column<string>(type: "TEXT", nullable: false),
                    Processador = table.Column<string>(type: "TEXT", nullable: false),
                    PlacaMae = table.Column<string>(type: "TEXT", nullable: false),
                    Memoria = table.Column<string>(type: "TEXT", nullable: false),
                    Hd = table.Column<string>(type: "TEXT", nullable: false),
                    NumeroPatrimonio = table.Column<int>(type: "INTEGER", nullable: false),
                    DataDeCompra = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_computadores", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "computadores");
        }
    }
}
