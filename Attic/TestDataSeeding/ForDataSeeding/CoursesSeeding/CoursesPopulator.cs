//using Microsoft.EntityFrameworkCore;
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

        private static List<Course> Courses { get; set; }

        internal static void AddCourse(Course course)
        {
            //LoggerDataHelper.Instance.TempFileLog($"{course.Id}\t{course.LatinTitle}");

            Courses.Add(course);
        }

        //internal static void StoreCourses(ModelBuilder modelBuilder)
        //{
        //    foreach (var course in Courses)
        //        modelBuilder.Entity<Course>().HasData(course);
        //}
    }
}
