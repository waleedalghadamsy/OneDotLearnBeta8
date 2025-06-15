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
    internal class ManagementCoursesPopulator
    {
        internal static void AddCourses()
        {
            var datHelper = OdlDataHelper.Instance;
            var picsPath = datHelper.PicsPath;
            //var crsId = datHelper.CourseId;

            #region 26 Start Your Small Business - 18H - L 400 | E 1000 | T 1000 | A (80 + 64 + 48) / 3 ~ 65
            var crsId = 26;
            CoursesPopulator.AddCourse(new Course()
            {
                Id = crsId,
                Level = ProductLevel.Beginner,
                Code = "BS101",
                Duration = 18,
                ArabicTitle = "ابدأ مشروعك التجاري الصغير",
                LatinTitle = "Start Your Small Business",
                CategoryId = 51,
                Picture = System.IO.File.ReadAllBytes(@$"{picsPath}\Start Your Business.png"),
                FinancialAccountId = 39,
                Status = ProductStatus.Proposed,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow,
                EntityStatus = EntityStatus.Active,
            });
            CoursesDetailsPopulator.CoursesContents.Add(crsId, new List<string>
            {
                "Small business, medium business, & large business", "Business owner characteristics",
                "Find an idea", "Business plan (feasibility study)", "Business strategy", "Funding",
                "Marketing & sales", "Work team (human resources)", "Finance and accounting",
                "Legalities", "Management & leadership", "Growing the business", "Useful online tools"
            });
            CoursesDetailsPopulator.CoursesFees.Add(crsId, new List<(int ctryId, float fees)>()
            {
                (datHelper.LibyaId, 400), (datHelper.EgyptId, 1000), (datHelper.TurkeyId, 1000), 
                (datHelper.AmericaId, 65)
            });
            CoursesDetailsPopulator.CoursesInstructors.Add(crsId, new List<int>() { 1 });
            #endregion
        }
    }
}
