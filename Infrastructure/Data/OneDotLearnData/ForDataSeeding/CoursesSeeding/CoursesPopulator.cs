using Microsoft.EntityFrameworkCore;
using OneDotLearnCore.Training;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneDotLearnData.CoursesSeeding
{
    internal class CoursesPopulator
    {
        static CoursesPopulator()
        {
            Courses = new List<Course>();
        }

        internal static List<Course> Courses { get; set; }

        internal static void AddCourse(Course course)
        {
            //var method = new System.Diagnostics.StackFrame(1).GetMethod();
            //var methodContainer = method.DeclaringType;

        //    LoggerDataHelper.Instance.TempFileLog(
        //$"[Course] -- {course.Id}\t{course.LatinTitle} from {methodContainer.FullName}.{method.Name}");

            Courses.Add(course);
        }

        internal static void StoreCourses(ModelBuilder modelBuilder)
        {
            foreach (var course in Courses)
                modelBuilder.Entity<Course>().HasData(course);
        }
    }
}
