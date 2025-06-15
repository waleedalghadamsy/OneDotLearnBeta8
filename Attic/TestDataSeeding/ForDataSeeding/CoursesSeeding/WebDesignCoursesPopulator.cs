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
    internal class WebDesignCoursesPopulator
    {
        internal static void AddCourses()
        {
            var datHelper = OdlDataHelper.Instance;
            var picsPath = datHelper.PicsPath;
            //var crsId = datHelper.CourseId;

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
                CategoryId = 6,
                Picture = System.IO.File.ReadAllBytes(@$"{picsPath}\Web Design.png"),
                FinancialAccountId = 34,
                Status = ProductStatus.Proposed,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow,
                EntityStatus = EntityStatus.Active,
            });
            CoursesDetailsPopulator.CoursesContents.Add(crsId, new List<string>
            {
                "What is the web?", "Web design vs web development", "HTML5",
                "Internet protocols (TCP/IP, HTTP, DNS, FTP, ...)", "Web domains", "Top Level Domains",
                "HTML elements and attributes", "Head, body, and footer", "Colors", "Fonts", "Tables",
                "Forms", "Images", "Media", "Favicon", "Element style", "Cascading Style Sheets (CSS)",
                "Bootstrap 5", "JavaScript basics", "jQuery", "Hosting & web servers"
            });
            CoursesDetailsPopulator.CoursesFees.Add(crsId, new List<(int ctryId, float fees)>()
            {
                (datHelper.LibyaId, 250), (datHelper.EgyptId, 800), (datHelper.TurkeyId, 800), 
                (datHelper.AmericaId, 45)
            });
            #endregion
        }
    }
}
