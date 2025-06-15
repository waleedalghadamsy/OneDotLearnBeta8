using OneDotLearnCore.Essential;
using OneDotLearnCore.Training;
using OneDotLearnData;

namespace WDataSeeder.Helpers
{
    public class AiCoursesPopulator
    {
        public AiCoursesPopulator()
        {
            
        }

        public void Populate()
        {
            var datHelper = OdlDataHelper.Instance;
            var picsPath = datHelper.PicsPath;
            var crsId = 1;// datHelper.CourseId;

            #region 111 Introduction to Prompt Engineering. - 10H - L 80 | E 800 | T 1000 | A 25
            crsId = 111;
            CoursesPopulator.AddCourse(new Course()
            {
                Id = crsId,
                Level = ProductLevel.Beginner,
                Code = "AI101",
                Duration = 10,
                ArabicTitle = "مدخل إلى هندسة التلقين",
                LatinTitle = "Introduction to Prompt Engineering",
                CategoryId = 32,
                Picture = System.IO.File.ReadAllBytes(@$"{picsPath}\Intro Prompt Eng.png"),
                FinancialAccountId = 38,
                Status = ProductStatus.Planned,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                EntityStatus = EntityStatus.Active,
            });

            CoursesDetailsPopulator.CoursesContents.Add(crsId, new List<string>
            {
                "Artificial Intelligence", "Why do we need AI?", "Brief history of AI", "Turing test", "AI branches",
                "Natural Language Processing (NLP)", "Machine Learning & Deep Leaning", "Large Language Models (LLMs)",
                "Fundamentals of Prompt Engineering", "Practices"
            });

            CoursesDetailsPopulator.CoursesFees.Add(crsId, new List<(int ctryId, float fees)>()
            {
                (datHelper.LibyaId, 80), (datHelper.EgyptId, 800), (datHelper.TurkeyId, 1000),
                (datHelper.AmericaId, 25)
            });
            #endregion

            #region 22 Mach. Lear. Fund. - 24H - L 400 | E 1500 | T 1000 | A (120 + 100 + 59) / 3 ~ 95
            crsId = 22;
            CoursesPopulator.AddCourse(new Course()
            {
                Id = crsId,
                Level = ProductLevel.Beginner,
                Code = "ML101",
                Duration = 24,
                ArabicTitle = "Machine Learning Fundamentals",
                LatinTitle = "Machine Learning Fundamentals",
                CategoryId = 32,
                Picture = System.IO.File.ReadAllBytes(@$"{picsPath}\Machine Learning.png"),
                FinancialAccountId = 38,
                Status = ProductStatus.Proposed,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                EntityStatus = EntityStatus.Active,
            });

            CoursesDetailsPopulator.CoursesContents.Add(crsId, new List<string>
            {
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
            {
                (datHelper.LibyaId, 600), (datHelper.EgyptId, 1500), (datHelper.TurkeyId, 1000),
                (datHelper.AmericaId, 95)
            });
            #endregion

        }
    }
}
