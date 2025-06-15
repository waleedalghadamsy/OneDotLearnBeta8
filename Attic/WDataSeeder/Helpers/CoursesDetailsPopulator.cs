using Microsoft.EntityFrameworkCore;
using OneDotLearnCore.Essential;
using OneDotLearnCore.Financials;
using OneDotLearnCore.Training;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WDataSeeder.Helpers
{
    internal class CoursesDetailsPopulator
    {
        #region Data Members
        private static int lastCntId = 1, lastPreqId = 1, lastFeesId = 1, lastInstrId = 1;
        #endregion

        #region Constructors
        static CoursesDetailsPopulator()
        {
            CoursesPrerequisites = new Dictionary<int, List<string>>();
            CoursesContents = new Dictionary<int, List<string>>();
            CoursesFees = new Dictionary<int, List<(int ctryId, float fees)>>();
            CoursesInstructors = new Dictionary<int, List<int>>();
        }
        #endregion

        #region Properties
        static private ModelBuilder ModelBuilder { get; set; }
        static internal Dictionary<int, List<string>> CoursesPrerequisites { get; set; }
        static internal Dictionary<int, List<string>> CoursesContents { get; set; }
        static internal Dictionary<int, List<(int ctryId, float fees)>> CoursesFees { get; set; }
        static internal Dictionary<int, List<int>> CoursesInstructors { get; set; }
        #endregion

        #region Methods
        internal static void AddCourseContents(int cId, List<string> contents)
        {
            //var method = new System.Diagnostics.StackFrame(1).GetMethod();
            //var methodContainer = method.DeclaringType;

            //LoggerDataHelper.Instance.TempFileLog(
            //                $"[Contents] -- {cId} from {methodContainer.FullName}.{method.Name}");

            CoursesContents.Add(cId, contents);
        }

        //internal static void AddCoursePrerequisites(int cId, List<string> prereqs)
        //{
        //    var method = new System.Diagnostics.StackFrame(1).GetMethod();
        //    var methodContainer = method.DeclaringType;

        //    LoggerDataHelper.Instance.TempFileLog(
        //                    $"[Prereqs] -- {cId} from {methodContainer.FullName}.{method.Name}");
        //}

        internal static void AddCourseFees(int cId, List<(int, float)> fees)
        {
            //var method = new System.Diagnostics.StackFrame(1).GetMethod();
            //var methodContainer = method.DeclaringType;

            //LoggerDataHelper.Instance.TempFileLog(
            //                $"[Fees] -- {cId} from {methodContainer.FullName}.{method.Name}");
        }

        internal static void AddCourseInstructors(int cId, List<int> instrs)
        {
        //    var method = new System.Diagnostics.StackFrame(1).GetMethod();
        //    var methodContainer = method.DeclaringType;

        //    LoggerDataHelper.Instance.TempFileLog(
        //                    $"[Instructors] -- {cId} from {methodContainer.FullName}.{method.Name}");
        }

        //internal static void StoreCoursesDetails(ModelBuilder mdlBldr)
        //{
        //    ModelBuilder = mdlBldr;

        //    StoreCoursesContents(); StoreCoursesPrerequisites(); StoreCoursesFees();
        //    StoreCoursesInstructors();
        //}

        private static void StoreCoursesContents()
        {
        //    var cntCounter = 1;

        //    foreach (var crsCnts in CoursesContents)
        //        foreach (var crsCnt in crsCnts.Value)
        //            ModelBuilder.Entity<CourseContent>().HasData(new CourseContent()
        //            {
        //                Id = cntCounter++,
        //                CourseId = crsCnts.Key,
        //                Content = crsCnt,
        //                CreatedById = 1,
        //                CreatedOn = DateTime.UtcNow,
        //                EntityStatus = EntityStatus.Active,
        //            });
        }

        //private static void StoreCoursesPrerequisites()
        //{
        //    var prereqCounter = 1;

        //    foreach (var crsPrereqs in CoursesPrerequisites)
        //        foreach (var crsPrereq in crsPrereqs.Value)
        //            ModelBuilder.Entity<Prerequisite>().HasData(new Prerequisite()
        //            {
        //                Id = prereqCounter++,
        //                ProductId = crsPrereqs.Key,
        //                ProductType = ProductType.Course,
        //                Detail = crsPrereq,
        //                CreatedById = 1,
        //                CreatedOn = DateTime.UtcNow,
        //                EntityStatus = EntityStatus.Active
        //            });
        //}

        private static void StoreCoursesFees()
        {
        //    var feesCounter = 1;

        //    foreach (var crsFees in CoursesFees)
        //        foreach (var cntrFees in crsFees.Value)
        //            ModelBuilder.Entity<ProductFees>().HasData(new ProductFees()
        //            {
        //                Id = feesCounter++,
        //                ProductType = ProductType.Course,
        //                ProductId = crsFees.Key,
        //                CurrencyId = cntrFees.ctryId,
        //                Fees = cntrFees.fees,
        //                CreatedById = 1,
        //                CreatedOn = DateTime.UtcNow,
        //                EntityStatus = EntityStatus.Active,
        //            });
        }

        //private static void StoreCoursesInstructors()
        //{
        //    var instCounter = 1;

        //    foreach (var crsInstrs in CoursesInstructors)
        //        foreach (var crsInstr in crsInstrs.Value)
        //            ModelBuilder.Entity<InstructorCourse>().HasData(new InstructorCourse()
        //            {
        //                Id = instCounter++,
        //                CourseId = crsInstrs.Key,
        //                InstructorId = crsInstr,
        //                CreatedById = 1,
        //                CreatedOn = DateTime.UtcNow,
        //                EntityStatus = EntityStatus.Active,
        //            });
        //}
        #endregion
    }
}
