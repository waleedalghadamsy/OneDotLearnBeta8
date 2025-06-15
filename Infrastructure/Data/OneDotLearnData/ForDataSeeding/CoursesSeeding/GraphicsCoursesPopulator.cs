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
    internal class GraphicsCoursesPopulator
    {
        internal static void AddCourses()
        {
            var datHelper = OdlDataHelper.Instance;
            var picsPath = datHelper.PicsPath;
            //var crsId = datHelper.CourseId;

            #region 15 PhotoShop Fundamentals - 18H - L 300 | E 850 | T 850 | A (60 + 57 + 51) / 3 ~ 53
            var crsId = 15;
            CoursesPopulator.AddCourse(new Course()
            {
                Id = crsId,
                Level = ProductLevel.Beginner,
                Code = "GR101",
                Duration = 18,
                ArabicTitle = "أساسيات فوتوشوب",
                LatinTitle = "PhotoShop Fundamentals",
                CategoryId = 7,
                Picture = System.IO.File.ReadAllBytes(@$"{picsPath}\Photoshop.png"),
                FinancialAccountId = 31,
                Status = ProductStatus.Proposed,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                EntityStatus = EntityStatus.Active,
            });
            CoursesDetailsPopulator.CoursesContents.Add(crsId, new List<string>
            {
                "PhotoShop workspace", "Toolbox", "Photo editor", "Image size & resolution",
                "Layers", "Color basics", "Image selection", "Image adjustment", "Camera Raw",
                "Resize and crop", "Image repair & restoration", "Image transformation",
                "Drawing & painting", "Working with text",  "Filters, effects & styles",
                "Working with files", "Printing", "Color management",  "Preparing images for web"
            });
            CoursesDetailsPopulator.CoursesFees.Add(crsId, new List<(int ctryId, float fees)>()
            {
                (datHelper.LibyaId, 300), (datHelper.EgyptId, 850), (datHelper.TurkeyId, 850), 
                (datHelper.AmericaId, 53)
            });
            #endregion

            #region 16 Adv. Graphic Design - 18H - L 350 | E 950 | T 950 | A (70 + 63 + 45) / 3 = 60
            crsId = 16;
            CoursesPopulator.AddCourse(new Course()
            {
                Id = crsId,
                Level = ProductLevel.Advanced,
                Code = "GR301",
                Duration = 18,
                ArabicTitle = "Advanced Graphic Design",
                LatinTitle = "Advanced Graphic Design",
                CategoryId = 7,
                Picture = System.IO.File.ReadAllBytes(@$"{picsPath}\Adv Graphic Design.png"),
                FinancialAccountId = 32,
                Status = ProductStatus.Proposed,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                EntityStatus = EntityStatus.Active,
            });
            CoursesDetailsPopulator.CoursesContents.Add(crsId, new List<string>
            {
                "Review of graphic design skills & tasks", "Different measurement systems",
                "Advanced selection techniques in PhotoShop", "PhotoShop Smart Objects",
                "PhotoShop Smart Filters", "Advanced layer management", "Make image sharper",
                "Remove unwanted objects from image", "Remove background", "Color correction",
                "Text effects", "Animated GIF", "PhotoShop automation", "Professional image printing",
                "Using PhotoShop for 3D"
            });
            CoursesDetailsPopulator.CoursesPrerequisites.Add(crsId, new List<string>()
                {
                    "Knowledge of PhotoShop essentials"
                });
            CoursesDetailsPopulator.CoursesFees.Add(crsId, new List<(int ctryId, float fees)>()
            {
                (datHelper.LibyaId, 350), (datHelper.EgyptId, 950), (datHelper.TurkeyId, 950), 
                (datHelper.AmericaId, 60)
            });
            #endregion

            #region 17 Anim. Fund. Us. Aft. Eff. - 18H - L 350 | E 950 | T 950 | A (70 + 63 + 45) / 3 ~ 60
            crsId = 17;
            CoursesPopulator.AddCourse(new Course()
            {
                Id = crsId,
                Level = ProductLevel.Beginner,
                Code = "GR102",
                Duration = 18,
                ArabicTitle = "أساسيات تحريك الرسوم باستخدام أدوبي أفتر إفكتس",
                LatinTitle = "Animation Fundamentals Using Adobe After Effects",
                CategoryId = 7,
                Picture = System.IO.File.ReadAllBytes(@$"{picsPath}\AfterEffects.png"),
                FinancialAccountId = 33,
                Status = ProductStatus.Proposed,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                EntityStatus = EntityStatus.Active,
            });
            CoursesDetailsPopulator.CoursesContents.Add(crsId, new List<string>
            {
                "After Effects user interface", "Animation techniques", "Layers", 
                "Modes, masks, & mattes",
                "Cameras and lights", "Text animation", "Effects & presets", "Color management",
                "Animation, keyframing & tracking",  "Drawing and painting", "Audio effects",
                "Importing and integration", "Exporting and rendering"
            });
            CoursesDetailsPopulator.CoursesFees.Add(crsId, new List<(int ctryId, float fees)>()
            {
                (datHelper.LibyaId, 350), (datHelper.EgyptId, 950), (datHelper.TurkeyId, 950), 
                (datHelper.AmericaId, 60)
            });
            #endregion
        }

        internal static int AddCourses(ModelBuilder modelBuilder, int cntStartId)
        {
            var datHelper = OdlDataHelper.Instance;
            var picsPath = datHelper.PicsPath;
            //var crsId = datHelper.CourseId;

            #region 15 PhotoShop Fundamentals - 18H - L 300 | E 850 | T 850 | A (60 + 57 + 51) / 3 ~ 53
            var crsId = 15;
            CoursesPopulator.AddCourse(new Course()
            {
                Id = crsId,
                Level = ProductLevel.Beginner,
                Code = "GR101",
                Duration = 18,
                ArabicTitle = "أساسيات فوتوشوب",
                LatinTitle = "PhotoShop Fundamentals",
                CategoryId = 7,
                Picture = System.IO.File.ReadAllBytes(@$"{picsPath}\Photoshop.png"),
                FinancialAccountId = 31,
                Status = ProductStatus.Proposed,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                EntityStatus = EntityStatus.Active,
            });
            CoursesDetailsPopulator.CoursesContents.Add(crsId, new List<string>
            {
                "PhotoShop workspace", "Toolbox", "Photo editor", "Image size & resolution",
                "Layers", "Color basics", "Image selection", "Image adjustment", "Camera Raw",
                "Resize and crop", "Image repair & restoration", "Image transformation",
                "Drawing & painting", "Working with text",  "Filters, effects & styles",
                "Working with files", "Printing", "Color management",  "Preparing images for web"
            });
            CoursesDetailsPopulator.CoursesFees.Add(crsId, new List<(int ctryId, float fees)>()
            {
                (datHelper.LibyaId, 300), (datHelper.EgyptId, 850), (datHelper.TurkeyId, 850),
                (datHelper.AmericaId, 53)
            });
            #endregion

            #region 16 Adv. Graphic Design - 18H - L 350 | E 950 | T 950 | A (70 + 63 + 45) / 3 = 60
            crsId = 16;
            CoursesPopulator.AddCourse(new Course()
            {
                Id = crsId,
                Level = ProductLevel.Advanced,
                Code = "GR301",
                Duration = 18,
                ArabicTitle = "Advanced Graphic Design",
                LatinTitle = "Advanced Graphic Design",
                CategoryId = 7,
                Picture = System.IO.File.ReadAllBytes(@$"{picsPath}\Adv Graphic Design.png"),
                FinancialAccountId = 32,
                Status = ProductStatus.Proposed,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                EntityStatus = EntityStatus.Active,
            });
            CoursesDetailsPopulator.CoursesContents.Add(crsId, new List<string>
            {
                "Review of graphic design skills & tasks", "Different measurement systems",
                "Advanced selection techniques in PhotoShop", "PhotoShop Smart Objects",
                "PhotoShop Smart Filters", "Advanced layer management", "Make image sharper",
                "Remove unwanted objects from image", "Remove background", "Color correction",
                "Text effects", "Animated GIF", "PhotoShop automation", "Professional image printing",
                "Using PhotoShop for 3D"
            });
            CoursesDetailsPopulator.CoursesPrerequisites.Add(crsId, new List<string>()
                {
                    "Knowledge of PhotoShop essentials"
                });
            CoursesDetailsPopulator.CoursesFees.Add(crsId, new List<(int ctryId, float fees)>()
            {
                (datHelper.LibyaId, 350), (datHelper.EgyptId, 950), (datHelper.TurkeyId, 950),
                (datHelper.AmericaId, 60)
            });
            #endregion

            #region 17 Anim. Fund. Us. Aft. Eff. - 18H - L 350 | E 950 | T 950 | A (70 + 63 + 45) / 3 ~ 60
            crsId = 17;
            CoursesPopulator.AddCourse(new Course()
            {
                Id = crsId,
                Level = ProductLevel.Beginner,
                Code = "GR102",
                Duration = 18,
                ArabicTitle = "أساسيات تحريك الرسوم باستخدام أدوبي أفتر إفكتس",
                LatinTitle = "Animation Fundamentals Using Adobe After Effects",
                CategoryId = 7,
                Picture = System.IO.File.ReadAllBytes(@$"{picsPath}\AfterEffects.png"),
                FinancialAccountId = 33,
                Status = ProductStatus.Proposed,
                CreatedById = 1,
                CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                EntityStatus = EntityStatus.Active,
            });
            CoursesDetailsPopulator.CoursesContents.Add(crsId, new List<string>
            {
                "After Effects user interface", "Animation techniques", "Layers",
                "Modes, masks, & mattes",
                "Cameras and lights", "Text animation", "Effects & presets", "Color management",
                "Animation, keyframing & tracking",  "Drawing and painting", "Audio effects",
                "Importing and integration", "Exporting and rendering"
            });
            CoursesDetailsPopulator.CoursesFees.Add(crsId, new List<(int ctryId, float fees)>()
            {
                (datHelper.LibyaId, 350), (datHelper.EgyptId, 950), (datHelper.TurkeyId, 950),
                (datHelper.AmericaId, 60)
            });
            #endregion

            return cntStartId;
        }
    }
}
