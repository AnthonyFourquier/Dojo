using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TPDojo.Migrations
{
    /// <inheritdoc />
    public partial class Initale : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Arme",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Degat = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Arme", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Samourai",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Force = table.Column<int>(type: "int", nullable: false),
                    ArmeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Samourai", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Samourai_Arme_ArmeId",
                        column: x => x.ArmeId,
                        principalTable: "Arme",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Samourai_ArmeId",
                table: "Samourai",
                column: "ArmeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Samourai");

            migrationBuilder.DropTable(
                name: "Arme");
        }
    }
}
