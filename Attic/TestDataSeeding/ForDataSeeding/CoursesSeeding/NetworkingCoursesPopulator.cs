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
    internal class NetworkingCoursesPopulator
    {
        internal static void AddCourses()
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
                CategoryId = 35,
                Picture = System.IO.File.ReadAllBytes(@$"{picsPath}\Networking Fund 05.jpg"),
                FinancialAccountId = 39,
                Status = ProductStatus.Proposed,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow,
                EntityStatus = EntityStatus.Active,
            });
            CoursesDetailsPopulator.CoursesContents.Add(crsId, new List<string>
            {
                "What is network?", "Network topologies", "LAN, MAN, and WAN", "Network components",
                "Network communication technologies", "Wireless networks", "Network devices",
                "Network cables", "OSI model", "Network protocols", "Internet & TCP/IP",
                "More details about some internet protocols", "IPv4 & IPv6",
                "Windows Server, Unix, and Linux", "Web servers", "Email servers", "Cloud computing"
            });
            CoursesDetailsPopulator.CoursesFees.Add(crsId, new List<(int ctryId, float fees)>()
            {
                (datHelper.LibyaId, 450), (datHelper.EgyptId, 1200), (datHelper.TurkeyId, 1200), 
                (datHelper.AmericaId, 75)
            });
            #endregion
        }
    }
}
