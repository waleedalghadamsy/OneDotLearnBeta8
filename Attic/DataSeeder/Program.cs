// See https://aka.ms/new-console-template for more information
using DataSeeder;
using OneDotLearnCore.Essential;
using OneDotLearnCore.Security;
using OneDotLearnData;

Console.WriteLine("Hello, World!");

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


//new InstructorSeeder();
//new CountriesSeeder();
//new CurrenciesSeeder();
//new TrainingDomainsSeeder();
//new CoursesSeeder();
