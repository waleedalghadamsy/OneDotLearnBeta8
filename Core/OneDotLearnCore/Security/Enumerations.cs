using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneDotLearnCore.Security
{
    public enum UserRole : byte
    {
        Administrator = 1,
        CustomerSupport,
        Instructor,
        Trainee,
        Blogger
    }
}
