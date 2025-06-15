using Microsoft.EntityFrameworkCore;
using OneDotLearnCore.Essential;
using OneDotLearnCore.People;
using OneDotLearnCore.Security;
using OneDotLearnData;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSeeder
{
    internal class InstructorSeeder
    {

        public InstructorSeeder()
        {
            Task.Run(async () =>
            {
                var rslt = await OdlDataHelper.Instance.Users.AddAsync(
                    new User()
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
                rslt = await OdlDataHelper.Instance.UsersProfiles.AddAsync(
                    new UserProfile()
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

                rslt = await OdlDataHelper.Instance.Instructors.AddAsync(
                    new Instructor()
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

                rslt = await OdlDataHelper.Instance.Experiences.AddRangeAsync(
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
            });
        }
    }
}
