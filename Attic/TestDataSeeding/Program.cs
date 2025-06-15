// See https://aka.ms/new-console-template for more information
using OneDotLearnData.CoursesSeeding;
using System.Reflection.Emit;

Console.WriteLine("Hello, World!");

AddCourses();

static void AddCourses()
{
    SwDevCoursesPopulator.AddCourses(); 
    //WebDesignCoursesPopulator.AddCourses();
    //GraphicsCoursesPopulator.AddCourses(); DataScienceCoursesPopulator.AddCourses();
    //NetworkingCoursesPopulator.AddCourses(); CloudComputingCoursesPopulator.AddCourses();
    //SecurityCoursesPopulator.AddCourses(); AppliedComputingCoursesPopulator.AddCourses();
    //ManagementCoursesPopulator.AddCourses();

    //CoursesPopulator.StoreCourses(modelBuilder);
    //CoursesDetailsPopulator.StoreCoursesDetails(modelBuilder);
}
