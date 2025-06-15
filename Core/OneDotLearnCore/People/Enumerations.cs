using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneDotLearnCore.People
{
    public class StringifiedEnums
    {
        static StringifiedEnums()
        {
            ProgLangs = new Dictionary<ProgrammingLanguages, string>()
            {
                { ProgrammingLanguages.Python, "Python" },
                { ProgrammingLanguages.JavaScript, "JavaScript" },
                { ProgrammingLanguages.Java, "Java" },
                { ProgrammingLanguages.CPP, "C++" },
                { ProgrammingLanguages.C, "C" },
                { ProgrammingLanguages.CSh, "C#" },
                { ProgrammingLanguages.SQL, "SQL" },
                { ProgrammingLanguages.PHP, "PHP" },
                { ProgrammingLanguages.R, "R" },
                { ProgrammingLanguages.VisualBasic, "Visual Basic" },
                { ProgrammingLanguages.Go, "Go" },
                { ProgrammingLanguages.Assembly, "Assembly" },
                { ProgrammingLanguages.Swift, "Swift" },
                { ProgrammingLanguages.Matlab, "MATLAB" },
                { ProgrammingLanguages.Ruby, "Ruby" },
                { ProgrammingLanguages.Kotlin, "Kotlin" },
                { ProgrammingLanguages.Rust, "Rust" },
                { ProgrammingLanguages.Delphi, "Delphi" },
                { ProgrammingLanguages.Dart, "Dart" },
                { ProgrammingLanguages.Fortran, "Fortran" },
                { ProgrammingLanguages.Julia, "Julia" },
                { ProgrammingLanguages.Perl, "Perl" },
                { ProgrammingLanguages.ObjectiveC, "Objective C" },
                { ProgrammingLanguages.Scala, "Scala" }
            };

            EduLevels = new Dictionary<EducationLevel, string>()
            {
                { EducationLevel.PrepartorySchool, "Prep. school student (class 7 to 9)" },
                { EducationLevel.SecondarySchool, "Sec. school student (class 10 to 12)" },
                { EducationLevel.UniversityStudent, "University student" },
                { EducationLevel.BSc, "BSc" },
                { EducationLevel.InMaster, "Currently studying for master" },
                { EducationLevel.MSc, "MSc" },
                { EducationLevel.InDoctorate, "Currently studying for doctorate" },
                { EducationLevel.PhD, "PhD" }
            };

            SWDevTechs = new Dictionary<SWDevTechnologies, string>()
            {
                { SWDevTechnologies.WinForms, "Microsoft Windows Forms" },
                { SWDevTechnologies.WPF, "Microsoft Windows Presentation Foundation (WPF)" },
                { SWDevTechnologies.ASPNET, "Microsoft ASP.NET" },
                { SWDevTechnologies.ASPNETCore, "Microsoft ASP.NET Core" },
                { SWDevTechnologies.WebAPI, "Microsoft ASP.NET Web API" },
                { SWDevTechnologies.XML, "XML" },
                { SWDevTechnologies.Xamarin, "Microsoft Xamarin" },
                { SWDevTechnologies.JSP, "Java Server Pages (JSP)" },
                { SWDevTechnologies.JSF, "Java Server Faces (JSF)" },
                { SWDevTechnologies.jQuery, "jQuery" },
                { SWDevTechnologies.Flutter, "Google Flutter" },
                { SWDevTechnologies.NodeJS, "Node " },
                { SWDevTechnologies.Angular, "Angular" },
            };

            ExperienceLevels = new Dictionary<ExperienceLevel, string>()
            {
                { ExperienceLevel.Beginner, "Beginner (no experience)" },
                { ExperienceLevel.Novice, "Novice (1 to 2 years of experience)" },
                { ExperienceLevel.Intermediate, "Intermediate (3 to 5 years of experience)" },
                { ExperienceLevel.Advanced, "Advanced (5 to 10 years of experience)" },
                { ExperienceLevel.Expert, "Expert (10 to 20 years of experience)" },
                { ExperienceLevel.Guru, "Guru (more than 20 years of experience)" }
            };
        }

        public static Dictionary<ProgrammingLanguages, string> ProgLangs { get; set; }
        public static Dictionary<EducationLevel, string> EduLevels { get; set; }
        public static Dictionary<SWDevTechnologies, string> SWDevTechs { get; set; }
        public static Dictionary<ExperienceLevel, string> ExperienceLevels { get; set; }
    }

    [Flags]
    public enum WeekDays : byte
    {
        Saturday = 1, Sunday = 2, Monday = 4, Tuesday = 8, Wednesday = 16, Thursday = 32, Friday = 64
    }

    public enum EducationLevel : byte
    {
        PrepartorySchool = 1,
        SecondarySchool,
        UniversityStudent,
        BSc,
        InMaster,
        MSc,
        InDoctorate,
        PhD
    }

    public enum ExperienceLevel : byte
    {
        Beginner = 1,   //Zero years exp
        Novice,         //1 - 2 years exp
        Intermediate,   //3 - 5 years exp
        Advanced,       // > 5 years exp
        Expert,         // > 10 years exp
        Guru            // > 20 years exp
    }

    //Tb: https://www.tiobe.com/tiobe-index/
    //Sp: https://spectrum.ieee.org/top-programming-languages/ | https://spectrum.ieee.org/top-programming-languages-2021
    //Gt: https://trends.google.com/trends/explore
    //Py: https://pypl.github.io/PYPL.html
    //Rm: https://redmonk.com/sogrady/2021/08/05/language-rankings-6-21/
    //So: https://insights.stackoverflow.com/survey/2021
    //Bk: https://bootcamp.berkeley.edu/blog/most-in-demand-programming-languages/
    [Flags]
    public enum ProgrammingLanguages
    {
        None = 0,
        Python = 1,          //Tb: 1, So: 3, Sp: 1, Bk: 2, Py: 1, Gt: 1 -- Av.: 1
        JavaScript = 2,      //Tb: 7, So: 1, Sp: 5, Bk: 1, Py: 3, Gt: 3 -- Av.: 2
        Java = 4,             //Tb: 3, So: 5, Sp: 2, Bk: 5, Py: 2, Gt: 2 -- Av.: 3
        CPP = 8,                //Tb: 4, So: 10, Sp: 4, Py: 5, Gt: 4 -- Av.: 4
        C = 16,                  //Tb: 2, So: 12, Sp: 3, Py: 5, Gt: 7 -- Av.: 5
        CSh = 32,               //Tb: 5, So: 8, Sp: 6, Bk: 8, Py: 4, Gt: 6 -- Av.: 6
        SQL = 64,                    //Tb: 9, So: 4, Sp: 15, Py: NA, Gt: 5 -- Av.: 7
        PHP = 128,               //Tb: 10, So: 11, Sp: 13, Py: 6, Gt: 8 -- Av.: 9
        R = 256,                      //Tb: 15, So: 21, Sp: 7, Py: 7, Gt: 9 -- Av.: 10
        VisualBasic = 512,       //Tb: 6, So: NA, Sp: 22, Py: 18, Gt: 12 -- Av.: 11
        Go = 1024,              //Tb: 18, So: 14, Sp: 8, Bk: 11, Py: 13, Gt: 11 -- Av.: 12
        Assembly = 2048,               //Tb: 8, So: 19, Sp: 18, Py: NA, Gt: 14 -- Av.: 12
        Swift = 4096,            //Tb: 14, So: 20, Sp: 10, Py: 9, Gt: 13 -- Av.: 13
        Matlab = 8192,                 //Tb: 20, So: 23, Sp: 12, Py: 12, Gt: 10 -- Av.: 
        Ruby = 16384,           //Tb: 13, So: 17, Sp: 16, Py: 16, Gt: 18 -- Av.: 14
        Kotlin = 32768,          //Tb: 33, So: 15, Sp: 19, Py: 11, Gt: 16 -- Av.: 16
        Rust = 65536,           //Tb: 29, So: 16, Sp: 17, Bk: 9, Py: 15, Gt: 17 -- Av.: 17
        Delphi = 131072,        //Tb: 17, So: 29, Sp: 33, Py: NA, Gt: 25 -- Av.: 18
        Dart = 262144,           //Tb: 31, So: 18, Sp: 14, Py: 19, Gt: 21 -- Av.: 19
        Fortran = 524288,            //Tb: 19, So: NA, Sp: 25, Py: NA, Gt: 22 -- Av.: 
        Julia = 1048576,                  //Tb: 36, So: 33, Sp: 20, , Py: 22, Gt: 23 -- Av.: 22
        Perl = 2097152,                   //Tb: 16, So: 27, Sp: 35, Py: 26, Gt: 20 -- Av.: 20
        ObjectiveC = 4194304,       //Tb: 28, So: 25, Sp: 26, Py: 8, Gt: 24 -- Av.: 24
        Scala = 8388608,                  //Tb: 35, So: 26, Sp: 21, Py: 20, Gt: 19 -- Av.: 20
    }

    [Flags]
    public enum InfoTechTechnologies
    {
        None = 0,
        SWDevelopment = 1,
        DBAdministration = 2,
        NetworkAdministration = 4,
        GraphicDesign = 8,
        WebDesign = 16,

    }

    [Flags]
    public enum SWDevTechnologies
    {
        None = 0,
        WinForms = 1,
        WPF = 2,
        ASPNET = 4,
        ASPNETCore = 8,
        WebAPI = 16,
        XML = 32,
        XAML = 64,
        Xamarin = 128,
        JSP = 256,
        JSF = 512,
        jQuery = 1024,
        Flutter = 2048,
        NodeJS = 4096,
        Angular = 8192,
        React = 16384,
        Vue = 32768,
        EntFrmk = 65536,
        Hibernate = 131072,
        gRPC = 262144,
        REST = 524288,
        HTML = 1048576,
        CSS = 2097152,
        NoSQL = 4194304,
        Spring = 8388608,
        EJB = 16777216,
        SOAP = 33554432,
        ADONET = 67108864,
        LINQ = 134217728
    }
}
