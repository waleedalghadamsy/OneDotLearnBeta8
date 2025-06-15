using Microsoft.EntityFrameworkCore;
using OneDotLearnCore.Essential;
using OneDotLearnData;
using OneDotLearnData.EntitiesRepositories;

namespace WDataSeeder.Helpers
{
    public class CountriesSeeder
    {
        public CountriesSeeder(OdlDataContext dbCtx)//, IRepositoryWrapper repos)
        {
            var sysTimeZones = TimeZoneInfo.GetSystemTimeZones();
            string flagPath = @"C:\Users\walee\OneDrive\Pictures\Flags";
            short cntrId = 1;

            try
            {
                var cntrs = new List<Country>() {
                            new Country() // 1
                            {
                                Id = cntrId++,
                                ArabicName = "الجزائر",
                                LatinName = "Algeria",
                                ItuCode = 213,
                                IsArabic = true,
                                Flag = System.IO.File.ReadAllBytes(@$"{flagPath}\125px-Flag_of_Algeria.svg.png"),
                                TimeZoneId = sysTimeZones.First(tz => tz.DisplayName.Contains("UTC+01")).Id,
                                CreatedById = 1,
                                CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                                EntityStatus = EntityStatus.Active,
                            },

                            new Country() // 2
                            {
                                Id = cntrId++,
                                ArabicName = "البحرين",
                                LatinName = "Bahrain",
                                ItuCode = 973,
                                IsArabic = true,
                                Flag = System.IO.File.ReadAllBytes(@$"{flagPath}\125px-Flag_of_Bahrain.svg.png"),
                                TimeZoneId = sysTimeZones.First(tz => tz.DisplayName.Contains("UTC+03")).Id,
                                CreatedById = 1,
                                CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                                EntityStatus = EntityStatus.Active,
                            },

                            new Country() // 3
                            {
                                Id = cntrId++,
                                ArabicName = "بوتسوانا",
                                LatinName = "Botswana",
                                ItuCode = 267,
                                IsArabic = false,
                                Flag = System.IO.File.ReadAllBytes(@$"{flagPath}\125px-Flag_of_Botswana.svg.png"),
                                TimeZoneId = sysTimeZones.First(tz => tz.DisplayName.Contains("UTC+02")).Id,
                                CreatedById = 1,
                                CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                                EntityStatus = EntityStatus.Active,
                            },

                            new Country() // 4
                            {
                                Id = cntrId++,
                                ArabicName = "بوروندي",
                                LatinName = "Burundi",
                                ItuCode = 257,
                                IsArabic = false,
                                Flag = System.IO.File.ReadAllBytes(@$"{flagPath}\Flag_of_Burundi.svg.png"),
                                TimeZoneId = sysTimeZones.First(tz => tz.DisplayName.Contains("UTC+02")).Id,
                                CreatedById = 1,
                                CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                                EntityStatus = EntityStatus.Active,
                            },

                            new Country() // 5
                            {
                                Id = cntrId++,
                                ArabicName = "الكاميرون",
                                LatinName = "Cameroon",
                                ItuCode = 237,
                                IsArabic = false,
                                Flag = System.IO.File.ReadAllBytes(@$"{flagPath}\125px-Flag_of_Cameroon.svg.png"),
                                TimeZoneId = sysTimeZones.First(tz => tz.DisplayName.Contains("UTC+02")).Id,
                                CreatedById = 1,
                                CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                                EntityStatus = EntityStatus.Active,
                            },

                            new Country() // 6
                            {
                                Id = cntrId++,
                                ArabicName = "مصر",
                                LatinName = "Egypt",
                                ItuCode = 20,
                                IsArabic = true,
                                Flag = System.IO.File.ReadAllBytes(@$"{flagPath}\125px-Flag_of_Egypt.svg.png"),
                                TimeZoneId = sysTimeZones.First(tz => tz.DisplayName.Contains("UTC+02")).Id,
                                CreatedById = 1,
                                CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                                EntityStatus = EntityStatus.Active,
                            },

                            new Country() // 7
                            {
                                Id = cntrId++,
                                ArabicName = "إريتريا",
                                LatinName = "Eritrea",
                                ItuCode = 291,
                                IsArabic = true,
                                Flag = System.IO.File.ReadAllBytes(@$"{flagPath}\Flag_of_Eritrea.svg.png"),
                                TimeZoneId = sysTimeZones.First(tz => tz.DisplayName.Contains("UTC+03")).Id,
                                CreatedById = 1,
                                CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                                EntityStatus = EntityStatus.Active,
                            },

                            new Country() // 8
                            {
                                Id = cntrId++,
                                ArabicName = "إسواتيني",
                                LatinName = "Eswatini",
                                ItuCode = 268,
                                IsArabic = false,
                                Flag = System.IO.File.ReadAllBytes(@$"{flagPath}\Flag_of_Eswatini.svg.png"),
                                TimeZoneId = sysTimeZones.First(tz => tz.DisplayName.Contains("UTC+02")).Id,
                                CreatedById = 1,
                                CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                                EntityStatus = EntityStatus.Active,
                            },

                            new Country() // 9
                            {
                                Id = cntrId++,
                                ArabicName = "إثيوبيا",
                                LatinName = "Ethiopia",
                                ItuCode = 251,
                                IsArabic = false,
                                Flag = System.IO.File.ReadAllBytes(@$"{flagPath}\Flag_of_Ethiopia.svg.png"),
                                TimeZoneId = sysTimeZones.First(tz => tz.DisplayName.Contains("UTC+03")).Id,
                                CreatedById = 1,
                                CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                                EntityStatus = EntityStatus.Active,
                            },

                            new Country() // 10
                            {
                                Id = cntrId++,
                                ArabicName = "غامبيا",
                                LatinName = "Gambia",
                                ItuCode = 220,
                                IsArabic = false,
                                Flag = System.IO.File.ReadAllBytes(@$"{flagPath}\800px-Flag_of_The_Gambia.svg.png"),
                                TimeZoneId = sysTimeZones.First(tz => tz.DisplayName.Contains("UTC+00")).Id,
                                CreatedById = 1,
                                CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                                EntityStatus = EntityStatus.Active,
                            },

                            new Country() // 11
                            {
                                Id = cntrId++,
                                ArabicName = "غانا",
                                LatinName = "Ghana",
                                ItuCode = 233,
                                IsArabic = false,
                                Flag = System.IO.File.ReadAllBytes(@$"{flagPath}\125px-Flag_of_Ghana.svg.png"),
                                TimeZoneId = sysTimeZones.First(tz => tz.DisplayName.Contains("UTC+02")).Id,
                                CreatedById = 1,
                                CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                                EntityStatus = EntityStatus.Active,
                            },

                            new Country() // 12
                            {
                                Id = cntrId++,
                                ArabicName = "العراق",
                                LatinName = "Iraq",
                                ItuCode = 964,
                                IsArabic = true,
                                Flag = System.IO.File.ReadAllBytes(@$"{flagPath}\125px-Flag_of_Iraq.svg.png"),
                                TimeZoneId = sysTimeZones.First(tz => tz.DisplayName.Contains("UTC+03")).Id,
                                CreatedById = 1,
                                CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                                EntityStatus = EntityStatus.Active,
                            },

                            new Country() // 13
                            {
                                Id = cntrId++,
                                ArabicName = "الأردن",
                                LatinName = "Jordan",
                                ItuCode = 962,
                                IsArabic = true,
                                Flag = System.IO.File.ReadAllBytes(@$"{flagPath}\125px-Flag_of_Jordan.svg.png"),
                                TimeZoneId = sysTimeZones.First(tz => tz.DisplayName.Contains("UTC+02")).Id,
                                CreatedById = 1,
                                CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                                EntityStatus = EntityStatus.Active,
                            },

                            new Country() // 14
                            {
                                Id = cntrId++,
                                ArabicName = "كينيا",
                                LatinName = "Kenya",
                                ItuCode = 254,
                                IsArabic = false,
                                Flag = System.IO.File.ReadAllBytes(@$"{flagPath}\125px-Flag_of_Kenya.svg.png"),
                                TimeZoneId = sysTimeZones.First(tz => tz.DisplayName.Contains("UTC+03")).Id,
                                CreatedById = 1,
                                CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                                EntityStatus = EntityStatus.Active,
                            },

                            new Country() // 15
                            {
                                Id = cntrId++,
                                ArabicName = "الكويت",
                                LatinName = "Kuwait",
                                ItuCode = 965,
                                IsArabic = true,
                                Flag = System.IO.File.ReadAllBytes(@$"{flagPath}\125px-Flag_of_Kuwait.svg.png"),
                                TimeZoneId = sysTimeZones.First(tz => tz.DisplayName.Contains("UTC+03")).Id,
                                CreatedById = 1,
                                CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                                EntityStatus = EntityStatus.Active,
                            },

                            new Country() // 16
                            {
                                Id = cntrId++,
                                ArabicName = "لبنان",
                                LatinName = "Lebanon",
                                ItuCode = 961,
                                IsArabic = true,
                                Flag = System.IO.File.ReadAllBytes(@$"{flagPath}\125px-Flag_of_Lebanon.svg.png"),
                                TimeZoneId = sysTimeZones.First(tz => tz.DisplayName.Contains("UTC+02")).Id,
                                CreatedById = 1,
                                CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                                EntityStatus = EntityStatus.Active,
                            },

                            new Country() // 17
                            {
                                Id = cntrId++,
                                ArabicName = "ليسوتو",
                                LatinName = "Lesotho",
                                ItuCode = 266,
                                IsArabic = false,
                                Flag = System.IO.File.ReadAllBytes(@$"{flagPath}\125px-Flag_of_Lesotho.svg.png"),
                                TimeZoneId = sysTimeZones.First(tz => tz.DisplayName.Contains("UTC+02")).Id,
                                CreatedById = 1,
                                CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                                EntityStatus = EntityStatus.Active,
                            },

                            new Country() // 18
                            {
                                Id = cntrId++,
                                ArabicName = "ليبيريا",
                                LatinName = "Liberia",
                                ItuCode = 231,
                                IsArabic = false,
                                Flag = System.IO.File.ReadAllBytes(@$"{flagPath}\Flag_of_Liberia.svg.png"),
                                TimeZoneId = sysTimeZones.First(tz => tz.DisplayName.Contains("UTC+00")).Id,
                                CreatedById = 1,
                                CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                                EntityStatus = EntityStatus.Active,
                            },

                            new Country() // 19
                            {
                                Id = cntrId++,
                                ArabicName = "ليبيا",
                                LatinName = "Libya",
                                ItuCode = 218,
                                IsArabic = true,
                                Flag = System.IO.File.ReadAllBytes(@$"{flagPath}\125px-Flag_of_Libya.svg.png"),
                                TimeZoneId = sysTimeZones.First(tz => tz.DisplayName.Contains("UTC+02")).Id,
                                CreatedById = 1,
                                CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                                EntityStatus = EntityStatus.Active,
                            },

                            new Country() // 20
                            {
                                Id = cntrId++,
                                ArabicName = "مالاوي",
                                LatinName = "Malawi",
                                ItuCode = 265,
                                IsArabic = false,
                                Flag = System.IO.File.ReadAllBytes(@$"{flagPath}\125px-Flag_of_Malawi.svg.png"),
                                TimeZoneId = sysTimeZones.First(tz => tz.DisplayName.Contains("UTC+02")).Id,
                                CreatedById = 1,
                                CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                                EntityStatus = EntityStatus.Active,
                            },

                            new Country() // 21
                            {
                                Id = cntrId++,
                                ArabicName = "موريتانيا",
                                LatinName = "Mauritania",
                                ItuCode = 222,
                                IsArabic = true,
                                Flag = System.IO.File.ReadAllBytes(@$"{flagPath}\Flag_of_Mauritania.svg.png"),
                                TimeZoneId = sysTimeZones.First(tz => tz.DisplayName.Contains("UTC+00")).Id,
                                CreatedById = 1,
                                CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                                EntityStatus = EntityStatus.Active,
                            },

                            new Country() // 22
                            {
                                Id = cntrId++,
                                ArabicName = "موريشيوس",
                                LatinName = "Mauritius",
                                ItuCode = 230,
                                IsArabic = false,
                                Flag = System.IO.File.ReadAllBytes(@$"{flagPath}\125px-Flag_of_Mauritius.svg.png"),
                                TimeZoneId = sysTimeZones.First(tz => tz.DisplayName.Contains("UTC+04")).Id,
                                CreatedById = 1,
                                CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                                EntityStatus = EntityStatus.Active,
                            },

                            new Country() // 23
                            {
                                Id = cntrId++,
                                ArabicName = "المغرب",
                                LatinName = "Morocco",
                                ItuCode = 212,
                                IsArabic = true,
                                Flag = System.IO.File.ReadAllBytes(@$"{flagPath}\125px-Flag_of_Morocco.svg.png"),
                                TimeZoneId = sysTimeZones.First(tz => tz.DisplayName.Contains("UTC+01")).Id,
                                CreatedById = 1,
                                CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                                EntityStatus = EntityStatus.Active,
                            },

                            new Country() // 24
                            {
                                Id = cntrId++,
                                ArabicName = "ناميبيا",
                                LatinName = "Namibia",
                                ItuCode = 264,
                                IsArabic = false,
                                Flag = System.IO.File.ReadAllBytes(@$"{flagPath}\Flag_of_Namibia.svg.png"),
                                TimeZoneId = sysTimeZones.First(tz => tz.DisplayName.Contains("UTC+02")).Id,
                                CreatedById = 1,
                                CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                                EntityStatus = EntityStatus.Active,
                            },

                            new Country() // 25
                            {
                                Id = cntrId++,
                                ArabicName = "نيجيريا",
                                LatinName = "Nigeria",
                                ItuCode = 234,
                                IsArabic = false,
                                Flag = System.IO.File.ReadAllBytes(@$"{flagPath}\125px-Flag_of_Nigeria.svg.png"),
                                TimeZoneId = sysTimeZones.First(tz => tz.DisplayName.Contains("UTC+01")).Id,
                                CreatedById = 1,
                                CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                                EntityStatus = EntityStatus.Active,
                            },

                            new Country() // 26
                            {
                                Id = cntrId++,
                                ArabicName = "عُمان",
                                LatinName = "Oman",
                                ItuCode = 968,
                                IsArabic = true,
                                Flag = System.IO.File.ReadAllBytes(@$"{flagPath}\125px-Flag_of_Oman.svg.png"),
                                TimeZoneId = sysTimeZones.First(tz => tz.DisplayName.Contains("UTC+04")).Id,
                                CreatedById = 1,
                                CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                                EntityStatus = EntityStatus.Active,
                            },

                            new Country() // 27
                            {
                                Id = cntrId++,
                                ArabicName = "قطر",
                                LatinName = "Qatar",
                                ItuCode = 974,
                                IsArabic = true,
                                Flag = System.IO.File.ReadAllBytes(@$"{flagPath}\Flag_of_Qatar.svg.png"),
                                TimeZoneId = sysTimeZones.First(tz => tz.DisplayName.Contains("UTC+03")).Id,
                                CreatedById = 1,
                                CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                                EntityStatus = EntityStatus.Active,
                            },

                            new Country() // 28
                            {
                                Id = cntrId++,
                                ArabicName = "رواندا",
                                LatinName = "Rwanda",
                                ItuCode = 250,
                                IsArabic = false,
                                Flag = System.IO.File.ReadAllBytes(@$"{flagPath}\125px-Flag_of_Rwanda.svg.png"),
                                TimeZoneId = sysTimeZones.First(tz => tz.DisplayName.Contains("UTC+02")).Id,
                                CreatedById = 1,
                                CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                                EntityStatus = EntityStatus.Active,
                            },

                            new Country() // 29
                            {
                                Id = cntrId++,
                                ArabicName = "السعودية",
                                LatinName = "Saudi Arabia",
                                ItuCode = 966,
                                IsArabic = true,
                                Flag = System.IO.File.ReadAllBytes(@$"{flagPath}\Flag_of_Saudi_Arabia.svg.png"),
                                TimeZoneId = sysTimeZones.First(tz => tz.DisplayName.Contains("UTC+03")).Id,
                                CreatedById = 1,
                                CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                                EntityStatus = EntityStatus.Active,
                            },

                            new Country() // 30
                            {
                                Id = cntrId++,
                                ArabicName = "سيشل",
                                LatinName = "Seychelles",
                                ItuCode = 248,
                                IsArabic = false,
                                Flag = System.IO.File.ReadAllBytes(@$"{flagPath}\Flag_of_Seychelles.svg.png"),
                                TimeZoneId = sysTimeZones.First(tz => tz.DisplayName.Contains("UTC+04")).Id,
                                CreatedById = 1,
                                CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                                EntityStatus = EntityStatus.Active,
                            },

                            new Country() // 31
                            {
                                Id = cntrId++,
                                ArabicName = "سيراليون",
                                LatinName = "Sierra Leone",
                                ItuCode = 232,
                                IsArabic = false,
                                Flag = System.IO.File.ReadAllBytes(@$"{flagPath}\125px-Flag_of_Sierra_Leone.svg.png"),
                                TimeZoneId = sysTimeZones.First(tz => tz.DisplayName.Contains("UTC+00")).Id,
                                CreatedById = 1,
                                CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                                EntityStatus = EntityStatus.Active,
                            },

                            new Country() // 32
                            {
                                Id = cntrId++,
                                ArabicName = "الصومال",
                                LatinName = "Somalia",
                                ItuCode = 252,
                                IsArabic = true,
                                Flag = System.IO.File.ReadAllBytes(@$"{flagPath}\Flag_of_Somalia.svg.png"),
                                TimeZoneId = sysTimeZones.First(tz => tz.DisplayName.Contains("UTC+03")).Id,
                                CreatedById = 1,
                                CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                                EntityStatus = EntityStatus.Active,
                            },

                            new Country() // 33
                            {
                                Id = cntrId++,
                                ArabicName = "جنوب أفريقيا",
                                LatinName = "South Africa",
                                ItuCode = 27,
                                IsArabic = false,
                                Flag = System.IO.File.ReadAllBytes(@$"{flagPath}\Flag_of_South_Africa.svg.png"),
                                TimeZoneId = sysTimeZones.First(tz => tz.DisplayName.Contains("UTC+02")).Id,
                                CreatedById = 1,
                                CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                                EntityStatus = EntityStatus.Active,
                            },

                            new Country() // 34
                            {
                                Id = cntrId++,
                                ArabicName = "جنوب السودان",
                                LatinName = "South Sudan",
                                ItuCode = 211,
                                IsArabic = false,
                                Flag = System.IO.File.ReadAllBytes(@$"{flagPath}\Flag_of_South_Sudan.svg.png"),
                                TimeZoneId = sysTimeZones.First(tz => tz.DisplayName.Contains("UTC+02")).Id,
                                CreatedById = 1,
                                CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                                EntityStatus = EntityStatus.Active,
                            },

                            new Country() // 35
                            {
                                Id = cntrId++,
                                ArabicName = "السودان",
                                LatinName = "Sudan",
                                ItuCode = 249,
                                IsArabic = true,
                                Flag = System.IO.File.ReadAllBytes(@$"{flagPath}\125px-Flag_of_Sudan.svg.png"),
                                TimeZoneId = sysTimeZones.First(tz => tz.DisplayName.Contains("UTC+02")).Id,
                                CreatedById = 1,
                                CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                                EntityStatus = EntityStatus.Active,
                            },

                            new Country() // 36
                            {
                                Id = cntrId++,
                                ArabicName = "تنزانيا",
                                LatinName = "Tanzania",
                                ItuCode = 255,
                                IsArabic = false,
                                Flag = System.IO.File.ReadAllBytes(@$"{flagPath}\125px-Flag_of_Tanzania.svg.png"),
                                TimeZoneId = sysTimeZones.First(tz => tz.DisplayName.Contains("UTC+03")).Id,
                                CreatedById = 1,
                                CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                                EntityStatus = EntityStatus.Active,
                            },

                            new Country() // 37
                            {
                                Id = cntrId++,
                                ArabicName = "تونس",
                                LatinName = "Tunisia",
                                ItuCode = 216,
                                IsArabic = true,
                                Flag = System.IO.File.ReadAllBytes(@$"{flagPath}\Flag_of_Tunisia.svg.png"),
                                TimeZoneId = sysTimeZones.First(tz => tz.DisplayName.Contains("UTC+01")).Id,
                                CreatedById = 1,
                                CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                                EntityStatus = EntityStatus.Active,
                            },

                            new Country() // 38
                            {
                                Id = cntrId++,
                                ArabicName = "تركيا",
                                LatinName = "Türkie",
                                ItuCode = 90,
                                IsArabic = false,
                                Flag = System.IO.File.ReadAllBytes(@$"{flagPath}\Flag_of_Turkey.svg.png"),
                                TimeZoneId = sysTimeZones.First(tz => tz.DisplayName.Contains("UTC+03")).Id,
                                CreatedById = 1,
                                CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                                EntityStatus = EntityStatus.Active,
                            },

                            new Country() // 39
                            {
                                Id = cntrId++,
                                ArabicName = "أوغندا",
                                LatinName = "Uganda",
                                ItuCode = 256,
                                IsArabic = false,
                                Flag = System.IO.File.ReadAllBytes(@$"{flagPath}\125px-Flag_of_Uganda.svg.png"),
                                TimeZoneId = sysTimeZones.First(tz => tz.DisplayName.Contains("UTC+03")).Id,
                                CreatedById = 1,
                                CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                                EntityStatus = EntityStatus.Active,
                            },

                            new Country() // 40
                            {
                                Id = cntrId++,
                                ArabicName = "الإمارات",
                                LatinName = "UAE",
                                ItuCode = 971,
                                IsArabic = true,
                                Flag = System.IO.File.ReadAllBytes(@$"{flagPath}\125px-Flag_of_Emirates.svg.png"),
                                TimeZoneId = sysTimeZones.First(tz => tz.DisplayName.Contains("UTC+04")).Id,
                                CreatedById = 1,
                                CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                                EntityStatus = EntityStatus.Active,
                            },

                            new Country() // 41
                            {
                                Id = cntrId++,
                                ArabicName = "الولايات المتحدة",
                                LatinName = "USA",
                                ItuCode = 1,
                                IsArabic = false,
                                Flag = System.IO.File.ReadAllBytes(@$"{flagPath}\Flag_of_USA.png"),
                                TimeZoneId = sysTimeZones.First(tz => tz.DisplayName.Contains("UTC-06")).Id,
                                CreatedById = 1,
                                CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                                EntityStatus = EntityStatus.Active,
                            },

                            new Country() // 42
                            {
                                Id = cntrId++,
                                ArabicName = "اليمن",
                                LatinName = "Yemen",
                                ItuCode = 967,
                                IsArabic = true,
                                Flag = System.IO.File.ReadAllBytes(@$"{flagPath}\125px-Flag_of_Yemen.svg.png"),
                                TimeZoneId = sysTimeZones.First(tz => tz.DisplayName.Contains("UTC+03")).Id,
                                CreatedById = 1,
                                CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                                EntityStatus = EntityStatus.Active,
                            },

                            new Country() // 43
                            {
                                Id = cntrId++,
                                ArabicName = "زامبيا",
                                LatinName = "Zambia",
                                ItuCode = 260,
                                IsArabic = false,
                                Flag = System.IO.File.ReadAllBytes(@$"{flagPath}\125px-Flag_of_Zambia.svg.png"),
                                TimeZoneId = sysTimeZones.First(tz => tz.DisplayName.Contains("UTC+02")).Id,
                                CreatedById = 1,
                                CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                                EntityStatus = EntityStatus.Active,
                            },

                            new Country() // 44
                            {
                                Id = cntrId++,
                                ArabicName = "زيمبابوي",
                                LatinName = "Zimbabwe",
                                ItuCode = 263,
                                IsArabic = false,
                                Flag = System.IO.File.ReadAllBytes(@$"{flagPath}\Flag_of_Zimbabwe.svg.png"),
                                TimeZoneId = sysTimeZones.First(tz => tz.DisplayName.Contains("UTC+02")).Id,
                                CreatedById = 1,
                                CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                                EntityStatus = EntityStatus.Active,
                            }
                    };

                Task.Run(async () =>
                {
                    try
                    {
                        await dbCtx.AddRangeAsync(cntrs);
                    }
                    catch (Exception ex)
                    {

                        throw;
                    }
                    

                    //var rslt = await repos.Countries.AddRangeAsync(cntrs);
                });
            }
            catch (Exception ex)
            {

                throw;
            }
            

            
        }
    }
}
