using Microsoft.EntityFrameworkCore;
using OneDotLearnCore.Essential;
using OneDotLearnCore.Training;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneDotLearnData.CoursesSeeding
{
    internal class SecurityCoursesPopulator
    {
        internal static int AddCourses(ModelBuilder modelBuilder, int cntStartId)
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
                CategoryId = 44,
                Picture = System.IO.File.ReadAllBytes(@$"{picsPath}\Info Security 03.jpg"),
                FinancialAccountId = 40,
                Status = ProductStatus.Proposed,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                EntityStatus = EntityStatus.Active,
            });
            CoursesDetailsPopulator.CoursesContents.Add(crsId, new List<string>
            {
                "Threats & vulnerabilities", "Types of attacks", "Malware", "Viruses", 
                "Stalking & fraud", "Hacking techniques", "Social engineering", "Firewalls", 
                "Authentication & authorization", "Monitoring & auditing", "Encryption & cryptography", 
                "System security", "Software security", "Network security", "Network scanning", 
                "User security", "Information security compliance laws", "Digital forensics"
            });
            CoursesDetailsPopulator.CoursesFees.Add(crsId, new List<(int ctryId, float fees)>()
            {
                (datHelper.LibyaId, 350), (datHelper.EgyptId, 900), (datHelper.TurkeyId, 900), 
                (datHelper.AmericaId, 60)
            });
            #endregion

            return cntStartId;
        }
    }
}
