using Microsoft.EntityFrameworkCore;
using OneDotLearnCore.Essential;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneDotLearnData.ForDataSeeding
{
    internal class CountriesPopulator
    {
        internal static void Add(ModelBuilder modelBuilder)
        {
            var sysTimeZones = TimeZoneInfo.GetSystemTimeZones();
            string flagPath = @"C:\Users\pc\Pictures\Flags";
            short cntrId = 1;

            modelBuilder.Entity<Country>().HasData(new Country() // 1
            {
                Id = cntrId++,
                ArabicName = "الجزائر",
                LatinName = "Algeria",
                IsArabic = true,
                Flag = System.IO.File.ReadAllBytes(@$"{flagPath}\125px-Flag_of_Algeria.svg.png"),
                TimeZoneId = sysTimeZones.First(tz => tz.DisplayName.Contains("UTC+01")).Id
            });

            modelBuilder.Entity<Country>().HasData(new Country() // 2
            {
                Id = cntrId++,
                ArabicName = "البحرين",
                LatinName = "Bahrain",
                IsArabic = true,
                Flag = System.IO.File.ReadAllBytes(@$"{flagPath}\125px-Flag_of_Bahrain.svg.png"),
                TimeZoneId = sysTimeZones.First(tz => tz.DisplayName.Contains("UTC+03")).Id
            });

            modelBuilder.Entity<Country>().HasData(new Country() // 3
            {
                Id = cntrId++,
                ArabicName = "بوتسوانا",
                LatinName = "Botswana",
                IsArabic = false,
                Flag = System.IO.File.ReadAllBytes(@$"{flagPath}\125px-Flag_of_Botswana.svg.png"),
                TimeZoneId = sysTimeZones.First(tz => tz.DisplayName.Contains("UTC+02")).Id
            });

            modelBuilder.Entity<Country>().HasData(new Country() // 4
            {
                Id = cntrId++,
                ArabicName = "بوروندي",
                LatinName = "Burundi",
                IsArabic = false,
                Flag = System.IO.File.ReadAllBytes(@$"{flagPath}\Flag_of_Burundi.svg.png"),
                TimeZoneId = sysTimeZones.First(tz => tz.DisplayName.Contains("UTC+02")).Id
            });

            modelBuilder.Entity<Country>().HasData(new Country() // 5
            {
                Id = cntrId++,
                ArabicName = "الكاميرون",
                LatinName = "Cameroon",
                IsArabic = false,
                Flag = System.IO.File.ReadAllBytes(@$"{flagPath}\125px-Flag_of_Cameroon.svg.png"),
                TimeZoneId = sysTimeZones.First(tz => tz.DisplayName.Contains("UTC+02")).Id
            });

            modelBuilder.Entity<Country>().HasData(new Country() // 6
            {
                Id = cntrId++,
                ArabicName = "مصر",
                LatinName = "Egypt",
                IsArabic = true,
                Flag = System.IO.File.ReadAllBytes(@$"{flagPath}\125px-Flag_of_Egypt.svg.png"),
                TimeZoneId = sysTimeZones.First(tz => tz.DisplayName.Contains("UTC+02")).Id
            });

            modelBuilder.Entity<Country>().HasData(new Country() // 7
            {
                Id = cntrId++,
                ArabicName = "إريتريا",
                LatinName = "Eritrea",
                IsArabic = true,
                Flag = System.IO.File.ReadAllBytes(@$"{flagPath}\Flag_of_Eritrea.svg.png"),
                TimeZoneId = sysTimeZones.First(tz => tz.DisplayName.Contains("UTC+03")).Id
            });

            modelBuilder.Entity<Country>().HasData(new Country() // 8
            {
                Id = cntrId++,
                ArabicName = "إسواتيني",
                LatinName = "Eswatini",
                IsArabic = false,
                Flag = System.IO.File.ReadAllBytes(@$"{flagPath}\Flag_of_Eswatini.svg.png"),
                TimeZoneId = sysTimeZones.First(tz => tz.DisplayName.Contains("UTC+02")).Id
            });

            modelBuilder.Entity<Country>().HasData(new Country() // 9
            {
                Id = cntrId++,
                ArabicName = "إثيوبيا",
                LatinName = "Ethiopia",
                IsArabic = false,
                Flag = System.IO.File.ReadAllBytes(@$"{flagPath}\Flag_of_Ethiopia.svg.png"),
                TimeZoneId = sysTimeZones.First(tz => tz.DisplayName.Contains("UTC+03")).Id
            });

            modelBuilder.Entity<Country>().HasData(new Country() // 10
            {
                Id = cntrId++,
                ArabicName = "غامبيا",
                LatinName = "Gambia",
                IsArabic = false,
                Flag = System.IO.File.ReadAllBytes(@$"{flagPath}\800px-Flag_of_The_Gambia.svg.png"),
                TimeZoneId = sysTimeZones.First(tz => tz.DisplayName.Contains("UTC+00")).Id
            });

            modelBuilder.Entity<Country>().HasData(new Country() // 11
            {
                Id = cntrId++,
                ArabicName = "غانا",
                LatinName = "Ghana",
                IsArabic = false,
                Flag = System.IO.File.ReadAllBytes(@$"{flagPath}\125px-Flag_of_Ghana.svg.png"),
                TimeZoneId = sysTimeZones.First(tz => tz.DisplayName.Contains("UTC+02")).Id
            });

            modelBuilder.Entity<Country>().HasData(new Country() // 12
            {
                Id = cntrId++,
                ArabicName = "العراق",
                LatinName = "Iraq",
                IsArabic = true,
                Flag = System.IO.File.ReadAllBytes(@$"{flagPath}\125px-Flag_of_Iraq.svg.png"),
                TimeZoneId = sysTimeZones.First(tz => tz.DisplayName.Contains("UTC+03")).Id
            });

            modelBuilder.Entity<Country>().HasData(new Country() // 13
            {
                Id = cntrId++,
                ArabicName = "الأردن",
                LatinName = "Jordan",
                IsArabic = true,
                Flag = System.IO.File.ReadAllBytes(@$"{flagPath}\125px-Flag_of_Jordan.svg.png"),
                TimeZoneId = sysTimeZones.First(tz => tz.DisplayName.Contains("UTC+02")).Id
            });

            modelBuilder.Entity<Country>().HasData(new Country() // 14
            {
                Id = cntrId++,
                ArabicName = "كينيا",
                LatinName = "Kenya",
                IsArabic = false,
                Flag = System.IO.File.ReadAllBytes(@$"{flagPath}\125px-Flag_of_Kenya.svg.png"),
                TimeZoneId = sysTimeZones.First(tz => tz.DisplayName.Contains("UTC+03")).Id
            });

            modelBuilder.Entity<Country>().HasData(new Country() // 15
            {
                Id = cntrId++,
                ArabicName = "الكويت",
                LatinName = "Kuwait",
                IsArabic = true,
                Flag = System.IO.File.ReadAllBytes(@$"{flagPath}\125px-Flag_of_Kuwait.svg.png"),
                TimeZoneId = sysTimeZones.First(tz => tz.DisplayName.Contains("UTC+03")).Id
            });

            modelBuilder.Entity<Country>().HasData(new Country() // 16
            {
                Id = cntrId++,
                ArabicName = "لبنان",
                LatinName = "Lebanon",
                IsArabic = true,
                Flag = System.IO.File.ReadAllBytes(@$"{flagPath}\125px-Flag_of_Lebanon.svg.png"),
                TimeZoneId = sysTimeZones.First(tz => tz.DisplayName.Contains("UTC+02")).Id
            });

            modelBuilder.Entity<Country>().HasData(new Country() // 17
            {
                Id = cntrId++,
                ArabicName = "ليسوتو",
                LatinName = "Lesotho",
                IsArabic = false,
                Flag = System.IO.File.ReadAllBytes(@$"{flagPath}\125px-Flag_of_Lesotho.svg.png"),
                TimeZoneId = sysTimeZones.First(tz => tz.DisplayName.Contains("UTC+02")).Id
            });

            modelBuilder.Entity<Country>().HasData(new Country() // 18
            {
                Id = cntrId++,
                ArabicName = "ليبيريا",
                LatinName = "Liberia",
                IsArabic = false,
                Flag = System.IO.File.ReadAllBytes(@$"{flagPath}\Flag_of_Liberia.svg.png"),
                TimeZoneId = sysTimeZones.First(tz => tz.DisplayName.Contains("UTC+00")).Id
            });

            modelBuilder.Entity<Country>().HasData(new Country() // 19
            {
                Id = cntrId++,
                ArabicName = "ليبيا",
                LatinName = "Libya",
                IsArabic = true,
                Flag = System.IO.File.ReadAllBytes(@$"{flagPath}\125px-Flag_of_Libya.svg.png"),
                TimeZoneId = sysTimeZones.First(tz => tz.DisplayName.Contains("UTC+02")).Id
            });

            modelBuilder.Entity<Country>().HasData(new Country() // 20
            {
                Id = cntrId++,
                ArabicName = "مالاوي",
                LatinName = "Malawi",
                IsArabic = false,
                Flag = System.IO.File.ReadAllBytes(@$"{flagPath}\125px-Flag_of_Malawi.svg.png"),
                TimeZoneId = sysTimeZones.First(tz => tz.DisplayName.Contains("UTC+02")).Id
            });

            modelBuilder.Entity<Country>().HasData(new Country() // 21
            {
                Id = cntrId++,
                ArabicName = "موريتانيا",
                LatinName = "Mauritania",
                IsArabic = true,
                Flag = System.IO.File.ReadAllBytes(@$"{flagPath}\Flag_of_Mauritania.svg.png"),
                TimeZoneId = sysTimeZones.First(tz => tz.DisplayName.Contains("UTC+00")).Id
            });

            modelBuilder.Entity<Country>().HasData(new Country() // 22
            {
                Id = cntrId++,
                ArabicName = "موريشيوس",
                LatinName = "Mauritius",
                IsArabic = false,
                Flag = System.IO.File.ReadAllBytes(@$"{flagPath}\125px-Flag_of_Mauritius.svg.png"),
                TimeZoneId = sysTimeZones.First(tz => tz.DisplayName.Contains("UTC+04")).Id
            });

            modelBuilder.Entity<Country>().HasData(new Country() // 23
            {
                Id = cntrId++,
                ArabicName = "المغرب",
                LatinName = "Morocco",
                IsArabic = true,
                Flag = System.IO.File.ReadAllBytes(@$"{flagPath}\125px-Flag_of_Morocco.svg.png"),
                TimeZoneId = sysTimeZones.First(tz => tz.DisplayName.Contains("UTC+01")).Id
            });

            modelBuilder.Entity<Country>().HasData(new Country() // 24
            {
                Id = cntrId++,
                ArabicName = "ناميبيا",
                LatinName = "Namibia",
                IsArabic = false,
                Flag = System.IO.File.ReadAllBytes(@$"{flagPath}\Flag_of_Namibia.svg.png"),
                TimeZoneId = sysTimeZones.First(tz => tz.DisplayName.Contains("UTC+02")).Id
            });

            modelBuilder.Entity<Country>().HasData(new Country() // 25
            {
                Id = cntrId++,
                ArabicName = "نيجيريا",
                LatinName = "Nigeria",
                IsArabic = false,
                Flag = System.IO.File.ReadAllBytes(@$"{flagPath}\125px-Flag_of_Nigeria.svg.png"),
                TimeZoneId = sysTimeZones.First(tz => tz.DisplayName.Contains("UTC+01")).Id
            });

            modelBuilder.Entity<Country>().HasData(new Country() // 26
            {
                Id = cntrId++,
                ArabicName = "عُمان",
                LatinName = "Oman",
                IsArabic = true,
                Flag = System.IO.File.ReadAllBytes(@$"{flagPath}\125px-Flag_of_Oman.svg.png"),
                TimeZoneId = sysTimeZones.First(tz => tz.DisplayName.Contains("UTC+04")).Id
            });

            modelBuilder.Entity<Country>().HasData(new Country() // 27
            {
                Id = cntrId++,
                ArabicName = "قطر",
                LatinName = "Qatar",
                IsArabic = true,
                Flag = System.IO.File.ReadAllBytes(@$"{flagPath}\Flag_of_Qatar.svg.png"),
                TimeZoneId = sysTimeZones.First(tz => tz.DisplayName.Contains("UTC+03")).Id
            });

            modelBuilder.Entity<Country>().HasData(new Country() // 28
            {
                Id = cntrId++,
                ArabicName = "رواندا",
                LatinName = "Rwanda",
                IsArabic = false,
                Flag = System.IO.File.ReadAllBytes(@$"{flagPath}\125px-Flag_of_Rwanda.svg.png"),
                TimeZoneId = sysTimeZones.First(tz => tz.DisplayName.Contains("UTC+02")).Id
            });

            modelBuilder.Entity<Country>().HasData(new Country() // 29
            {
                Id = cntrId++,
                ArabicName = "السعودية",
                LatinName = "Saudi Arabia",
                IsArabic = true,
                Flag = System.IO.File.ReadAllBytes(@$"{flagPath}\Flag_of_Saudi_Arabia.svg.png"),
                TimeZoneId = sysTimeZones.First(tz => tz.DisplayName.Contains("UTC+03")).Id
            });

            modelBuilder.Entity<Country>().HasData(new Country() // 30
            {
                Id = cntrId++,
                ArabicName = "سيشل",
                LatinName = "Seychelles",
                IsArabic = false,
                Flag = System.IO.File.ReadAllBytes(@$"{flagPath}\Flag_of_Seychelles.svg.png"),
                TimeZoneId = sysTimeZones.First(tz => tz.DisplayName.Contains("UTC+04")).Id
            });

            modelBuilder.Entity<Country>().HasData(new Country() // 31
            {
                Id = cntrId++,
                ArabicName = "سيراليون",
                LatinName = "Sierra Leone",
                IsArabic = false,
                Flag = System.IO.File.ReadAllBytes(@$"{flagPath}\125px-Flag_of_Sierra_Leone.svg.png"),
                TimeZoneId = sysTimeZones.First(tz => tz.DisplayName.Contains("UTC+00")).Id
            });

            modelBuilder.Entity<Country>().HasData(new Country() // 32
            {
                Id = cntrId++,
                ArabicName = "الصومال",
                LatinName = "Somalia",
                IsArabic = true,
                Flag = System.IO.File.ReadAllBytes(@$"{flagPath}\Flag_of_Somalia.svg.png"),
                TimeZoneId = sysTimeZones.First(tz => tz.DisplayName.Contains("UTC+03")).Id
            });

            modelBuilder.Entity<Country>().HasData(new Country() // 33
            {
                Id = cntrId++,
                ArabicName = "جنوب أفريقيا",
                LatinName = "South Africa",
                IsArabic = false,
                Flag = System.IO.File.ReadAllBytes(@$"{flagPath}\Flag_of_South_Africa.svg.png"),
                TimeZoneId = sysTimeZones.First(tz => tz.DisplayName.Contains("UTC+02")).Id
            });

            modelBuilder.Entity<Country>().HasData(new Country() // 34
            {
                Id = cntrId++,
                ArabicName = "جنوب السودان",
                LatinName = "South Sudan",
                IsArabic = false,
                Flag = System.IO.File.ReadAllBytes(@$"{flagPath}\Flag_of_South_Sudan.svg.png"),
                TimeZoneId = sysTimeZones.First(tz => tz.DisplayName.Contains("UTC+02")).Id
            });

            modelBuilder.Entity<Country>().HasData(new Country() // 35
            {
                Id = cntrId++,
                ArabicName = "السودان",
                LatinName = "Sudan",
                IsArabic = true,
                Flag = System.IO.File.ReadAllBytes(@$"{flagPath}\125px-Flag_of_Sudan.svg.png"),
                TimeZoneId = sysTimeZones.First(tz => tz.DisplayName.Contains("UTC+02")).Id
            });

            modelBuilder.Entity<Country>().HasData(new Country() // 36
            {
                Id = cntrId++,
                ArabicName = "تنزانيا",
                LatinName = "Tanzania",
                IsArabic = false,
                Flag = System.IO.File.ReadAllBytes(@$"{flagPath}\125px-Flag_of_Tanzania.svg.png"),
                TimeZoneId = sysTimeZones.First(tz => tz.DisplayName.Contains("UTC+03")).Id
            });

            modelBuilder.Entity<Country>().HasData(new Country() // 37
            {
                Id = cntrId++,
                ArabicName = "تونس",
                LatinName = "Tunisia",
                IsArabic = true,
                Flag = System.IO.File.ReadAllBytes(@$"{flagPath}\Flag_of_Tunisia.svg.png"),
                TimeZoneId = sysTimeZones.First(tz => tz.DisplayName.Contains("UTC+01")).Id
            });

            modelBuilder.Entity<Country>().HasData(new Country() // 38
            {
                Id = cntrId++,
                ArabicName = "تركيا",
                LatinName = "Türkie",
                IsArabic = false,
                Flag = System.IO.File.ReadAllBytes(@$"{flagPath}\Flag_of_Turkey.svg.png"),
                TimeZoneId = sysTimeZones.First(tz => tz.DisplayName.Contains("UTC+03")).Id
            });

            modelBuilder.Entity<Country>().HasData(new Country() // 39
            {
                Id = cntrId++,
                ArabicName = "أوغندا",
                LatinName = "Uganda",
                IsArabic = false,
                Flag = System.IO.File.ReadAllBytes(@$"{flagPath}\125px-Flag_of_Uganda.svg.png"),
                TimeZoneId = sysTimeZones.First(tz => tz.DisplayName.Contains("UTC+03")).Id
            });

            modelBuilder.Entity<Country>().HasData(new Country() // 40
            {
                Id = cntrId++,
                ArabicName = "الإمارات",
                LatinName = "UAE",
                IsArabic = true,
                Flag = System.IO.File.ReadAllBytes(@$"{flagPath}\125px-Flag_of_Emirates.svg.png"),
                TimeZoneId = sysTimeZones.First(tz => tz.DisplayName.Contains("UTC+04")).Id
            });

            modelBuilder.Entity<Country>().HasData(new Country() // 41
            {
                Id = cntrId++,
                ArabicName = "الولايات المتحدة",
                LatinName = "USA",
                IsArabic = false,
                Flag = System.IO.File.ReadAllBytes(@$"{flagPath}\Flag_of_USA.png"),
                TimeZoneId = sysTimeZones.First(tz => tz.DisplayName.Contains("UTC-06")).Id
            });

            modelBuilder.Entity<Country>().HasData(new Country() // 42
            {
                Id = cntrId++,
                ArabicName = "اليمن",
                LatinName = "Yemen",
                IsArabic = true,
                Flag = System.IO.File.ReadAllBytes(@$"{flagPath}\125px-Flag_of_Yemen.svg.png"),
                TimeZoneId = sysTimeZones.First(tz => tz.DisplayName.Contains("UTC+03")).Id
            });

            modelBuilder.Entity<Country>().HasData(new Country() // 43
            {
                Id = cntrId++,
                ArabicName = "زامبيا",
                LatinName = "Zambia",
                IsArabic = false,
                Flag = System.IO.File.ReadAllBytes(@$"{flagPath}\125px-Flag_of_Zambia.svg.png"),
                TimeZoneId = sysTimeZones.First(tz => tz.DisplayName.Contains("UTC+02")).Id
            });

            modelBuilder.Entity<Country>().HasData(new Country() // 44
            {
                Id = cntrId++,
                ArabicName = "زيمبابوي",
                LatinName = "Zimbabwe",
                IsArabic = false,
                Flag = System.IO.File.ReadAllBytes(@$"{flagPath}\Flag_of_Zimbabwe.svg.png"),
                TimeZoneId = sysTimeZones.First(tz => tz.DisplayName.Contains("UTC+02")).Id
            });
        }
    }
}
