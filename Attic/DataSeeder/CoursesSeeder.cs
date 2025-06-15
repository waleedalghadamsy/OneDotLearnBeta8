using OneDotLearnCore.Training;
using OneDotLearnData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSeeder
{
    internal class CoursesSeeder
    {
        public CoursesSeeder()
        {
            Task.Run(() => OdlDataHelper.Instance.Courses.AddRangeAsync(
                    new List<Course>(){
                        new Course(),
                    })
                );
        }
    }
}
