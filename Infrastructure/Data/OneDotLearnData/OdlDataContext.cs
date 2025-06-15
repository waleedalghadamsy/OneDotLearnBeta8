using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using OneDotLearnCore.Essential;
using OneDotLearnCore.Logging;
using OneDotLearnCore.Security;
using OneDotLearnCore.Training;
using OneDotLearnCore.Financials;
using OneDotLearnCore.People;
using OneDotLearnData.CoursesSeeding;
using OneDotLearnData.ForDataSeeding;
using OneDotLearnCore.Blog;

namespace OneDotLearnData
{
    public class OdlDataContext : DbContext
    {
        #region Data Members
        private bool isBuilt = false;
        #endregion

        #region Constructors
        public OdlDataContext() { } 
        public OdlDataContext(DbContextOptions<OdlDataContext> op) : base(op)
        {
        }
        #endregion

        #region Properties
        public DbSet<Country> Countries { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<CurrencyRate> CurrenciesRates { get; set; }
        //public DbSet<Account> Accounts { get; set; }
        //public DbSet<JournalEntry> Journal { get; set; }
        //public DbSet<Invoice> Invoices { get; set; }
        //public DbSet<PayablePayment> PayablePayments { get; set; }
        //public DbSet<ReceivablePayment> ReceivablePayments { get; set; }
        //public DbSet<Discount> Discounts { get; set; }
        public DbSet<Course> Courses { get; set; }
        //public DbSet<Package> Packages { get; set; }
        //public DbSet<Prerequisite> Prerequisites { get; set; }
        public DbSet<ProductDomain> Categories { get; set; }
        public DbSet<CourseContent> CoursesContents { get; set; }
        //public DbSet<PackageCourse> PackagesCourses { get; set; }
        //public DbSet<ProductFees> ProductsFees { get; set; }
        //public DbSet<CourseRequest> RequestedCourses { get; set; }
        //public DbSet<RequestAnswer> RequestsAnswers { get; set; }
        //public DbSet<Recruit> Recruits { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Trainee> Trainees { get; set; }
        //public DbSet<TraineeInterest> TraineesInterests { get; set; }
        //public DbSet<Cycle> ProductsCycles { get; set; }
        //public DbSet<InstructorCourse> InstructorsCourses { get; set; }
        //public DbSet<InstructorCycle> InstructorsCycles { get; set; }
        //public DbSet<CycleRequest> RequestedCycles { get; set; }
        public DbSet<Enrolment> Enrolments { get; set; }
        public DbSet<SessionAttendance> AttendanceSheet { get; set; }
        //public DbSet<AttendedCourse> AttendedCourses { get; set; }
        //public DbSet<FavouredCourse> FavouredCourses { get; set; }
        //public DbSet<StudyPlace> StudyPlaces { get; set; }
        //public DbSet<WorkPlace> WorkPlaces { get; set; }
        public DbSet<WorkExperience> Experiences { get; set; }
        //public DbSet<Article> Articles { get; set; }
        //public DbSet<Keyword> Keywords { get; set; }
        //public DbSet<Comment> Comments { get; set; }
        //public DbSet<ArticleKeyword> ArticlesKeywords { get; set; }
        //public DbSet<LikedArticle> LikedArticles { get; set; }
        //public DbSet<Notification> Notifications { get; set; }
        //public DbSet<Communication> ContactDetails { get; set; }
        public DbSet<EmailAddress> EmailAddresses { get; set; }
        public DbSet<TelephoneNumber> TelephoneNumbers { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserProfile> UsersProfiles { get; set; }
        //public DbSet<EntityEvaluation> Evaluations { get; set; }
        //public DbSet<EntityPicture> Pictures { get; set; }
        #endregion

        #region Methods
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(OdlDataHelper.Instance.ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //LoggerDataHelper.Instance.TempFileLog($"Checking isBuilt ({isBuilt})...");

            //CountriesPopulator.Add(modelBuilder);
            //CurrenciesPopulator.Add(modelBuilder);
            //FinAccountsPopulator.Add(modelBuilder);
            //AddUser(modelBuilder);
            //AddInstructor(modelBuilder);
            //AddDomains(modelBuilder);
            //AddCourses(modelBuilder);
        }

        private void AddUser(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(new User()
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
            modelBuilder.Entity<UserProfile>().HasData(new UserProfile()
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
        }

        private void AddInstructor(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Instructor>().HasData(new Instructor()
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
            modelBuilder.Entity<WorkExperience>().HasData(new WorkExperience()
            {
                Id = 1,
                EmployeeId = 1,
                Achievement = "In addition to nucl. eng., studied computer engineering in university",
                FromDate = new DateTime(1982,10, 1, 0, 0, 0, DateTimeKind.Utc),
                ToDate = new DateTime(1984, 6, 30, 0, 0, 0, DateTimeKind.Utc),
                EntityStatus = EntityStatus.Active,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff")
            });
            modelBuilder.Entity<WorkExperience>().HasData(new WorkExperience()
            {
                Id = 2,
                EmployeeId = 1,
                Achievement = "More than thirty years experience in software engineering with many prog. languages",
                FromDate = new DateTime(1990, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                ToDate = new DateTime(2020, 12, 31, 0, 0, 0, DateTimeKind.Utc),
                EntityStatus = EntityStatus.Active,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff")
            });
            modelBuilder.Entity<WorkExperience>().HasData(new WorkExperience()
            {
                Id = 3,
                EmployeeId = 1,
                Achievement = "Software team leader in Microsoft for a few years",
                FromDate = new DateTime(2009, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                ToDate = new DateTime(2011, 12, 31, 0, 0, 0, DateTimeKind.Utc),
                EntityStatus = EntityStatus.Active,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff")
            });
            modelBuilder.Entity<WorkExperience>().HasData(new WorkExperience()
            {
                Id = 4,
                EmployeeId = 1,
                Achievement = "Former instructors manager in YAT, the largest Egyptian training company",
                FromDate = new DateTime(2004, 3, 1, 0, 0, 0, DateTimeKind.Utc),
                ToDate = new DateTime(2008, 12, 31, 0, 0, 0, DateTimeKind.Utc),
                EntityStatus = EntityStatus.Active,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff")
            });
            modelBuilder.Entity<WorkExperience>().HasData(new WorkExperience()
            {
                Id = 5,
                EmployeeId = 1,
                Achievement = "Chief executive officer (CEO) in several workplaces",
                FromDate = new DateTime(2016, 6, 1, 0, 0, 0, DateTimeKind.Utc),
                ToDate = new DateTime(2019, 5, 31, 0, 0, 0, DateTimeKind.Utc),
                EntityStatus = EntityStatus.Active,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff")
            });
            modelBuilder.Entity<WorkExperience>().HasData(new WorkExperience()
            {
                Id = 6,
                EmployeeId = 1,
                Achievement = "Accomplished several huge SW systems (incl. the SW system of the Libyan Civil Registry)",
                FromDate = new DateTime(2009, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                ToDate = new DateTime(2017, 2, 28, 0, 0, 0, DateTimeKind.Utc),
                EntityStatus = EntityStatus.Active,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff")
            });
            modelBuilder.Entity<WorkExperience>().HasData(new WorkExperience()
            {
                Id = 7,
                EmployeeId = 1,
                Achievement = "Delivered many advanced training courses to hundreds of trainees in several IT fields",
                FromDate = new DateTime(2002, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                ToDate = new DateTime(2008, 12, 31, 0, 0, 0, DateTimeKind.Utc),
                EntityStatus = EntityStatus.Active,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff")
            });
            modelBuilder.Entity<WorkExperience>().HasData(new WorkExperience()
            {
                Id = 8,
                EmployeeId = 1,
                Achievement = "Published several scientific papers in the field of computer simulation of nuclear reactors",
                FromDate = new DateTime(1990, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                ToDate = new DateTime(1991, 10, 31, 0, 0, 0, DateTimeKind.Utc),
                EntityStatus = EntityStatus.Active,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff")
            });
        }

        private void AddDomains(ModelBuilder modelBuilder)
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
                    SubDomains = new ()
                    {
                        new ()    //Id 9
                        {
                            Id = catId++,
                            ParentId = 8,
                            Name = "Relational DB Management Systems",
                            SubDomains = new List<ProductDomain>()
                            {
                                new ()    //Id 10
                                {
                                    Id = catId++,
                                    ParentId = 9,
                                    Name = "Oracle DB Server",
                                    CreatedById = 1,
                                    CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                                    EntityStatus = EntityStatus.Active,
                                },
                                new ()    //Id 11
                                {
                                    Id = catId++,
                                    ParentId = 9,
                                    Name = "Microsoft SQL Server",
                                    CreatedById = 1,
                                    CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                                    EntityStatus = EntityStatus.Active,
                                }
                            },
                            CreatedById = 1,
                            CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                            EntityStatus = EntityStatus.Active,
                        },
                        new ()    //Id 12
                        {
                            Id = catId++,
                            ParentId = 8,
                            Name = "Non-Relational DB Management Systems",
                            SubDomains = new List<ProductDomain>()
                            {
                                new ()    //Id 13
                                {
                                    Id = catId++,
                                    ParentId = 12,
                                    Name = "Document Data Store",
                                    SubDomains = new List<ProductDomain>()
                                    {
                                        new ()    //Id 14
                                        {
                                            Id = catId++,
                                            ParentId = 13,
                                            Name = "Apache CouchDB",
                                            CreatedById = 1,
                                            CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                                            EntityStatus = EntityStatus.Active,
                                        },
                                        new ()    //Id 15
                                        {
                                            Id = catId++,
                                            ParentId = 13,
                                            Name = "Amazon DocumentDB",
                                            CreatedById = 1,
                                            CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                                            EntityStatus = EntityStatus.Active,
                                        },
                                        new ()    //Id 16
                                        {
                                            Id = catId++,
                                            ParentId = 13,
                                            Name = "Microsoft Cosmos DB",
                                            CreatedById = 1,
                                            CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                                            EntityStatus = EntityStatus.Active,
                                        },
                                        new ()    //Id 17
                                        {
                                            Id = catId++,
                                            ParentId = 13,
                                            Name = "MongoDB",
                                            CreatedById = 1,
                                            CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                                            EntityStatus = EntityStatus.Active,
                                        },
                                        new ()    //Id 18
                                        {
                                            Id = catId++,
                                            ParentId = 13,
                                            Name = "Couchbase",
                                            CreatedById = 1,
                                            CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                                            EntityStatus = EntityStatus.Active,
                                        },
                                    },
                                    CreatedById = 1,
                                    CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                                    EntityStatus = EntityStatus.Active,
                                },
                                new ()    //Id 19
                                {
                                    Id = catId++,
                                    ParentId = 12,
                                    Name = "Columnar Data Store",
                                    SubDomains = new ()
                                    {
                                        new ()    //Id 20
                                        {
                                            Id = catId++,
                                            ParentId = 19,
                                            Name = "Apache Cassandra",
                                            CreatedById = 1,
                                            CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                                            EntityStatus = EntityStatus.Active,
                                        },
                                        new ()    //Id 21
                                        {
                                            Id = catId++,
                                            ParentId = 19,
                                            Name = "Apache Hbase",
                                            CreatedById = 1,
                                            CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                                            EntityStatus = EntityStatus.Active,
                                        },
                                    },
                                    CreatedById = 1,
                                    CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                                    EntityStatus = EntityStatus.Active,
                                },
                                new ()    //Id 22
                                {
                                    Id = catId++,
                                    ParentId = 12,
                                    Name = "Key/Value Data Store",
                                    SubDomains = new ()
                                    {
                                        new ()    //Id 23
                                        {
                                            Id = catId++,
                                            ParentId = 22,
                                            Name = "Amazon DynamoDB",
                                            CreatedById = 1,
                                            CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                                            EntityStatus = EntityStatus.Active,
                                        },
                                        new ()    //Id 24
                                        {
                                            Id = catId++,
                                            ParentId = 22,
                                            Name = "Redis",
                                            CreatedById = 1,
                                            CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                                            EntityStatus = EntityStatus.Active,
                                        },
                                        new ()    //Id 25
                                        {
                                            Id = catId++,
                                            ParentId = 22,
                                            Name = "Oracle Berkeley DB",
                                            CreatedById = 1,
                                            CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                                            EntityStatus = EntityStatus.Active,
                                        },
                                    },
                                    CreatedById = 1,
                                    CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                                    EntityStatus = EntityStatus.Active,
                                },
                                new ()    //Id 26
                                {
                                    Id = catId++,
                                    ParentId = 12,
                                    Name = "Graph Data Store",
                                    CreatedById = 1,
                                    CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                                    EntityStatus = EntityStatus.Active,
                                },
                            },
                            CreatedById = 1,
                            CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                            EntityStatus = EntityStatus.Active,
                        },
                    },
                    CreatedById = 1,
                    CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                    EntityStatus = EntityStatus.Active,
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
                }, //Id 27
                new ()
                {
                    Id = catId++,
                    ParentId = null,
                    Name = "Artifical Intelligence",
                    SubDomains = new ()
                    {
                        new ()    //Id 29
                        {
                            Id = catId++,
                            ParentId = 28,
                            Name = "Natural Language Processing",
                            CreatedById = 1,
                            CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                            EntityStatus = EntityStatus.Active,
                        },
                        new ()    //Id 30
                        {
                            Id = catId++,
                            ParentId = 28,
                            Name = "Knowledge Representation",
                            CreatedById = 1,
                            CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                            EntityStatus = EntityStatus.Active,
                        },
                        new ()    //Id 31
                        {
                            Id = catId++,
                            ParentId = 28,
                            Name = "Automated Reasoning",
                            CreatedById = 1,
                            CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                            EntityStatus = EntityStatus.Active,
                        },
                        new ()    //Id 32
                        {
                            Id = catId++,
                            ParentId = 28,
                            Name = "Machine Learning",
                            CreatedById = 1,
                            CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                            EntityStatus = EntityStatus.Active,
                        },
                        new ()    //Id 33
                        {
                            Id = catId++,
                            ParentId = 28,
                            Name = "Computer Vision",
                            CreatedById = 1,
                            CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                            EntityStatus = EntityStatus.Active,
                        },
                        new ()    //Id 34
                        {
                            Id = catId++,
                            ParentId = 28,
                            Name = "Robotics",
                            CreatedById = 1,
                            CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                            EntityStatus = EntityStatus.Active,
                        },
                    },
                    CreatedById = 1,
                    CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                    EntityStatus = EntityStatus.Active,
                }, //Id 28
                new ()
                {
                    Id = catId++,
                    ParentId = null,
                    Name = "Network Administration",
                    SubDomains = new ()
                    {
                        new ()    //Id 36
                        {
                            Id = catId++,
                            ParentId = 35,
                            Name = "Cisco Routers",
                            CreatedById = 1,
                            CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                            EntityStatus = EntityStatus.Active,
                        },
                        new ()    //Id 37
                        {
                            Id = catId++,
                            ParentId = 35,
                            Name = "Linux Server",
                            CreatedById = 1,
                            CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                            EntityStatus = EntityStatus.Active,
                        },
                        new ()    //Id 38
                        {
                            Id = catId++,
                            ParentId = 35,
                            Name = "Windows Server",
                            CreatedById = 1,
                            CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                            EntityStatus = EntityStatus.Active,
                        },
                        new ()    //Id 39
                        {
                            Id = catId++,
                            ParentId = 35,
                            Name = "Unix",
                            CreatedById = 1,
                            CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                            EntityStatus = EntityStatus.Active,
                        }
                    },
                    CreatedById = 1,
                    CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                    EntityStatus = EntityStatus.Active,
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
                AddCategory(cat);

            void AddCategory(ProductDomain category)
            {
                modelBuilder.Entity<ProductDomain>().HasData(category);

                if (category.SubDomains != null && category.SubDomains.Any())
                    foreach (var subCat in category.SubDomains)
                        AddCategory(subCat);
            }
        }

        //09-12 14-17 19 - 22
        private void AddCourses(ModelBuilder modelBuilder)
        {
            var newCntStartId = SwDevCoursesPopulator.AddCourses(modelBuilder, 1);
            //newCntStartId = WebDesignCoursesPopulator.AddCourses(modelBuilder, newCntStartId);
            //newCntStartId = GraphicsCoursesPopulator.AddCourses(modelBuilder, newCntStartId);
            //newCntStartId = DataScienceCoursesPopulator.AddCourses(modelBuilder, newCntStartId);
            //newCntStartId = NetworkingCoursesPopulator.AddCourses(modelBuilder, newCntStartId);
            //newCntStartId = CloudComputingCoursesPopulator.AddCourses(modelBuilder, newCntStartId);
            //newCntStartId = SecurityCoursesPopulator.AddCourses(modelBuilder, newCntStartId);
            //newCntStartId = AppliedComputingCoursesPopulator.AddCourses(modelBuilder, newCntStartId);
            //newCntStartId = ManagementCoursesPopulator.AddCourses(modelBuilder, newCntStartId);

            //LoggerDataHelper.Instance.TempFileLog("Adding data to model...");

            //foreach (var course in CoursesPopulator.Courses)
            //    modelBuilder.Entity<Course>().HasData(course);

            //var cntCounter = 1;
            //foreach (var crsCnts in CoursesDetailsPopulator.CoursesContents)
            //    foreach (var crsCnt in crsCnts.Value)
            //        modelBuilder.Entity<CourseContent>().HasData(new CourseContent()
            //        {
            //            Id = cntCounter++,
            //            CourseId = crsCnts.Key,
            //            Content = crsCnt,
            //            CreatedById = 1,
            //            CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff") = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
            //            EntityStatus = EntityStatus.Active,
            //        });

            //var prereqCounter = 1;
            //foreach (var crsPrereqs in CoursesDetailsPopulator.CoursesPrerequisites)
            //    foreach (var crsPrereq in crsPrereqs.Value)
            //        modelBuilder.Entity<Prerequisite>().HasData(new Prerequisite()
            //        {
            //            Id = prereqCounter++,
            //            ProductId = crsPrereqs.Key,
            //            ProductType = ProductType.Course,
            //            Detail = crsPrereq,
            //            CreatedById = 1,
            //            CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff") = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
            //            EntityStatus = EntityStatus.Active
            //        });

            //var feesCounter = 1;
            //foreach (var crsFees in CoursesDetailsPopulator.CoursesFees)
            //    foreach (var cntrFees in crsFees.Value)
            //        modelBuilder.Entity<ProductFees>().HasData(new ProductFees()
            //        {
            //            Id = feesCounter++,
            //            ProductType = ProductType.Course,
            //            ProductId = crsFees.Key,
            //            CurrencyId = cntrFees.ctryId,
            //            Fees = cntrFees.fees,
            //            CreatedById = 1,
            //            CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff") = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
            //            EntityStatus = EntityStatus.Active,
            //        });

            //var instCounter = 1;
            //foreach (var crsInstrs in CoursesDetailsPopulator.CoursesInstructors)
            //    foreach (var crsInstr in crsInstrs.Value)
            //        modelBuilder.Entity<InstructorCourse>().HasData(new InstructorCourse()
            //        {
            //            Id = instCounter++,
            //            CourseId = crsInstrs.Key,
            //            InstructorId = crsInstr,
            //            CreatedById = 1,
            //            CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff") = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
            //            EntityStatus = EntityStatus.Active,
            //        });

            //CoursesPopulator.StoreCourses(modelBuilder);
            //CoursesDetailsPopulator.StoreCoursesDetails(modelBuilder);
        }
        #endregion
    }
}