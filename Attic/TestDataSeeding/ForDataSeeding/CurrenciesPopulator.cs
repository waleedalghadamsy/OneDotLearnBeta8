using Microsoft.EntityFrameworkCore;
using OneDotLearnCore.Essential;
using OneDotLearnCore.Financials;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneDotLearnData.ForDataSeeding
{
    internal class CurrenciesPopulator
    {
        internal static void Add(ModelBuilder modelBuilder)
        {
            var crnsId = 1;
            modelBuilder.Entity<Currency>().HasData(new Currency()
            {
                Id = crnsId++,
                ArabicName = "دينار جزائري",
                LatinName = "Algerian Dinar",
                IsoCode = "DZD",
                ArabicSymbol = "د ج",
                LatinSymbol = "DA",
                CountryId = 1,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow,
                EntityStatus = EntityStatus.Active,
            });
            modelBuilder.Entity<Currency>().HasData(new Currency()
            {
                Id = crnsId++,
                ArabicName = "دينار بحريني",
                LatinName = "Bahraini Dinar",
                IsoCode = "BHD",
                ArabicSymbol = "د ب",
                LatinSymbol = "BD",
                CountryId = 2,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow,
                EntityStatus = EntityStatus.Active,
            });
            modelBuilder.Entity<Currency>().HasData(new Currency()
            {
                Id = crnsId++,
                LatinName = "Botswana Pula",
                IsoCode = "BWP",
                LatinSymbol = "BWP",
                CountryId = 3,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow,
                EntityStatus = EntityStatus.Active,
            });
            modelBuilder.Entity<Currency>().HasData(new Currency()
            {
                Id = crnsId++,
                LatinName = "Burundi Franc",
                IsoCode = "BIF",
                LatinSymbol = "BIF",
                CountryId = 4,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow,
                EntityStatus = EntityStatus.Active,
            });
            modelBuilder.Entity<Currency>().HasData(new Currency()
            {
                Id = crnsId++,
                LatinName = "Central African CFA Franc",
                IsoCode = "XAF",
                LatinSymbol = "XAF",
                CountryId = 5,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow,
                EntityStatus = EntityStatus.Active,
            });
            modelBuilder.Entity<Currency>().HasData(new Currency()
            {
                Id = crnsId++,
                ArabicName = "جنيه مصري",
                LatinName = "Egyptian Pound",
                IsoCode = "EGP",
                ArabicSymbol = "ج م",
                LatinSymbol = "LE",
                CountryId = 6,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow,
                EntityStatus = EntityStatus.Active,
            });
            modelBuilder.Entity<Currency>().HasData(new Currency()
            {
                Id = crnsId++,
                ArabicName = "نقفة إريتري",
                LatinName = "Eritrean Nakfa",
                IsoCode = "ERN",
                ArabicSymbol = "ن ر",
                LatinSymbol = "ERN",
                CountryId = 7,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow,
                EntityStatus = EntityStatus.Active,
            });
            modelBuilder.Entity<Currency>().HasData(new Currency()
            {
                Id = crnsId++,
                LatinName = "Swazi Lilangeni",
                IsoCode = "SZL",
                LatinSymbol = "SZL",
                CountryId = 8,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow,
                EntityStatus = EntityStatus.Active,
            });
            modelBuilder.Entity<Currency>().HasData(new Currency()
            {
                Id = crnsId++,
                LatinName = "Ethiopian Birr",
                IsoCode = "ETB",
                LatinSymbol = "ETB",
                CountryId = 9,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow,
                EntityStatus = EntityStatus.Active,
            });
            modelBuilder.Entity<Currency>().HasData(new Currency()
            {
                Id = crnsId++,
                LatinName = "Gambian Dalasi",
                IsoCode = "GMD",
                LatinSymbol = "GMD",
                CountryId = 10,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow,
                EntityStatus = EntityStatus.Active,
            });
            modelBuilder.Entity<Currency>().HasData(new Currency()
            {
                Id = crnsId++,
                LatinName = "Ghanaian Cedi",
                IsoCode = "GHS",
                LatinSymbol = "GHS",
                CountryId = 11,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow,
                EntityStatus = EntityStatus.Active,
            });
            modelBuilder.Entity<Currency>().HasData(new Currency()
            {
                Id = crnsId++,
                ArabicName = "دينار عراقي",
                LatinName = "Iraqi Dinar",
                IsoCode = "IQD",
                ArabicSymbol = "د ع",
                LatinSymbol = "ID",
                CountryId = 12,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow,
                EntityStatus = EntityStatus.Active,
            });
            modelBuilder.Entity<Currency>().HasData(new Currency()
            {
                Id = crnsId++,
                ArabicName = "دينار أردني",
                LatinName = "Jordanian Dinar",
                IsoCode = "JOD",
                ArabicSymbol = "د أ",
                LatinSymbol = "JD",
                CountryId = 13,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow,
                EntityStatus = EntityStatus.Active,
            });
            modelBuilder.Entity<Currency>().HasData(new Currency()
            {
                Id = crnsId++,
                LatinName = "Kenyan Shilling",
                IsoCode = "KES",
                LatinSymbol = "KES",
                CountryId = 14,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow,
                EntityStatus = EntityStatus.Active,
            });
            modelBuilder.Entity<Currency>().HasData(new Currency()
            {
                Id = crnsId++,
                ArabicName = "دينار كويتي",
                LatinName = "Kuwaiti Dinar",
                IsoCode = "KWD",
                ArabicSymbol = "د ك",
                LatinSymbol = "KD",
                CountryId = 15,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow,
                EntityStatus = EntityStatus.Active,
            });
            modelBuilder.Entity<Currency>().HasData(new Currency()
            {
                Id = crnsId++,
                ArabicName = "ليرة لبنانية",
                LatinName = "Lebanese Pound",
                IsoCode = "LBP",
                ArabicSymbol = "ل ل",
                LatinSymbol = "LL",
                CountryId = 16,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow,
                EntityStatus = EntityStatus.Active,
            });
            modelBuilder.Entity<Currency>().HasData(new Currency()
            {
                Id = crnsId++,
                LatinName = "Lesotho Loti",
                IsoCode = "LSL",
                LatinSymbol = "LSL",
                CountryId = 17,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow,
                EntityStatus = EntityStatus.Active,
            });
            modelBuilder.Entity<Currency>().HasData(new Currency()
            {
                Id = crnsId++,
                LatinName = "Liberian Dollar",
                IsoCode = "LRD",
                LatinSymbol = "LRD",
                CountryId = 18,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow,
                EntityStatus = EntityStatus.Active,
            });
            modelBuilder.Entity<Currency>().HasData(new Currency()
            {
                Id = crnsId++,
                ArabicName = "دينار ليبي",
                LatinName = "Libyan Dinar",
                IsoCode = "LYD",
                ArabicSymbol = "د ل",
                LatinSymbol = "LD",
                CountryId = 19,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow,
                EntityStatus = EntityStatus.Active,
            });
            modelBuilder.Entity<Currency>().HasData(new Currency()
            {
                Id = crnsId++,
                LatinName = "Malawian Kwacha",
                IsoCode = "MWK",
                LatinSymbol = "MWK",
                CountryId = 20,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow,
                EntityStatus = EntityStatus.Active,
            });
            modelBuilder.Entity<Currency>().HasData(new Currency()
            {
                Id = crnsId++,
                ArabicName = "أوقية موريتانية",
                LatinName = "Mauritanian Ouguiya",
                IsoCode = "MRU",
                ArabicSymbol = "أ م",
                LatinSymbol = "UM",
                CountryId = 21,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow,
                EntityStatus = EntityStatus.Active,
            });
            modelBuilder.Entity<Currency>().HasData(new Currency()
            {
                Id = crnsId++,
                LatinName = "Mauritian Rupee",
                IsoCode = "MUR",
                LatinSymbol = "MUR",
                CountryId = 22,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow,
                EntityStatus = EntityStatus.Active,
            });
            modelBuilder.Entity<Currency>().HasData(new Currency()
            {
                Id = crnsId++,
                ArabicName = "درهم مغربي",
                LatinName = "Moroccan Dirham",
                IsoCode = "MAD",
                ArabicSymbol = "د م",
                LatinSymbol = "DH",
                CountryId = 23,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow,
                EntityStatus = EntityStatus.Active,
            });
            modelBuilder.Entity<Currency>().HasData(new Currency()
            {
                Id = crnsId++,
                LatinName = "Namibian Dollar",
                IsoCode = "NAD",
                LatinSymbol = "NAD",
                CountryId = 24,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow,
                EntityStatus = EntityStatus.Active,
            });
            modelBuilder.Entity<Currency>().HasData(new Currency()
            {
                Id = crnsId++,
                LatinName = "Nigerian Naira",
                IsoCode = "NGN",
                LatinSymbol = "NGN",
                CountryId = 25,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow,
                EntityStatus = EntityStatus.Active,
            });
            modelBuilder.Entity<Currency>().HasData(new Currency()
            {
                Id = crnsId++,
                ArabicName = "ريال عماني",
                LatinName = "Omani Rial",
                IsoCode = "OMR",
                ArabicSymbol = "ر ع",
                LatinSymbol = "RO",
                CountryId = 26,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow,
                EntityStatus = EntityStatus.Active,
            });
            modelBuilder.Entity<Currency>().HasData(new Currency()
            {
                Id = crnsId++,
                ArabicName = "ريال قطري",
                LatinName = "Qatari Rial",
                IsoCode = "QAR",
                ArabicSymbol = "ر ق",
                LatinSymbol = "QR",
                CountryId = 27,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow,
                EntityStatus = EntityStatus.Active,
            });
            modelBuilder.Entity<Currency>().HasData(new Currency()
            {
                Id = crnsId++,
                LatinName = "Rwandan Franc",
                IsoCode = "RWF",
                LatinSymbol = "RWF",
                CountryId = 28,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow,
                EntityStatus = EntityStatus.Active,
            });
            modelBuilder.Entity<Currency>().HasData(new Currency()
            {
                Id = crnsId++,
                ArabicName = "ريال سعودي",
                LatinName = "Saudi Rial",
                IsoCode = "SAR",
                ArabicSymbol = "ر س",
                LatinSymbol = "SAR",
                CountryId = 29,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow,
                EntityStatus = EntityStatus.Active,
            });
            modelBuilder.Entity<Currency>().HasData(new Currency()
            {
                Id = crnsId++,
                LatinName = "Seychellois Rupee",
                IsoCode = "SCR",
                LatinSymbol = "SCR",
                CountryId = 30,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow,
                EntityStatus = EntityStatus.Active,
            });
            modelBuilder.Entity<Currency>().HasData(new Currency()
            {
                Id = crnsId++,
                LatinName = "Sierra Leonean Leone",
                IsoCode = "SLL",
                LatinSymbol = "SLL",
                CountryId = 31,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow,
                EntityStatus = EntityStatus.Active,
            });
            modelBuilder.Entity<Currency>().HasData(new Currency()
            {
                Id = crnsId++,
                ArabicName = "شلن صومالي",
                LatinName = "Somali Shilling",
                IsoCode = "SOS",
                ArabicSymbol = "ش ص",
                LatinSymbol = "ShSo",
                CountryId = 32,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow,
                EntityStatus = EntityStatus.Active,
            });
            modelBuilder.Entity<Currency>().HasData(new Currency()
            {
                Id = crnsId++,
                LatinName = "South African Rand",
                IsoCode = "ZAR",
                LatinSymbol = "ZAR",
                CountryId = 33,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow,
                EntityStatus = EntityStatus.Active,
            });
            modelBuilder.Entity<Currency>().HasData(new Currency()
            {
                Id = crnsId++,
                LatinName = "South Sudanese Pound",
                IsoCode = "SSP",
                LatinSymbol = "SSP",
                CountryId = 34,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow,
                EntityStatus = EntityStatus.Active,
            });
            modelBuilder.Entity<Currency>().HasData(new Currency()
            {
                Id = crnsId++,
                ArabicName = "جنيه سوداني",
                LatinName = "Sudanese Pound",
                IsoCode = "SDG",
                ArabicSymbol = "ج س",
                LatinSymbol = "SD",
                CountryId = 35,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow,
                EntityStatus = EntityStatus.Active,
            });
            modelBuilder.Entity<Currency>().HasData(new Currency()
            {
                Id = crnsId++,
                LatinName = "Tanzanian Shilling",
                IsoCode = "TZS",
                LatinSymbol = "TZS",
                CountryId = 36,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow,
                EntityStatus = EntityStatus.Active,
            });
            modelBuilder.Entity<Currency>().HasData(new Currency()
            {
                Id = crnsId++,
                ArabicName = "دينار تونسي",
                LatinName = "Tunisian Dinar",
                IsoCode = "TND",
                ArabicSymbol = "د ت",
                LatinSymbol = "DT",
                CountryId = 37,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow,
                EntityStatus = EntityStatus.Active,
            });
            modelBuilder.Entity<Currency>().HasData(new Currency()
            {
                Id = crnsId++,
                LatinName = "Turkish Lira",
                IsoCode = "TRY",
                LatinSymbol = "TL",
                CountryId = 38,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow,
                EntityStatus = EntityStatus.Active,
            });
            modelBuilder.Entity<Currency>().HasData(new Currency()
            {
                Id = crnsId++,
                LatinName = "Ugandan Shilling",
                IsoCode = "UGX",
                LatinSymbol = "UG",
                CountryId = 39,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow,
                EntityStatus = EntityStatus.Active,
            });
            modelBuilder.Entity<Currency>().HasData(new Currency()
            {
                Id = crnsId++,
                ArabicName = "درهم إماراتي",
                LatinName = "Emirati Dirham",
                IsoCode = "AED",
                ArabicSymbol = "د إ",
                LatinSymbol = "AED",
                CountryId = 40,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow,
                EntityStatus = EntityStatus.Active,
            });
            modelBuilder.Entity<Currency>().HasData(new Currency()
            {
                Id = crnsId++,
                LatinName = "American Dollar",
                IsoCode = "USD",
                LatinSymbol = "US$",
                CountryId = 41,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow,
                EntityStatus = EntityStatus.Active,
            });
            modelBuilder.Entity<Currency>().HasData(new Currency()
            {
                Id = crnsId++,
                ArabicName = "ريال يمني",
                LatinName = "Yemeni Rial",
                IsoCode = "YER",
                ArabicSymbol = "ر ي",
                LatinSymbol = "YR",
                CountryId = 42,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow,
                EntityStatus = EntityStatus.Active,
            });
            modelBuilder.Entity<Currency>().HasData(new Currency()
            {
                Id = crnsId++,
                LatinName = "Zambian Kwacha",
                IsoCode = "ZMW",
                LatinSymbol = "ZMW",
                CountryId = 43,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow,
                EntityStatus = EntityStatus.Active,
            });
            modelBuilder.Entity<Currency>().HasData(new Currency()
            {
                Id = crnsId++,
                LatinName = "Zimbabwean Dollar",
                IsoCode = "ZWL",
                LatinSymbol = "ZWL",
                CountryId = 44,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow,
                EntityStatus = EntityStatus.Active,
            });




            var crnsRtId = 1;
            modelBuilder.Entity<CurrencyRate>().HasData(new CurrencyRate()
            {
                Id = crnsRtId++,
                CurrencyId = 1, //Algeria
                Rate = 140.718f,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow,
                EntityStatus = EntityStatus.Active,
            });
            modelBuilder.Entity<CurrencyRate>().HasData(new CurrencyRate()
            {
                Id = crnsRtId++,
                CurrencyId = 2,  //Bahrain
                Rate = 0.376f,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow,
                EntityStatus = EntityStatus.Active,
            });
            modelBuilder.Entity<CurrencyRate>().HasData(new CurrencyRate()
            {
                Id = crnsRtId++,
                CurrencyId = 3, //Botswana
                Rate = 12.926f,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow,
                EntityStatus = EntityStatus.Active,
            });
            modelBuilder.Entity<CurrencyRate>().HasData(new CurrencyRate()
            {
                Id = crnsRtId++,
                CurrencyId = 4, //Burundi
                Rate = 2059.601f,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow,
                EntityStatus = EntityStatus.Active,
            });
            modelBuilder.Entity<CurrencyRate>().HasData(new CurrencyRate()
            {
                Id = crnsRtId++,
                CurrencyId = 5, //Cameroon
                Rate = 646.289f,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow,
                EntityStatus = EntityStatus.Active,
            });
            modelBuilder.Entity<CurrencyRate>().HasData(new CurrencyRate()
            {
                Id = crnsRtId++,
                CurrencyId = 6,  //Egypt
                Rate = 19.339f,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow,
                EntityStatus = EntityStatus.Active,
            });
            modelBuilder.Entity<CurrencyRate>().HasData(new CurrencyRate()
            {
                Id = crnsRtId++,
                CurrencyId = 7, //Eritrea
                Rate = 15f,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow,
                EntityStatus = EntityStatus.Active,
            });
            modelBuilder.Entity<CurrencyRate>().HasData(new CurrencyRate()
            {
                Id = crnsRtId++,
                CurrencyId = 8, //Eswatini
                Rate = 17.019f,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow,
                EntityStatus = EntityStatus.Active,
            });
            modelBuilder.Entity<CurrencyRate>().HasData(new CurrencyRate()
            {
                Id = crnsRtId++,
                CurrencyId = 9, //Ethiopia
                Rate = 52.723f,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow,
                EntityStatus = EntityStatus.Active,
            });
            modelBuilder.Entity<CurrencyRate>().HasData(new CurrencyRate()
            {
                Id = crnsRtId++,
                CurrencyId = 10, //Gambia
                Rate = 54.543f,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow,
                EntityStatus = EntityStatus.Active,
            });
            modelBuilder.Entity<CurrencyRate>().HasData(new CurrencyRate()
            {
                Id = crnsRtId++,
                CurrencyId = 11, //Ghana
                Rate = 10.056f,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow,
                EntityStatus = EntityStatus.Active,
            });
            modelBuilder.Entity<CurrencyRate>().HasData(new CurrencyRate()
            {
                Id = crnsRtId++,
                CurrencyId = 12, //Iraq
                Rate = 1459.146f,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow,
                EntityStatus = EntityStatus.Active,
            });
            modelBuilder.Entity<CurrencyRate>().HasData(new CurrencyRate()
            {
                Id = crnsRtId++,
                CurrencyId = 13, //Jordan
                Rate = 0.709f,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow,
                EntityStatus = EntityStatus.Active,
            });
            modelBuilder.Entity<CurrencyRate>().HasData(new CurrencyRate()
            {
                Id = crnsRtId++,
                CurrencyId = 14, //Kenya
                Rate = 120.418f,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow,
                EntityStatus = EntityStatus.Active,
            });
            modelBuilder.Entity<CurrencyRate>().HasData(new CurrencyRate()
            {
                Id = crnsRtId++,
                CurrencyId = 15, //Kuwait
                Rate = 0.308f,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow,
                EntityStatus = EntityStatus.Active,
            });
            modelBuilder.Entity<CurrencyRate>().HasData(new CurrencyRate()
            {
                Id = crnsRtId++,
                CurrencyId = 16, //Lebanon
                Rate = 1507.5f,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow,
                EntityStatus = EntityStatus.Active,
            });
            modelBuilder.Entity<CurrencyRate>().HasData(new CurrencyRate()
            {
                Id = crnsRtId++,
                CurrencyId = 17, //Lesotho
                Rate = 17.005f,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow,
                EntityStatus = EntityStatus.Active,
            });
            modelBuilder.Entity<CurrencyRate>().HasData(new CurrencyRate()
            {
                Id = crnsRtId++,
                CurrencyId = 18, //Liberia
                Rate = 153.796f,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow,
                EntityStatus = EntityStatus.Active,
            });
            modelBuilder.Entity<CurrencyRate>().HasData(new CurrencyRate()
            {
                Id = crnsRtId++,
                CurrencyId = 19, //Libya
                Rate = 4.943f,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow,
                EntityStatus = EntityStatus.Active,
            });
            modelBuilder.Entity<CurrencyRate>().HasData(new CurrencyRate()
            {
                Id = crnsRtId++,
                CurrencyId = 20, //Malawi
                Rate = 1022.797f,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow,
                EntityStatus = EntityStatus.Active,
            });
            modelBuilder.Entity<CurrencyRate>().HasData(new CurrencyRate()
            {
                Id = crnsRtId++,
                CurrencyId = 21, //Mauritania
                Rate = 37.743f,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow,
                EntityStatus = EntityStatus.Active,
            });
            modelBuilder.Entity<CurrencyRate>().HasData(new CurrencyRate()
            {
                Id = crnsRtId++,
                CurrencyId = 22, //Mauritius
                Rate = 45.118f,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow,
                EntityStatus = EntityStatus.Active,
            });
            modelBuilder.Entity<CurrencyRate>().HasData(new CurrencyRate()
            {
                Id = crnsRtId++,
                CurrencyId = 23, //Morocco
                Rate = 10.663f,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow,
                EntityStatus = EntityStatus.Active,
            });
            modelBuilder.Entity<CurrencyRate>().HasData(new CurrencyRate()
            {
                Id = crnsRtId++,
                CurrencyId = 24, //Namibia
                Rate = 17.008f,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow,
                EntityStatus = EntityStatus.Active,
            });
            modelBuilder.Entity<CurrencyRate>().HasData(new CurrencyRate()
            {
                Id = crnsRtId++,
                CurrencyId = 25, //Nigeria
                Rate = 427.62f,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow,
                EntityStatus = EntityStatus.Active,
            });
            modelBuilder.Entity<CurrencyRate>().HasData(new CurrencyRate()
            {
                Id = crnsRtId++,
                CurrencyId = 26, //Oman
                Rate = 0.384f,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow,
                EntityStatus = EntityStatus.Active,
            });
            modelBuilder.Entity<CurrencyRate>().HasData(new CurrencyRate()
            {
                Id = crnsRtId++,
                CurrencyId = 27, //Qatar
                Rate = 3.64f,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow,
                EntityStatus = EntityStatus.Active,
            });
            modelBuilder.Entity<CurrencyRate>().HasData(new CurrencyRate()
            {
                Id = crnsRtId++,
                CurrencyId = 28, //Rwanda
                Rate = 1034.834f,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow,
                EntityStatus = EntityStatus.Active,
            });
            modelBuilder.Entity<CurrencyRate>().HasData(new CurrencyRate()
            {
                Id = crnsRtId++,
                CurrencyId = 29, //Saudi
                Rate = 3.75f,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow,
                EntityStatus = EntityStatus.Active,
            });
            modelBuilder.Entity<CurrencyRate>().HasData(new CurrencyRate()
            {
                Id = crnsRtId++,
                CurrencyId = 30, //Seychelles
                Rate = 12.969f,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow,
                EntityStatus = EntityStatus.Active,
            });
            modelBuilder.Entity<CurrencyRate>().HasData(new CurrencyRate()
            {
                Id = crnsRtId++,
                CurrencyId = 31, //Sierra Leone
                Rate = 14007.689f,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow,
                EntityStatus = EntityStatus.Active,
            });
            modelBuilder.Entity<CurrencyRate>().HasData(new CurrencyRate()
            {
                Id = crnsRtId++,
                CurrencyId = 32, //Somalia
                Rate = 567.907f,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow,
                EntityStatus = EntityStatus.Active,
            });
            modelBuilder.Entity<CurrencyRate>().HasData(new CurrencyRate()
            {
                Id = crnsRtId++,
                CurrencyId = 33, //South Africa
                Rate = 17.008f,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow,
                EntityStatus = EntityStatus.Active,
            });
            modelBuilder.Entity<CurrencyRate>().HasData(new CurrencyRate()
            {
                Id = crnsRtId++,
                CurrencyId = 34, //South Sudan
                Rate = 130.26f,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow,
                EntityStatus = EntityStatus.Active,
            });
            modelBuilder.Entity<CurrencyRate>().HasData(new CurrencyRate()
            {
                Id = crnsRtId++,
                CurrencyId = 35, //Sudan
                Rate = 574.892f,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow,
                EntityStatus = EntityStatus.Active,
            });
            modelBuilder.Entity<CurrencyRate>().HasData(new CurrencyRate()
            {
                Id = crnsRtId++,
                CurrencyId = 36, //Tanzania
                Rate = 2332.081f,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow,
                EntityStatus = EntityStatus.Active,
            });
            modelBuilder.Entity<CurrencyRate>().HasData(new CurrencyRate()
            {
                Id = crnsRtId++,
                CurrencyId = 37, //Tunisia
                Rate = 3.183f,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow,
                EntityStatus = EntityStatus.Active,
            });
            modelBuilder.Entity<CurrencyRate>().HasData(new CurrencyRate()
            {
                Id = crnsRtId++,
                CurrencyId = 38, //Turkey
                Rate = 18.244f,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow,
                EntityStatus = EntityStatus.Active,
            });
            modelBuilder.Entity<CurrencyRate>().HasData(new CurrencyRate()
            {
                Id = crnsRtId++,
                CurrencyId = 39, //Uganda
                Rate = 3804.585f,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow,
                EntityStatus = EntityStatus.Active,
            });
            modelBuilder.Entity<CurrencyRate>().HasData(new CurrencyRate()
            {
                Id = crnsRtId++,
                CurrencyId = 40, //Emirates
                Rate = 3.673f,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow,
                EntityStatus = EntityStatus.Active,
            });
            modelBuilder.Entity<CurrencyRate>().HasData(new CurrencyRate()
            {
                Id = crnsRtId++,
                CurrencyId = 41, //USA
                Rate = 1,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow,
                EntityStatus = EntityStatus.Active,
            });
            modelBuilder.Entity<CurrencyRate>().HasData(new CurrencyRate()
            {
                Id = crnsRtId++,
                CurrencyId = 42, //Yemen
                Rate = 250.296f,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow,
                EntityStatus = EntityStatus.Active,
            });
            modelBuilder.Entity<CurrencyRate>().HasData(new CurrencyRate()
            {
                Id = crnsRtId++,
                CurrencyId = 43, //Zambia
                Rate = 15528.397f,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow,
                EntityStatus = EntityStatus.Active,
            });
            modelBuilder.Entity<CurrencyRate>().HasData(new CurrencyRate()
            {
                Id = crnsRtId++,
                CurrencyId = 44, //Zimbabwe
                Rate = 361.9f,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow,
                EntityStatus = EntityStatus.Active,
            });
        }
    }
}
