//using Microsoft.EntityFrameworkCore;
using OneDotLearnCore.Essential;
using OneDotLearnCore.Financials;
using OneDotLearnCore.Training;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneDotLearnData.CoursesSeeding
{
    internal class CourseDetailsPopulator
    {
        #region Data Members
        private static int lastCntId = 1, lastPreqId = 1, lastFeesId = 1, lastInstrId = 1;
        #endregion

        #region Constructors
        #endregion

        #region Properties
        //private static ModelBuilder ModelBuilder { get; set; }
        #endregion

        #region Methods
        private static void AddCourseContents(int crsId, List<string> contents)
        {
            //foreach (var cnt in contents)
            //    ModelBuilder.Entity<CourseContent>().HasData(new CourseContent()
            //    {
            //        Id = lastCntId++,
            //        CourseId = crsId,
            //        Content = cnt,
            //        CreatedById = 1,
            //        CreatedOn = DateTime.UtcNow,
            //        EntityStatus = EntityStatus.Active,
            //    });
        }

        private static void AddCoursePrerequisites(int crsId, List<string> prerequisites)
        {
            //foreach (var prereq in prerequisites)
            //    ModelBuilder.Entity<Prerequisite>().HasData(new Prerequisite()
            //    {
            //        Id = lastPreqId++,
            //        ProductId = crsId,
            //        ProductType = ProductType.Course,
            //        Detail = prereq,
            //        CreatedById = 1,
            //        CreatedOn = DateTime.UtcNow,
            //        EntityStatus = EntityStatus.Active
            //    });
        }

        private static void AddCourseFees(int crsId, List<(int ctryId, float fees)> crsFees)
        {
            //foreach (var cntrFees in crsFees)
            //    ModelBuilder.Entity<ProductFees>().HasData(new ProductFees()
            //    {
            //        Id = lastFeesId++,
            //        ProductType = ProductType.Course,
            //        ProductId = crsId,
            //        CurrencyId = cntrFees.ctryId,
            //        Fees = cntrFees.fees,
            //        CreatedById = 1,
            //        CreatedOn = DateTime.UtcNow,
            //        EntityStatus = EntityStatus.Active,
            //    });
        }

        private static void AddCourseInstructors(int crsId, List<int> instrsIds)
        {
            //foreach (var instrId in instrsIds)
            //    ModelBuilder.Entity<InstructorCourse>().HasData(new InstructorCourse()
            //    {
            //        Id = lastInstrId++,
            //        CourseId = crsId,
            //        InstructorId = instrId,
            //        CreatedById = 1,
            //        CreatedOn = DateTime.UtcNow,
            //        EntityStatus = EntityStatus.Active,
            //    });
        }
        #endregion
    }
}
