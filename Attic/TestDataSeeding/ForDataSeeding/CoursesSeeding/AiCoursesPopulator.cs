﻿using Microsoft.EntityFrameworkCore;
using OneDotLearnCore.Essential;
using OneDotLearnCore.Training;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneDotLearnData.CoursesSeeding
{
    internal class AiCoursesPopulator
    {
        internal void AddCourses()
        {
            var datHelper = OdlDataHelper.Instance;
            var picsPath = datHelper.PicsPath;
            //var crsId = datHelper.CourseId;

            #region 22 Mach. Lear. Fund. - 24H - L 600 | E 1500 | T 1000 | A (120 + 100 + 59) / 3 ~ 95
            var crsId = 22;
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
                CreatedOn = DateTime.UtcNow,
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
