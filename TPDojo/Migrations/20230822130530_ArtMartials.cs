using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TPDojo.Migrations
{
    /// <inheritdoc />
    public partial class ArtMartials : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ArtMartialId",
                table: "Samourai",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ArtMartial",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArtMartial", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 353 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 446 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 478 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 212 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 615 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 1686 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 1334 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 1823 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 1668 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 1720 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 1150 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 1022 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 1179 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 299 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 399 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 191 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 1538 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 939 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 1786 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 1389 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 240 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 1459 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 1849 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 1873 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 1161 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 514 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 57 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 1099 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 101 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 741 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 1677 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 478 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 1006 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 996 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 1000 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 1203 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 253 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 770 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 253 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 1809 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 445 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 1065 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 326 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 429 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 1325 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 1073 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 592 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 1723 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 1229 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 397 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 598 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 521 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 1947 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 842 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 294 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 1558 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 100 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 1717 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 1265 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 1515 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 1295 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 1792 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 551 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 758 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 37 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 1557 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 967 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 1368 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 544 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 1053 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 39 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 1031 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 99 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 1698 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 435 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 1644 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 1705 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 588 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 1577 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 664 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 975 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 530 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 1611 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 584 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 139 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 79 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 1698 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 603 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 414 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 1784 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 1132 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 39 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 72 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 1012 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 1023 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 349 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 673 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 1124 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 1531 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 1760 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 402 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 255 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 668 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 122 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 1241 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 941 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 1845 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 492 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 1106 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 326 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 1108 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 974 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 124 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 1669 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 591 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 1828 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 1789 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 34 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 1907 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 1964 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 370 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 319 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 1657 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 594 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 1921 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 819 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 361 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 873 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 1411 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 201 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 179 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 1501 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 404 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 70 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 520 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 348 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 354 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 848 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 1040 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 574 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 1192 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 73 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 1337 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 1880 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 59 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 9 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 309 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 986 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 1239 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 768 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 1021 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 433 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 575 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 414 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 475 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 396 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 396 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 264 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 94 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 307 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 255 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 1940 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 1760 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 1321 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 1991 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 1961 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 272 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 1182 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 962 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 416 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 682 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 1577 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 1702 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 1535 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 1242 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 1760 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 670 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 121 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 1664 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 792 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 584 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 127 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 681 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 1498 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 304 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 35 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 924 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 458 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 1431 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 1613 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 929 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 1048 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 387 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 497 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 1059 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 865 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 39 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 1733 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 1689 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 1974 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 95 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 61 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 1312 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 1347 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 72 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 802 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 504 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 765 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 321 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 926 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 286 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 1938 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 204 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 297 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 608 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 214 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 1143 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 738 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 38 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 1070 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 1518 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 555 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 1940 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 1155 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 351 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 282 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 1843 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 1084 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 1512 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 1050 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 580 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 552 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 1864 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 604 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 1231 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 875 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 332 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 846 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 1091 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 171 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 1181 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 851 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 330 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 525 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 422 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 955 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 1079 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 1223 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 275 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 880 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 80 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 1433 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 1212 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 254,
                column: "ArtMartialId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 1176 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 256,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 418 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 1130 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 258,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 1305 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 259,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 1158 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 260,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 1758 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 1459 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 262,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 1852 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 263,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 1930 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 264,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 521 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 265,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 1548 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 266,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 820 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 267,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 5 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 892 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 1603 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 1916 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 271,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 1053 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 272,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 1460 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 273,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 979 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 274,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 1395 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 742 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 276,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 257 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 1021 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 695 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 279,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 68 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 280,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 1662 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 26 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 282,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 1352 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 561 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 1716 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 697 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 512 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 1875 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 370 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 966 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 74 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 657 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 471 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 293,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 707 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 263 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 295,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 1530 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 296,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 950 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 297,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 608 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 298,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 1606 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 299,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 558 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 300,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 208 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 301,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 39 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 302,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 1961 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 303,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 1688 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 304,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 804 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 305,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 738 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 306,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 1332 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 307,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 1685 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 308,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 190 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 309,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 115 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 310,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 1434 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 799 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 312,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 723 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 313,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 402 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 314,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 1335 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 315,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 191 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 316,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 589 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 317,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 605 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 318,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 409 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 319,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 1707 });

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 320,
                columns: new[] { "ArtMartialId", "Force" },
                values: new object[] { null, 305 });

            migrationBuilder.CreateIndex(
                name: "IX_Samourai_ArtMartialId",
                table: "Samourai",
                column: "ArtMartialId");

            migrationBuilder.AddForeignKey(
                name: "FK_Samourai_ArtMartial_ArtMartialId",
                table: "Samourai",
                column: "ArtMartialId",
                principalTable: "ArtMartial",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Samourai_ArtMartial_ArtMartialId",
                table: "Samourai");

            migrationBuilder.DropTable(
                name: "ArtMartial");

            migrationBuilder.DropIndex(
                name: "IX_Samourai_ArtMartialId",
                table: "Samourai");

            migrationBuilder.DropColumn(
                name: "ArtMartialId",
                table: "Samourai");

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 1,
                column: "Force",
                value: 1876);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 2,
                column: "Force",
                value: 890);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 3,
                column: "Force",
                value: 467);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 4,
                column: "Force",
                value: 1452);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 5,
                column: "Force",
                value: 175);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 6,
                column: "Force",
                value: 473);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 7,
                column: "Force",
                value: 383);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 8,
                column: "Force",
                value: 1041);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 9,
                column: "Force",
                value: 1912);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 10,
                column: "Force",
                value: 736);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 11,
                column: "Force",
                value: 848);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 12,
                column: "Force",
                value: 1861);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 13,
                column: "Force",
                value: 1922);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 14,
                column: "Force",
                value: 1172);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 15,
                column: "Force",
                value: 220);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 16,
                column: "Force",
                value: 743);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 17,
                column: "Force",
                value: 1151);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 18,
                column: "Force",
                value: 617);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 19,
                column: "Force",
                value: 592);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 20,
                column: "Force",
                value: 560);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 21,
                column: "Force",
                value: 234);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 22,
                column: "Force",
                value: 1942);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 23,
                column: "Force",
                value: 16);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 24,
                column: "Force",
                value: 362);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 25,
                column: "Force",
                value: 1302);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 26,
                column: "Force",
                value: 144);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 27,
                column: "Force",
                value: 1902);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 28,
                column: "Force",
                value: 809);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 29,
                column: "Force",
                value: 544);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 30,
                column: "Force",
                value: 381);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 31,
                column: "Force",
                value: 1247);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 32,
                column: "Force",
                value: 416);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 33,
                column: "Force",
                value: 1064);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 34,
                column: "Force",
                value: 626);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 35,
                column: "Force",
                value: 145);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 36,
                column: "Force",
                value: 23);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 37,
                column: "Force",
                value: 1076);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 38,
                column: "Force",
                value: 412);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 39,
                column: "Force",
                value: 1523);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 40,
                column: "Force",
                value: 1527);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 41,
                column: "Force",
                value: 804);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 42,
                column: "Force",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 43,
                column: "Force",
                value: 1444);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 44,
                column: "Force",
                value: 1291);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 45,
                column: "Force",
                value: 1012);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 46,
                column: "Force",
                value: 355);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 47,
                column: "Force",
                value: 1973);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 48,
                column: "Force",
                value: 172);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 49,
                column: "Force",
                value: 1001);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 50,
                column: "Force",
                value: 1573);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 51,
                column: "Force",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 52,
                column: "Force",
                value: 1916);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 53,
                column: "Force",
                value: 1126);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 54,
                column: "Force",
                value: 1808);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 55,
                column: "Force",
                value: 335);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 56,
                column: "Force",
                value: 1505);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 57,
                column: "Force",
                value: 731);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 58,
                column: "Force",
                value: 824);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 59,
                column: "Force",
                value: 274);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 60,
                column: "Force",
                value: 180);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 61,
                column: "Force",
                value: 602);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 62,
                column: "Force",
                value: 1232);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 63,
                column: "Force",
                value: 39);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 64,
                column: "Force",
                value: 151);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 65,
                column: "Force",
                value: 1790);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 66,
                column: "Force",
                value: 1580);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 67,
                column: "Force",
                value: 990);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 68,
                column: "Force",
                value: 1079);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 69,
                column: "Force",
                value: 204);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 70,
                column: "Force",
                value: 1869);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 71,
                column: "Force",
                value: 1929);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 72,
                column: "Force",
                value: 316);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 73,
                column: "Force",
                value: 805);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 74,
                column: "Force",
                value: 1547);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 75,
                column: "Force",
                value: 968);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 76,
                column: "Force",
                value: 1426);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 77,
                column: "Force",
                value: 32);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 78,
                column: "Force",
                value: 1337);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 79,
                column: "Force",
                value: 743);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 80,
                column: "Force",
                value: 1380);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 81,
                column: "Force",
                value: 504);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 82,
                column: "Force",
                value: 1821);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 83,
                column: "Force",
                value: 533);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 84,
                column: "Force",
                value: 1378);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 85,
                column: "Force",
                value: 545);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 86,
                column: "Force",
                value: 1888);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 87,
                column: "Force",
                value: 938);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 88,
                column: "Force",
                value: 1048);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 89,
                column: "Force",
                value: 1170);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 90,
                column: "Force",
                value: 1344);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 91,
                column: "Force",
                value: 1029);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 92,
                column: "Force",
                value: 1352);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 93,
                column: "Force",
                value: 145);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 94,
                column: "Force",
                value: 1712);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 95,
                column: "Force",
                value: 565);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 96,
                column: "Force",
                value: 877);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 97,
                column: "Force",
                value: 92);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 98,
                column: "Force",
                value: 1711);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 99,
                column: "Force",
                value: 445);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 100,
                column: "Force",
                value: 408);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 101,
                column: "Force",
                value: 1235);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 102,
                column: "Force",
                value: 1683);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 103,
                column: "Force",
                value: 1823);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 104,
                column: "Force",
                value: 473);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 105,
                column: "Force",
                value: 755);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 106,
                column: "Force",
                value: 1513);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 107,
                column: "Force",
                value: 1868);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 108,
                column: "Force",
                value: 1995);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 109,
                column: "Force",
                value: 1634);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 110,
                column: "Force",
                value: 293);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 111,
                column: "Force",
                value: 117);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 112,
                column: "Force",
                value: 1922);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 113,
                column: "Force",
                value: 1848);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 114,
                column: "Force",
                value: 1208);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 115,
                column: "Force",
                value: 1769);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 116,
                column: "Force",
                value: 743);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 117,
                column: "Force",
                value: 235);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 118,
                column: "Force",
                value: 775);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 119,
                column: "Force",
                value: 1761);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 120,
                column: "Force",
                value: 286);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 121,
                column: "Force",
                value: 1050);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 122,
                column: "Force",
                value: 65);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 123,
                column: "Force",
                value: 732);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 124,
                column: "Force",
                value: 668);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 125,
                column: "Force",
                value: 802);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 126,
                column: "Force",
                value: 558);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 127,
                column: "Force",
                value: 349);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 128,
                column: "Force",
                value: 408);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 129,
                column: "Force",
                value: 733);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 130,
                column: "Force",
                value: 1236);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 131,
                column: "Force",
                value: 988);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 132,
                column: "Force",
                value: 675);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 133,
                column: "Force",
                value: 438);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 134,
                column: "Force",
                value: 991);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 135,
                column: "Force",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 136,
                column: "Force",
                value: 104);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 137,
                column: "Force",
                value: 97);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 138,
                column: "Force",
                value: 150);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 139,
                column: "Force",
                value: 965);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 140,
                column: "Force",
                value: 660);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 141,
                column: "Force",
                value: 691);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 142,
                column: "Force",
                value: 917);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 143,
                column: "Force",
                value: 1951);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 144,
                column: "Force",
                value: 1812);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 145,
                column: "Force",
                value: 1296);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 146,
                column: "Force",
                value: 580);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 147,
                column: "Force",
                value: 1061);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 148,
                column: "Force",
                value: 1616);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 149,
                column: "Force",
                value: 531);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 150,
                column: "Force",
                value: 465);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 151,
                column: "Force",
                value: 1569);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 152,
                column: "Force",
                value: 484);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 153,
                column: "Force",
                value: 1943);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 154,
                column: "Force",
                value: 310);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 155,
                column: "Force",
                value: 831);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 156,
                column: "Force",
                value: 1756);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 157,
                column: "Force",
                value: 222);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 158,
                column: "Force",
                value: 1485);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 159,
                column: "Force",
                value: 663);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 160,
                column: "Force",
                value: 674);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 161,
                column: "Force",
                value: 1523);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 162,
                column: "Force",
                value: 993);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 163,
                column: "Force",
                value: 1373);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 164,
                column: "Force",
                value: 509);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 165,
                column: "Force",
                value: 1389);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 166,
                column: "Force",
                value: 391);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 167,
                column: "Force",
                value: 1377);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 168,
                column: "Force",
                value: 1205);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 169,
                column: "Force",
                value: 904);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 170,
                column: "Force",
                value: 306);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 171,
                column: "Force",
                value: 677);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 172,
                column: "Force",
                value: 306);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 173,
                column: "Force",
                value: 708);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 174,
                column: "Force",
                value: 220);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 175,
                column: "Force",
                value: 840);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 176,
                column: "Force",
                value: 1937);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 177,
                column: "Force",
                value: 1314);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 178,
                column: "Force",
                value: 1541);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 179,
                column: "Force",
                value: 754);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 180,
                column: "Force",
                value: 1046);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 181,
                column: "Force",
                value: 1028);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 182,
                column: "Force",
                value: 1317);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 183,
                column: "Force",
                value: 78);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 184,
                column: "Force",
                value: 938);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 185,
                column: "Force",
                value: 480);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 186,
                column: "Force",
                value: 1242);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 187,
                column: "Force",
                value: 1634);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 188,
                column: "Force",
                value: 447);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 189,
                column: "Force",
                value: 301);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 190,
                column: "Force",
                value: 351);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 191,
                column: "Force",
                value: 502);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 192,
                column: "Force",
                value: 862);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 193,
                column: "Force",
                value: 583);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 194,
                column: "Force",
                value: 1516);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 195,
                column: "Force",
                value: 239);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 196,
                column: "Force",
                value: 989);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 197,
                column: "Force",
                value: 1350);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 198,
                column: "Force",
                value: 298);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 199,
                column: "Force",
                value: 1789);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 200,
                column: "Force",
                value: 293);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 201,
                column: "Force",
                value: 890);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 202,
                column: "Force",
                value: 1179);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 203,
                column: "Force",
                value: 1681);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 204,
                column: "Force",
                value: 1822);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 205,
                column: "Force",
                value: 715);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 206,
                column: "Force",
                value: 393);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 207,
                column: "Force",
                value: 974);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 208,
                column: "Force",
                value: 675);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 209,
                column: "Force",
                value: 1259);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 210,
                column: "Force",
                value: 1575);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 211,
                column: "Force",
                value: 1783);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 212,
                column: "Force",
                value: 915);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 213,
                column: "Force",
                value: 1167);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 214,
                column: "Force",
                value: 1416);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 215,
                column: "Force",
                value: 585);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 216,
                column: "Force",
                value: 1464);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 217,
                column: "Force",
                value: 1550);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 218,
                column: "Force",
                value: 1500);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 219,
                column: "Force",
                value: 554);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 220,
                column: "Force",
                value: 327);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 221,
                column: "Force",
                value: 108);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 222,
                column: "Force",
                value: 842);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 223,
                column: "Force",
                value: 1158);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 224,
                column: "Force",
                value: 944);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 225,
                column: "Force",
                value: 811);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 226,
                column: "Force",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 227,
                column: "Force",
                value: 1928);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 228,
                column: "Force",
                value: 854);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 229,
                column: "Force",
                value: 1392);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 230,
                column: "Force",
                value: 1447);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 231,
                column: "Force",
                value: 633);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 232,
                column: "Force",
                value: 401);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 233,
                column: "Force",
                value: 1290);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 234,
                column: "Force",
                value: 1775);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 235,
                column: "Force",
                value: 1939);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 236,
                column: "Force",
                value: 569);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 237,
                column: "Force",
                value: 866);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 238,
                column: "Force",
                value: 41);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 239,
                column: "Force",
                value: 1284);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 240,
                column: "Force",
                value: 276);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 241,
                column: "Force",
                value: 33);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 242,
                column: "Force",
                value: 963);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 243,
                column: "Force",
                value: 1079);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 244,
                column: "Force",
                value: 1904);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 245,
                column: "Force",
                value: 189);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 246,
                column: "Force",
                value: 313);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 247,
                column: "Force",
                value: 748);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 248,
                column: "Force",
                value: 723);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 249,
                column: "Force",
                value: 1107);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 250,
                column: "Force",
                value: 676);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 251,
                column: "Force",
                value: 39);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 252,
                column: "Force",
                value: 1106);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 253,
                column: "Force",
                value: 1863);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 255,
                column: "Force",
                value: 1736);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 256,
                column: "Force",
                value: 125);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 257,
                column: "Force",
                value: 55);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 258,
                column: "Force",
                value: 310);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 259,
                column: "Force",
                value: 1591);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 260,
                column: "Force",
                value: 1252);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 261,
                column: "Force",
                value: 1499);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 262,
                column: "Force",
                value: 1825);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 263,
                column: "Force",
                value: 848);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 264,
                column: "Force",
                value: 1386);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 265,
                column: "Force",
                value: 1272);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 266,
                column: "Force",
                value: 1206);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 267,
                column: "Force",
                value: 201);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 268,
                column: "Force",
                value: 1313);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 269,
                column: "Force",
                value: 124);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 270,
                column: "Force",
                value: 1076);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 271,
                column: "Force",
                value: 417);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 272,
                column: "Force",
                value: 418);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 273,
                column: "Force",
                value: 1820);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 274,
                column: "Force",
                value: 1226);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 275,
                column: "Force",
                value: 1845);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 276,
                column: "Force",
                value: 1294);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 277,
                column: "Force",
                value: 1176);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 278,
                column: "Force",
                value: 1614);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 279,
                column: "Force",
                value: 1453);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 280,
                column: "Force",
                value: 701);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 281,
                column: "Force",
                value: 1031);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 282,
                column: "Force",
                value: 589);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 283,
                column: "Force",
                value: 1851);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 284,
                column: "Force",
                value: 1205);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 285,
                column: "Force",
                value: 705);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 286,
                column: "Force",
                value: 1524);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 287,
                column: "Force",
                value: 1612);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 288,
                column: "Force",
                value: 1476);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 289,
                column: "Force",
                value: 1654);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 290,
                column: "Force",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 291,
                column: "Force",
                value: 73);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 292,
                column: "Force",
                value: 1500);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 293,
                column: "Force",
                value: 1041);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 294,
                column: "Force",
                value: 1775);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 295,
                column: "Force",
                value: 1638);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 296,
                column: "Force",
                value: 463);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 297,
                column: "Force",
                value: 989);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 298,
                column: "Force",
                value: 1625);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 299,
                column: "Force",
                value: 1371);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 300,
                column: "Force",
                value: 1079);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 301,
                column: "Force",
                value: 1622);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 302,
                column: "Force",
                value: 1116);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 303,
                column: "Force",
                value: 1559);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 304,
                column: "Force",
                value: 807);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 305,
                column: "Force",
                value: 600);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 306,
                column: "Force",
                value: 1879);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 307,
                column: "Force",
                value: 403);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 308,
                column: "Force",
                value: 326);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 309,
                column: "Force",
                value: 1565);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 310,
                column: "Force",
                value: 1475);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 311,
                column: "Force",
                value: 1930);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 312,
                column: "Force",
                value: 999);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 313,
                column: "Force",
                value: 1882);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 314,
                column: "Force",
                value: 371);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 315,
                column: "Force",
                value: 1668);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 316,
                column: "Force",
                value: 1225);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 317,
                column: "Force",
                value: 1235);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 318,
                column: "Force",
                value: 37);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 319,
                column: "Force",
                value: 71);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 320,
                column: "Force",
                value: 807);
        }
    }
}
