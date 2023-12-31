﻿using Azure;
using BO;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;


namespace TPDojo
{
    /// <summary>
    /// Class de connection a ma base de donnée
    /// </summary>
    public class DojoDbContext : DbContext
    {
        /// <summary>
        /// Mapping de la table Person sur la class Person
        /// </summary>
        public DbSet<Samourai> Samourai { get; set; }

        public DbSet<Arme> Arme { get; set; }

        public DbSet<ArtMartial> ArtMartial { get; set; }

        public DbSet<ArtMartialSamourai> ArtMartialSamourai { get; set; }

        /// <summary>
        /// overide de la methode de configuration de la connection a la base de donnée
        /// </summary>
        /// <param name="optionsBuilder"></param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=TPDOJODB;MultipleActiveResultSets=true");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Samourai>()
                .HasMany(e => e.ArtMartials)
                .WithMany(e => e.Samourais)
                .UsingEntity<ArtMartialSamourai>(
            l => l.HasOne<ArtMartial>().WithMany().HasForeignKey(e => e.SamouraiId),
            r => r.HasOne<Samourai>().WithMany().HasForeignKey(e => e.ArtMartialId));

            int id = 1;
            Random r = new Random();
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Abe Masakatsu", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Adachi Yasumori", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Adachi Kagemori", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Adams William", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Aiou Mototsuna", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Akai Terukage", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Akao Kiyotsuna", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Akechi Mitsuhide", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Akiyama Nobutomo", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Amago Haruhisa", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Amago Yoshihisa", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Andō Morinari", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Ankokuji Ekei", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Aochi Shigetsuna", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Aokage Takaakira", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Aoki Kazushige", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Akahori Chohichi", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Arai Hakuseki", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Araki Motokiyo", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Araki Murashige", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Araki Muratsugu", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Arima Kihei", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Asakura Yoshikage", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Ayame Kagekatsu", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Azai Hisamasa", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Azai Nagamasa", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Azai Sukemasa", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Baba Nobufusa", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Bessho Nagaharu", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Chacha", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Chiba Shusaku Narimasa", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Chōsokabe Morichika", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Chōsokabe Kunichika", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Chōsokabe Motochika", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Chōsokabe Nobuchika", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Collache Eugène", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Date Masamune", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Date Shigezane", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Doi Toshikatsu", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Etō Shinpei", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Endō Naotsune", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Enjoji Nobutane", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "ENameoto Takeaki", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Era Fusahide", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Fūma Kotarō", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Fuwa Mitsuharu", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Fukushima Masanori", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Gamō Katahide", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Gamō Ujisato", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Harada Naomasa", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Harada Nobutane", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Harada Sanosuke", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Hasekura Tsunenaga", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Hattori Hanzō", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Hatano Hideharu", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Hasegawa Eishin", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Hayashizaki Jinsuke Shigenobu", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Hayashi Narinaga", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Hijikata Toshizo", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Hirate Masahide", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Hitotsubashi Keiki", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Hōjō Masako", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Hōjō Tokimune", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Hōjō Ujiyasu", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Hōjō Ujimasa", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Honda Tadakatsu", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Honda Tadatomo", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Honganji Kennyo", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Horio Yoshiharu", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Hosokawa Fujitaka", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Hosokawa Gracia", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Hosokawa Tadaoki", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Hotta Masatoshi", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Ii Naoaki", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Ii Naomasa", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Ii Naomori", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Ii Naonaka", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Ii Naosuke", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Ii Naotaka", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Ii Naotora", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Ii Naoyuki", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Ii Naozumi", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Iizasa Ienao", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Ijuin Tadaaki", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Ikeda Tsuneoki", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Imagawa Ujizane", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Imagawa Yoshimoto", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Imai Kanehira", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Inaba Yoshimichi", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Inugami Nagayasu", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Ishida Mitsunari", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Isshiki Fujinaga", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Itagaki Nobukata", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Itō Hirobumi", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Iwanari Tomomichi", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Jinbo Nagamoto", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Jonas Tönse", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Kannan Kumar(Salem)", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Kakeda Toshimune", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Kaneko Ietada", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Katagiri Katsumoto", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Katakura Kojūro", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Katakura Shigenaga", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Kataoka Mitsumasa", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Katō Kiyomasa", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Kawakami Gensai", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Kido Takayoshi", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Kikkawa Hiroie", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Kimotsuki Kanetsugu", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Kitamura Kansuke", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Kobayakawa Hideaki", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Kobayakawa Hidekane", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Kobayakawa Takakage", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Konishi Yukinaga", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Kojima Toyoharu", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Kuroda Kanbei", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Kuroda Kiyotaka", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Kusunoki Masashige", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Kuwana Tarozaemon", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Kumagai Naozane", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Maeda Keiji", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Maeda Matsu", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Maeda Nagatane", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Maeda Toshiie", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Maeda Toshinaga", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Maeda Toshitsune", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Magome Kageyu", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Manabe Akifusa", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Matsudaira Katamori", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Matsudaira Nobutsuna", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Matsudaira Nobuyasu", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Matsudaira Higo no Kami Katamori", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Matsudaira Sadanobu", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Matsudaira Tadayoshi", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Matsudaira Teru", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Matsunaga Hisahide", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Matsunaga Hisamichi", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Matsuo Bashō", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Matsudaira Motoyasu", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Minamoto no Mitsunaka", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Minamoto no Yoshiie", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Minamoto no Yoshimitsu", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Minamoto no Yoshinaka", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Minamoto no Yoshitomo", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Minamoto no Yoshitsune", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Minamoto no Tameyoshi", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Minamoto no Yorimasa", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Minamoto no Yorimitsu", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Minamoto no Yoritomo", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Minamoto no Noriyori", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Minoro Takashi", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Miura Anjin", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Miura Yoshimoto", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Miyamoto Musashi", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Miyoshi Chōkei", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Miyoshi Kazuhide", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Miyoshi Masaga", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Miyoshi Masayasu", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Miyoshi Moriyata", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Miyoshi Nagayuki", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Miyoshi Yoshitsugu", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Mizuno Tadakuni", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Moniwa Yoshinao", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Mōri Motonari", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Mōri Nagasada", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Mori Nagayoshi", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Mōri Okimoto", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Mori Ranmaru", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Mōri Takamoto", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Mori Tadamasa", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Mōri Terumoto", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Mori Yoshinari", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Murai Sadakatsu", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Nagakura Shinpachi", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Nagao Harukage", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Nagao Kagenobu", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Nagao Masakage", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Nagao Tamekage", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Nakagawa Kiyohide", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Nakaoka Shintarō", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Naoe Kagetsuna", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Naoe Kanetsugu", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Narita Kaihime", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Nene", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Nihonmatsu Yoshitsugu", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Niimi Nishiki", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Niiro Tadamoto", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Niwa Nagahide", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Niwa Nagashige", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Oda Hiroyoshi", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Oda Nobuhide", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Oda Nobukata", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Oda Nobukiyo", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Oda Nobunaga", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Oda Nobutada", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Oda Nobutomo", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Oda Nobukatsu", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Oda Nobuyasu", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Ogasawara Shōsai", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Ōishi Kuranosuke", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Okada Izō", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Judge Ooka", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Ōta Dōkan", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Ōtani Yoshitsugu", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Ōtani Yoshiharu", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Ōtomo Sōrin", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Okita Sōji", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Ōkubo Toshimichi", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "OkuNameiya Masaie", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Ōuchi Yoshitaka", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Omy Yoshika", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Pore Sufi", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Reizei Takatoyo", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Rokkaku Sadayori", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Rokkaku Yoshiharu", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Rokkaku Yoshikata", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Rusu Masakage", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Ryūzōji Takanobu", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Saigo Kiyokazu", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Saigō Masako", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Sagara Taketō", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Saigō Takamori", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Saigo Yoshikatsu", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Saitō Dōsan", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Saitō Hajime", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Saito Musashibō Benkei", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Saitō Yoshitatsu", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Sakai Tadakiyo", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Sakai Tadashige", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Sakai Tadatsugu", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Sakai Tadayo", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Sakakibara Yasumasa", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Sakamoto Ryōma", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Sakuma Morimasa", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Sakuma Nobumori", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Sanada Akihime", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Sanada Komatsuhime", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Sanada Masayuki", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Sanada Nobuyuki", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Sanada Yukimura", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Sasaki Kojirō", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Sassa Narimasa", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Sasuke Sarutobi", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Serizawa Kamo", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Shibata Katsuie", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Shima Sakon", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Shimada Ichirō", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Shimazu Katsuhisa", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Shimazu Tadahisa", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Shimazu Tadatsune", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Shimazu Tadayoshi", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Shimazu Takahisa", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Shimazu Toyohisa", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Shimazu Yoshihiro", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Shimazu Yoshihisa", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Shindou Hiroshii", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Sogo Nagayasu", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Sue Yoshitaka", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Tachibana Muneshige", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Tachibana Dōsetsu", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Tachibana Ginchiyo", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Taigen Sessai", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Taira no Kiyomori", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Taira Masakado", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Takahashi Shigetane", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Takenaka Shigeharu", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Takasugi Shinsaku", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Takayama Justo", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Takayama Ukon", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Takechi Hanpeita", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Takeda Katsuyori", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Takeda Nobukatsu", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Takeda Nobushige", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Takeda Shingen", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Takenaka Hanbei", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Tani Tadasumi", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Tōdō Takatora", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Toki Yorinari", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Tochimitsu Gantyoki", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Tokugawa Ieyasu", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Tokugawa Hidetada", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Tokugawa Nariaki", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Tokugawa Yoshinobu", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Torii Mototada", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Toyotomi Hidenaga", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Toyotomi Hideyoshi", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Toyotomi Hideyori", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Tozuka Tadaharu", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Tsukahara Bokuden", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Uesugi Kagekatsu", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Uesugi Kagetora", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Uesugi Kenshin", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Ujiie Naotomo", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Ukita Naoie", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Ukita Okiie", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Umezawa Michiharu", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Usami Sadamitsu", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Uyama Hisanobu", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Wada Shinsuke", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Watanabe Kazan", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Watanabe no Tsuna", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Yasumero Kenshin", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Yagyū Jūbei Mitsuyoshi", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Yagyū Munenori", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Yamauchi Kazutoyo", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Yamada Arinaga", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Yamada Arinobu", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Yamada Nagamasa", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Yamagata Masakage", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Yamakawa Hiroshi", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Yamakawa Kenjirō", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Yamakawa Naoe", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Yamanaka Yukimori", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Yamanami Keisuke", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Yamaoka Tesshū", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Yanagawa Kenzaburo", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Yanagisawa Yoshiyasu", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Yonekura Shigetsugu", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Yūki Hideyasu", Force = r.Next(2000) });
            modelBuilder.Entity<Samourai>().HasData(new Samourai { Id = id++, Name = "Yasuke", Force = r.Next(2000) });

        }
    }
}