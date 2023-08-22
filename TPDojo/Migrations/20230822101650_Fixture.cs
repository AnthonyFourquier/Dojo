using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TPDojo.Migrations
{
    /// <inheritdoc />
    public partial class Fixture : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Samourai",
                columns: new[] { "Id", "ArmeId", "Force", "Name" },
                values: new object[,]
                {
                    { 1, null, 1876, "Abe Masakatsu" },
                    { 2, null, 890, "Adachi Yasumori" },
                    { 3, null, 467, "Adachi Kagemori" },
                    { 4, null, 1452, "Adams William" },
                    { 5, null, 175, "Aiou Mototsuna" },
                    { 6, null, 473, "Akai Terukage" },
                    { 7, null, 383, "Akao Kiyotsuna" },
                    { 8, null, 1041, "Akechi Mitsuhide" },
                    { 9, null, 1912, "Akiyama Nobutomo" },
                    { 10, null, 736, "Amago Haruhisa" },
                    { 11, null, 848, "Amago Yoshihisa" },
                    { 12, null, 1861, "Andō Morinari" },
                    { 13, null, 1922, "Ankokuji Ekei" },
                    { 14, null, 1172, "Aochi Shigetsuna" },
                    { 15, null, 220, "Aokage Takaakira" },
                    { 16, null, 743, "Aoki Kazushige" },
                    { 17, null, 1151, "Akahori Chohichi" },
                    { 18, null, 617, "Arai Hakuseki" },
                    { 19, null, 592, "Araki Motokiyo" },
                    { 20, null, 560, "Araki Murashige" },
                    { 21, null, 234, "Araki Muratsugu" },
                    { 22, null, 1942, "Arima Kihei" },
                    { 23, null, 16, "Asakura Yoshikage" },
                    { 24, null, 362, "Ayame Kagekatsu" },
                    { 25, null, 1302, "Azai Hisamasa" },
                    { 26, null, 144, "Azai Nagamasa" },
                    { 27, null, 1902, "Azai Sukemasa" },
                    { 28, null, 809, "Baba Nobufusa" },
                    { 29, null, 544, "Bessho Nagaharu" },
                    { 30, null, 381, "Chacha" },
                    { 31, null, 1247, "Chiba Shusaku Narimasa" },
                    { 32, null, 416, "Chōsokabe Morichika" },
                    { 33, null, 1064, "Chōsokabe Kunichika" },
                    { 34, null, 626, "Chōsokabe Motochika" },
                    { 35, null, 145, "Chōsokabe Nobuchika" },
                    { 36, null, 23, "Collache Eugène" },
                    { 37, null, 1076, "Date Masamune" },
                    { 38, null, 412, "Date Shigezane" },
                    { 39, null, 1523, "Doi Toshikatsu" },
                    { 40, null, 1527, "Etō Shinpei" },
                    { 41, null, 804, "Endō Naotsune" },
                    { 42, null, 2, "Enjoji Nobutane" },
                    { 43, null, 1444, "ENameoto Takeaki" },
                    { 44, null, 1291, "Era Fusahide" },
                    { 45, null, 1012, "Fūma Kotarō" },
                    { 46, null, 355, "Fuwa Mitsuharu" },
                    { 47, null, 1973, "Fukushima Masanori" },
                    { 48, null, 172, "Gamō Katahide" },
                    { 49, null, 1001, "Gamō Ujisato" },
                    { 50, null, 1573, "Harada Naomasa" },
                    { 51, null, 3, "Harada Nobutane" },
                    { 52, null, 1916, "Harada Sanosuke" },
                    { 53, null, 1126, "Hasekura Tsunenaga" },
                    { 54, null, 1808, "Hattori Hanzō" },
                    { 55, null, 335, "Hatano Hideharu" },
                    { 56, null, 1505, "Hasegawa Eishin" },
                    { 57, null, 731, "Hayashizaki Jinsuke Shigenobu" },
                    { 58, null, 824, "Hayashi Narinaga" },
                    { 59, null, 274, "Hijikata Toshizo" },
                    { 60, null, 180, "Hirate Masahide" },
                    { 61, null, 602, "Hitotsubashi Keiki" },
                    { 62, null, 1232, "Hōjō Masako" },
                    { 63, null, 39, "Hōjō Tokimune" },
                    { 64, null, 151, "Hōjō Ujiyasu" },
                    { 65, null, 1790, "Hōjō Ujimasa" },
                    { 66, null, 1580, "Honda Tadakatsu" },
                    { 67, null, 990, "Honda Tadatomo" },
                    { 68, null, 1079, "Honganji Kennyo" },
                    { 69, null, 204, "Horio Yoshiharu" },
                    { 70, null, 1869, "Hosokawa Fujitaka" },
                    { 71, null, 1929, "Hosokawa Gracia" },
                    { 72, null, 316, "Hosokawa Tadaoki" },
                    { 73, null, 805, "Hotta Masatoshi" },
                    { 74, null, 1547, "Ii Naoaki" },
                    { 75, null, 968, "Ii Naomasa" },
                    { 76, null, 1426, "Ii Naomori" },
                    { 77, null, 32, "Ii Naonaka" },
                    { 78, null, 1337, "Ii Naosuke" },
                    { 79, null, 743, "Ii Naotaka" },
                    { 80, null, 1380, "Ii Naotora" },
                    { 81, null, 504, "Ii Naoyuki" },
                    { 82, null, 1821, "Ii Naozumi" },
                    { 83, null, 533, "Iizasa Ienao" },
                    { 84, null, 1378, "Ijuin Tadaaki" },
                    { 85, null, 545, "Ikeda Tsuneoki" },
                    { 86, null, 1888, "Imagawa Ujizane" },
                    { 87, null, 938, "Imagawa Yoshimoto" },
                    { 88, null, 1048, "Imai Kanehira" },
                    { 89, null, 1170, "Inaba Yoshimichi" },
                    { 90, null, 1344, "Inugami Nagayasu" },
                    { 91, null, 1029, "Ishida Mitsunari" },
                    { 92, null, 1352, "Isshiki Fujinaga" },
                    { 93, null, 145, "Itagaki Nobukata" },
                    { 94, null, 1712, "Itō Hirobumi" },
                    { 95, null, 565, "Iwanari Tomomichi" },
                    { 96, null, 877, "Jinbo Nagamoto" },
                    { 97, null, 92, "Jonas Tönse" },
                    { 98, null, 1711, "Kannan Kumar(Salem)" },
                    { 99, null, 445, "Kakeda Toshimune" },
                    { 100, null, 408, "Kaneko Ietada" },
                    { 101, null, 1235, "Katagiri Katsumoto" },
                    { 102, null, 1683, "Katakura Kojūro" },
                    { 103, null, 1823, "Katakura Shigenaga" },
                    { 104, null, 473, "Kataoka Mitsumasa" },
                    { 105, null, 755, "Katō Kiyomasa" },
                    { 106, null, 1513, "Kawakami Gensai" },
                    { 107, null, 1868, "Kido Takayoshi" },
                    { 108, null, 1995, "Kikkawa Hiroie" },
                    { 109, null, 1634, "Kimotsuki Kanetsugu" },
                    { 110, null, 293, "Kitamura Kansuke" },
                    { 111, null, 117, "Kobayakawa Hideaki" },
                    { 112, null, 1922, "Kobayakawa Hidekane" },
                    { 113, null, 1848, "Kobayakawa Takakage" },
                    { 114, null, 1208, "Konishi Yukinaga" },
                    { 115, null, 1769, "Kojima Toyoharu" },
                    { 116, null, 743, "Kuroda Kanbei" },
                    { 117, null, 235, "Kuroda Kiyotaka" },
                    { 118, null, 775, "Kusunoki Masashige" },
                    { 119, null, 1761, "Kuwana Tarozaemon" },
                    { 120, null, 286, "Kumagai Naozane" },
                    { 121, null, 1050, "Maeda Keiji" },
                    { 122, null, 65, "Maeda Matsu" },
                    { 123, null, 732, "Maeda Nagatane" },
                    { 124, null, 668, "Maeda Toshiie" },
                    { 125, null, 802, "Maeda Toshinaga" },
                    { 126, null, 558, "Maeda Toshitsune" },
                    { 127, null, 349, "Magome Kageyu" },
                    { 128, null, 408, "Manabe Akifusa" },
                    { 129, null, 733, "Matsudaira Katamori" },
                    { 130, null, 1236, "Matsudaira Nobutsuna" },
                    { 131, null, 988, "Matsudaira Nobuyasu" },
                    { 132, null, 675, "Matsudaira Higo no Kami Katamori" },
                    { 133, null, 438, "Matsudaira Sadanobu" },
                    { 134, null, 991, "Matsudaira Tadayoshi" },
                    { 135, null, 8, "Matsudaira Teru" },
                    { 136, null, 104, "Matsunaga Hisahide" },
                    { 137, null, 97, "Matsunaga Hisamichi" },
                    { 138, null, 150, "Matsuo Bashō" },
                    { 139, null, 965, "Matsudaira Motoyasu" },
                    { 140, null, 660, "Minamoto no Mitsunaka" },
                    { 141, null, 691, "Minamoto no Yoshiie" },
                    { 142, null, 917, "Minamoto no Yoshimitsu" },
                    { 143, null, 1951, "Minamoto no Yoshinaka" },
                    { 144, null, 1812, "Minamoto no Yoshitomo" },
                    { 145, null, 1296, "Minamoto no Yoshitsune" },
                    { 146, null, 580, "Minamoto no Tameyoshi" },
                    { 147, null, 1061, "Minamoto no Yorimasa" },
                    { 148, null, 1616, "Minamoto no Yorimitsu" },
                    { 149, null, 531, "Minamoto no Yoritomo" },
                    { 150, null, 465, "Minamoto no Noriyori" },
                    { 151, null, 1569, "Minoro Takashi" },
                    { 152, null, 484, "Miura Anjin" },
                    { 153, null, 1943, "Miura Yoshimoto" },
                    { 154, null, 310, "Miyamoto Musashi" },
                    { 155, null, 831, "Miyoshi Chōkei" },
                    { 156, null, 1756, "Miyoshi Kazuhide" },
                    { 157, null, 222, "Miyoshi Masaga" },
                    { 158, null, 1485, "Miyoshi Masayasu" },
                    { 159, null, 663, "Miyoshi Moriyata" },
                    { 160, null, 674, "Miyoshi Nagayuki" },
                    { 161, null, 1523, "Miyoshi Yoshitsugu" },
                    { 162, null, 993, "Mizuno Tadakuni" },
                    { 163, null, 1373, "Moniwa Yoshinao" },
                    { 164, null, 509, "Mōri Motonari" },
                    { 165, null, 1389, "Mōri Nagasada" },
                    { 166, null, 391, "Mori Nagayoshi" },
                    { 167, null, 1377, "Mōri Okimoto" },
                    { 168, null, 1205, "Mori Ranmaru" },
                    { 169, null, 904, "Mōri Takamoto" },
                    { 170, null, 306, "Mori Tadamasa" },
                    { 171, null, 677, "Mōri Terumoto" },
                    { 172, null, 306, "Mori Yoshinari" },
                    { 173, null, 708, "Murai Sadakatsu" },
                    { 174, null, 220, "Nagakura Shinpachi" },
                    { 175, null, 840, "Nagao Harukage" },
                    { 176, null, 1937, "Nagao Kagenobu" },
                    { 177, null, 1314, "Nagao Masakage" },
                    { 178, null, 1541, "Nagao Tamekage" },
                    { 179, null, 754, "Nakagawa Kiyohide" },
                    { 180, null, 1046, "Nakaoka Shintarō" },
                    { 181, null, 1028, "Naoe Kagetsuna" },
                    { 182, null, 1317, "Naoe Kanetsugu" },
                    { 183, null, 78, "Narita Kaihime" },
                    { 184, null, 938, "Nene" },
                    { 185, null, 480, "Nihonmatsu Yoshitsugu" },
                    { 186, null, 1242, "Niimi Nishiki" },
                    { 187, null, 1634, "Niiro Tadamoto" },
                    { 188, null, 447, "Niwa Nagahide" },
                    { 189, null, 301, "Niwa Nagashige" },
                    { 190, null, 351, "Oda Hiroyoshi" },
                    { 191, null, 502, "Oda Nobuhide" },
                    { 192, null, 862, "Oda Nobukata" },
                    { 193, null, 583, "Oda Nobukiyo" },
                    { 194, null, 1516, "Oda Nobunaga" },
                    { 195, null, 239, "Oda Nobutada" },
                    { 196, null, 989, "Oda Nobutomo" },
                    { 197, null, 1350, "Oda Nobukatsu" },
                    { 198, null, 298, "Oda Nobuyasu" },
                    { 199, null, 1789, "Ogasawara Shōsai" },
                    { 200, null, 293, "Ōishi Kuranosuke" },
                    { 201, null, 890, "Okada Izō" },
                    { 202, null, 1179, "Judge Ooka" },
                    { 203, null, 1681, "Ōta Dōkan" },
                    { 204, null, 1822, "Ōtani Yoshitsugu" },
                    { 205, null, 715, "Ōtani Yoshiharu" },
                    { 206, null, 393, "Ōtomo Sōrin" },
                    { 207, null, 974, "Okita Sōji" },
                    { 208, null, 675, "Ōkubo Toshimichi" },
                    { 209, null, 1259, "OkuNameiya Masaie" },
                    { 210, null, 1575, "Ōuchi Yoshitaka" },
                    { 211, null, 1783, "Omy Yoshika" },
                    { 212, null, 915, "Pore Sufi" },
                    { 213, null, 1167, "Reizei Takatoyo" },
                    { 214, null, 1416, "Rokkaku Sadayori" },
                    { 215, null, 585, "Rokkaku Yoshiharu" },
                    { 216, null, 1464, "Rokkaku Yoshikata" },
                    { 217, null, 1550, "Rusu Masakage" },
                    { 218, null, 1500, "Ryūzōji Takanobu" },
                    { 219, null, 554, "Saigo Kiyokazu" },
                    { 220, null, 327, "Saigō Masako" },
                    { 221, null, 108, "Sagara Taketō" },
                    { 222, null, 842, "Saigō Takamori" },
                    { 223, null, 1158, "Saigo Yoshikatsu" },
                    { 224, null, 944, "Saitō Dōsan" },
                    { 225, null, 811, "Saitō Hajime" },
                    { 226, null, 5, "Saito Musashibō Benkei" },
                    { 227, null, 1928, "Saitō Yoshitatsu" },
                    { 228, null, 854, "Sakai Tadakiyo" },
                    { 229, null, 1392, "Sakai Tadashige" },
                    { 230, null, 1447, "Sakai Tadatsugu" },
                    { 231, null, 633, "Sakai Tadayo" },
                    { 232, null, 401, "Sakakibara Yasumasa" },
                    { 233, null, 1290, "Sakamoto Ryōma" },
                    { 234, null, 1775, "Sakuma Morimasa" },
                    { 235, null, 1939, "Sakuma Nobumori" },
                    { 236, null, 569, "Sanada Akihime" },
                    { 237, null, 866, "Sanada Komatsuhime" },
                    { 238, null, 41, "Sanada Masayuki" },
                    { 239, null, 1284, "Sanada Nobuyuki" },
                    { 240, null, 276, "Sanada Yukimura" },
                    { 241, null, 33, "Sasaki Kojirō" },
                    { 242, null, 963, "Sassa Narimasa" },
                    { 243, null, 1079, "Sasuke Sarutobi" },
                    { 244, null, 1904, "Serizawa Kamo" },
                    { 245, null, 189, "Shibata Katsuie" },
                    { 246, null, 313, "Shima Sakon" },
                    { 247, null, 748, "Shimada Ichirō" },
                    { 248, null, 723, "Shimazu Katsuhisa" },
                    { 249, null, 1107, "Shimazu Tadahisa" },
                    { 250, null, 676, "Shimazu Tadatsune" },
                    { 251, null, 39, "Shimazu Tadayoshi" },
                    { 252, null, 1106, "Shimazu Takahisa" },
                    { 253, null, 1863, "Shimazu Toyohisa" },
                    { 254, null, 1138, "Shimazu Yoshihiro" },
                    { 255, null, 1736, "Shimazu Yoshihisa" },
                    { 256, null, 125, "Shindou Hiroshii" },
                    { 257, null, 55, "Sogo Nagayasu" },
                    { 258, null, 310, "Sue Yoshitaka" },
                    { 259, null, 1591, "Tachibana Muneshige" },
                    { 260, null, 1252, "Tachibana Dōsetsu" },
                    { 261, null, 1499, "Tachibana Ginchiyo" },
                    { 262, null, 1825, "Taigen Sessai" },
                    { 263, null, 848, "Taira no Kiyomori" },
                    { 264, null, 1386, "Taira Masakado" },
                    { 265, null, 1272, "Takahashi Shigetane" },
                    { 266, null, 1206, "Takenaka Shigeharu" },
                    { 267, null, 201, "Takasugi Shinsaku" },
                    { 268, null, 1313, "Takayama Justo" },
                    { 269, null, 124, "Takayama Ukon" },
                    { 270, null, 1076, "Takechi Hanpeita" },
                    { 271, null, 417, "Takeda Katsuyori" },
                    { 272, null, 418, "Takeda Nobukatsu" },
                    { 273, null, 1820, "Takeda Nobushige" },
                    { 274, null, 1226, "Takeda Shingen" },
                    { 275, null, 1845, "Takenaka Hanbei" },
                    { 276, null, 1294, "Tani Tadasumi" },
                    { 277, null, 1176, "Tōdō Takatora" },
                    { 278, null, 1614, "Toki Yorinari" },
                    { 279, null, 1453, "Tochimitsu Gantyoki" },
                    { 280, null, 701, "Tokugawa Ieyasu" },
                    { 281, null, 1031, "Tokugawa Hidetada" },
                    { 282, null, 589, "Tokugawa Nariaki" },
                    { 283, null, 1851, "Tokugawa Yoshinobu" },
                    { 284, null, 1205, "Torii Mototada" },
                    { 285, null, 705, "Toyotomi Hidenaga" },
                    { 286, null, 1524, "Toyotomi Hideyoshi" },
                    { 287, null, 1612, "Toyotomi Hideyori" },
                    { 288, null, 1476, "Tozuka Tadaharu" },
                    { 289, null, 1654, "Tsukahara Bokuden" },
                    { 290, null, 0, "Uesugi Kagekatsu" },
                    { 291, null, 73, "Uesugi Kagetora" },
                    { 292, null, 1500, "Uesugi Kenshin" },
                    { 293, null, 1041, "Ujiie Naotomo" },
                    { 294, null, 1775, "Ukita Naoie" },
                    { 295, null, 1638, "Ukita Okiie" },
                    { 296, null, 463, "Umezawa Michiharu" },
                    { 297, null, 989, "Usami Sadamitsu" },
                    { 298, null, 1625, "Uyama Hisanobu" },
                    { 299, null, 1371, "Wada Shinsuke" },
                    { 300, null, 1079, "Watanabe Kazan" },
                    { 301, null, 1622, "Watanabe no Tsuna" },
                    { 302, null, 1116, "Yasumero Kenshin" },
                    { 303, null, 1559, "Yagyū Jūbei Mitsuyoshi" },
                    { 304, null, 807, "Yagyū Munenori" },
                    { 305, null, 600, "Yamauchi Kazutoyo" },
                    { 306, null, 1879, "Yamada Arinaga" },
                    { 307, null, 403, "Yamada Arinobu" },
                    { 308, null, 326, "Yamada Nagamasa" },
                    { 309, null, 1565, "Yamagata Masakage" },
                    { 310, null, 1475, "Yamakawa Hiroshi" },
                    { 311, null, 1930, "Yamakawa Kenjirō" },
                    { 312, null, 999, "Yamakawa Naoe" },
                    { 313, null, 1882, "Yamanaka Yukimori" },
                    { 314, null, 371, "Yamanami Keisuke" },
                    { 315, null, 1668, "Yamaoka Tesshū" },
                    { 316, null, 1225, "Yanagawa Kenzaburo" },
                    { 317, null, 1235, "Yanagisawa Yoshiyasu" },
                    { 318, null, 37, "Yonekura Shigetsugu" },
                    { 319, null, 71, "Yūki Hideyasu" },
                    { 320, null, 807, "Yasuke" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "Samourai",
                keyColumn: "Id",
                keyValue: 320);
        }
    }
}
