using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace OneDotLearnData.Migrations
{
    /// <inheritdoc />
    public partial class OneDotLearnMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Training");

            migrationBuilder.EnsureSchema(
                name: "General");

            migrationBuilder.EnsureSchema(
                name: "Financials");

            migrationBuilder.EnsureSchema(
                name: "People");

            migrationBuilder.EnsureSchema(
                name: "Security");

            migrationBuilder.CreateTable(
                name: "AttanedanceSheet",
                schema: "Training",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CycleId = table.Column<int>(type: "integer", nullable: false),
                    TraineeId = table.Column<int>(type: "integer", nullable: false),
                    AttendedAt = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    CreatedById = table.Column<int>(type: "integer", nullable: false),
                    CreatedOn = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: false),
                    EntityStatus = table.Column<byte>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttanedanceSheet", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                schema: "General",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ArabicName = table.Column<string>(type: "character varying(75)", maxLength: 75, nullable: false),
                    LatinName = table.Column<string>(type: "character varying(75)", maxLength: 75, nullable: false),
                    Flag = table.Column<byte[]>(type: "bytea", nullable: true),
                    ItuCode = table.Column<short>(type: "smallint", nullable: false),
                    TimeZoneId = table.Column<string>(type: "text", nullable: false),
                    IsArabic = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedById = table.Column<int>(type: "integer", nullable: false),
                    CreatedOn = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: false),
                    EntityStatus = table.Column<byte>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                schema: "Training",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CategoryId = table.Column<int>(type: "integer", nullable: false),
                    ArabicTitle = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false),
                    LatinTitle = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false),
                    Code = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Duration = table.Column<byte>(type: "smallint", nullable: false),
                    Level = table.Column<byte>(type: "smallint", nullable: false),
                    Picture = table.Column<byte[]>(type: "bytea", nullable: true),
                    InstructorFeesShare = table.Column<byte>(type: "smallint", nullable: false),
                    FinancialAccountId = table.Column<int>(type: "integer", nullable: false),
                    Status = table.Column<byte>(type: "smallint", nullable: false),
                    CreatedById = table.Column<int>(type: "integer", nullable: false),
                    CreatedOn = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: false),
                    EntityStatus = table.Column<byte>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CoursesContents",
                schema: "Training",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CourseId = table.Column<int>(type: "integer", nullable: false),
                    Content = table.Column<string>(type: "text", nullable: false),
                    CreatedById = table.Column<int>(type: "integer", nullable: false),
                    CreatedOn = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: false),
                    EntityStatus = table.Column<byte>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoursesContents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Currencies",
                schema: "Financials",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CountryId = table.Column<int>(type: "integer", nullable: false),
                    ArabicName = table.Column<string>(type: "character varying(75)", maxLength: 75, nullable: true),
                    LatinName = table.Column<string>(type: "character varying(75)", maxLength: 75, nullable: false),
                    IsoCode = table.Column<string>(type: "character varying(3)", maxLength: 3, nullable: false),
                    ArabicSymbol = table.Column<string>(type: "character varying(5)", maxLength: 5, nullable: true),
                    LatinSymbol = table.Column<string>(type: "character varying(5)", maxLength: 5, nullable: false),
                    CreatedById = table.Column<int>(type: "integer", nullable: false),
                    CreatedOn = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: false),
                    EntityStatus = table.Column<byte>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Currencies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CurrenciesRates",
                schema: "Financials",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CurrencyId = table.Column<int>(type: "integer", nullable: false),
                    Rate = table.Column<float>(type: "real", nullable: false),
                    CreatedById = table.Column<int>(type: "integer", nullable: false),
                    CreatedOn = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: false),
                    EntityStatus = table.Column<byte>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CurrenciesRates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmailAddresses",
                schema: "General",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ContactDetailId = table.Column<int>(type: "integer", nullable: false),
                    Address = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: false),
                    IsBusiness = table.Column<bool>(type: "boolean", nullable: true),
                    CreatedById = table.Column<int>(type: "integer", nullable: false),
                    CreatedOn = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: false),
                    EntityStatus = table.Column<byte>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailAddresses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Enrolments",
                schema: "Training",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CourseId = table.Column<int>(type: "integer", nullable: false),
                    CycleId = table.Column<int>(type: "integer", nullable: false),
                    TraineeId = table.Column<int>(type: "integer", nullable: false),
                    CountryId = table.Column<int>(type: "integer", nullable: false),
                    CurrencyId = table.Column<int>(type: "integer", nullable: false),
                    Fees = table.Column<float>(type: "real", nullable: false),
                    PaymentMethod = table.Column<byte>(type: "smallint", nullable: false),
                    CashPaymentQrCode = table.Column<byte[]>(type: "bytea", nullable: true),
                    IsCancelled = table.Column<bool>(type: "boolean", nullable: true),
                    CancellationReason = table.Column<string>(type: "text", nullable: true),
                    CancelledOn = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    CreatedById = table.Column<int>(type: "integer", nullable: false),
                    CreatedOn = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: false),
                    EntityStatus = table.Column<byte>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enrolments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Experiences",
                schema: "People",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    EmployeeId = table.Column<int>(type: "integer", nullable: false),
                    JobId = table.Column<int>(type: "integer", nullable: true),
                    WorkPlaceId = table.Column<int>(type: "integer", nullable: true),
                    CategoryId = table.Column<int>(type: "integer", nullable: true),
                    FromDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    ToDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    Achievement = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    Notes = table.Column<string>(type: "text", nullable: true),
                    CreatedById = table.Column<int>(type: "integer", nullable: false),
                    CreatedOn = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: false),
                    EntityStatus = table.Column<byte>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Experiences", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Instructors",
                schema: "People",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    OtherFields = table.Column<string>(type: "text", nullable: true),
                    OtherCourses = table.Column<string>(type: "text", nullable: true),
                    FinancialAccountId = table.Column<int>(type: "integer", nullable: false),
                    CreatedById = table.Column<int>(type: "integer", nullable: false),
                    CreatedOn = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: false),
                    EntityStatus = table.Column<byte>(type: "smallint", nullable: false),
                    ArFirstName = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: false),
                    ArFatherName = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true),
                    ArGrandfatherName = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true),
                    ArFamilyName = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: false),
                    LtnFirstName = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: false),
                    LtnFatherName = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true),
                    LtnGrandfatherName = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true),
                    LtnFamilyName = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: false),
                    Gender = table.Column<byte>(type: "smallint", nullable: false),
                    BirthDate = table.Column<DateOnly>(type: "date", nullable: false),
                    IsArabic = table.Column<bool>(type: "boolean", nullable: false),
                    NationalityId = table.Column<short>(type: "smallint", nullable: true),
                    OtherNationality = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    ResidenceCountryId = table.Column<int>(type: "integer", nullable: false),
                    OtherResidenceCountry = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    EducationLevel = table.Column<byte>(type: "smallint", nullable: false),
                    AcademicSpecialization = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    AddressId = table.Column<int>(type: "integer", nullable: true),
                    ContactDetailsId = table.Column<int>(type: "integer", nullable: true),
                    UserId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instructors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductsDomains",
                schema: "Training",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ParentId = table.Column<int>(type: "integer", nullable: true),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    CreatedById = table.Column<int>(type: "integer", nullable: false),
                    CreatedOn = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: false),
                    EntityStatus = table.Column<byte>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductsDomains", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TelephoneNumbers",
                schema: "General",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ContactDetailId = table.Column<int>(type: "integer", nullable: false),
                    Number = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: false),
                    IsBusiness = table.Column<bool>(type: "boolean", nullable: true),
                    IsMobile = table.Column<bool>(type: "boolean", nullable: true),
                    CreatedById = table.Column<int>(type: "integer", nullable: false),
                    CreatedOn = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: false),
                    EntityStatus = table.Column<byte>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TelephoneNumbers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Trainees",
                schema: "Training",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    OtherInterests = table.Column<string>(type: "text", nullable: true),
                    FinancialAccountId = table.Column<int>(type: "integer", nullable: false),
                    CreatedById = table.Column<int>(type: "integer", nullable: false),
                    CreatedOn = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: false),
                    EntityStatus = table.Column<byte>(type: "smallint", nullable: false),
                    ArFirstName = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: false),
                    ArFatherName = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true),
                    ArGrandfatherName = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true),
                    ArFamilyName = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: false),
                    LtnFirstName = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: false),
                    LtnFatherName = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true),
                    LtnGrandfatherName = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true),
                    LtnFamilyName = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: false),
                    Gender = table.Column<byte>(type: "smallint", nullable: false),
                    BirthDate = table.Column<DateOnly>(type: "date", nullable: false),
                    IsArabic = table.Column<bool>(type: "boolean", nullable: false),
                    NationalityId = table.Column<short>(type: "smallint", nullable: true),
                    OtherNationality = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    ResidenceCountryId = table.Column<int>(type: "integer", nullable: false),
                    OtherResidenceCountry = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    EducationLevel = table.Column<byte>(type: "smallint", nullable: false),
                    AcademicSpecialization = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    AddressId = table.Column<int>(type: "integer", nullable: true),
                    ContactDetailsId = table.Column<int>(type: "integer", nullable: true),
                    UserId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trainees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                schema: "Security",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    LoginName = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: false),
                    FullName = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    HashedPassword = table.Column<string>(type: "text", nullable: false),
                    Role = table.Column<byte>(type: "smallint", nullable: false),
                    LastSignedInAt = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    CreatedById = table.Column<int>(type: "integer", nullable: false),
                    CreatedOn = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: false),
                    EntityStatus = table.Column<byte>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UsersProfiles",
                schema: "Security",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    FullName = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    ProgExperience = table.Column<byte>(type: "smallint", nullable: true),
                    ProgLanguages = table.Column<int>(type: "integer", nullable: true),
                    OtherProgLanguages = table.Column<string>(type: "text", nullable: true),
                    RdbmsLevel = table.Column<byte>(type: "smallint", nullable: true),
                    SWDevTechnologies = table.Column<int>(type: "integer", nullable: true),
                    OtherTechnologies = table.Column<string>(type: "text", nullable: true),
                    OtherInterests = table.Column<string>(type: "text", nullable: true),
                    CreatedById = table.Column<int>(type: "integer", nullable: false),
                    CreatedOn = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: false),
                    EntityStatus = table.Column<byte>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersProfiles", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AttanedanceSheet",
                schema: "Training");

            migrationBuilder.DropTable(
                name: "Countries",
                schema: "General");

            migrationBuilder.DropTable(
                name: "Courses",
                schema: "Training");

            migrationBuilder.DropTable(
                name: "CoursesContents",
                schema: "Training");

            migrationBuilder.DropTable(
                name: "Currencies",
                schema: "Financials");

            migrationBuilder.DropTable(
                name: "CurrenciesRates",
                schema: "Financials");

            migrationBuilder.DropTable(
                name: "EmailAddresses",
                schema: "General");

            migrationBuilder.DropTable(
                name: "Enrolments",
                schema: "Training");

            migrationBuilder.DropTable(
                name: "Experiences",
                schema: "People");

            migrationBuilder.DropTable(
                name: "Instructors",
                schema: "People");

            migrationBuilder.DropTable(
                name: "ProductsDomains",
                schema: "Training");

            migrationBuilder.DropTable(
                name: "TelephoneNumbers",
                schema: "General");

            migrationBuilder.DropTable(
                name: "Trainees",
                schema: "Training");

            migrationBuilder.DropTable(
                name: "Users",
                schema: "Security");

            migrationBuilder.DropTable(
                name: "UsersProfiles",
                schema: "Security");
        }
    }
}
