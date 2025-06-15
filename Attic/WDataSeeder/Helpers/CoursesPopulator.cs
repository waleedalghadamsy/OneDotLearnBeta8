using Microsoft.EntityFrameworkCore;
using OneDotLearnCore.Training;
using OneDotLearnData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WDataSeeder.Helpers
{
    internal class CoursesPopulator
    {
        //private OdlDataContext _dbCtx;
        private static int crsId;
        static CoursesPopulator()
        {
            Courses = new List<Course>();

            crsId = 1;
        }

        internal static List<Course> Courses { get; set; }

        internal static void AddCourse(Course course, List<string> contents)
        {
            //var method = new System.Diagnostics.StackFrame(1).GetMethod();
            //var methodContainer = method.DeclaringType;

        //    LoggerDataHelper.Instance.TempFileLog(
        //$"[Course] -- {course.Id}\t{course.LatinTitle} from {methodContainer.FullName}.{method.Name}");

            course.Id = crsId++;
            Courses.Add(course);
            CoursesDetailsPopulator.AddCourseContents(course.Id, contents);
        }

        internal static void StoreCourses(OdlDataContext dbCtx)
        {
            try
            {
                dbCtx.Courses.AddRange(Courses);

                dbCtx.SaveChanges();
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
