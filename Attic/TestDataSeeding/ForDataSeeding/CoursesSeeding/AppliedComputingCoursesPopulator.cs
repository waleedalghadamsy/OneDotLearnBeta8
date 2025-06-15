using Microsoft.EntityFrameworkCore;
using OneDotLearnCore.Essential;
using OneDotLearnCore.Training;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace OneDotLearnData.CoursesSeeding
{
    internal class AppliedComputingCoursesPopulator
    {
        internal static void AddCourses()
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
                CategoryId = 47,
                Picture = System.IO.File.ReadAllBytes(@$"{picsPath}\MatLab.png"),
                FinancialAccountId = 35,
                Status = ProductStatus.Proposed,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow,
                EntityStatus = EntityStatus.Active,
            });
            CoursesDetailsPopulator.CoursesContents.Add(crsId, new List<string>
            {
                "MATLAB desktop", "Simple calculations", "Operators", "Workspace variables",
                "Formatting functions", "Working with vectors and matrices", "Algebraic equations", 
                "Linear algebra", "Non-linear functions", "Statistical operations",
                "Calculus and differential equations", "Integration", "Polynomials", "Transforms",
                "Curve fitting", "2-D plotting", "3-D plotting", "Script files", 
                "Variables & Data types", "Relational operators", "Logical operators", 
                "Decision statements", "Loops"
            });
            CoursesDetailsPopulator.CoursesFees.Add(crsId, new List<(int ctryId, float fees)>()
            {
                (datHelper.LibyaId, 350), (datHelper.EgyptId, 950), (datHelper.TurkeyId, 950), 
                (datHelper.AmericaId, 60)
            });

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
                CategoryId = 46,
                Picture = System.IO.File.ReadAllBytes(@$"{picsPath}\AutoCAD.png"),
                FinancialAccountId = 36,
                Status = ProductStatus.Proposed,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow,
                EntityStatus = EntityStatus.Active,
            });
            CoursesDetailsPopulator.CoursesContents.Add(crsId, new List<string>
            {
                "What is CAD?", "AutoCAD user interface", "Basic drawing and editing",
                "Coordinate systems", "Drawing commands", "Drawing precision", "AutoCAD objects",
                "Making changes", "Modify commands", "View commands", "Layers", "Advanced object types",
                "Advanced editing", "Templates", "Text manipulation", "Hatching", "Dimensions"
            });
            CoursesDetailsPopulator.CoursesFees.Add(crsId, new List<(int ctryId, float fees)>()
            {
                (datHelper.LibyaId, 350), (datHelper.EgyptId, 950), (datHelper.TurkeyId, 950), 
                (datHelper.AmericaId, 60)
            });
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
                CategoryId = 51,
                Picture = System.IO.File.ReadAllBytes(@$"{picsPath}\IT Tech Supp.jpg"),
                FinancialAccountId = 41,
                Status = ProductStatus.Proposed,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow,
                EntityStatus = EntityStatus.Active,
            });
            CoursesDetailsPopulator.CoursesContents.Add(crsId, new List<string>
            {
                "Computer hardware", "Operating systems", "Windows, Unix, Linux, and MacOS",
                "Software concepts", "Software applications", "Computer networks", "Network protocols",
                "Network devices", "Internet and web", "Virtualization & cloud computing",
                "Mobile devices", "Information security", "Hardware troubleshooting",
                "Network troubleshooting", "Software troubleshooting"
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
