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
    internal class DataScienceCoursesPopulator
    {
        internal static void AddCourses()
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
                CategoryId = 11,
                Picture = System.IO.File.ReadAllBytes(@$"{picsPath}\Data Science with Python.png"),
                FinancialAccountId = 37,
                Status = ProductStatus.Proposed,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow,
                EntityStatus = EntityStatus.Active,
            });
            CoursesDetailsPopulator.CoursesContents.Add(crsId, new List<string>
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
    }
}
