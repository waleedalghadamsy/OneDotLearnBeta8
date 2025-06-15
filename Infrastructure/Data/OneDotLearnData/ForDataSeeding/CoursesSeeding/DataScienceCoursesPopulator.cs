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
        internal static int AddCourses(ModelBuilder modelBuilder, int cntStartId)
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
                CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
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

            #region 29 Intro. to Data Science - 18H - L 250 | E 500 | T 500 | A (?? + ?? + ??) / 3 ~ ??
            crsId = 29;
            CoursesPopulator.AddCourse(new Course()
            {
                Id = crsId,
                Level = ProductLevel.Beginner,
                Code = "ML101",
                Duration = 24,
                ArabicTitle = "مدخل إلى علم البيانات",
                LatinTitle = "Introduction to Data Science",
                CategoryId = 32, //TODO: Set correctly
                Picture = System.IO.File.ReadAllBytes(@$"{picsPath}\Machine Learning.png"), //TODO: Change
                FinancialAccountId = 38, //TODO: Set correctly
                Status = ProductStatus.Proposed,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                EntityStatus = EntityStatus.Active,
            });

            CoursesDetailsPopulator.CoursesContents.Add(crsId, new List<string>
            {   //TODO: Correct
                "What is machine learning (ML)?", "What is artificial intelligence (AI)?",
                "Why do we need AI?", "Brief history of AI", "Turing test", "AI branches",
                "Famous AI applications", "ML life cycle", "Neural networks",
                "ML approaches (supervised, unsupervised, semi-supervised, reinforcement)",
                "ML algorithms", "Mathematics required for ML", "ML libraries", "Using public datasets",
                "Data collection & preparation", "ML and data science",  "Building ML model",
                "Feature engineering", "Famous ML applications", "Computer vision",
                "Natural language processing", "Personal (smart) assistant", "Sentiment analysis", "GPT3"
            });

            CoursesDetailsPopulator.CoursesFees.Add(crsId, new List<(int ctryId, float fees)>()
            { //TODO: Correct
                (datHelper.LibyaId, 600), (datHelper.EgyptId, 1500), (datHelper.TurkeyId, 1000),
                (datHelper.AmericaId, 95)
            });
            #endregion
            return cntStartId;
        }
    }
}
