using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TPDojo.Migrations
{
    /// <inheritdoc />
    public partial class ArtMartialSamouraiAddEntityKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ArtMartialSamourai_ArtMartial_ArtMartialId",
                table: "ArtMartialSamourai");

            migrationBuilder.DropForeignKey(
                name: "FK_ArtMartialSamourai_Samourai_SamouraiId",
                table: "ArtMartialSamourai");

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 1,
                column: "Force",
                value: 920);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 2,
                column: "Force",
                value: 772);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 3,
                column: "Force",
                value: 632);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 4,
                column: "Force",
                value: 1489);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 5,
                column: "Force",
                value: 1483);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 6,
                column: "Force",
                value: 239);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 7,
                column: "Force",
                value: 1932);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 8,
                column: "Force",
                value: 773);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 9,
                column: "Force",
                value: 1489);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 10,
                column: "Force",
                value: 89);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 11,
                column: "Force",
                value: 1071);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 12,
                column: "Force",
                value: 1382);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 13,
                column: "Force",
                value: 1062);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 14,
                column: "Force",
                value: 394);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 15,
                column: "Force",
                value: 658);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 16,
                column: "Force",
                value: 1590);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 17,
                column: "Force",
                value: 122);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 18,
                column: "Force",
                value: 540);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 19,
                column: "Force",
                value: 1686);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 20,
                column: "Force",
                value: 1969);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 21,
                column: "Force",
                value: 1757);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 22,
                column: "Force",
                value: 1102);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 23,
                column: "Force",
                value: 1357);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 24,
                column: "Force",
                value: 538);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 25,
                column: "Force",
                value: 1822);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 26,
                column: "Force",
                value: 1073);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 27,
                column: "Force",
                value: 1975);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 28,
                column: "Force",
                value: 195);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 29,
                column: "Force",
                value: 1221);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 30,
                column: "Force",
                value: 1989);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 31,
                column: "Force",
                value: 1126);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 32,
                column: "Force",
                value: 195);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 33,
                column: "Force",
                value: 1663);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 34,
                column: "Force",
                value: 1010);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 35,
                column: "Force",
                value: 555);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 36,
                column: "Force",
                value: 510);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 37,
                column: "Force",
                value: 1009);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 38,
                column: "Force",
                value: 1489);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 39,
                column: "Force",
                value: 1566);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 40,
                column: "Force",
                value: 1622);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 41,
                column: "Force",
                value: 755);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 42,
                column: "Force",
                value: 808);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 43,
                column: "Force",
                value: 1626);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 44,
                column: "Force",
                value: 662);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 45,
                column: "Force",
                value: 1537);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 46,
                column: "Force",
                value: 248);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 47,
                column: "Force",
                value: 1970);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 48,
                column: "Force",
                value: 143);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 49,
                column: "Force",
                value: 915);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 50,
                column: "Force",
                value: 1597);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 51,
                column: "Force",
                value: 1840);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 52,
                column: "Force",
                value: 1700);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 53,
                column: "Force",
                value: 1849);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 54,
                column: "Force",
                value: 299);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 55,
                column: "Force",
                value: 1821);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 56,
                column: "Force",
                value: 660);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 57,
                column: "Force",
                value: 1144);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 58,
                column: "Force",
                value: 882);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 59,
                column: "Force",
                value: 1424);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 60,
                column: "Force",
                value: 167);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 61,
                column: "Force",
                value: 489);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 62,
                column: "Force",
                value: 1525);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 63,
                column: "Force",
                value: 498);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 64,
                column: "Force",
                value: 1732);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 65,
                column: "Force",
                value: 685);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 66,
                column: "Force",
                value: 676);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 67,
                column: "Force",
                value: 924);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 68,
                column: "Force",
                value: 842);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 69,
                column: "Force",
                value: 1048);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 70,
                column: "Force",
                value: 1570);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 71,
                column: "Force",
                value: 1943);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 72,
                column: "Force",
                value: 62);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 73,
                column: "Force",
                value: 1303);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 74,
                column: "Force",
                value: 1875);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 75,
                column: "Force",
                value: 1751);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 76,
                column: "Force",
                value: 699);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 77,
                column: "Force",
                value: 1562);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 78,
                column: "Force",
                value: 550);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 79,
                column: "Force",
                value: 1444);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 80,
                column: "Force",
                value: 1883);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 81,
                column: "Force",
                value: 885);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 82,
                column: "Force",
                value: 1161);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 83,
                column: "Force",
                value: 1914);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 84,
                column: "Force",
                value: 981);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 85,
                column: "Force",
                value: 1989);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 86,
                column: "Force",
                value: 1587);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 87,
                column: "Force",
                value: 1023);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 88,
                column: "Force",
                value: 1957);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 89,
                column: "Force",
                value: 642);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 90,
                column: "Force",
                value: 220);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 91,
                column: "Force",
                value: 930);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 92,
                column: "Force",
                value: 500);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 93,
                column: "Force",
                value: 1875);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 94,
                column: "Force",
                value: 988);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 95,
                column: "Force",
                value: 767);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 96,
                column: "Force",
                value: 701);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 97,
                column: "Force",
                value: 1787);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 98,
                column: "Force",
                value: 1392);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 99,
                column: "Force",
                value: 1784);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 100,
                column: "Force",
                value: 306);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 101,
                column: "Force",
                value: 1041);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 102,
                column: "Force",
                value: 630);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 103,
                column: "Force",
                value: 246);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 104,
                column: "Force",
                value: 1562);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 105,
                column: "Force",
                value: 1349);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 106,
                column: "Force",
                value: 822);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 107,
                column: "Force",
                value: 1292);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 108,
                column: "Force",
                value: 1631);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 109,
                column: "Force",
                value: 1005);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 110,
                column: "Force",
                value: 1488);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 111,
                column: "Force",
                value: 867);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 112,
                column: "Force",
                value: 302);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 113,
                column: "Force",
                value: 35);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 114,
                column: "Force",
                value: 622);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 115,
                column: "Force",
                value: 1951);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 116,
                column: "Force",
                value: 1146);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 117,
                column: "Force",
                value: 1621);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 118,
                column: "Force",
                value: 1220);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 119,
                column: "Force",
                value: 568);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 120,
                column: "Force",
                value: 442);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 121,
                column: "Force",
                value: 956);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 122,
                column: "Force",
                value: 1031);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 123,
                column: "Force",
                value: 210);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 124,
                column: "Force",
                value: 1310);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 125,
                column: "Force",
                value: 281);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 126,
                column: "Force",
                value: 244);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 127,
                column: "Force",
                value: 429);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 128,
                column: "Force",
                value: 1669);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 129,
                column: "Force",
                value: 1741);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 130,
                column: "Force",
                value: 1486);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 131,
                column: "Force",
                value: 796);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 132,
                column: "Force",
                value: 1704);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 133,
                column: "Force",
                value: 447);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 134,
                column: "Force",
                value: 1208);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 135,
                column: "Force",
                value: 1239);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 136,
                column: "Force",
                value: 1267);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 137,
                column: "Force",
                value: 1405);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 138,
                column: "Force",
                value: 1477);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 139,
                column: "Force",
                value: 1971);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 140,
                column: "Force",
                value: 801);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 141,
                column: "Force",
                value: 323);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 142,
                column: "Force",
                value: 1707);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 143,
                column: "Force",
                value: 446);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 144,
                column: "Force",
                value: 1998);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 145,
                column: "Force",
                value: 950);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 146,
                column: "Force",
                value: 904);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 147,
                column: "Force",
                value: 169);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 148,
                column: "Force",
                value: 1259);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 149,
                column: "Force",
                value: 421);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 150,
                column: "Force",
                value: 1896);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 151,
                column: "Force",
                value: 1581);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 152,
                column: "Force",
                value: 961);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 153,
                column: "Force",
                value: 1526);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 154,
                column: "Force",
                value: 593);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 155,
                column: "Force",
                value: 576);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 156,
                column: "Force",
                value: 292);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 157,
                column: "Force",
                value: 634);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 158,
                column: "Force",
                value: 1353);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 159,
                column: "Force",
                value: 1560);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 160,
                column: "Force",
                value: 336);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 161,
                column: "Force",
                value: 363);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 162,
                column: "Force",
                value: 880);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 163,
                column: "Force",
                value: 356);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 164,
                column: "Force",
                value: 1657);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 165,
                column: "Force",
                value: 1843);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 166,
                column: "Force",
                value: 136);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 167,
                column: "Force",
                value: 1363);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 168,
                column: "Force",
                value: 438);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 169,
                column: "Force",
                value: 617);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 170,
                column: "Force",
                value: 1496);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 171,
                column: "Force",
                value: 572);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 172,
                column: "Force",
                value: 394);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 173,
                column: "Force",
                value: 1314);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 174,
                column: "Force",
                value: 494);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 175,
                column: "Force",
                value: 1415);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 176,
                column: "Force",
                value: 1657);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 177,
                column: "Force",
                value: 1774);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 178,
                column: "Force",
                value: 581);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 179,
                column: "Force",
                value: 1512);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 180,
                column: "Force",
                value: 741);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 181,
                column: "Force",
                value: 1595);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 182,
                column: "Force",
                value: 499);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 183,
                column: "Force",
                value: 832);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 184,
                column: "Force",
                value: 1312);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 185,
                column: "Force",
                value: 699);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 186,
                column: "Force",
                value: 71);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 187,
                column: "Force",
                value: 16);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 188,
                column: "Force",
                value: 124);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 189,
                column: "Force",
                value: 1659);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 190,
                column: "Force",
                value: 1061);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 191,
                column: "Force",
                value: 1820);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 192,
                column: "Force",
                value: 1521);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 193,
                column: "Force",
                value: 421);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 194,
                column: "Force",
                value: 226);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 195,
                column: "Force",
                value: 1077);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 196,
                column: "Force",
                value: 1027);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 197,
                column: "Force",
                value: 1015);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 198,
                column: "Force",
                value: 421);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 199,
                column: "Force",
                value: 1571);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 200,
                column: "Force",
                value: 1946);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 201,
                column: "Force",
                value: 1775);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 202,
                column: "Force",
                value: 794);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 203,
                column: "Force",
                value: 1824);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 204,
                column: "Force",
                value: 200);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 205,
                column: "Force",
                value: 1621);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 206,
                column: "Force",
                value: 1549);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 207,
                column: "Force",
                value: 1901);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 208,
                column: "Force",
                value: 15);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 209,
                column: "Force",
                value: 397);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 210,
                column: "Force",
                value: 621);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 211,
                column: "Force",
                value: 775);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 212,
                column: "Force",
                value: 1421);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 213,
                column: "Force",
                value: 186);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 214,
                column: "Force",
                value: 726);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 215,
                column: "Force",
                value: 453);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 216,
                column: "Force",
                value: 1488);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 217,
                column: "Force",
                value: 683);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 218,
                column: "Force",
                value: 1235);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 219,
                column: "Force",
                value: 1416);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 220,
                column: "Force",
                value: 1678);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 221,
                column: "Force",
                value: 1775);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 222,
                column: "Force",
                value: 1649);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 223,
                column: "Force",
                value: 172);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 224,
                column: "Force",
                value: 645);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 225,
                column: "Force",
                value: 1810);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 226,
                column: "Force",
                value: 214);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 227,
                column: "Force",
                value: 122);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 228,
                column: "Force",
                value: 131);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 229,
                column: "Force",
                value: 1408);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 230,
                column: "Force",
                value: 1356);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 231,
                column: "Force",
                value: 1828);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 232,
                column: "Force",
                value: 774);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 233,
                column: "Force",
                value: 1747);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 234,
                column: "Force",
                value: 1853);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 235,
                column: "Force",
                value: 1066);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 236,
                column: "Force",
                value: 914);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 237,
                column: "Force",
                value: 1636);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 238,
                column: "Force",
                value: 1117);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 239,
                column: "Force",
                value: 416);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 240,
                column: "Force",
                value: 1565);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 241,
                column: "Force",
                value: 1416);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 242,
                column: "Force",
                value: 690);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 243,
                column: "Force",
                value: 768);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 244,
                column: "Force",
                value: 985);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 245,
                column: "Force",
                value: 1471);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 246,
                column: "Force",
                value: 1270);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 247,
                column: "Force",
                value: 367);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 248,
                column: "Force",
                value: 992);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 249,
                column: "Force",
                value: 1378);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 250,
                column: "Force",
                value: 685);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 251,
                column: "Force",
                value: 1115);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 252,
                column: "Force",
                value: 566);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 253,
                column: "Force",
                value: 1171);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 254,
                column: "Force",
                value: 1184);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 255,
                column: "Force",
                value: 1798);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 256,
                column: "Force",
                value: 771);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 257,
                column: "Force",
                value: 1169);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 258,
                column: "Force",
                value: 1298);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 259,
                column: "Force",
                value: 913);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 260,
                column: "Force",
                value: 1465);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 261,
                column: "Force",
                value: 1981);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 262,
                column: "Force",
                value: 1998);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 263,
                column: "Force",
                value: 271);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 264,
                column: "Force",
                value: 250);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 265,
                column: "Force",
                value: 50);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 266,
                column: "Force",
                value: 193);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 267,
                column: "Force",
                value: 265);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 268,
                column: "Force",
                value: 819);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 269,
                column: "Force",
                value: 254);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 270,
                column: "Force",
                value: 1380);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 271,
                column: "Force",
                value: 105);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 272,
                column: "Force",
                value: 1695);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 273,
                column: "Force",
                value: 512);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 274,
                column: "Force",
                value: 1324);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 275,
                column: "Force",
                value: 913);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 276,
                column: "Force",
                value: 580);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 277,
                column: "Force",
                value: 1713);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 278,
                column: "Force",
                value: 180);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 279,
                column: "Force",
                value: 806);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 280,
                column: "Force",
                value: 1702);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 281,
                column: "Force",
                value: 1684);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 282,
                column: "Force",
                value: 111);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 283,
                column: "Force",
                value: 236);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 284,
                column: "Force",
                value: 306);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 285,
                column: "Force",
                value: 395);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 286,
                column: "Force",
                value: 1007);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 287,
                column: "Force",
                value: 121);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 288,
                column: "Force",
                value: 1786);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 289,
                column: "Force",
                value: 1574);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 290,
                column: "Force",
                value: 666);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 291,
                column: "Force",
                value: 66);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 292,
                column: "Force",
                value: 671);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 293,
                column: "Force",
                value: 1612);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 294,
                column: "Force",
                value: 1129);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 295,
                column: "Force",
                value: 850);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 296,
                column: "Force",
                value: 453);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 297,
                column: "Force",
                value: 746);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 298,
                column: "Force",
                value: 807);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 299,
                column: "Force",
                value: 832);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 300,
                column: "Force",
                value: 716);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 301,
                column: "Force",
                value: 1210);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 302,
                column: "Force",
                value: 1230);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 303,
                column: "Force",
                value: 652);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 304,
                column: "Force",
                value: 876);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 305,
                column: "Force",
                value: 1803);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 306,
                column: "Force",
                value: 867);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 307,
                column: "Force",
                value: 820);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 308,
                column: "Force",
                value: 119);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 309,
                column: "Force",
                value: 1689);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 310,
                column: "Force",
                value: 635);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 311,
                column: "Force",
                value: 1204);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 312,
                column: "Force",
                value: 1495);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 313,
                column: "Force",
                value: 388);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 314,
                column: "Force",
                value: 1620);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 315,
                column: "Force",
                value: 147);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 316,
                column: "Force",
                value: 1685);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 317,
                column: "Force",
                value: 1418);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 318,
                column: "Force",
                value: 274);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 319,
                column: "Force",
                value: 224);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 320,
                column: "Force",
                value: 862);

            migrationBuilder.AddForeignKey(
                name: "FK_ArtMartialSamourai_ArtMartial_SamouraiId",
                table: "ArtMartialSamourai",
                column: "SamouraiId",
                principalTable: "ArtMartial",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ArtMartialSamourai_Samourai_ArtMartialId",
                table: "ArtMartialSamourai",
                column: "ArtMartialId",
                principalTable: "Samourai",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ArtMartialSamourai_ArtMartial_SamouraiId",
                table: "ArtMartialSamourai");

            migrationBuilder.DropForeignKey(
                name: "FK_ArtMartialSamourai_Samourai_ArtMartialId",
                table: "ArtMartialSamourai");

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 1,
                column: "Force",
                value: 1955);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 2,
                column: "Force",
                value: 332);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 3,
                column: "Force",
                value: 1551);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 4,
                column: "Force",
                value: 832);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 5,
                column: "Force",
                value: 1945);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 6,
                column: "Force",
                value: 1456);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 7,
                column: "Force",
                value: 594);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 8,
                column: "Force",
                value: 1154);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 9,
                column: "Force",
                value: 1271);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 10,
                column: "Force",
                value: 951);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 11,
                column: "Force",
                value: 119);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 12,
                column: "Force",
                value: 790);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 13,
                column: "Force",
                value: 1082);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 14,
                column: "Force",
                value: 1873);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 15,
                column: "Force",
                value: 1038);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 16,
                column: "Force",
                value: 377);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 17,
                column: "Force",
                value: 432);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 18,
                column: "Force",
                value: 1906);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 19,
                column: "Force",
                value: 719);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 20,
                column: "Force",
                value: 249);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 21,
                column: "Force",
                value: 1249);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 22,
                column: "Force",
                value: 142);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 23,
                column: "Force",
                value: 634);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 24,
                column: "Force",
                value: 18);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 25,
                column: "Force",
                value: 256);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 26,
                column: "Force",
                value: 957);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 27,
                column: "Force",
                value: 245);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 28,
                column: "Force",
                value: 1648);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 29,
                column: "Force",
                value: 1670);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 30,
                column: "Force",
                value: 373);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 31,
                column: "Force",
                value: 1751);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 32,
                column: "Force",
                value: 671);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 33,
                column: "Force",
                value: 1529);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 34,
                column: "Force",
                value: 211);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 35,
                column: "Force",
                value: 137);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 36,
                column: "Force",
                value: 1926);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 37,
                column: "Force",
                value: 1887);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 38,
                column: "Force",
                value: 415);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 39,
                column: "Force",
                value: 1794);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 40,
                column: "Force",
                value: 618);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 41,
                column: "Force",
                value: 99);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 42,
                column: "Force",
                value: 1761);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 43,
                column: "Force",
                value: 135);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 44,
                column: "Force",
                value: 1314);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 45,
                column: "Force",
                value: 778);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 46,
                column: "Force",
                value: 344);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 47,
                column: "Force",
                value: 487);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 48,
                column: "Force",
                value: 242);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 49,
                column: "Force",
                value: 1362);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 50,
                column: "Force",
                value: 41);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 51,
                column: "Force",
                value: 482);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 52,
                column: "Force",
                value: 463);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 53,
                column: "Force",
                value: 1038);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 54,
                column: "Force",
                value: 237);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 55,
                column: "Force",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 56,
                column: "Force",
                value: 669);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 57,
                column: "Force",
                value: 1564);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 58,
                column: "Force",
                value: 1776);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 59,
                column: "Force",
                value: 549);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 60,
                column: "Force",
                value: 206);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 61,
                column: "Force",
                value: 1829);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 62,
                column: "Force",
                value: 1082);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 63,
                column: "Force",
                value: 778);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 64,
                column: "Force",
                value: 771);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 65,
                column: "Force",
                value: 268);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 66,
                column: "Force",
                value: 945);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 67,
                column: "Force",
                value: 622);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 68,
                column: "Force",
                value: 259);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 69,
                column: "Force",
                value: 1671);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 70,
                column: "Force",
                value: 847);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 71,
                column: "Force",
                value: 1021);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 72,
                column: "Force",
                value: 1459);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 73,
                column: "Force",
                value: 198);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 74,
                column: "Force",
                value: 980);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 75,
                column: "Force",
                value: 537);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 76,
                column: "Force",
                value: 372);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 77,
                column: "Force",
                value: 346);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 78,
                column: "Force",
                value: 601);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 79,
                column: "Force",
                value: 697);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 80,
                column: "Force",
                value: 1841);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 81,
                column: "Force",
                value: 83);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 82,
                column: "Force",
                value: 1154);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 83,
                column: "Force",
                value: 774);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 84,
                column: "Force",
                value: 1292);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 85,
                column: "Force",
                value: 247);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 86,
                column: "Force",
                value: 1792);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 87,
                column: "Force",
                value: 163);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 88,
                column: "Force",
                value: 339);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 89,
                column: "Force",
                value: 1409);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 90,
                column: "Force",
                value: 1104);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 91,
                column: "Force",
                value: 1815);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 92,
                column: "Force",
                value: 903);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 93,
                column: "Force",
                value: 26);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 94,
                column: "Force",
                value: 1605);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 95,
                column: "Force",
                value: 1303);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 96,
                column: "Force",
                value: 1702);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 97,
                column: "Force",
                value: 737);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 98,
                column: "Force",
                value: 1653);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 99,
                column: "Force",
                value: 36);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 100,
                column: "Force",
                value: 272);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 101,
                column: "Force",
                value: 1283);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 102,
                column: "Force",
                value: 1014);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 103,
                column: "Force",
                value: 685);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 104,
                column: "Force",
                value: 1831);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 105,
                column: "Force",
                value: 75);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 106,
                column: "Force",
                value: 1256);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 107,
                column: "Force",
                value: 888);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 108,
                column: "Force",
                value: 209);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 109,
                column: "Force",
                value: 721);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 110,
                column: "Force",
                value: 1547);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 111,
                column: "Force",
                value: 371);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 112,
                column: "Force",
                value: 831);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 113,
                column: "Force",
                value: 21);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 114,
                column: "Force",
                value: 1158);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 115,
                column: "Force",
                value: 1097);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 116,
                column: "Force",
                value: 750);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 117,
                column: "Force",
                value: 673);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 118,
                column: "Force",
                value: 819);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 119,
                column: "Force",
                value: 1355);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 120,
                column: "Force",
                value: 1252);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 121,
                column: "Force",
                value: 1220);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 122,
                column: "Force",
                value: 567);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 123,
                column: "Force",
                value: 1220);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 124,
                column: "Force",
                value: 1155);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 125,
                column: "Force",
                value: 418);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 126,
                column: "Force",
                value: 1043);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 127,
                column: "Force",
                value: 1119);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 128,
                column: "Force",
                value: 1163);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 129,
                column: "Force",
                value: 532);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 130,
                column: "Force",
                value: 1720);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 131,
                column: "Force",
                value: 1613);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 132,
                column: "Force",
                value: 1667);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 133,
                column: "Force",
                value: 752);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 134,
                column: "Force",
                value: 1469);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 135,
                column: "Force",
                value: 222);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 136,
                column: "Force",
                value: 1339);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 137,
                column: "Force",
                value: 1009);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 138,
                column: "Force",
                value: 1037);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 139,
                column: "Force",
                value: 964);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 140,
                column: "Force",
                value: 349);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 141,
                column: "Force",
                value: 1025);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 142,
                column: "Force",
                value: 1364);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 143,
                column: "Force",
                value: 445);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 144,
                column: "Force",
                value: 1272);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 145,
                column: "Force",
                value: 881);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 146,
                column: "Force",
                value: 1438);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 147,
                column: "Force",
                value: 413);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 148,
                column: "Force",
                value: 1430);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 149,
                column: "Force",
                value: 1313);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 150,
                column: "Force",
                value: 399);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 151,
                column: "Force",
                value: 335);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 152,
                column: "Force",
                value: 1346);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 153,
                column: "Force",
                value: 291);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 154,
                column: "Force",
                value: 1145);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 155,
                column: "Force",
                value: 1545);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 156,
                column: "Force",
                value: 1331);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 157,
                column: "Force",
                value: 1908);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 158,
                column: "Force",
                value: 87);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 159,
                column: "Force",
                value: 882);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 160,
                column: "Force",
                value: 1908);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 161,
                column: "Force",
                value: 1843);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 162,
                column: "Force",
                value: 579);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 163,
                column: "Force",
                value: 31);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 164,
                column: "Force",
                value: 1667);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 165,
                column: "Force",
                value: 1053);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 166,
                column: "Force",
                value: 1270);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 167,
                column: "Force",
                value: 1156);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 168,
                column: "Force",
                value: 1295);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 169,
                column: "Force",
                value: 1185);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 170,
                column: "Force",
                value: 1623);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 171,
                column: "Force",
                value: 245);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 172,
                column: "Force",
                value: 31);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 173,
                column: "Force",
                value: 1011);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 174,
                column: "Force",
                value: 720);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 175,
                column: "Force",
                value: 1249);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 176,
                column: "Force",
                value: 226);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 177,
                column: "Force",
                value: 1811);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 178,
                column: "Force",
                value: 961);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 179,
                column: "Force",
                value: 1373);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 180,
                column: "Force",
                value: 233);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 181,
                column: "Force",
                value: 1430);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 182,
                column: "Force",
                value: 1665);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 183,
                column: "Force",
                value: 812);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 184,
                column: "Force",
                value: 1199);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 185,
                column: "Force",
                value: 600);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 186,
                column: "Force",
                value: 157);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 187,
                column: "Force",
                value: 707);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 188,
                column: "Force",
                value: 1397);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 189,
                column: "Force",
                value: 1225);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 190,
                column: "Force",
                value: 529);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 191,
                column: "Force",
                value: 527);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 192,
                column: "Force",
                value: 1675);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 193,
                column: "Force",
                value: 788);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 194,
                column: "Force",
                value: 911);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 195,
                column: "Force",
                value: 824);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 196,
                column: "Force",
                value: 1156);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 197,
                column: "Force",
                value: 494);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 198,
                column: "Force",
                value: 59);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 199,
                column: "Force",
                value: 274);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 200,
                column: "Force",
                value: 89);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 201,
                column: "Force",
                value: 914);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 202,
                column: "Force",
                value: 1633);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 203,
                column: "Force",
                value: 1780);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 204,
                column: "Force",
                value: 1559);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 205,
                column: "Force",
                value: 1757);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 206,
                column: "Force",
                value: 1629);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 207,
                column: "Force",
                value: 1446);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 208,
                column: "Force",
                value: 485);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 209,
                column: "Force",
                value: 1733);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 210,
                column: "Force",
                value: 1338);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 211,
                column: "Force",
                value: 1558);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 212,
                column: "Force",
                value: 1865);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 213,
                column: "Force",
                value: 1478);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 214,
                column: "Force",
                value: 202);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 215,
                column: "Force",
                value: 1161);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 216,
                column: "Force",
                value: 749);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 217,
                column: "Force",
                value: 550);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 218,
                column: "Force",
                value: 549);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 219,
                column: "Force",
                value: 611);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 220,
                column: "Force",
                value: 1287);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 221,
                column: "Force",
                value: 1306);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 222,
                column: "Force",
                value: 233);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 223,
                column: "Force",
                value: 820);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 224,
                column: "Force",
                value: 1610);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 225,
                column: "Force",
                value: 836);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 226,
                column: "Force",
                value: 127);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 227,
                column: "Force",
                value: 1042);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 228,
                column: "Force",
                value: 1985);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 229,
                column: "Force",
                value: 645);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 230,
                column: "Force",
                value: 582);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 231,
                column: "Force",
                value: 1301);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 232,
                column: "Force",
                value: 968);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 233,
                column: "Force",
                value: 824);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 234,
                column: "Force",
                value: 540);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 235,
                column: "Force",
                value: 945);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 236,
                column: "Force",
                value: 1893);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 237,
                column: "Force",
                value: 212);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 238,
                column: "Force",
                value: 886);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 239,
                column: "Force",
                value: 593);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 240,
                column: "Force",
                value: 1678);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 241,
                column: "Force",
                value: 1925);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 242,
                column: "Force",
                value: 1036);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 243,
                column: "Force",
                value: 174);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 244,
                column: "Force",
                value: 299);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 245,
                column: "Force",
                value: 1474);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 246,
                column: "Force",
                value: 997);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 247,
                column: "Force",
                value: 1237);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 248,
                column: "Force",
                value: 1923);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 249,
                column: "Force",
                value: 194);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 250,
                column: "Force",
                value: 1202);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 251,
                column: "Force",
                value: 1528);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 252,
                column: "Force",
                value: 1888);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 253,
                column: "Force",
                value: 563);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 254,
                column: "Force",
                value: 1288);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 255,
                column: "Force",
                value: 1825);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 256,
                column: "Force",
                value: 131);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 257,
                column: "Force",
                value: 1016);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 258,
                column: "Force",
                value: 1246);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 259,
                column: "Force",
                value: 1279);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 260,
                column: "Force",
                value: 1473);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 261,
                column: "Force",
                value: 131);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 262,
                column: "Force",
                value: 552);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 263,
                column: "Force",
                value: 292);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 264,
                column: "Force",
                value: 1891);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 265,
                column: "Force",
                value: 63);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 266,
                column: "Force",
                value: 998);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 267,
                column: "Force",
                value: 217);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 268,
                column: "Force",
                value: 1423);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 269,
                column: "Force",
                value: 209);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 270,
                column: "Force",
                value: 1001);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 271,
                column: "Force",
                value: 1793);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 272,
                column: "Force",
                value: 1866);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 273,
                column: "Force",
                value: 758);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 274,
                column: "Force",
                value: 889);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 275,
                column: "Force",
                value: 1467);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 276,
                column: "Force",
                value: 209);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 277,
                column: "Force",
                value: 589);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 278,
                column: "Force",
                value: 226);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 279,
                column: "Force",
                value: 230);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 280,
                column: "Force",
                value: 761);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 281,
                column: "Force",
                value: 1314);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 282,
                column: "Force",
                value: 266);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 283,
                column: "Force",
                value: 1545);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 284,
                column: "Force",
                value: 580);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 285,
                column: "Force",
                value: 71);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 286,
                column: "Force",
                value: 1567);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 287,
                column: "Force",
                value: 1023);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 288,
                column: "Force",
                value: 1944);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 289,
                column: "Force",
                value: 639);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 290,
                column: "Force",
                value: 964);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 291,
                column: "Force",
                value: 593);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 292,
                column: "Force",
                value: 860);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 293,
                column: "Force",
                value: 1374);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 294,
                column: "Force",
                value: 1900);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 295,
                column: "Force",
                value: 1637);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 296,
                column: "Force",
                value: 52);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 297,
                column: "Force",
                value: 1529);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 298,
                column: "Force",
                value: 1836);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 299,
                column: "Force",
                value: 854);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 300,
                column: "Force",
                value: 1731);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 301,
                column: "Force",
                value: 1533);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 302,
                column: "Force",
                value: 1474);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 303,
                column: "Force",
                value: 1393);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 304,
                column: "Force",
                value: 560);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 305,
                column: "Force",
                value: 1719);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 306,
                column: "Force",
                value: 335);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 307,
                column: "Force",
                value: 618);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 308,
                column: "Force",
                value: 1274);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 309,
                column: "Force",
                value: 1814);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 310,
                column: "Force",
                value: 1667);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 311,
                column: "Force",
                value: 532);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 312,
                column: "Force",
                value: 297);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 313,
                column: "Force",
                value: 732);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 314,
                column: "Force",
                value: 578);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 315,
                column: "Force",
                value: 486);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 316,
                column: "Force",
                value: 1372);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 317,
                column: "Force",
                value: 1178);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 318,
                column: "Force",
                value: 1371);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 319,
                column: "Force",
                value: 1729);

            migrationBuilder.UpdateData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 320,
                column: "Force",
                value: 78);

            migrationBuilder.AddForeignKey(
                name: "FK_ArtMartialSamourai_ArtMartial_ArtMartialId",
                table: "ArtMartialSamourai",
                column: "ArtMartialId",
                principalTable: "ArtMartial",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ArtMartialSamourai_Samourai_SamouraiId",
                table: "ArtMartialSamourai",
                column: "SamouraiId",
                principalTable: "Samourai",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
