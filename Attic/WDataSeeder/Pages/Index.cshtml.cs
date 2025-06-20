using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using OneDotLearnCore;
using OneDotLearnCore.Essential;
using OneDotLearnCore.Financials;
using OneDotLearnCore.People;
using OneDotLearnCore.Security;
using OneDotLearnCore.Training;
using OneDotLearnData;
using OneDotLearnData.EntitiesRepositories;
using System.Reflection.Emit;
using WDataSeeder.Helpers;

namespace WDataSeeder.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private IRepositoryWrapper _repos;
        private OdlDataContext _dbCtx;

        public IndexModel(ILogger<IndexModel> logger, OdlDataContext dbCtx)//, IRepositoryWrapper repoWrap)
        {
            _logger = logger; _dbCtx = dbCtx; //_repos = repoWrap;
        }

        public async Task OnGetAsync()
        {
            try
            {
                //await SeedUser();

                //await SeedCountries();

                //await SeedCurrencies();

                //await SeedTrDomains();

                SeedCourses();

                await Task.Run(() => { });
            }
            catch (Exception)
            {

                throw;
            }
        }

        private async Task SeedUser()
        {
            try
            {
                var rslt = await _dbCtx.Users.AddAsync(new User()
                {
                    Id = 1,
                    LoginName = "waleed",
                    Role = UserRole.Administrator,
                    HashedPassword = //AbcXyz123
                        "AQAAAAEAACcQAAAAEB7ffPQnqFbXVy+4P04pYpylmm/CBKDPYoz+w44iqxiU0NWT19PAs4HNCEP735iDcg==",
                    //LastSignedInAt = new DateTime(1, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                    EntityStatus = EntityStatus.Active,
                    CreatedById = 1,
                    CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff")
                });

                await _dbCtx.UsersProfiles.AddAsync(new UserProfile()
                {
                    Id = 1,
                    UserId = 1,
                    FullName = "Waleed AlGhadamsy",
                    ProgExperience = ExperienceLevel.Guru,
                    ProgLanguages = ProgrammingLanguages.C | ProgrammingLanguages.CPP
                                | ProgrammingLanguages.CSh | ProgrammingLanguages.Fortran
                                | ProgrammingLanguages.Java | ProgrammingLanguages.JavaScript
                                | ProgrammingLanguages.PHP | ProgrammingLanguages.Python
                                | ProgrammingLanguages.Delphi,
                    RdbmsLevel = ExperienceLevel.Guru,
                    SWDevTechnologies = SWDevTechnologies.ASPNET | SWDevTechnologies.CSS
                    | SWDevTechnologies.EntFrmk
                    | SWDevTechnologies.Flutter | SWDevTechnologies.gRPC | SWDevTechnologies.HTML
                    | SWDevTechnologies.jQuery | SWDevTechnologies.JSP | SWDevTechnologies.REST
                    | SWDevTechnologies.WebAPI | SWDevTechnologies.WinForms | SWDevTechnologies.WPF
                    | SWDevTechnologies.Xamarin | SWDevTechnologies.XAML | SWDevTechnologies.XML
                    | SWDevTechnologies.ASPNETCore | SWDevTechnologies.SOAP | SWDevTechnologies.LINQ,
                    CreatedById = 1,
                    EntityStatus = EntityStatus.Active,
                    CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff")
                });

                await _dbCtx.Instructors.AddAsync(new Instructor()
                {
                    Id = 1,
                    ArFirstName = "وليد",
                    ArFatherName = "ناصر",
                    ArFamilyName = "الغدامسي",
                    LtnFirstName = "Waleed",
                    LtnFatherName = "Nasser",
                    LtnFamilyName = "AlGhadamsy",
                    Gender = Gender.Male,
                    BirthDate = new DateOnly(1962, 12, 10),
                    NationalityId = 9,
                    ResidenceCountryId = 38,
                    EducationLevel = EducationLevel.BSc,
                    AcademicSpecialization = "Nuclear Engineering",
                    FinancialAccountId = 40,
                    UserId = 1,
                    EntityStatus = EntityStatus.Active,
                    CreatedById = 1,
                    CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff")
                });

                await _dbCtx.Experiences.AddRangeAsync(
                    new List<WorkExperience>()
                    {
                        new WorkExperience()
                        {
                            Id = 1,
                            EmployeeId = 1,
                            Achievement = "In addition to nucl. eng., studied computer engineering in university",
                            FromDate = new DateTime(1982, 10, 1, 0, 0, 0, DateTimeKind.Utc),
                            ToDate = new DateTime(1984, 6, 30, 0, 0, 0, DateTimeKind.Utc),
                            EntityStatus = EntityStatus.Active,
                            CreatedById = 1,
                            CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff")
                        },
                        new WorkExperience()
                        {
                            Id = 2,
                            EmployeeId = 1,
                            Achievement = "More than thirty years experience in software engineering with many prog. languages",
                            FromDate = new DateTime(1990, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                            ToDate = new DateTime(2020, 12, 31, 0, 0, 0, DateTimeKind.Utc),
                            EntityStatus = EntityStatus.Active,
                            CreatedById = 1,
                            CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff")
                        },
                        new WorkExperience()
                        {
                            Id = 3,
                            EmployeeId = 1,
                            Achievement = "Software team leader in Microsoft for a few years",
                            FromDate = new DateTime(2009, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                            ToDate = new DateTime(2011, 12, 31, 0, 0, 0, DateTimeKind.Utc),
                            EntityStatus = EntityStatus.Active,
                            CreatedById = 1,
                            CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff")
                        },
                        new WorkExperience()
                        {
                            Id = 4,
                            EmployeeId = 1,
                            Achievement = "Former instructors manager in YAT, the largest Egyptian training company",
                            FromDate = new DateTime(2004, 3, 1, 0, 0, 0, DateTimeKind.Utc),
                            ToDate = new DateTime(2008, 12, 31, 0, 0, 0, DateTimeKind.Utc),
                            EntityStatus = EntityStatus.Active,
                            CreatedById = 1,
                            CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff")
                        },
                        new WorkExperience()
                        {
                            Id = 5,
                            EmployeeId = 1,
                            Achievement = "Chief executive officer (CEO) in several workplaces",
                            FromDate = new DateTime(2016, 6, 1, 0, 0, 0, DateTimeKind.Utc),
                            ToDate = new DateTime(2019, 5, 31, 0, 0, 0, DateTimeKind.Utc),
                            EntityStatus = EntityStatus.Active,
                            CreatedById = 1,
                            CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff")
                        },
                        new WorkExperience()
                        {
                            Id = 6,
                            EmployeeId = 1,
                            Achievement = "Accomplished several huge SW systems (incl. the SW system of the Libyan Civil Registry)",
                            FromDate = new DateTime(2009, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                            ToDate = new DateTime(2017, 2, 28, 0, 0, 0, DateTimeKind.Utc),
                            EntityStatus = EntityStatus.Active,
                            CreatedById = 1,
                            CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff")
                        },
                        new WorkExperience()
                        {
                            Id = 7,
                            EmployeeId = 1,
                            Achievement = "Delivered many advanced training courses to hundreds of trainees in several IT fields",
                            FromDate = new DateTime(2002, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                            ToDate = new DateTime(2008, 12, 31, 0, 0, 0, DateTimeKind.Utc),
                            EntityStatus = EntityStatus.Active,
                            CreatedById = 1,
                            CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff")
                        },
                        new WorkExperience()
                        {
                            Id = 8,
                            EmployeeId = 1,
                            Achievement = "Published several scientific papers in the field of computer simulation of nuclear reactors",
                            FromDate = new DateTime(1990, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                            ToDate = new DateTime(1991, 10, 31, 0, 0, 0, DateTimeKind.Utc),
                            EntityStatus = EntityStatus.Active,
                            CreatedById = 1,
                            CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff")
                        }
                    });

                await _dbCtx.SaveChangesAsync();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private async Task SeedCountries()
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

                await _dbCtx.AddRangeAsync(cntrs);

                await _dbCtx.SaveChangesAsync();
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private async Task SeedCurrencies()
        {
            try
            {
                var crnsId = 1;

                var crns = new List<Currency>()
                {
                    new Currency()
                    {
                        Id = crnsId++,
                        ArabicName = "دينار جزائري",
                        LatinName = "Algerian Dinar",
                        IsoCode = "DZD",
                        ArabicSymbol = "د ج",
                        LatinSymbol = "DA",
                        CountryId = 1,
                        CreatedById = 1,
                        CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                        EntityStatus = EntityStatus.Active,
                    },
                    new Currency()
                    {
                        Id = crnsId++,
                        ArabicName = "دينار بحريني",
                        LatinName = "Bahraini Dinar",
                        IsoCode = "BHD",
                        ArabicSymbol = "د ب",
                        LatinSymbol = "BD",
                        CountryId = 2,
                        CreatedById = 1,
                        CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                        EntityStatus = EntityStatus.Active,
                    },
                    new Currency()
                    {
                        Id = crnsId++,
                        LatinName = "Botswana Pula",
                        IsoCode = "BWP",
                        LatinSymbol = "BWP",
                        CountryId = 3,
                        CreatedById = 1,
                        CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                        EntityStatus = EntityStatus.Active,
                    },
                    new Currency()
                    {
                        Id = crnsId++,
                        LatinName = "Burundi Franc",
                        IsoCode = "BIF",
                        LatinSymbol = "BIF",
                        CountryId = 4,
                        CreatedById = 1,
                        CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                        EntityStatus = EntityStatus.Active,
                    },
                    new Currency()
                    {
                        Id = crnsId++,
                        LatinName = "Central African CFA Franc",
                        IsoCode = "XAF",
                        LatinSymbol = "XAF",
                        CountryId = 5,
                        CreatedById = 1,
                        CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                        EntityStatus = EntityStatus.Active,
                    },
                    new Currency()
                    {
                        Id = crnsId++,
                        ArabicName = "جنيه مصري",
                        LatinName = "Egyptian Pound",
                        IsoCode = "EGP",
                        ArabicSymbol = "ج م",
                        LatinSymbol = "LE",
                        CountryId = 6,
                        CreatedById = 1,
                        CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                        EntityStatus = EntityStatus.Active,
                    },
                    new Currency()
                    {
                        Id = crnsId++,
                        ArabicName = "نقفة إريتري",
                        LatinName = "Eritrean Nakfa",
                        IsoCode = "ERN",
                        ArabicSymbol = "ن ر",
                        LatinSymbol = "ERN",
                        CountryId = 7,
                        CreatedById = 1,
                        CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                        EntityStatus = EntityStatus.Active,
                    },
                    new Currency()
                    {
                        Id = crnsId++,
                        LatinName = "Swazi Lilangeni",
                        IsoCode = "SZL",
                        LatinSymbol = "SZL",
                        CountryId = 8,
                        CreatedById = 1,
                        CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                        EntityStatus = EntityStatus.Active,
                    },
                    new Currency()
                    {
                        Id = crnsId++,
                        LatinName = "Ethiopian Birr",
                        IsoCode = "ETB",
                        LatinSymbol = "ETB",
                        CountryId = 9,
                        CreatedById = 1,
                        CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                        EntityStatus = EntityStatus.Active,
                    },
                    new Currency()
                    {
                        Id = crnsId++,
                        LatinName = "Gambian Dalasi",
                        IsoCode = "GMD",
                        LatinSymbol = "GMD",
                        CountryId = 10,
                        CreatedById = 1,
                        CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                        EntityStatus = EntityStatus.Active,
                    },
                    new Currency()
                    {
                        Id = crnsId++,
                        LatinName = "Ghanaian Cedi",
                        IsoCode = "GHS",
                        LatinSymbol = "GHS",
                        CountryId = 11,
                        CreatedById = 1,
                        CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                        EntityStatus = EntityStatus.Active,
                    },
                    new Currency()
                    {
                        Id = crnsId++,
                        ArabicName = "دينار عراقي",
                        LatinName = "Iraqi Dinar",
                        IsoCode = "IQD",
                        ArabicSymbol = "د ع",
                        LatinSymbol = "ID",
                        CountryId = 12,
                        CreatedById = 1,
                        CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                        EntityStatus = EntityStatus.Active,
                    },
                    new Currency()
                    {
                        Id = crnsId++,
                        ArabicName = "دينار أردني",
                        LatinName = "Jordanian Dinar",
                        IsoCode = "JOD",
                        ArabicSymbol = "د أ",
                        LatinSymbol = "JD",
                        CountryId = 13,
                        CreatedById = 1,
                        CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                        EntityStatus = EntityStatus.Active,
                    },
                    new Currency()
                    {
                        Id = crnsId++,
                        LatinName = "Kenyan Shilling",
                        IsoCode = "KES",
                        LatinSymbol = "KES",
                        CountryId = 14,
                        CreatedById = 1,
                        CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                        EntityStatus = EntityStatus.Active,
                    },
                    new Currency()
                    {
                        Id = crnsId++,
                        ArabicName = "دينار كويتي",
                        LatinName = "Kuwaiti Dinar",
                        IsoCode = "KWD",
                        ArabicSymbol = "د ك",
                        LatinSymbol = "KD",
                        CountryId = 15,
                        CreatedById = 1,
                        CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                        EntityStatus = EntityStatus.Active,
                    },
                    new Currency()
                    {
                        Id = crnsId++,
                        ArabicName = "ليرة لبنانية",
                        LatinName = "Lebanese Pound",
                        IsoCode = "LBP",
                        ArabicSymbol = "ل ل",
                        LatinSymbol = "LL",
                        CountryId = 16,
                        CreatedById = 1,
                        CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                        EntityStatus = EntityStatus.Active,
                    },
                    new Currency()
                    {
                        Id = crnsId++,
                        LatinName = "Lesotho Loti",
                        IsoCode = "LSL",
                        LatinSymbol = "LSL",
                        CountryId = 17,
                        CreatedById = 1,
                        CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                        EntityStatus = EntityStatus.Active,
                    },
                    new Currency()
                    {
                        Id = crnsId++,
                        LatinName = "Liberian Dollar",
                        IsoCode = "LRD",
                        LatinSymbol = "LRD",
                        CountryId = 18,
                        CreatedById = 1,
                        CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                        EntityStatus = EntityStatus.Active,
                    },
                    new Currency()
                    {
                        Id = crnsId++,
                        ArabicName = "دينار ليبي",
                        LatinName = "Libyan Dinar",
                        IsoCode = "LYD",
                        ArabicSymbol = "د ل",
                        LatinSymbol = "LD",
                        CountryId = 19,
                        CreatedById = 1,
                        CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                        EntityStatus = EntityStatus.Active,
                    },
                    new Currency()
                    {
                        Id = crnsId++,
                        LatinName = "Malawian Kwacha",
                        IsoCode = "MWK",
                        LatinSymbol = "MWK",
                        CountryId = 20,
                        CreatedById = 1,
                        CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                        EntityStatus = EntityStatus.Active,
                    },
                    new Currency()
                    {
                        Id = crnsId++,
                        ArabicName = "أوقية موريتانية",
                        LatinName = "Mauritanian Ouguiya",
                        IsoCode = "MRU",
                        ArabicSymbol = "أ م",
                        LatinSymbol = "UM",
                        CountryId = 21,
                        CreatedById = 1,
                        CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                        EntityStatus = EntityStatus.Active,
                    },
                    new Currency()
                    {
                        Id = crnsId++,
                        LatinName = "Mauritian Rupee",
                        IsoCode = "MUR",
                        LatinSymbol = "MUR",
                        CountryId = 22,
                        CreatedById = 1,
                        CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                        EntityStatus = EntityStatus.Active,
                    },
                    new Currency()
                    {
                        Id = crnsId++,
                        ArabicName = "درهم مغربي",
                        LatinName = "Moroccan Dirham",
                        IsoCode = "MAD",
                        ArabicSymbol = "د م",
                        LatinSymbol = "DH",
                        CountryId = 23,
                        CreatedById = 1,
                        CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                        EntityStatus = EntityStatus.Active,
                    },
                    new Currency()
                    {
                        Id = crnsId++,
                        LatinName = "Namibian Dollar",
                        IsoCode = "NAD",
                        LatinSymbol = "NAD",
                        CountryId = 24,
                        CreatedById = 1,
                        CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                        EntityStatus = EntityStatus.Active,
                    },
                    new Currency()
                    {
                        Id = crnsId++,
                        LatinName = "Nigerian Naira",
                        IsoCode = "NGN",
                        LatinSymbol = "NGN",
                        CountryId = 25,
                        CreatedById = 1,
                        CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                        EntityStatus = EntityStatus.Active,
                    },
                    new Currency()
                    {
                        Id = crnsId++,
                        ArabicName = "ريال عماني",
                        LatinName = "Omani Rial",
                        IsoCode = "OMR",
                        ArabicSymbol = "ر ع",
                        LatinSymbol = "RO",
                        CountryId = 26,
                        CreatedById = 1,
                        CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                        EntityStatus = EntityStatus.Active,
                    },
                    new Currency()
                    {
                        Id = crnsId++,
                        ArabicName = "ريال قطري",
                        LatinName = "Qatari Rial",
                        IsoCode = "QAR",
                        ArabicSymbol = "ر ق",
                        LatinSymbol = "QR",
                        CountryId = 27,
                        CreatedById = 1,
                        CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                        EntityStatus = EntityStatus.Active,
                    },
                    new Currency()
                    {
                        Id = crnsId++,
                        LatinName = "Rwandan Franc",
                        IsoCode = "RWF",
                        LatinSymbol = "RWF",
                        CountryId = 28,
                        CreatedById = 1,
                        CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                        EntityStatus = EntityStatus.Active,
                    },
                    new Currency()
                    {
                        Id = crnsId++,
                        ArabicName = "ريال سعودي",
                        LatinName = "Saudi Rial",
                        IsoCode = "SAR",
                        ArabicSymbol = "ر س",
                        LatinSymbol = "SAR",
                        CountryId = 29,
                        CreatedById = 1,
                        CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                        EntityStatus = EntityStatus.Active,
                    },
                    new Currency()
                    {
                        Id = crnsId++,
                        LatinName = "Seychellois Rupee",
                        IsoCode = "SCR",
                        LatinSymbol = "SCR",
                        CountryId = 30,
                        CreatedById = 1,
                        CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                        EntityStatus = EntityStatus.Active,
                    },
                    new Currency()
                    {
                        Id = crnsId++,
                        LatinName = "Sierra Leonean Leone",
                        IsoCode = "SLL",
                        LatinSymbol = "SLL",
                        CountryId = 31,
                        CreatedById = 1,
                        CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                        EntityStatus = EntityStatus.Active,
                    },
                    new Currency()
                    {
                        Id = crnsId++,
                        ArabicName = "شلن صومالي",
                        LatinName = "Somali Shilling",
                        IsoCode = "SOS",
                        ArabicSymbol = "ش ص",
                        LatinSymbol = "ShSo",
                        CountryId = 32,
                        CreatedById = 1,
                        CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                        EntityStatus = EntityStatus.Active,
                    },
                    new Currency()
                    {
                        Id = crnsId++,
                        LatinName = "South African Rand",
                        IsoCode = "ZAR",
                        LatinSymbol = "ZAR",
                        CountryId = 33,
                        CreatedById = 1,
                        CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                        EntityStatus = EntityStatus.Active,
                    },
                    new Currency()
                    {
                        Id = crnsId++,
                        LatinName = "South Sudanese Pound",
                        IsoCode = "SSP",
                        LatinSymbol = "SSP",
                        CountryId = 34,
                        CreatedById = 1,
                        CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                        EntityStatus = EntityStatus.Active,
                    },
                    new Currency()
                    {
                        Id = crnsId++,
                        ArabicName = "جنيه سوداني",
                        LatinName = "Sudanese Pound",
                        IsoCode = "SDG",
                        ArabicSymbol = "ج س",
                        LatinSymbol = "SD",
                        CountryId = 35,
                        CreatedById = 1,
                        CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                        EntityStatus = EntityStatus.Active,
                    },
                    new Currency()
                    {
                        Id = crnsId++,
                        LatinName = "Tanzanian Shilling",
                        IsoCode = "TZS",
                        LatinSymbol = "TZS",
                        CountryId = 36,
                        CreatedById = 1,
                        CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                        EntityStatus = EntityStatus.Active,
                    },
                    new Currency()
                    {
                        Id = crnsId++,
                        ArabicName = "دينار تونسي",
                        LatinName = "Tunisian Dinar",
                        IsoCode = "TND",
                        ArabicSymbol = "د ت",
                        LatinSymbol = "DT",
                        CountryId = 37,
                        CreatedById = 1,
                        CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                        EntityStatus = EntityStatus.Active,
                    },
                    new Currency()
                    {
                        Id = crnsId++,
                        LatinName = "Turkish Lira",
                        IsoCode = "TRY",
                        LatinSymbol = "TL",
                        CountryId = 38,
                        CreatedById = 1,
                        CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                        EntityStatus = EntityStatus.Active,
                    },
                    new Currency()
                    {
                        Id = crnsId++,
                        LatinName = "Ugandan Shilling",
                        IsoCode = "UGX",
                        LatinSymbol = "UG",
                        CountryId = 39,
                        CreatedById = 1,
                        CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                        EntityStatus = EntityStatus.Active,
                    },
                    new Currency()
                    {
                        Id = crnsId++,
                        ArabicName = "درهم إماراتي",
                        LatinName = "Emirati Dirham",
                        IsoCode = "AED",
                        ArabicSymbol = "د إ",
                        LatinSymbol = "AED",
                        CountryId = 40,
                        CreatedById = 1,
                        CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                        EntityStatus = EntityStatus.Active,
                    },
                    new Currency()
                    {
                        Id = crnsId++,
                        LatinName = "American Dollar",
                        IsoCode = "USD",
                        LatinSymbol = "US$",
                        CountryId = 41,
                        CreatedById = 1,
                        CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                        EntityStatus = EntityStatus.Active,
                    },
                    new Currency()
                    {
                        Id = crnsId++,
                        ArabicName = "ريال يمني",
                        LatinName = "Yemeni Rial",
                        IsoCode = "YER",
                        ArabicSymbol = "ر ي",
                        LatinSymbol = "YR",
                        CountryId = 42,
                        CreatedById = 1,
                        CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                        EntityStatus = EntityStatus.Active,
                    },
                    new Currency()
                    {
                        Id = crnsId++,
                        LatinName = "Zambian Kwacha",
                        IsoCode = "ZMW",
                        LatinSymbol = "ZMW",
                        CountryId = 43,
                        CreatedById = 1,
                        CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                        EntityStatus = EntityStatus.Active,
                    },
                    new Currency()
                    {
                        Id = crnsId++,
                        LatinName = "Zimbabwean Dollar",
                        IsoCode = "ZWL",
                        LatinSymbol = "ZWL",
                        CountryId = 44,
                        CreatedById = 1,
                        CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                        EntityStatus = EntityStatus.Active,
                    }
                };

                await _dbCtx.AddRangeAsync(crns);

                await _dbCtx.SaveChangesAsync();


                var crnsRtId = 1;
                
                var crnsRts = new List<CurrencyRate>()
                {
                new CurrencyRate()
                {
                    Id = crnsRtId++,
                    CurrencyId = 1, //Algeria
                    Rate = 140.718f,
                    CreatedById = 1,
                    CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                    EntityStatus = EntityStatus.Active,
                },
                new CurrencyRate()
                {
                    Id = crnsRtId++,
                    CurrencyId = 2,  //Bahrain
                    Rate = 0.376f,
                    CreatedById = 1,
                    CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                    EntityStatus = EntityStatus.Active,
                },
                new CurrencyRate()
                {
                    Id = crnsRtId++,
                    CurrencyId = 3, //Botswana
                    Rate = 12.926f,
                    CreatedById = 1,
                    CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                    EntityStatus = EntityStatus.Active,
                },
                new CurrencyRate()
                {
                    Id = crnsRtId++,
                    CurrencyId = 4, //Burundi
                    Rate = 2059.601f,
                    CreatedById = 1,
                    CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                    EntityStatus = EntityStatus.Active,
                },
                new CurrencyRate()
                {
                    Id = crnsRtId++,
                    CurrencyId = 5, //Cameroon
                    Rate = 646.289f,
                    CreatedById = 1,
                    CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                    EntityStatus = EntityStatus.Active,
                },
                new CurrencyRate()
                {
                    Id = crnsRtId++,
                    CurrencyId = 6,  //Egypt
                    Rate = 19.339f,
                    CreatedById = 1,
                    CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                    EntityStatus = EntityStatus.Active,
                },
                new CurrencyRate()
                {
                    Id = crnsRtId++,
                    CurrencyId = 7, //Eritrea
                    Rate = 15f,
                    CreatedById = 1,
                    CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                    EntityStatus = EntityStatus.Active,
                },
                new CurrencyRate()
                {
                    Id = crnsRtId++,
                    CurrencyId = 8, //Eswatini
                    Rate = 17.019f,
                    CreatedById = 1,
                    CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                    EntityStatus = EntityStatus.Active,
                },
                new CurrencyRate()
                {
                    Id = crnsRtId++,
                    CurrencyId = 9, //Ethiopia
                    Rate = 52.723f,
                    CreatedById = 1,
                    CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                    EntityStatus = EntityStatus.Active,
                },
                new CurrencyRate()
                {
                    Id = crnsRtId++,
                    CurrencyId = 10, //Gambia
                    Rate = 54.543f,
                    CreatedById = 1,
                    CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                    EntityStatus = EntityStatus.Active,
                },
                new CurrencyRate()
                {
                    Id = crnsRtId++,
                    CurrencyId = 11, //Ghana
                    Rate = 10.056f,
                    CreatedById = 1,
                    CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                    EntityStatus = EntityStatus.Active,
                },
                new CurrencyRate()
                {
                    Id = crnsRtId++,
                    CurrencyId = 12, //Iraq
                    Rate = 1459.146f,
                    CreatedById = 1,
                    CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                    EntityStatus = EntityStatus.Active,
                },
                new CurrencyRate()
                {
                    Id = crnsRtId++,
                    CurrencyId = 13, //Jordan
                    Rate = 0.709f,
                    CreatedById = 1,
                    CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                    EntityStatus = EntityStatus.Active,
                },
                new CurrencyRate()
                {
                    Id = crnsRtId++,
                    CurrencyId = 14, //Kenya
                    Rate = 120.418f,
                    CreatedById = 1,
                    CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                    EntityStatus = EntityStatus.Active,
                },
                new CurrencyRate()
                {
                    Id = crnsRtId++,
                    CurrencyId = 15, //Kuwait
                    Rate = 0.308f,
                    CreatedById = 1,
                    CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                    EntityStatus = EntityStatus.Active,
                },
                new CurrencyRate()
                {
                    Id = crnsRtId++,
                    CurrencyId = 16, //Lebanon
                    Rate = 1507.5f,
                    CreatedById = 1,
                    CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                    EntityStatus = EntityStatus.Active,
                },
                new CurrencyRate()
                {
                    Id = crnsRtId++,
                    CurrencyId = 17, //Lesotho
                    Rate = 17.005f,
                    CreatedById = 1,
                    CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                    EntityStatus = EntityStatus.Active,
                },
                new CurrencyRate()
                {
                    Id = crnsRtId++,
                    CurrencyId = 18, //Liberia
                    Rate = 153.796f,
                    CreatedById = 1,
                    CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                    EntityStatus = EntityStatus.Active,
                },
                new CurrencyRate()
                {
                    Id = crnsRtId++,
                    CurrencyId = 19, //Libya
                    Rate = 4.943f,
                    CreatedById = 1,
                    CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                    EntityStatus = EntityStatus.Active,
                },
                new CurrencyRate()
                {
                    Id = crnsRtId++,
                    CurrencyId = 20, //Malawi
                    Rate = 1022.797f,
                    CreatedById = 1,
                    CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                    EntityStatus = EntityStatus.Active,
                },
                new CurrencyRate()
                {
                    Id = crnsRtId++,
                    CurrencyId = 21, //Mauritania
                    Rate = 37.743f,
                    CreatedById = 1,
                    CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                    EntityStatus = EntityStatus.Active,
                },
                new CurrencyRate()
                {
                    Id = crnsRtId++,
                    CurrencyId = 22, //Mauritius
                    Rate = 45.118f,
                    CreatedById = 1,
                    CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                    EntityStatus = EntityStatus.Active,
                },
                new CurrencyRate()
                {
                    Id = crnsRtId++,
                    CurrencyId = 23, //Morocco
                    Rate = 10.663f,
                    CreatedById = 1,
                    CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                    EntityStatus = EntityStatus.Active,
                },
                new CurrencyRate()
                {
                    Id = crnsRtId++,
                    CurrencyId = 24, //Namibia
                    Rate = 17.008f,
                    CreatedById = 1,
                    CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                    EntityStatus = EntityStatus.Active,
                },
                new CurrencyRate()
                {
                    Id = crnsRtId++,
                    CurrencyId = 25, //Nigeria
                    Rate = 427.62f,
                    CreatedById = 1,
                    CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                    EntityStatus = EntityStatus.Active,
                },
                new CurrencyRate()
                {
                    Id = crnsRtId++,
                    CurrencyId = 26, //Oman
                    Rate = 0.384f,
                    CreatedById = 1,
                    CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                    EntityStatus = EntityStatus.Active,
                },
                new CurrencyRate()
                {
                    Id = crnsRtId++,
                    CurrencyId = 27, //Qatar
                    Rate = 3.64f,
                    CreatedById = 1,
                    CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                    EntityStatus = EntityStatus.Active,
                },
                new CurrencyRate()
                {
                    Id = crnsRtId++,
                    CurrencyId = 28, //Rwanda
                    Rate = 1034.834f,
                    CreatedById = 1,
                    CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                    EntityStatus = EntityStatus.Active,
                },
                new CurrencyRate()
                {
                    Id = crnsRtId++,
                    CurrencyId = 29, //Saudi
                    Rate = 3.75f,
                    CreatedById = 1,
                    CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                    EntityStatus = EntityStatus.Active,
                },
                new CurrencyRate()
                {
                    Id = crnsRtId++,
                    CurrencyId = 30, //Seychelles
                    Rate = 12.969f,
                    CreatedById = 1,
                    CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                    EntityStatus = EntityStatus.Active,
                },
                new CurrencyRate()
                {
                    Id = crnsRtId++,
                    CurrencyId = 31, //Sierra Leone
                    Rate = 14007.689f,
                    CreatedById = 1,
                    CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                    EntityStatus = EntityStatus.Active,
                },
                new CurrencyRate()
                {
                    Id = crnsRtId++,
                    CurrencyId = 32, //Somalia
                    Rate = 567.907f,
                    CreatedById = 1,
                    CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                    EntityStatus = EntityStatus.Active,
                },
                new CurrencyRate()
                {
                    Id = crnsRtId++,
                    CurrencyId = 33, //South Africa
                    Rate = 17.008f,
                    CreatedById = 1,
                    CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                    EntityStatus = EntityStatus.Active,
                },
                new CurrencyRate()
                {
                    Id = crnsRtId++,
                    CurrencyId = 34, //South Sudan
                    Rate = 130.26f,
                    CreatedById = 1,
                    CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                    EntityStatus = EntityStatus.Active,
                },
                new CurrencyRate()
                {
                    Id = crnsRtId++,
                    CurrencyId = 35, //Sudan
                    Rate = 574.892f,
                    CreatedById = 1,
                    CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                    EntityStatus = EntityStatus.Active,
                },
                new CurrencyRate()
                {
                    Id = crnsRtId++,
                    CurrencyId = 36, //Tanzania
                    Rate = 2332.081f,
                    CreatedById = 1,
                    CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                    EntityStatus = EntityStatus.Active,
                },
                new CurrencyRate()
                {
                    Id = crnsRtId++,
                    CurrencyId = 37, //Tunisia
                    Rate = 3.183f,
                    CreatedById = 1,
                    CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                    EntityStatus = EntityStatus.Active,
                },
                new CurrencyRate()
                {
                    Id = crnsRtId++,
                    CurrencyId = 38, //Turkey
                    Rate = 18.244f,
                    CreatedById = 1,
                    CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                    EntityStatus = EntityStatus.Active,
                },
                new CurrencyRate()
                {
                    Id = crnsRtId++,
                    CurrencyId = 39, //Uganda
                    Rate = 3804.585f,
                    CreatedById = 1,
                    CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                    EntityStatus = EntityStatus.Active,
                },
                new CurrencyRate()
                {
                    Id = crnsRtId++,
                    CurrencyId = 40, //Emirates
                    Rate = 3.673f,
                    CreatedById = 1,
                    CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                    EntityStatus = EntityStatus.Active,
                },
                new CurrencyRate()
                {
                    Id = crnsRtId++,
                    CurrencyId = 41, //USA
                    Rate = 1,
                    CreatedById = 1,
                    CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                    EntityStatus = EntityStatus.Active,
                },
                new CurrencyRate()
                {
                    Id = crnsRtId++,
                    CurrencyId = 42, //Yemen
                    Rate = 250.296f,
                    CreatedById = 1,
                    CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                    EntityStatus = EntityStatus.Active,
                },
                new CurrencyRate()
                {
                    Id = crnsRtId++,
                    CurrencyId = 43, //Zambia
                    Rate = 15528.397f,
                    CreatedById = 1,
                    CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                    EntityStatus = EntityStatus.Active,
                },
                new CurrencyRate()
                {
                    Id = crnsRtId++,
                    CurrencyId = 44, //Zimbabwe
                    Rate = 361.9f,
                    CreatedById = 1,
                    CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                    EntityStatus = EntityStatus.Active,
                }
                };

                await _dbCtx.AddRangeAsync(crnsRts);

                await _dbCtx.SaveChangesAsync();

            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private async Task SeedTrDomains()
        {
            try
            {
                int catId = 1;

                var categories = new List<ProductDomain>()
                {
                    new ()
                    {
                        Id = catId++,
                        ParentId = null,
                        Name = "Software Development",
                        SubDomains = new ()
                        {
                            new ()    //Id 2
                            {
                                Id = catId++,
                                ParentId = 1,
                                Name = "Desktop Applications",
                                CreatedById = 1,
                                CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                                EntityStatus = EntityStatus.Active,
                            },
                            new ()    //Id 3
                            {
                                Id = catId++,
                                ParentId = 1,
                                Name = "Web Applications",
                                CreatedById = 1,
                                CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                                EntityStatus = EntityStatus.Active,
                            },
                            new ()    //Id 4
                            {
                                Id = catId++,
                                ParentId = 1,
                                Name = "Mobile Applications",
                                CreatedById = 1,
                                CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                                EntityStatus = EntityStatus.Active,
                            },
                            new ()    //Id 5
                            {
                                Id = catId++,
                                ParentId = 1,
                                Name = "Games",
                                CreatedById = 1,
                                CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                                EntityStatus = EntityStatus.Active,
                            }
                        },
                        CreatedById = 1,
                        CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                        EntityStatus = EntityStatus.Active,
                    }, //Id 1
                    new ()
                    {
                        Id = catId++,
                        ParentId = null,
                        Name = "Web Design",
                        SubDomains = null,
                        CreatedById = 1,
                        CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                        EntityStatus = EntityStatus.Active,
                    }, //Id 6
                    new ()
                    {
                        Id = catId++,
                        ParentId = null,
                        Name = "Graphic Design",
                        SubDomains = null,
                        CreatedById = 1,
                        CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                        EntityStatus = EntityStatus.Active,
                    }, //Id 7
                    new ()
                    {
                        Id = catId++,
                        ParentId = null,
                        Name = "Database Management",
                        //SubDomains = new ()
                        //{
                            //new ()    //Id 9
                            //{
                            //    Id = catId++,
                            //    ParentId = 8,
                            //    Name = "Relational DB Management Systems",
                            //    SubDomains = new List<ProductDomain>()
                            //    {
                            //        new ()    //Id 10
                            //        {
                            //            Id = catId++,
                            //            ParentId = 9,
                            //            Name = "Oracle DB Server",
                            //            CreatedById = 1,
                            //            CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                            //            EntityStatus = EntityStatus.Active,
                            //        },
                            //        new ()    //Id 11
                            //        {
                            //            Id = catId++,
                            //            ParentId = 9,
                            //            Name = "Microsoft SQL Server",
                            //            CreatedById = 1,
                            //            CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                            //            EntityStatus = EntityStatus.Active,
                            //        }
                            //    },
                            //    CreatedById = 1,
                            //    CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                            //    EntityStatus = EntityStatus.Active,
                            //},
                            //new ()    //Id 12
                            //{
                            //    Id = catId++,
                            //    ParentId = 8,
                            //    Name = "Non-Relational DB Management Systems",
                            //    SubDomains = new List<ProductDomain>()
                            //    {
                            //        //new ()    //Id 13
                            //        //{
                            //        //    Id = catId++,
                            //        //    ParentId = 12,
                            //        //    Name = "Document Data Store",
                            //        //    SubDomains = new List<ProductDomain>()
                            //        //    {
                            //        //        new ()    //Id 14
                            //        //        {
                            //        //            Id = catId++,
                            //        //            ParentId = 13,
                            //        //            Name = "Apache CouchDB",
                            //        //            CreatedById = 1,
                            //        //            CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                            //        //            EntityStatus = EntityStatus.Active,
                            //        //        },
                            //        //        new ()    //Id 15
                            //        //        {
                            //        //            Id = catId++,
                            //        //            ParentId = 13,
                            //        //            Name = "Amazon DocumentDB",
                            //        //            CreatedById = 1,
                            //        //            CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                            //        //            EntityStatus = EntityStatus.Active,
                            //        //        },
                            //        //        new ()    //Id 16
                            //        //        {
                            //        //            Id = catId++,
                            //        //            ParentId = 13,
                            //        //            Name = "Microsoft Cosmos DB",
                            //        //            CreatedById = 1,
                            //        //            CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                            //        //            EntityStatus = EntityStatus.Active,
                            //        //        },
                            //        //        new ()    //Id 17
                            //        //        {
                            //        //            Id = catId++,
                            //        //            ParentId = 13,
                            //        //            Name = "MongoDB",
                            //        //            CreatedById = 1,
                            //        //            CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                            //        //            EntityStatus = EntityStatus.Active,
                            //        //        },
                            //        //        new ()    //Id 18
                            //        //        {
                            //        //            Id = catId++,
                            //        //            ParentId = 13,
                            //        //            Name = "Couchbase",
                            //        //            CreatedById = 1,
                            //        //            CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                            //        //            EntityStatus = EntityStatus.Active,
                            //        //        },
                            //        //    },
                            //        //    CreatedById = 1,
                            //        //    CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                            //        //    EntityStatus = EntityStatus.Active,
                            //        //},
                            //        //new ()    //Id 19
                            //        //{
                            //        //    Id = catId++,
                            //        //    ParentId = 12,
                            //        //    Name = "Columnar Data Store",
                            //        //    SubDomains = new ()
                            //        //    {
                            //        //        new ()    //Id 20
                            //        //        {
                            //        //            Id = catId++,
                            //        //            ParentId = 19,
                            //        //            Name = "Apache Cassandra",
                            //        //            CreatedById = 1,
                            //        //            CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                            //        //            EntityStatus = EntityStatus.Active,
                            //        //        },
                            //        //        new ()    //Id 21
                            //        //        {
                            //        //            Id = catId++,
                            //        //            ParentId = 19,
                            //        //            Name = "Apache Hbase",
                            //        //            CreatedById = 1,
                            //        //            CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                            //        //            EntityStatus = EntityStatus.Active,
                            //        //        },
                            //        //    },
                            //        //    CreatedById = 1,
                            //        //    CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                            //        //    EntityStatus = EntityStatus.Active,
                            //        //},
                            //        //new ()    //Id 22
                            //        //{
                            //        //    Id = catId++,
                            //        //    ParentId = 12,
                            //        //    Name = "Key/Value Data Store",
                            //        //    SubDomains = new ()
                            //        //    {
                            //        //        new ()    //Id 23
                            //        //        {
                            //        //            Id = catId++,
                            //        //            ParentId = 22,
                            //        //            Name = "Amazon DynamoDB",
                            //        //            CreatedById = 1,
                            //        //            CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                            //        //            EntityStatus = EntityStatus.Active,
                            //        //        },
                            //        //        new ()    //Id 24
                            //        //        {
                            //        //            Id = catId++,
                            //        //            ParentId = 22,
                            //        //            Name = "Redis",
                            //        //            CreatedById = 1,
                            //        //            CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                            //        //            EntityStatus = EntityStatus.Active,
                            //        //        },
                            //        //        new ()    //Id 25
                            //        //        {
                            //        //            Id = catId++,
                            //        //            ParentId = 22,
                            //        //            Name = "Oracle Berkeley DB",
                            //        //            CreatedById = 1,
                            //        //            CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                            //        //            EntityStatus = EntityStatus.Active,
                            //        //        },
                            //        //    },
                            //        //    CreatedById = 1,
                            //        //    CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                            //        //    EntityStatus = EntityStatus.Active,
                            //        //},
                            //        //new ()    //Id 26
                            //        //{
                            //        //    Id = catId++,
                            //        //    ParentId = 12,
                            //        //    Name = "Graph Data Store",
                            //        //    CreatedById = 1,
                            //        //    CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                            //        //    EntityStatus = EntityStatus.Active,
                            //        //},
                            //    },
                            //    CreatedById = 1,
                            //    CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                            //    EntityStatus = EntityStatus.Active,
                            //},
                        //},
                        //CreatedById = 1,
                        //CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                        //EntityStatus = EntityStatus.Active,
                    }, //Id 8
                    new ()
                    {
                        Id = catId++,
                        ParentId = null,
                        Name = "Data Science",
                        SubDomains = null,
                        CreatedById = 1,
                        CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                        EntityStatus = EntityStatus.Active,
                    }, //Id 9 --- (prev. Id 27)
                    new ()
                    {
                        Id = catId++,
                        ParentId = null,
                        Name = "Artifical Intelligence",
                        //SubDomains = new ()
                        //{
                            //new ()    //Id 29
                            //{
                            //    Id = catId++,
                            //    ParentId = 28,
                            //    Name = "Natural Language Processing",
                            //    CreatedById = 1,
                            //    CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                            //    EntityStatus = EntityStatus.Active,
                            //},
                            //new ()    //Id 30
                            //{
                            //    Id = catId++,
                            //    ParentId = 28,
                            //    Name = "Knowledge Representation",
                            //    CreatedById = 1,
                            //    CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                            //    EntityStatus = EntityStatus.Active,
                            //},
                            //new ()    //Id 31
                            //{
                            //    Id = catId++,
                            //    ParentId = 28,
                            //    Name = "Automated Reasoning",
                            //    CreatedById = 1,
                            //    CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                            //    EntityStatus = EntityStatus.Active,
                            //},
                            //new ()    //Id 32
                            //{
                            //    Id = catId++,
                            //    ParentId = 28,
                            //    Name = "Machine Learning",
                            //    CreatedById = 1,
                            //    CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                            //    EntityStatus = EntityStatus.Active,
                            //},
                            //new ()    //Id 33
                            //{
                            //    Id = catId++,
                            //    ParentId = 28,
                            //    Name = "Computer Vision",
                            //    CreatedById = 1,
                            //    CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                            //    EntityStatus = EntityStatus.Active,
                            //},
                            //new ()    //Id 34
                            //{
                            //    Id = catId++,
                            //    ParentId = 28,
                            //    Name = "Robotics",
                            //    CreatedById = 1,
                            //    CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                            //    EntityStatus = EntityStatus.Active,
                            //},
                        //},
                        CreatedById = 1,
                        CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                        EntityStatus = EntityStatus.Active,
                    }, //Id 10 --- (prev. Id 28)
                    new ()
                    {
                        Id = catId++,
                        ParentId = null,
                        Name = "Network Administration",
                    //    SubDomains = new ()
                    //    {
                    //        new ()    //Id 36
                    //        {
                    //            Id = catId++,
                    //            ParentId = 35,
                    //            Name = "Cisco Routers",
                    //            CreatedById = 1,
                    //            CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                    //            EntityStatus = EntityStatus.Active,
                    //        },
                    //        new ()    //Id 37
                    //        {
                    //            Id = catId++,
                    //            ParentId = 35,
                    //            Name = "Linux Server",
                    //            CreatedById = 1,
                    //            CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                    //            EntityStatus = EntityStatus.Active,
                    //        },
                    //        new ()    //Id 38
                    //        {
                    //            Id = catId++,
                    //            ParentId = 35,
                    //            Name = "Windows Server",
                    //            CreatedById = 1,
                    //            CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                    //            EntityStatus = EntityStatus.Active,
                    //        },
                    //        new ()    //Id 39
                    //        {
                    //            Id = catId++,
                    //            ParentId = 35,
                    //            Name = "Unix",
                    //            CreatedById = 1,
                    //            CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                    //            EntityStatus = EntityStatus.Active,
                    //        }
                    //    },
                    //    CreatedById = 1,
                    //    CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                    //    EntityStatus = EntityStatus.Active,
                    }, //Id 35
                    new ()
                    {
                        Id = catId++,
                        ParentId = null,
                        Name = "Cloud Computing",
                        SubDomains = new ()
                        {
                            new ()    //Id 41
                            {
                                Id = catId++,
                                ParentId = 40,
                                Name = "Amazon AWS Cloud",
                                CreatedById = 1,
                                CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                                EntityStatus = EntityStatus.Active,
                            },
                            new ()    //Id 42
                            {
                                Id = catId++,
                                ParentId = 40,
                                Name = "Microsoft Azure",
                                CreatedById = 1,
                                CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                                EntityStatus = EntityStatus.Active,
                            },
                            new ()    //Id 43
                            {
                                Id = catId++,
                                ParentId = 40,
                                Name = "Google Cloud Platform",
                                CreatedById = 1,
                                CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                                EntityStatus = EntityStatus.Active,
                            }
                        },
                        CreatedById = 1,
                        CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                        EntityStatus = EntityStatus.Active,
                    }, //Id 40
                    new ()
                    {
                        Id = catId++,
                        ParentId = null,
                        Name = "Security",
                        SubDomains = null,
                        CreatedById = 1,
                        CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                        EntityStatus = EntityStatus.Active,
                    }, //Id 44
                    new ()
                    {
                        Id = catId++,
                        ParentId = null,
                        Name = "Applied Computing",
                        SubDomains = new ()
                        {
                            new () //Id 46
                            {
                                Id = catId++,
                                ParentId = 45,
                                Name = "Computer Aided Design (CAD)",
                                SubDomains = null,
                                CreatedById = 1,
                                CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                                EntityStatus = EntityStatus.Active,
                            },
                            new () //Id 47
                            {
                                Id = catId++,
                                ParentId = 45,
                                Name = "Computer Aided Mathematics",
                                SubDomains = null,
                                CreatedById = 1,
                                CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                                EntityStatus = EntityStatus.Active,
                            },
                            new () //Id 48
                            {
                                Id = catId++,
                                ParentId = 45,
                                Name = "ERP",
                                SubDomains = null,
                                CreatedById = 1,
                                CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                                EntityStatus = EntityStatus.Active,
                            },
                            new () //Id 49
                            {
                                Id = catId++,
                                ParentId = 45,
                                Name = "Accounting Using Computer",
                                SubDomains = null,
                                CreatedById = 1,
                                CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                                EntityStatus = EntityStatus.Active,
                            },
                            new () //Id 50
                            {
                                Id = catId++,
                                ParentId = 45,
                                Name = "Statistics Using Computer",
                                SubDomains = null,
                                CreatedById = 1,
                                CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                                EntityStatus = EntityStatus.Active,
                            },
                            new () //Id 51
                            {
                                Id = catId++,
                                ParentId = 45,
                                Name = "Computer Technical Support",
                                SubDomains = null,
                                CreatedById = 1,
                                CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                                EntityStatus = EntityStatus.Active,
                            },
                        },
                        CreatedById = 1,
                        CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                        EntityStatus = EntityStatus.Active,
                    }, //Id 45
                    new ()
                    {
                        Id = catId++,
                        ParentId = null,
                        Name = "Business Administration",
                        SubDomains = null,
                        CreatedById = 1,
                        CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                        EntityStatus = EntityStatus.Active,
                    } //Id 52
                };

                foreach (var cat in categories)
                    await AddCategory(cat);

                async Task AddCategory(ProductDomain category)
                {
                    await _dbCtx.Domains.AddAsync(category);

                    if (category.SubDomains != null && category.SubDomains.Any())
                        foreach (var subCat in category.SubDomains)
                            await AddCategory(subCat);
                }

                await _dbCtx.SaveChangesAsync();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void SeedCourses()
        {
            try
            {
                SeedSwDevCourses();
                //SeedNetworkingCourses();
                SeedSecurityCourses();
                //SeedGraphicsCourses();
                SeedCloudComputingCourses();
                //SeedAppliedComputingCourses();
                SeedDataScienceCourses();
                SeedAiCourses();
                //SeedWebDesignCourses();

                CoursesPopulator.StoreCourses(_dbCtx);
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        
        private void SeedSwDevCourses()
        {
            try
            {
                var datHelper = OdlDataHelper.Instance;
                var picsPath = datHelper.PicsPath;
                //List<string> CoursesDetailsPopulator.AddCourseContents(1, null;
                //var crsId = datHelper.CourseId;

                //var method = new System.Diagnostics.StackFrame(1).GetMethod();
                //var methodContainer = method.DeclaringType;

                //LoggerDataHelper.Instance.TempFileLog(
                //    $"[SW.AddCourses with model] -- from {methodContainer.FullName}.{method.Name}");

                #region 01 C Programming - 18H - L 200 | E 750 | T 750 | A (40 + 50 + 35) / 3 = 40
                var crsId = 1; var crsCntId = 1;
                CoursesPopulator.AddCourse(new Course()
                {
                    Id = crsId,
                    Level = ProductLevel.Beginner,
                    Code = "PG101",
                    Duration = 18,
                    ArabicTitle = "أساسيات البرمجة بلغة سي",
                    LatinTitle = "C Programming Fundamentals",
                    //CategoryId = 1,
                    Picture = System.IO.File.ReadAllBytes(@$"{picsPath}\C Prog 02.png"),
                    FinancialAccountId = 17,
                    Status = ProductStatus.Proposed,
                    CreatedById = 1,
                    CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                    EntityStatus = EntityStatus.Active,
                }, new List<string>()
                    {
                        "C and Unix", "Importance of C", "High level languages, assembly, machine code",
                        "main() function", "Hello, world", "Visual Studio Code",
                        "Compiler and Linker", "Characters and strings", "printf() function", "Escape sequences",
                        "Comments", "Variables and data types", "Operators and expressions",
                        "Type conversion and casting", "Increment, decrement and compound assignment",
                        "printf() argument specifiers", "Selection statements (if, else, switch)",
                        "Iteration statements (while, do while, for)", "Arrays", "Pointers",
                        "Command-line arguments", "String manipulation functions", "Header files",
                        "Functions and return", "Data structures & algorithms", "File I/O",
                        "The C Standard Library"
                    });

                //CoursesDetailsPopulator.CoursesFees.Add(crsId, new List<(int ctryId, float fees)>()
                //{
                //    (datHelper.LibyaId, 200), (datHelper.EgyptId, 750), (datHelper.TurkeyId, 750),
                //            (datHelper.AmericaId, 40)
                //});
                //CoursesDetailsPopulator.CoursesInstructors.Add(crsId, new List<int>() { 1 });
                #endregion

                #region 02 C++ Programming - 24H - L 250 | E 800 | T 800 | A (50 + 53 + 38) / 3 ~ 45
                crsId = 2;
                CoursesPopulator.AddCourse(new Course()
                {
                    Id = crsId,
                    Level = ProductLevel.Beginner,
                    Code = "PG102",
                    Duration = 24,
                    ArabicTitle = "أساسيات البرمجة بلغة سي ++",
                    LatinTitle = "C++ Programming Fundamentals",
                    //CategoryId = 1,
                    Picture = System.IO.File.ReadAllBytes(@$"{picsPath}\C++ Prog 01.png"),
                    FinancialAccountId = 18,
                    Status = ProductStatus.Proposed,
                    CreatedById = 1,
                    CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                    EntityStatus = EntityStatus.Active,
                }, new List<string>()
                    {
                        "C++, C and Unix", "Importance of C++", "C++ versions",
                        "High level languages, assembly, machine code",  "main() function", "Hello, world",
                        "Visual Studio Code", "Compiler and Linker", "Characters and strings",
                        "cout stream object", "Escape sequences", "Comments", "Variables and data types",
                        "Operators and expressions", "Type conversion and casting",
                        "Increment, decrement and compound assignment", "Output formatting using manipulators",
                        "Selection statements (if, else, switch)", "Iteration statements (while, do while, for)",
                        "Arrays", "Pointers and references", "Command-line arguments",
                        "String manipulation functions", "Header files", "Functions and return", "File I/O",
                        "The C++ Standard Library", "Object-oriented programming",
                        "Classes and objects", "Encapsulation", "Method overloading", "Inheritance",
                        "Polymorphism", "Data structures & algorithms"
                    });
                
                //CoursesDetailsPopulator.CoursesFees.Add(crsId, new List<(int ctryId, float fees)>()
                //{
                //    (datHelper.LibyaId, 250), (datHelper.EgyptId, 800), (datHelper.TurkeyId, 800),
                //    (datHelper.AmericaId, 45)
                //});
                //CoursesDetailsPopulator.CoursesInstructors.Add(crsId, new List<int>() { 1 });
                #endregion

                #region 03 Java Programming - 24H - L 300 | E 850 | T 850 | A (60 + 57 + 41) / 3 ~ 53
                crsId = 3;
                CoursesPopulator.AddCourse(new Course()
                {
                    Id = crsId,
                    Level = ProductLevel.Beginner,
                    Code = "PG103",
                    Duration = 24,
                    ArabicTitle = "أساسيات لغة جافا 17 (لتطبيقات سطح المكتب)",
                    LatinTitle = "Java 17 Programming Fundamentals (Desktop)",
                    //CategoryId = 2,
                    Picture = System.IO.File.ReadAllBytes(@$"{picsPath}\Java Prog 03.png"),
                    FinancialAccountId = 19,
                    Status = ProductStatus.Proposed,
                    CreatedById = 1,
                    CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                    EntityStatus = EntityStatus.Active,
                }, new List<string>()
                    {
                        "Java features", "Different development tools",
                        "Java compiler, runtime, virtual machine, and JDK",
                        "Oracle JDK vs OpenJDK", "Hello, world", "The main() method",
                        "System.out.println() method", "Command-line arguments", "Variables and data types",
                        "Statements, expressions & operators", "Type conversion and casting",
                        "Conditional/Decision statements (if, if else, switch)",
                        "Increment, decrement and compound assignment", "Operator precedence",
                        "Iteration statements (while, do while, for)", "Characters and strings", "Arrays",
                        "Enhanced for loop", "Oracle Java documentation (Java Platform SE Doc)",
                        "Graphical User Interface (GUI)", "Swing or JavaFX", "JFrame", "JLabel",
                        "JTextField and JTextArea", "JButton and event listeners", "Methods and return",
                        "JCheckBox and JRadioButton", "JList and JComboBox", "Layouts", "Mouse events",
                        "Colors and JColorChooser", "Simple file handling with JFileChooser", "JavaFX overview",
                        "Packages", "Object-oriented programming (OOP)",  "Classes and objects", "Collections",
                        "Encapsulation", "Method overloading", "Inheritance", "Polymorphism",
                        "Data structures & algorithms"
                    });

                //CoursesDetailsPopulator.CoursesFees.Add(crsId, new List<(int ctryId, float fees)>()
                //{
                //    (datHelper.LibyaId, 300), (datHelper.EgyptId, 850), (datHelper.TurkeyId, 850),
                //    (datHelper.AmericaId, 53)
                //});
                //CoursesDetailsPopulator.CoursesInstructors.Add(crsId, new List<int>() { 1 });
                #endregion

                #region 04 Python Programming - 18H - L 200 | E 750 | T 750 | A (40 + 50 + 35) / 3 = 40
                crsId = 4;
                CoursesPopulator.AddCourse(new Course()
                {
                    Id = crsId,
                    Level = ProductLevel.Beginner,
                    Code = "PG103",
                    Duration = 24,
                    ArabicTitle = "أساسيات لغة بايثون 3 ",
                    LatinTitle = "Python 3 Programming Fundamentals",
                    //CategoryId = 2,
                    Picture = System.IO.File.ReadAllBytes(@$"{picsPath}\Python Prog.png"),
                    FinancialAccountId = 19, //TODO: Modify
                    Status = ProductStatus.Proposed,
                    CreatedById = 1,
                    CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                    EntityStatus = EntityStatus.Active,
                }, new List<string>() //TODO: Modify
                    {

                    });
                
                //CoursesDetailsPopulator.CoursesFees.Add(crsId, new List<(int ctryId, float fees)>()
                //{
                //    (datHelper.LibyaId, 300), (datHelper.EgyptId, 850), (datHelper.TurkeyId, 850),
                //    (datHelper.AmericaId, 53)
                //});
                //CoursesDetailsPopulator.CoursesInstructors.Add(crsId, new List<int>() { 1 });
                #endregion

                #region 05 Adv. Java Programming - 18H - L 350 | E 950 | T 950 | A (70 + 63 + 45) / 3 ~ 60
                
                CoursesPopulator.AddCourse(new Course()
                {
                    Id = crsId,
                    Level = ProductLevel.Advanced,
                    Code = "PG303",
                    Duration = 18,
                    ArabicTitle = "Advanced Java 17 Programming (Desktop)",
                    LatinTitle = "Advanced Java 17 Programming (Desktop)",
                    //CategoryId = 2,
                    Picture = System.IO.File.ReadAllBytes(@$"{picsPath}\Adv Java Prog.png"),
                    FinancialAccountId = 20,
                    Status = ProductStatus.Proposed,
                    CreatedById = 1,
                    CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                    EntityStatus = EntityStatus.Active,
                }, new List<string>()
                    {
                        "Exception handling", "Method overloading", "Abstract classes", "Method overriding",
                        "Interfaces", "Generics", "Annotations", "Enums", "Switch expressions", "this & static",
                        "Records", "String class methods", "Lambda expressions", "Streams", "Working with XML",
                        "Working with JSON", "Multithreaded programming",  "Network programming",
                        "Working with relational databases", "Java Archive (JAR)",
                        "JProgressBar", "JTabbedPane", "JScrollBar", "JPanel", "JSlider", "JSpinner", "JTree",
                        "JMenuBar", "JPopupMenu", "JavaFX FXML", "Scene builder", "JavaFX Label & TextField",
                        "JavaFX Button", "JavaFX RadioButton & CheckBox", "JavaFX Layouts", "JavaFX 2D Shapes",
                        "Java FX Effects", "JavaFX Animation"
                    });
            
                //CoursesDetailsPopulator.CoursesPrerequisites.Add(crsId,
                //    new List<string>() { "Knowledge of Java language essentials" });
                //CoursesDetailsPopulator.CoursesFees.Add(crsId, new List<(int ctryId, float fees)>()
                //{
                //    (datHelper.LibyaId, 350), (datHelper.EgyptId, 950), (datHelper.TurkeyId, 950),
                //    (datHelper.AmericaId, 60)
                //});
                //CoursesDetailsPopulator.CoursesInstructors.Add(crsId, new List<int>() { 1 });
                #endregion

                #region 06 C# Programming - 24H - L 300 | E 850 | T 850 | A (60 + 57 + 41) / 3 ~ 53
                crsId = 6;
                CoursesPopulator.AddCourse(new Course()
                {
                    Id = crsId,
                    Level = ProductLevel.Beginner,
                    Code = "PG104",
                    Duration = 24,
                    ArabicTitle = "أساسيات لغة سي شارب 10 (لتطبيقات سطح المكتب)",
                    LatinTitle = "C# 10 Programming Fundamentals (Desktop)",
                    //CategoryId = 2,
                    Picture = System.IO.File.ReadAllBytes(@$"{picsPath}\CSh Prog 02.png"),
                    FinancialAccountId = 21,
                    Status = ProductStatus.Proposed,
                    CreatedById = 1,
                    CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                    EntityStatus = EntityStatus.Active,
                }, new List<string>()
                    {
                        ".NET technologies",
                        "C# origins and features (desktop, web, mobile, Mac, games, IoT, AI)",
                        "Microsoft Visual Studio (IDE) or Visual Studio Code",
                        "C# compiler, common lang. runtime, and .NET SDK", "Hello, world",
                        "Main() method", "System.Console.WriteLine() method", "Command-line arguments",
                        "Variables and data types", "Statements, expressions & operators", "Operator precedence",
                        "Comments", "Conditional/Decision statements (if, if else, switch)",
                        "Increment, decrement and compound assignment", "Operator precedence",
                        "Iteration statements (while, do while, for)", "Characters and strings",
                        "Arrays", "foreach loop", "DateTime, DateOnly, TimeOnly", "Microsoft documentation",
                        "Graphical User Interface (GUI)", "Windows Forms, WPF and MAUI", "Window control",
                        "XAML", "Button and event handling", "Methods and return", "Label and TextBlock",
                        "Text input", "CheckBox and RadioButton", "Controls position & alignment", "GroupBox",
                        "ListBox and ComboBox", "Colors and Brushes", "Mouse events", "Grid and StackPanel",
                        "DatePicker and Calendar", "Simple file handling with SaveFileDialog & OpenFileDialog",
                        "Assemblies and namespaces", "Object-oriented programming (OOP)", "Classes and objects",
                        "Collections", "Encapsulation", "Method overloading", "Inheritance", "Polymorphism",
                        "Data structures & algorithms"
                    });

                //CoursesDetailsPopulator.CoursesFees.Add(crsId, new List<(int ctryId, float fees)>()
                //{
                //    (datHelper.LibyaId, 300), (datHelper.EgyptId, 850), (datHelper.TurkeyId, 850),
                //    (datHelper.AmericaId, 53)
                //});
                //CoursesDetailsPopulator.CoursesInstructors.Add(crsId, new List<int>() { 1 });
                #endregion

                #region 07 Adv. C# Programming - 18H - L 350 | E 950 | T 950 | A (70 + 63 + 45) / 3 ~ 60
                crsId = 7;
                CoursesPopulator.AddCourse(new Course()
                {
                    Id = crsId,
                    Level = ProductLevel.Advanced,
                    Code = "PG304",
                    Duration = 18,
                    ArabicTitle = "Advanced C# 10 Programming (Desktop)",
                    LatinTitle = "Advanced C# 10 Programming (Desktop)",
                    //CategoryId = 2,
                    Picture = System.IO.File.ReadAllBytes(@$"{picsPath}\Adv CSh Prog.png"),
                    FinancialAccountId = 22,
                    Status = ProductStatus.Proposed,
                    CreatedById = 1,
                    CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                    EntityStatus = EntityStatus.Active,
                } , new List<string>()
                    {
                        "String methods and operations", "is and as operators", "Bitwise operations",
                        "typeof and sizeof operators", "switch pattern matching and expressions",
                        "Exception handling", "Recursion", "Delegates", "Attributes", "Generics",
                        "Abstract classes", "Interfaces", "LINQ and Lambda expressions", "Files and streams",
                        ".NET asynchronous programming (tasks, async and await)",
                        "Debugging using Visual Studio Debugger", "WPF TextBlock", "ListView",
                        "DatePicker & Calendar", "Image control", "Keyboard events", "MediaElement control",
                        "ScrollViewer", "Tab control", "ToolTip", "Ribbon control",  "User control",
                        "Relational database systems and SQL", "Object-relational mapping using Entity Framework"
                    });
                
                //CoursesDetailsPopulator.CoursesPrerequisites.Add(crsId,
                //    new List<string>() { "Knowledge of C# language essentials" });
                //CoursesDetailsPopulator.CoursesFees.Add(crsId, new List<(int ctryId, float fees)>()
                //{
                //    (datHelper.LibyaId, 350), (datHelper.EgyptId, 950), (datHelper.TurkeyId, 950),
                //    (datHelper.AmericaId, 60)
                //});
                //CoursesDetailsPopulator.CoursesInstructors.Add(crsId, new List<int>() { 1 });
                #endregion

                #region 08 Intro to Web Dev C# - 18H - L 350 | E 950 | T 950 | A (70 + 63 + 45) / 3 = 60
                crsId = 8;
                CoursesPopulator.AddCourse(new Course()
                {
                    Id = crsId,
                    Level = ProductLevel.Beginner,
                    Code = "PG105",
                    Duration = 30,
                    ArabicTitle = "مدخل إلى تطوير تطبيقات الويب باستخدام ميكروسوفت  بليزر ولغة سي شارب 12",
                    LatinTitle = "Introduction to Web Development Using Microsoft Blazor with C# 12",
                    //CategoryId = 3,
                    Picture = System.IO.File.ReadAllBytes(@$"{picsPath}\ASP.NET Core 01.png"),
                    FinancialAccountId = 23,
                    Status = ProductStatus.Proposed,
                    CreatedById = 1,
                    CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                    EntityStatus = EntityStatus.Active,
                }, new List<string>() //TODO: Modify
                    {
                        ".NET technologies", "Internet and Web", "Web development technologies",
                        "Internet protocols (TCP/IP, HTTP, DNS, FTP, ...)", "Web domains", "Top Level Domains",
                        "Features of ASP.NET Core",
                        "C# origins & features (desktop, web, mobile, Mac, games, IoT, AI)",
                        "Microsoft Visual Studio (IDE) or Visual Studio Code",
                        "C# compiler, Common Language Runtime (CLR), and .NET SDK",
                        "ASP.NET Core SDK and runtime", "First ASP.NET Core web application",
                        "Hosting & web servers",  "Variables and data types",
                        "Statements, expressions and operators", "Operator precedence", "Comments",
                        "Conditional/Decision statements (if, if else, switch)",
                        "Increment, decrement and compound assignment", "Operator precedence",
                        "Iteration statements (while, do while, for)", "Characters and strings", "Arrays",
                        "foreach loop", "DateTime, DateOnly, TimeOnly", "Microsoft documentation",
                        "String methods", "Razor Pages and MVC",
                        "Project structure of ASP.NET Core Razor Pages application", "Program class",
                        "Razor page layout","HTML elements", "HTTP verbs", "HTML forms", "Razor model binding",
                        "Using CSS to enhance the user interface", "JavaScript essentials",
                        "JSON, jQuery, XML, and AJAX", "Session handling",  "Object-oriented programming",
                        "Classes and objects", "Encapsulation", "Inheritance", "Polymorphism",
                        "Data structures & algorithms", "Working with database", "Relational database concepts",
                        "SQL statements", "Object-relational mapping", "Introduction to Entity Framework"
                    });
              //CoursesDetailsPopulator.CoursesContents.Add(crsId, new List<string>
                //{

                //});
                //CoursesDetailsPopulator.CoursesFees.Add(crsId, new List<(int ctryId, float fees)>()
                //{
                //    (datHelper.LibyaId, 500), (datHelper.EgyptId, 1300), (datHelper.TurkeyId, 1300),
                //    (datHelper.AmericaId, 80)
                //});
                //CoursesDetailsPopulator.CoursesInstructors.Add(crsId, new List<int>() { 1 });
                #endregion

                #region 09 Web Apps C# - 30H - L 500 | E 1300 | T 1300 | A (100 + 87 + 52) / 3 = 80
                crsId = 9;
                CoursesPopulator.AddCourse(new Course()
                {
                    Id = crsId,
                    Level = ProductLevel.Beginner,
                    Code = "PG105",
                    Duration = 30,
                    ArabicTitle = "تطوير تطبيقات الويب باستخدام إيه إس بي دوت نت 6 ولغة سي شارب 10",
                    LatinTitle = "Developing Web Applications Using ASP.NET Core 6 with C# 10",
                    //CategoryId = 3,
                    Picture = System.IO.File.ReadAllBytes(@$"{picsPath}\ASP.NET Core 01.png"),
                    FinancialAccountId = 23,
                    Status = ProductStatus.Proposed,
                    CreatedById = 1,
                    CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                    EntityStatus = EntityStatus.Active,
                }, new List<string>()
                    {
                        ".NET technologies", "Internet and Web", "Web development technologies",
                        "Internet protocols (TCP/IP, HTTP, DNS, FTP, ...)", "Web domains", "Top Level Domains",
                        "Features of ASP.NET Core",
                        "C# origins & features (desktop, web, mobile, Mac, games, IoT, AI)",
                        "Microsoft Visual Studio (IDE) or Visual Studio Code",
                        "C# compiler, Common Language Runtime (CLR), and .NET SDK",
                        "ASP.NET Core SDK and runtime", "First ASP.NET Core web application",
                        "Hosting & web servers",  "Variables and data types",
                        "Statements, expressions and operators", "Operator precedence", "Comments",
                        "Conditional/Decision statements (if, if else, switch)",
                        "Increment, decrement and compound assignment", "Operator precedence",
                        "Iteration statements (while, do while, for)", "Characters and strings", "Arrays",
                        "foreach loop", "DateTime, DateOnly, TimeOnly", "Microsoft documentation",
                        "String methods", "Razor Pages and MVC",
                        "Project structure of ASP.NET Core Razor Pages application", "Program class",
                        "Razor page layout","HTML elements", "HTTP verbs", "HTML forms", "Razor model binding",
                        "Using CSS to enhance the user interface", "JavaScript essentials",
                        "JSON, jQuery, XML, and AJAX", "Session handling",  "Object-oriented programming",
                        "Classes and objects", "Encapsulation", "Inheritance", "Polymorphism",
                        "Data structures & algorithms", "Working with database", "Relational database concepts",
                        "SQL statements", "Object-relational mapping", "Introduction to Entity Framework"
                    });
                            //CoursesDetailsPopulator.CoursesContents.Add(crsId, new List<string>
                //{

                //});
                //CoursesDetailsPopulator.CoursesFees.Add(crsId, new List<(int ctryId, float fees)>()
                //{
                //    (datHelper.LibyaId, 500), (datHelper.EgyptId, 1300), (datHelper.TurkeyId, 1300),
                //    (datHelper.AmericaId, 80)
                //});
                //CoursesDetailsPopulator.CoursesInstructors.Add(crsId, new List<int>() { 1 });
                #endregion

                #region 10 Adv. Web Apps C# - 18H - L 400 | E 1000 | T 1000 | A (80 + 64 + 48) / 3 = 65
                crsId = 10;
                CoursesPopulator.AddCourse(new Course()
                {
                    Id = crsId,
                    Level = ProductLevel.Advanced,
                    Code = "PG305",
                    Duration = 18,
                    ArabicTitle = "Advanced Web Applications Development Using ASP.NET Core 6 with C# 10",
                    LatinTitle = "Advanced Web Applications Development Using ASP.NET Core 6 with C# 10",
                    //CategoryId = 3,
                    Picture = System.IO.File.ReadAllBytes(@$"{picsPath}\Adv ASP.NET Core.png"),
                    FinancialAccountId = 24,
                    Status = ProductStatus.Proposed,
                    CreatedById = 1,
                    CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                    EntityStatus = EntityStatus.Active,
                }, new List<string>()
                    {
                        "String methods and operations", "is and as operators", "Bitwise operations",
                        "typeof and sizeof operators", "switch pattern matching and expressions",
                        "Exception handling", "Recursion", "Delegates", "Attributes", "Generics",
                        "Abstract classes", "Interfaces", "LINQ and Lambda expressions", "Files and streams",
                        ".NET asynchronous programming (tasks, async and await)",
                        "Debugging using Visual Studio Debugger", "Configuration", "Routing", "Tag helpers",
                        "Partial views", "Using Bootstrap for better HTML page design", "Cookies", "Caching",
                        "Dependency injection", "Authentication & authorization", "ASP.NET Core Web APIs (REST)",
                        "gRPC services"
                    });
                //CoursesDetailsPopulator.CoursesContents.Add(crsId, new List<string>
                //{

                //});
                //CoursesDetailsPopulator.CoursesPrerequisites.Add(crsId, new List<string>()
                //    {
                //        "Knowledge of C# language essentials", "Knowledge of ASP.NET Core essentials"
                //    });
                //CoursesDetailsPopulator.CoursesFees.Add(crsId, new List<(int ctryId, float fees)>()
                //{
                //    (datHelper.LibyaId, 400), (datHelper.EgyptId, 1000), (datHelper.TurkeyId, 1000),
                //    (datHelper.AmericaId, 65)
                //});
                //CoursesDetailsPopulator.CoursesInstructors.Add(crsId, new List<int>() { 1 });
                #endregion

                #region 11 Web Apps PHP - 30H - L 500 | E 1300 | T 1300 | A (100 + 87 + 52) / 3 = 80
                crsId = 11;
                CoursesPopulator.AddCourse(new Course()
                {
                    Id = crsId,
                    Level = ProductLevel.Beginner,
                    Code = "PG106",
                    Duration = 30,
                    ArabicTitle = "تطوير تطبيقات الويب باستخدلم لغة بي إتش بي 8",
                    LatinTitle = "Developing Web Applications Using PHP 8",
                    //CategoryId = 3,
                    Picture = System.IO.File.ReadAllBytes(@$"{picsPath}\PHP Prog 01.png"),
                    FinancialAccountId = 25,
                    Status = ProductStatus.Proposed,
                    CreatedById = 1,
                    CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                    EntityStatus = EntityStatus.Active,
                }, new List<string>()
                    {
                        "Internet and Web", "Web development technologies",
                        "Internet protocols (TCP/IP, HTTP, DNS, FTP, ...)", "Web domains", "Top Level Domains",
                        "PHP features", "Installation", "Visual Studio Code", "First PHP web application",
                        "Hosting & web servers",  "echo function", "Variables and data types",
                        "Operators and expressions", "Increment, decrement, and compound statements",
                        "Conditional/Decision statements (if, else, elseif, switch)",
                        "Iteration statements (for, while, do while)", "Arrays", "Functions and return",
                        "String functions", "HTML elements", "Using CSS to enhance the user interface",
                        "JavaScript Essentials", "JSON, jQuery, AJAX, XML", "HTTP verbs",
                        "HTML forms", "Time and date functions", "Session handling", "include and require",
                        "Object-oriented programming", "Classes and objects", "Encapsulation",
                        "Function overloading", "Inheritance", "Polymorphism", "Data structures & algorithms",
                        "Working with database", "Relational database concepts", "NoSQL databases",
                        "SQL statements", "Object-relational mapping", "Using frameworks",
                        "Brief introduction to Laravel framework"
                    });
                //CoursesDetailsPopulator.CoursesContents.Add(crsId, new List<string>
                //{

                //});
                //CoursesDetailsPopulator.CoursesFees.Add(crsId, new List<(int ctryId, float fees)>()
                //{
                //    (datHelper.LibyaId, 500), (datHelper.EgyptId, 1300), (datHelper.TurkeyId, 1300),
                //    (datHelper.AmericaId, 80)
                //});
                //CoursesDetailsPopulator.CoursesInstructors.Add(crsId, new List<int>() { 1 });
                #endregion

                #region 12 Android Apps Using Java - 30H - L 600 | E 1500 | T 1500 | A (120 + 100 + 59) / 3 ~ 95
                crsId = 12;
                CoursesPopulator.AddCourse(new Course()
                {
                    Id = crsId,
                    Level = ProductLevel.Beginner,
                    Code = "PG107",
                    Duration = 30,
                    ArabicTitle = "تطوير تطبيقات أندرويد باستخدام لغة جافا",
                    LatinTitle = "Developing Android Mobile Apps Using Java",
                    //CategoryId = 4,
                    Picture = System.IO.File.ReadAllBytes(@$"{picsPath}\Android Java 01.png"),
                    FinancialAccountId = 26,
                    Status = ProductStatus.Proposed,
                    CreatedById = 1,
                    CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                    EntityStatus = EntityStatus.Active,
                }, new List<string>()
                    {
                        "Android OS history and architecture", "Android versions", "Other Android dialects",
                        "Android vs iOS", "Java language features",
                        "Java compiler, runtime, virtual machine, and JDK", "Oracle JDK vs OpenJDK",
                        "Hello, world", "Android app project structure",
                        "Android SDK tools, platform tools and API levels",
                        "Java variables and data types", "Statements, expressions & operators",
                        "Type conversion and casting", "Decision statements (if, if else, switch)",
                        "Increment, decrement and compound assignment", "Operator precedence",
                        "Iteration statements (while, do while, for)", "Characters and strings",
                        "Arrays", "Enhanced for loop", "Oracle Java documentation (Java Platform SE Doc)",
                        "Android documentation", "Testing app on mobile", "Android app components",
                        "Manifest file", "Activities", "EditText widget -- one line or more",
                        "TextView widget", "Button and event listeners", "CheckBox",
                        "RadioButton and RadioGroup", "Layouts",
                        "DatePicker, DatePickerDialog, CalendarView, TimePicker, and TimePickerDialog",
                        "Colors", "Starting activities using intent", "App icon", "App resources", "Packages",
                        "Object-oriented programming", "Classes and objects", "Encapsulation",
                        "Method overloading", "Inheritance", "Polymorphism", "Data structures & algorithms",
                        "Kotlin language", "Flutter framework and Dart language"
                    });
                //CoursesDetailsPopulator.CoursesContents.Add(crsId, new List<string>
                //{

                //});
                //CoursesDetailsPopulator.CoursesFees.Add(crsId, new List<(int ctryId, float fees)>()
                //{
                //    (datHelper.LibyaId, 600), (datHelper.EgyptId, 1500), (datHelper.TurkeyId, 1500),
                //    (datHelper.AmericaId, 95)
                //});
                //CoursesDetailsPopulator.CoursesInstructors.Add(crsId, new List<int>() { 1 });
                #endregion

                #region 13 Adv. Andr. Apps Us. Java - 18H - L 450 | E 1200 | T 1200 | A (90 + 76 + 50) / 3 ~ 75
                crsId = 13;
                CoursesPopulator.AddCourse(new Course()
                {
                    Id = crsId,
                    Level = ProductLevel.Advanced,
                    Code = "PG307",
                    Duration = 18,
                    ArabicTitle = "Advanced Android Mobile Apps Development Using Java",
                    LatinTitle = "Advanced Android Mobile Apps Development Using Java",
                    //CategoryId = 4,
                    Picture = System.IO.File.ReadAllBytes(@$"{picsPath}\Adv Android Java.png"),
                    FinancialAccountId = 27,
                    Status = ProductStatus.Proposed,
                    CreatedById = 1,
                    CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                    EntityStatus = EntityStatus.Active,
                }, new List<string>()
                    {
                        "Exception handling", "Method overloading", "Abstract classes", "Method overriding",
                        "Interfaces", "this & static", "Collections & Generics", "Annotations",
                        "Lambda expressions", "Multithreaded programming", "Streams", "Working with XML",
                        "Working with JSON", "Java Archive (JAR)", "Resources", "Intent filters",
                        "Broadcast receivers", "Content providers", "Fragments", "Styles and themes",
                        "Alert dialogs", "Camera", "Phone calls", "Sending SMS", "Sending email", "Sensors",
                        "Location & mapping", "Consume REST service"
                    });
                //CoursesDetailsPopulator.CoursesContents.Add(crsId, new List<string>
                //{

                //});
                //CoursesDetailsPopulator.CoursesPrerequisites.Add(crsId, new List<string>()
                //    {
                //        "Knowledge of Java language essentials",
                //        "Knowledge of Android programming essentials"
                //    });
                //CoursesDetailsPopulator.CoursesFees.Add(crsId, new List<(int ctryId, float fees)>()
                //{
                //    (datHelper.LibyaId, 450), (datHelper.EgyptId, 1200), (datHelper.TurkeyId, 1200),
                //    (datHelper.AmericaId, 75)
                //});
                //CoursesDetailsPopulator.CoursesInstructors.Add(crsId, new List<int>() { 1 });
                #endregion

                #region 14 Android Apps Us. Xam. - 30H - L 600 | E 1500 | T 1500 | A (120 + 100 + 59) / 3 ~ 95
                crsId = 14;
                CoursesPopulator.AddCourse(new Course()
                {
                    Id = crsId,
                    Level = ProductLevel.Beginner,
                    Code = "PG108",
                    Duration = 30,
                    ArabicTitle = "تطوير تطبيقات أندرويد باستخدام زمارين فورمز بلغة سي شارب",
                    LatinTitle = "Developing Android Mobile Apps Using Xamarin Forms with C#",
                    //CategoryId = 4,
                    Picture = System.IO.File.ReadAllBytes(@$"{picsPath}\Android Xamarin 01.png"),
                    FinancialAccountId = 28,
                    Status = ProductStatus.Proposed,
                    CreatedById = 1,
                    CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                    EntityStatus = EntityStatus.Active,
                }, new List<string>()
                    {
                        "Android OS history and architecture", "Android versions", "Other Android dialects",
                        "Android vs iOS", "Xamarin features", ".NET Technologies",
                        "Xamarin Forms, Xamarin Android, Xamarin iOS, and Xamarin Mac",
                        "Visual Studio vs Visual Studio Code", "Visual Studio installation",
                        "First Android app (Hello, world)", "Xamarin Forms project structure",
                        "C# variables and types", "Statements, expressions and operators",
                        "Conditional statements", "Iteration statements", "Characters and strings",
                        "Arrays and collections", "foreach loop", "DateTime, DateOnly, TimeOnly",
                        "Microsoft documentation", "Button and event handling", "XML and XAML",
                        "Testing app on mobile", "Entry and Editor controls", "Label control", "Layouts",
                        "CheckBox", "Picker", "DatePicker and TimePicker", "Colors and brushes",
                        "Pages and navigation", "App icon", "Android app resources",
                        "Object-oriented programming",
                        "Classes and objects", "Encapsulation", "Method overloading", "Inheritance",
                        "Polymorphism", "Data structures & algorithms", "Assemblies and namespaces"
                    });
                //CoursesDetailsPopulator.CoursesContents.Add(crsId, new List<string>
                //{

                //});
                //CoursesDetailsPopulator.CoursesFees.Add(crsId, new List<(int ctryId, float fees)>()
                //{
                //    (datHelper.LibyaId, 600), (datHelper.EgyptId, 1500), (datHelper.TurkeyId, 1500),
                //    (datHelper.AmericaId, 95)
                //});
                //CoursesDetailsPopulator.CoursesInstructors.Add(crsId, new List<int>() { 1 });
                #endregion

                #region 15 Adv. Andr. Apps Us. Xam. - 18H - L 450 | E 1200 | T 1200 | A (90 + 76 + 50) / 3 ~ 75
                crsId = 15;
                CoursesPopulator.AddCourse(new Course()
                {
                    Id = crsId,
                    Level = ProductLevel.Advanced,
                    Code = "PG308",
                    Duration = 18,
                    ArabicTitle = "Advanced Android Mobile Apps Development Using Xamarin Forms with C#",
                    LatinTitle = "Advanced Android Mobile Apps Development Using Xamarin Forms with C#",
                    //CategoryId = 4,
                    Picture = System.IO.File.ReadAllBytes(@$"{picsPath}\Adv Android Xamarin.png"),
                    FinancialAccountId = 29,
                    Status = ProductStatus.Proposed,
                    CreatedById = 1,
                    CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                    EntityStatus = EntityStatus.Active,
                }, new List<string>()
                    {
                        "String methods and operations", "is and as operators", "Bitwise operations",
                        "typeof and sizeof operators", "switch pattern matching and expressions",
                        "Exception handling", "Recursion", "Delegates", "Attributes", "Generics",
                        "Abstract classes", "Method overriding", "Interfaces", "LINQ and Lambda expressions",
                        "Files and streams", ".NET asynchronous programming (tasks, async and await)",
                        "Page types", "Navigation", "Tabbed page", "Carousel page", "Modal page", "ListView",
                        "CarouselView", "TableView", "Splash screen", "ActivityIndicator", "ProgressBar",
                        "Xamarin Essentials", "Android API levels", "Dependency service",
                        "Select image in Android", "Make phone call", "Send SMS", "Send email", "Sensors",
                        "Location & mapping", "Consume REST service"
                    });
                //CoursesDetailsPopulator.CoursesContents.Add(crsId, new List<string>
                //{

                //});
                //CoursesDetailsPopulator.CoursesPrerequisites.Add(crsId, new List<string>()
                //    {
                //        "Knowledge of C# language essentials",
                //        "Knowledge of Android programming essentials",
                //        "Knowledge of Xamarin Forms essentials"
                //    });
                //CoursesDetailsPopulator.CoursesFees.Add(crsId, new List<(int ctryId, float fees)>()
                //{
                //    (datHelper.LibyaId, 450), (datHelper.EgyptId, 1200), (datHelper.TurkeyId, 1200),
                //    (datHelper.AmericaId, 75)
                //});
                //CoursesDetailsPopulator.CoursesInstructors.Add(crsId, new List<int>() { 1 });
                #endregion

                #region 16 Intr. Games Prg. Unity & C# - 18H - L 600 | E 1500 | T 1500 | A (120 + 100 + 59) / 3 ~ 95
                crsId = 16;
                CoursesPopulator.AddCourse(new Course()
                {
                    Id = crsId,
                    Level = ProductLevel.Advanced,
                    Code = "GM101",
                    Duration = 18,
                    ArabicTitle = "مدخل إلى برمجة الألعاب باستخدام يونيتي ولغة سي شارب",
                    LatinTitle = "Introduction to Games Programming Using Unity and C#",
                    //CategoryId = 5,
                    Picture = System.IO.File.ReadAllBytes(@$"{picsPath}\Games Programming.png"),
                    FinancialAccountId = 30,
                    Status = ProductStatus.Proposed,
                    CreatedById = 1,
                    CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                    EntityStatus = EntityStatus.Active,
                }, new List<string>()
                    {
                        "Why use game engine?", "Why Unity?",
                        "How design a game (concept, characters, gameplay)?",
                        "Games genres (types)", "Unity user interface", "Scenes and objects", "Prefabs",
                        "Lighting", "Code scripts", "Movement & camera", "Obstacles & collision",
                        "Materials & effects", "Importing & integrating assets", "Audio", "Animation",
                        "Basic AI & enemy behavior", "Game levels", "Win & lose"
                    });
                //CoursesDetailsPopulator.CoursesContents.Add(crsId, new List<string>
                //{

                //});
                //CoursesDetailsPopulator.CoursesPrerequisites.Add(crsId,
                //    new List<string>() { "Knowledge of C# language essentials" });
                //CoursesDetailsPopulator.CoursesFees.Add(crsId, new List<(int ctryId, float fees)>()
                //{
                //    (datHelper.LibyaId, 450), (datHelper.EgyptId, 1200), (datHelper.TurkeyId, 1500),
                //    (datHelper.AmericaId, 95)
                //});
                #endregion
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void SeedGraphicsCourses()
        {
            try
            {
                var datHelper = OdlDataHelper.Instance;
                var picsPath = datHelper.PicsPath;

                #region 15 PhotoShop Fundamentals - 18H - L 300 | E 850 | T 850 | A (60 + 57 + 51) / 3 ~ 53
                var crsId = 15;
                CoursesPopulator.AddCourse(new Course()
                {
                    Id = crsId,
                    Level = ProductLevel.Beginner,
                    Code = "GR101",
                    Duration = 18,
                    ArabicTitle = "أساسيات فوتوشوب",
                    LatinTitle = "PhotoShop Fundamentals",
                    //CategoryId = 7,
                    Picture = System.IO.File.ReadAllBytes(@$"{picsPath}\Photoshop.png"),
                    FinancialAccountId = 31,
                    Status = ProductStatus.Proposed,
                    CreatedById = 1,
                    CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                    EntityStatus = EntityStatus.Active,
                }, new List<string>
                    {
                        "PhotoShop workspace", "Toolbox", "Photo editor", "Image size & resolution",
                        "Layers", "Color basics", "Image selection", "Image adjustment", "Camera Raw",
                        "Resize and crop", "Image repair & restoration", "Image transformation",
                        "Drawing & painting", "Working with text",  "Filters, effects & styles",
                        "Working with files", "Printing", "Color management",  "Preparing images for web"
                    });
                #endregion

                #region 16 Adv. Graphic Design - 18H - L 350 | E 950 | T 950 | A (70 + 63 + 45) / 3 = 60
                crsId = 16;
                CoursesPopulator.AddCourse(new Course()
                {
                    Id = crsId,
                    Level = ProductLevel.Advanced,
                    Code = "GR301",
                    Duration = 18,
                    ArabicTitle = "Advanced Graphic Design",
                    LatinTitle = "Advanced Graphic Design",
                    //CategoryId = 7,
                    Picture = System.IO.File.ReadAllBytes(@$"{picsPath}\Adv Graphic Design.png"),
                    FinancialAccountId = 32,
                    Status = ProductStatus.Proposed,
                    CreatedById = 1,
                    CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                    EntityStatus = EntityStatus.Active,
                }, new List<string>
                    {
                        "Review of graphic design skills & tasks", "Different measurement systems",
                        "Advanced selection techniques in PhotoShop", "PhotoShop Smart Objects",
                        "PhotoShop Smart Filters", "Advanced layer management", "Make image sharper",
                        "Remove unwanted objects from image", "Remove background", "Color correction",
                        "Text effects", "Animated GIF", "PhotoShop automation", "Professional image printing",
                        "Using PhotoShop for 3D"
                    });
                
                CoursesDetailsPopulator.CoursesFees.Add(crsId, new List<(int ctryId, float fees)>()
                {
                    (datHelper.LibyaId, 350), (datHelper.EgyptId, 950), (datHelper.TurkeyId, 950),
                    (datHelper.AmericaId, 60)
                });
                #endregion

                #region 17 Anim. Fund. Us. Aft. Eff. - 18H - L 350 | E 950 | T 950 | A (70 + 63 + 45) / 3 ~ 60
                crsId = 17;
                CoursesPopulator.AddCourse(new Course()
                {
                    Id = crsId,
                    Level = ProductLevel.Beginner,
                    Code = "GR102",
                    Duration = 18,
                    ArabicTitle = "أساسيات تحريك الرسوم باستخدام أدوبي أفتر إفكتس",
                    LatinTitle = "Animation Fundamentals Using Adobe After Effects",
                    //CategoryId = 7,
                    Picture = System.IO.File.ReadAllBytes(@$"{picsPath}\AfterEffects.png"),
                    FinancialAccountId = 33,
                    Status = ProductStatus.Proposed,
                    CreatedById = 1,
                    CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                    EntityStatus = EntityStatus.Active,
                }, new List<string>
                    {
                        "After Effects user interface", "Animation techniques", "Layers",
                        "Modes, masks, & mattes",
                        "Cameras and lights", "Text animation", "Effects & presets", "Color management",
                        "Animation, keyframing & tracking",  "Drawing and painting", "Audio effects",
                        "Importing and integration", "Exporting and rendering"
                    });
                CoursesDetailsPopulator.CoursesFees.Add(crsId, new List<(int ctryId, float fees)>()
                {
                    (datHelper.LibyaId, 350), (datHelper.EgyptId, 950), (datHelper.TurkeyId, 950),
                    (datHelper.AmericaId, 60)
                });
                #endregion
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void SeedNetworkingCourses()
        {
            try
            {
                var datHelper = OdlDataHelper.Instance;
                var picsPath = datHelper.PicsPath;
                //var crsId = datHelper.CourseId;

                #region 23 Networking Fund. - 24H - L 450 | E 1200 | T 1200 | A (90 + 76 + 50) / 3 ~ 75
                var crsId = 23;
                CoursesPopulator.AddCourse(new Course()
                {
                    Id = crsId,
                    Level = ProductLevel.Beginner,
                    Code = "NW101",
                    Duration = 24,
                    ArabicTitle = "أساسيات الشبكات",
                    LatinTitle = "Networking Fundamentals",
                    //CategoryId = 35,
                    Picture = System.IO.File.ReadAllBytes(@$"{picsPath}\Networking Fund 05.jpg"),
                    FinancialAccountId = 39,
                    Status = ProductStatus.Proposed,
                    CreatedById = 1,
                    CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                    EntityStatus = EntityStatus.Active,
                }, new List<string>
                    {
                        "What is network?", "Network topologies", "LAN, MAN, and WAN", "Network components",
                        "Network communication technologies", "Wireless networks", "Network devices",
                        "Network cables", "OSI model", "Network protocols", "Internet & TCP/IP",
                        "More details about some internet protocols", "IPv4 & IPv6",
                        "Windows Server, Unix, and Linux", "Web servers", "Email servers", "Cloud computing"
                    });    
                #endregion
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void SeedSecurityCourses()
        {
            try
            {
                var datHelper = OdlDataHelper.Instance;
                var picsPath = datHelper.PicsPath;
                //var crsId = datHelper.CourseId;

                #region 24 Intr. Info & Net Sec. - 18H - L 320 | E 900 | T 900 | A (65 + 65 + 65) / 3 ~ 60
                var crsId = 24;
                CoursesPopulator.AddCourse(new Course()
                {
                    Id = crsId,
                    Level = ProductLevel.Beginner,
                    Code = "SC101",
                    Duration = 18,
                    ArabicTitle = "مدخل إلى أمن المعلومات والشبكات",
                    LatinTitle = "Introduction to Information & Network Security",
                    //CategoryId = 44,
                    Picture = System.IO.File.ReadAllBytes(@$"{picsPath}\Info Security 03.jpg"),
                    FinancialAccountId = 40,
                    Status = ProductStatus.Proposed,
                    CreatedById = 1,
                    CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                    EntityStatus = EntityStatus.Active,
                }, new List<string>
                    {
                        "Threats & vulnerabilities", "Types of attacks", "Malware", "Viruses",
                        "Stalking & fraud", "Hacking techniques", "Social engineering", "Firewalls",
                        "Authentication & authorization", "Monitoring & auditing", "Encryption & cryptography",
                        "System security", "Software security", "Network security", "Network scanning",
                        "User security", "Information security compliance laws", "Digital forensics"
                    });
                #endregion
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void SeedAiCourses()
        {
            try
            {
                var datHelper = OdlDataHelper.Instance;
                var picsPath = datHelper.PicsPath;
                var crsId = 1;// datHelper.CourseId;

                #region 111 Introduction to Prompt Engineering. - 10H - L 80 | E 800 | T 1000 | A 25
                crsId = 111;
                CoursesPopulator.AddCourse(new Course()
                {
                    Id = crsId,
                    Level = ProductLevel.Beginner,
                    Code = "AI101",
                    Duration = 10,
                    ArabicTitle = "مدخل إلى هندسة التلقين",
                    LatinTitle = "Introduction to Prompt Engineering",
                    //CategoryId = 32,
                    Picture = System.IO.File.ReadAllBytes(@$"{picsPath}\Intro Prompt Eng.png"),
                    FinancialAccountId = 38,
                    Status = ProductStatus.Planned,
                    CreatedById = 1,
                    CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                    EntityStatus = EntityStatus.Active,
                }, new List<string> //TODO: Topics of prompt engineering should be changed
                    {
                        "Artificial Intelligence", "Why do we need AI?", "Brief history of AI", "Turing test", "AI branches",
                        "Natural Language Processing (NLP)", "Machine Learning & Deep Leaning", "Large Language Models (LLMs)",
                        "Fundamentals of Prompt Engineering", "Practices"
                    });

                //    CoursesDetailsPopulator.CoursesFees.Add(crsId, new List<(int ctryId, float fees)>()
                //{
                //    (datHelper.LibyaId, 80), (datHelper.EgyptId, 800), (datHelper.TurkeyId, 1000),
                //    (datHelper.AmericaId, 25)
                //});
                #endregion

                #region 22 Mach. Lear. Fund. - 24H - L 400 | E 1500 | T 1000 | A (120 + 100 + 59) / 3 ~ 95
                crsId = 22;
                CoursesPopulator.AddCourse(new Course()
                {
                    Id = crsId,
                    Level = ProductLevel.Beginner,
                    Code = "ML101",
                    Duration = 24,
                    ArabicTitle = "Machine Learning Fundamentals",
                    LatinTitle = "Machine Learning Fundamentals",
                    //CategoryId = 32,
                    Picture = System.IO.File.ReadAllBytes(@$"{picsPath}\Machine Learning.png"),
                    FinancialAccountId = 38,
                    Status = ProductStatus.Proposed,
                    CreatedById = 1,
                    CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                    EntityStatus = EntityStatus.Active,
                }, new List<string>
                    {
                        "What is machine learning (ML)?", "What is artificial intelligence (AI)?",
                        "Why do we need AI?", "Brief history of AI", "Turing test", "AI branches",
                        "Famous AI applications", "ML life cycle", "Neural networks",
                        "ML approaches (supervised, unsupervised, semi-supervised, reinforcement)",
                        "ML algorithms", "Mathematics required for ML", "ML libraries", "Using public datasets",
                        "Data collection & preparation", "ML and data science",  "Building ML model",
                        "Feature engineering", "Famous ML applications", "Computer vision",
                        "Natural language processing", "Personal (smart) assistant", "Sentiment analysis", "GPT3"
                    });

                //    CoursesDetailsPopulator.CoursesFees.Add(crsId, new List<(int ctryId, float fees)>()
                //{
                //    (datHelper.LibyaId, 600), (datHelper.EgyptId, 1500), (datHelper.TurkeyId, 1000),
                //    (datHelper.AmericaId, 95)
                //});
                #endregion

                #region AI Developement Fundamentals - ??H - L ?? | E ?? | T ?? | A (120 + 100 + 59) / 3 ~ 95
                #endregion

                #region AI For Beginners - ??H - L ?? | E ?? | T ?? | A (120 + 100 + 59) / 3 ~ 95
                #endregion

                #region Master AI Agents - ??H - L ?? | E ?? | T ?? | A (120 + 100 + 59) / 3 ~ 95
                #endregion

                #region Machine Learning Basics - ??H - L ?? | E ?? | T ?? | A (120 + 100 + 59) / 3 ~ 95
                #endregion

                #region Deep Learning Basics - ??H - L ?? | E ?? | T ?? | A (120 + 100 + 59) / 3 ~ 95
                #endregion

                #region Master AI Agents - ??H - L ?? | E ?? | T ?? | A (120 + 100 + 59) / 3 ~ 95
                #endregion

                #region Master AI Agents - ??H - L ?? | E ?? | T ?? | A (120 + 100 + 59) / 3 ~ 95
                #endregion

            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void SeedCloudComputingCourses()
        {
            try
            {

            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void SeedDataScienceCourses()
        {
            try
            {
                var datHelper = OdlDataHelper.Instance;
                var picsPath = datHelper.PicsPath;
                //var crsId = datHelper.CourseId;

                #region 21 Intr. Dat. Sci. U. Python - 24H - L 450 | E 1200 | T 1200 | A (90 + 76 + 50) / 3 ~ 75
                var crsId = 21;
                CoursesPopulator.AddCourse(new Course()
                {
                    Id = crsId,
                    Level = ProductLevel.Beginner,
                    Code = "DS101",
                    Duration = 24,
                    ArabicTitle = "مدخل إلى علم البيانات باستخدام لغة بايثون",
                    LatinTitle = "Introduction to Data Science Using Python",
                    //CategoryId = 11,
                    Picture = System.IO.File.ReadAllBytes(@$"{picsPath}\Data Science with Python.png"),
                    FinancialAccountId = 37,
                    Status = ProductStatus.Proposed,
                    CreatedById = 1,
                    CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                    EntityStatus = EntityStatus.Active,
                }, new List<string>
                    {
                        "What is data science", "Why data science", "What is data", "What is big data",
                        "Facets of data", "Structured, unstructured, and machine-generated data",
                        "Data science process", "Databases (SQL or NoSQL)",
                        "Need for statistics and probability", "Data visualization", "Why Python",
                        "Essentials of Python", "Using Python libraries for data manipulation",
                        "Relation between data science and machine learning"
                    });
                CoursesDetailsPopulator.CoursesFees.Add(crsId, new List<(int ctryId, float fees)>()
            {
                (datHelper.LibyaId, 450), (datHelper.EgyptId, 1200), (datHelper.TurkeyId, 1200),
                (datHelper.AmericaId, 75)
            });
                #endregion
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void SeedAppliedComputingCourses()
        {
            try
            {
                var datHelper = OdlDataHelper.Instance;
                var picsPath = datHelper.PicsPath;
                //var crsId = datHelper.CourseId;

                #region 19 MATLAB Fundamentals - 18H - L 350 | E 950 | T 950 | A (70 + 63 + 45) / 3 ~ 60
                var crsId = 19;
                CoursesPopulator.AddCourse(new Course()
                {
                    Id = crsId,
                    Level = ProductLevel.Beginner,
                    Code = "AC101",
                    Duration = 18,
                    ArabicTitle = "أساسيات ماتلاب",
                    LatinTitle = "MATLAB Fundamentals",
                    //CategoryId = 47,
                    Picture = System.IO.File.ReadAllBytes(@$"{picsPath}\MatLab.png"),
                    FinancialAccountId = 35,
                    Status = ProductStatus.Proposed,
                    CreatedById = 1,
                    CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                    EntityStatus = EntityStatus.Active,
                }, new List<string>
                    {
                        "MATLAB desktop", "Simple calculations", "Operators", "Workspace variables",
                        "Formatting functions", "Working with vectors and matrices", "Algebraic equations",
                        "Linear algebra", "Non-linear functions", "Statistical operations",
                        "Calculus and differential equations", "Integration", "Polynomials", "Transforms",
                        "Curve fitting", "2-D plotting", "3-D plotting", "Script files",
                        "Variables & Data types", "Relational operators", "Logical operators",
                        "Decision statements", "Loops"
                    });
            //    CoursesDetailsPopulator.CoursesFees.Add(crsId, new List<(int ctryId, float fees)>()
            //{
            //    (datHelper.LibyaId, 350), (datHelper.EgyptId, 950), (datHelper.TurkeyId, 950),
            //    (datHelper.AmericaId, 60)
            //});

                //AddCourseInstructors(crsId, new List<int>() { 1 });
                //AddCycle(modelBuilder, crsId, "", new DateTime(), new DateTime(),
                //    new DateTime(), new DateTime(), 6, WeekDays.Saturday | WeekDays.Monday | WeekDays.Wednesday);
                #endregion
                #region 20 Introduction to AutoCAD - 18H - L 350 | E 950 | T 950 | A (70 + 63 + 45) / 3 ~ 60
                crsId = 20;
                CoursesPopulator.AddCourse(new Course()
                {
                    Id = crsId,
                    Level = ProductLevel.Beginner,
                    Code = "AC103",
                    Duration = 18,
                    ArabicTitle = "مدخل إلى أوتوكاد",
                    LatinTitle = "Introduction to AutoCAD",
                    //CategoryId = 46,
                    Picture = System.IO.File.ReadAllBytes(@$"{picsPath}\AutoCAD.png"),
                    FinancialAccountId = 36,
                    Status = ProductStatus.Proposed,
                    CreatedById = 1,
                    CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                    EntityStatus = EntityStatus.Active,
                }, new List<string>
                    {
                        "What is CAD?", "AutoCAD user interface", "Basic drawing and editing",
                        "Coordinate systems", "Drawing commands", "Drawing precision", "AutoCAD objects",
                        "Making changes", "Modify commands", "View commands", "Layers", "Advanced object types",
                        "Advanced editing", "Templates", "Text manipulation", "Hatching", "Dimensions"
                    });
            //    CoursesDetailsPopulator.CoursesFees.Add(crsId, new List<(int ctryId, float fees)>()
            //{
            //    (datHelper.LibyaId, 350), (datHelper.EgyptId, 950), (datHelper.TurkeyId, 950),
            //    (datHelper.AmericaId, 60)
            //});
                //AddCourseInstructors(crsId, new List<int>() { 1 });
                //AddCycle(modelBuilder, crsId, "", new DateTime(), new DateTime(),
                //    new DateTime(), new DateTime(), 6, WeekDays.Saturday | WeekDays.Monday | WeekDays.Wednesday);
                #endregion
                #region 25 Ess. IT Support - 18H - L 250 | E 800 | T 800 | A (50 + 53 + 38) / 3 ~ 45
                crsId = 25;
                CoursesPopulator.AddCourse(new Course()
                {
                    Id = crsId,
                    Level = ProductLevel.Beginner,
                    Code = "IS101",
                    Duration = 18,
                    ArabicTitle = "أسس الدعم الفني لأنظمة تقنية المعلومات",
                    LatinTitle = "Essentials of IT Support",
                    //CategoryId = 51,
                    Picture = System.IO.File.ReadAllBytes(@$"{picsPath}\IT Tech Supp.jpg"),
                    FinancialAccountId = 41,
                    Status = ProductStatus.Proposed,
                    CreatedById = 1,
                    CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                    EntityStatus = EntityStatus.Active,
                }, new List<string>
                    {
                        "Computer hardware", "Operating systems", "Windows, Unix, Linux, and MacOS",
                        "Software concepts", "Software applications", "Computer networks", "Network protocols",
                        "Network devices", "Internet and web", "Virtualization & cloud computing",
                        "Mobile devices", "Information security", "Hardware troubleshooting",
                        "Network troubleshooting", "Software troubleshooting"
                    });
            //    CoursesDetailsPopulator.CoursesFees.Add(crsId, new List<(int ctryId, float fees)>()
            //{
            //    (datHelper.LibyaId, 250), (datHelper.EgyptId, 800), (datHelper.TurkeyId, 800),
            //    (datHelper.AmericaId, 45)
            //});
                #endregion
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void SeedWebDesignCourses()
        {
            var datHelper = OdlDataHelper.Instance;
            var picsPath = datHelper.PicsPath;

            #region 18 Web Design Fundamentals - 18H - L 250 | E 800 | T 800 | A (50 + 50 + 50) / 3 = 45
            var crsId = 18;
            CoursesPopulator.AddCourse(new Course()
            {
                Id = crsId,
                Level = ProductLevel.Beginner,
                Code = "WD101",
                Duration = 18,
                ArabicTitle = "أساسيات تصميم مواقع الويب",
                LatinTitle = "Web Design Fundamentals",
                //CategoryId = 6,
                Picture = System.IO.File.ReadAllBytes(@$"{picsPath}\Web Design.png"),
                FinancialAccountId = 34,
                Status = ProductStatus.Proposed,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                EntityStatus = EntityStatus.Active,
            }, new List<string>
                {
                    "What is the web?", "Web design vs web development", "HTML5",
                    "Internet protocols (TCP/IP, HTTP, DNS, FTP, ...)", "Web domains", "Top Level Domains",
                    "HTML elements and attributes", "Head, body, and footer", "Colors", "Fonts", "Tables",
                    "Forms", "Images", "Media", "Favicon", "Element style", "Cascading Style Sheets (CSS)",
                    "Bootstrap 5", "JavaScript basics", "jQuery", "Hosting & web servers"
                });
            //CoursesDetailsPopulator.CoursesFees.Add(crsId, new List<(int ctryId, float fees)>()
            //{
            //    (datHelper.LibyaId, 250), (datHelper.EgyptId, 800), (datHelper.TurkeyId, 800),
            //    (datHelper.AmericaId, 45)
            //});
            #endregion
        }
    }
}
