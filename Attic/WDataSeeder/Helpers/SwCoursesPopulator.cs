using OneDotLearnData;
using OneDotLearnCore.Training;
using Microsoft.EntityFrameworkCore;
using OneDotLearnCore.Essential;

namespace WDataSeeder.Helpers
{
    public class SwCoursesPopulator
    {
        private readonly OdlDataContext _context;
        private string picsPath = @"C:\Users\walee\source\repos\OneDotLearnBeta7\Presentation\Web\OneDotLearnWebApp\wwwroot\images";
        public SwCoursesPopulator(OdlDataContext context)
        {
            _context = context;
        }
        public void Populate()
        {
            var crsId = 1;
            if (_context.Courses.Any())
            {
                return; // DB has been seeded
            }

            #region Seeding courses
            var courses = new List<Course>
            {
                new Course
                {
                    Id = 1,
                    Level = ProductLevel.Beginner,
                    Code = "PG101",
                    Duration = 18,
                    ArabicTitle = "أساسيات البرمجة بلغة سي",
                    LatinTitle = "C Programming Fundamentals",
                    CategoryId = 1,
                    Picture = System.IO.File.ReadAllBytes(@$"{picsPath}\C Prog 02.png"),
                    FinancialAccountId = 17,
                    Status = ProductStatus.Proposed,
                    CreatedById = 1,
                    CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                    EntityStatus = EntityStatus.Active,
                },
                new Course
                {
                    Id = 2,
                    Level = ProductLevel.Beginner,
                    Code = "PG102",
                    Duration = 24,
                    ArabicTitle = "أساسيات البرمجة بلغة سي ++",
                    LatinTitle = "C++ Programming Fundamentals",
                    CategoryId = 1,
                    Picture = System.IO.File.ReadAllBytes(@$"{picsPath}\C++ Prog 01.png"),
                    FinancialAccountId = 18,
                    Status = ProductStatus.Proposed,
                    CreatedById = 1,
                    CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                    EntityStatus = EntityStatus.Active,
                },
                new Course
                {
                    Id = 3,
                    Level = ProductLevel.Beginner,
                    Code = "PG103",
                    Duration = 24,
                    ArabicTitle = "أساسيات لغة جافا 17 (لتطبيقات سطح المكتب)",
                    LatinTitle = "Java 17 Programming Fundamentals (Desktop)",
                    CategoryId = 2,
                    Picture = System.IO.File.ReadAllBytes(@$"{picsPath}\Java Prog 03.png"),
                    FinancialAccountId = 19,
                    Status = ProductStatus.Proposed,
                    CreatedById = 1,
                    CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                    EntityStatus = EntityStatus.Active,
                },
                new Course
                {
                    Id = 4,
                    Level = ProductLevel.Beginner,
                    Code = "PG103",
                    Duration = 24,
                    ArabicTitle = "أساسيات لغة بايثون 3 ",
                    LatinTitle = "Python 3 Programming Fundamentals",
                    CategoryId = 2,
                    Picture = System.IO.File.ReadAllBytes(@$"{picsPath}\Python Prog.png"),
                    FinancialAccountId = 19,
                    Status = ProductStatus.Proposed,
                    CreatedById = 1,
                    CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                    EntityStatus = EntityStatus.Active,
                },
                new Course
                {
                    Id = 5,
                    Level = ProductLevel.Advanced,
                    Code = "PG303",
                    Duration = 18,
                    ArabicTitle = "Advanced Java 17 Programming (Desktop)",
                    LatinTitle = "Advanced Java 17 Programming (Desktop)",
                    CategoryId = 2,
                    Picture = System.IO.File.ReadAllBytes(@$"{picsPath}\Adv Java Prog.png"),
                    FinancialAccountId = 20,
                    Status = ProductStatus.Proposed,
                    CreatedById = 1,
                    CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                    EntityStatus = EntityStatus.Active,
                },
                new Course
                {
                    Id = 6,
                    Level = ProductLevel.Beginner,
                    Code = "PG104",
                    Duration = 24,
                    ArabicTitle = "أساسيات لغة سي شارب 10 (لتطبيقات سطح المكتب)",
                    LatinTitle = "C# 10 Programming Fundamentals (Desktop)",
                    CategoryId = 2,
                    Picture = System.IO.File.ReadAllBytes(@$"{picsPath}\CSh Prog 02.png"),
                    FinancialAccountId = 21,
                    Status = ProductStatus.Proposed,
                    CreatedById = 1,
                    CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                    EntityStatus = EntityStatus.Active,
                },
                new Course
                {
                    Id = 7,
                    Level = ProductLevel.Advanced,
                    Code = "PG304",
                    Duration = 18,
                    ArabicTitle = "Advanced C# 10 Programming (Desktop)",
                    LatinTitle = "Advanced C# 10 Programming (Desktop)",
                    CategoryId = 2,
                    Picture = System.IO.File.ReadAllBytes(@$"{picsPath}\Adv CSh Prog.png"),
                    FinancialAccountId = 22,
                    Status = ProductStatus.Proposed,
                    CreatedById = 1,
                    CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                    EntityStatus = EntityStatus.Active,
                },
                new Course
                {
                    Id = 8,
                    Level = ProductLevel.Beginner,
                    Code = "PG105",
                    Duration = 30,
                    ArabicTitle = "مدخل إلى تطوير تطبيقات الويب باستخدام ميكروسوفت  بليزر ولغة سي شارب 12",
                    LatinTitle = "Introduction to Web Development Using Microsoft Blazor with C# 12",
                    CategoryId = 3,
                    Picture = System.IO.File.ReadAllBytes(@$"{picsPath}\ASP.NET Core 01.png"),
                    FinancialAccountId = 23,
                    Status = ProductStatus.Proposed,
                    CreatedById = 1,
                    CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                    EntityStatus = EntityStatus.Active,
                },
                new Course
                {
                    Id = 9,
                    Level = ProductLevel.Beginner,
                    Code = "PG105",
                    Duration = 30,
                    ArabicTitle = "تطوير تطبيقات الويب باستخدام إيه إس بي دوت نت 6 ولغة سي شارب 10",
                    LatinTitle = "Developing Web Applications Using ASP.NET Core 6 with C# 10",
                    CategoryId = 3,
                    Picture = System.IO.File.ReadAllBytes(@$"{picsPath}\ASP.NET Core 01.png"),
                    FinancialAccountId = 23,
                    Status = ProductStatus.Proposed,
                    CreatedById = 1,
                    CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                    EntityStatus = EntityStatus.Active,
                },
                new Course
                {
                    Id = 10,
                    Level = ProductLevel.Advanced,
                    Code = "PG305",
                    Duration = 18,
                    ArabicTitle = "Advanced Web Applications Development Using ASP.NET Core 6 with C# 10",
                    LatinTitle = "Advanced Web Applications Development Using ASP.NET Core 6 with C# 10",
                    CategoryId = 3,
                    Picture = System.IO.File.ReadAllBytes(@$"{picsPath}\Adv ASP.NET Core.png"),
                    FinancialAccountId = 24,
                    Status = ProductStatus.Proposed,
                    CreatedById = 1,
                    CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                    EntityStatus = EntityStatus.Active,
                },
                new Course
                {
                    Id = 11,
                    Level = ProductLevel.Beginner,
                    Code = "PG106",
                    Duration = 30,
                    ArabicTitle = "تطوير تطبيقات الويب باستخدلم لغة بي إتش بي 8",
                    LatinTitle = "Developing Web Applications Using PHP 8",
                    CategoryId = 3,
                    Picture = System.IO.File.ReadAllBytes(@$"{picsPath}\PHP Prog 01.png"),
                    FinancialAccountId = 25,
                    Status = ProductStatus.Proposed,
                    CreatedById = 1,
                    CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                    EntityStatus = EntityStatus.Active,
                },
                new Course
                {
                    Id = 12,
                    Level = ProductLevel.Beginner,
                    Code = "PG107",
                    Duration = 30,
                    ArabicTitle = "تطوير تطبيقات أندرويد باستخدام لغة جافا",
                    LatinTitle = "Developing Android Mobile Apps Using Java",
                    CategoryId = 4,
                    Picture = System.IO.File.ReadAllBytes(@$"{picsPath}\Android Java 01.png"),
                    FinancialAccountId = 26,
                    Status = ProductStatus.Proposed,
                    CreatedById = 1,
                    CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                    EntityStatus = EntityStatus.Active,
                },
                new Course
                {
                    Id = 13,
                    Level = ProductLevel.Advanced,
                    Code = "PG307",
                    Duration = 18,
                    ArabicTitle = "Advanced Android Mobile Apps Development Using Java",
                    LatinTitle = "Advanced Android Mobile Apps Development Using Java",
                    CategoryId = 4,
                    Picture = System.IO.File.ReadAllBytes(@$"{picsPath}\Adv Android Java.png"),
                    FinancialAccountId = 27,
                    Status = ProductStatus.Proposed,
                    CreatedById = 1,
                    CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                    EntityStatus = EntityStatus.Active,
                },
                new Course
                {
                    Id = 14,
                    Level = ProductLevel.Beginner,
                    Code = "PG108",
                    Duration = 30,
                    ArabicTitle = "تطوير تطبيقات أندرويد باستخدام زمارين فورمز بلغة سي شارب",
                    LatinTitle = "Developing Android Mobile Apps Using Xamarin Forms with C#",
                    CategoryId = 4,
                    Picture = System.IO.File.ReadAllBytes(@$"{picsPath}\Android Xamarin 01.png"),
                    FinancialAccountId = 28,
                    Status = ProductStatus.Proposed,
                    CreatedById = 1,
                    CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                    EntityStatus = EntityStatus.Active,
                },
                new Course
                {
                    Id = 15,
                    Level = ProductLevel.Advanced,
                    Code = "PG308",
                    Duration = 18,
                    ArabicTitle = "Advanced Android Mobile Apps Development Using Xamarin Forms with C#",
                    LatinTitle = "Advanced Android Mobile Apps Development Using Xamarin Forms with C#",
                    CategoryId = 4,
                    Picture = System.IO.File.ReadAllBytes(@$"{picsPath}\Adv Android Xamarin.png"),
                    FinancialAccountId = 29,
                    Status = ProductStatus.Proposed,
                    CreatedById = 1,
                    CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                    EntityStatus = EntityStatus.Active,
                },
                new Course
                {
                    Id = 16,
                    Level = ProductLevel.Advanced,
                    Code = "GM101",
                    Duration = 18,
                    ArabicTitle = "مدخل إلى برمجة الألعاب باستخدام يونيتي ولغة سي شارب",
                    LatinTitle = "Introduction to Games Programming Using Unity and C#",
                    CategoryId = 5,
                    Picture = System.IO.File.ReadAllBytes(@$"{picsPath}\Games Programming.png"),
                    FinancialAccountId = 30,
                    Status = ProductStatus.Proposed,
                    CreatedById = 1,
                    CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                    EntityStatus = EntityStatus.Active,
                }
            };

            _context.Courses.AddRange(courses);
            _context.SaveChanges();

            #endregion

            //});
            //CoursesDetailsPopulator.CoursesFees.Add(crsId, new List<(int ctryId, float fees)>()
            //{
            //    (datHelper.LibyaId, 200), (datHelper.EgyptId, 750), (datHelper.TurkeyId, 750),
            //            (datHelper.AmericaId, 40)
            //});
            //CoursesDetailsPopulator.CoursesInstructors.Add(crsId, new List<int>() { 1 });

            #region Seeding Courses Contents
            #endregion

            #region 01 C Programming - 18H - L 200 | E 750 | T 750 | A (40 + 50 + 35) / 3 = 40
            crsId = 2;
            var crsContents = new List<string>()
            {
                "C and Unix", "Importance of C", "High level languages, assembly, machine code",
                "main() function", "Hello, world", "Visual Studio Code",
                "Compiler and Linker", "Characters and strings", "printf() function", "Escape sequences",
                "Comments", "Variables and data types", "Operators and expressions",
                "Type conversion and casting", "Increment, decrement and compound assignment",
                "printf() argument specifiers", "Selection statements (if, else, switch)",
                "Iteration statements (while, do while, for)", "Arrays", "Pointers",
                "Command-line arguments", "String manipulation functions", "Header files",
                "Functions and return", "Data structures & algorithms", "File I/O",
                "The C Standard Library"
            };
            #endregion

            #region 02 C++ Programming - 24H - L 250 | E 800 | T 800 | A (50 + 53 + 38) / 3 ~ 45
            crsId = 2;
            
            crsContents = new List<string>()
            {
                "C++, C and Unix", "Importance of C++", "C++ versions",
                "High level languages, assembly, machine code",  "main() function", "Hello, world",
                "Visual Studio Code", "Compiler and Linker", "Characters and strings",
                "cout stream object", "Escape sequences", "Comments", "Variables and data types",
                "Operators and expressions", "Type conversion and casting",
                "Increment, decrement and compound assignment", "Output formatting using manipulators",
                "Selection statements (if, else, switch)", "Iteration statements (while, do while, for)",
                "Arrays", "Pointers and references", "Command-line arguments",
                "String manipulation functions", "Header files", "Functions and return", "File I/O",
                "The C++ Standard Library", "Object-oriented programming",
                "Classes and objects", "Encapsulation", "Method overloading", "Inheritance",
                "Polymorphism", "Data structures & algorithms"
            };
            foreach (var cnt in crsContents)
                modelBuilder.Entity<CourseContent>().HasData(new CourseContent()
                {
                    Id = cntStartId++,
                    CourseId = crsId,
                    Content = cnt,
                    CreatedById = 1,
                    CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                    EntityStatus = EntityStatus.Active,
                });
            //CoursesDetailsPopulator.CoursesContents.Add(crsId, new List<string>
            //{

            //});
            //CoursesDetailsPopulator.CoursesFees.Add(crsId, new List<(int ctryId, float fees)>()
            //{
            //    (datHelper.LibyaId, 250), (datHelper.EgyptId, 800), (datHelper.TurkeyId, 800),
            //    (datHelper.AmericaId, 45)
            //});
            //CoursesDetailsPopulator.CoursesInstructors.Add(crsId, new List<int>() { 1 });
            #endregion

            #region 03 Java Programming - 24H - L 300 | E 850 | T 850 | A (60 + 57 + 41) / 3 ~ 53
            crsId = 3;
            crsContents = new List<string>()
            {
                "Java features", "Different development tools",
                "Java compiler, runtime, virtual machine, and JDK",
                "Oracle JDK vs OpenJDK", "Hello, world", "The main() method",
                "System.out.println() method", "Command-line arguments", "Variables and data types",
                "Statements, expressions & operators", "Type conversion and casting",
                "Conditional/Decision statements (if, if else, switch)",
                "Increment, decrement and compound assignment", "Operator precedence",
                "Iteration statements (while, do while, for)", "Characters and strings", "Arrays",
                "Enhanced for loop", "Oracle Java documentation (Java Platform SE Doc)",
                "Graphical User Interface (GUI)", "Swing or JavaFX", "JFrame", "JLabel",
                "JTextField and JTextArea", "JButton and event listeners", "Methods and return",
                "JCheckBox and JRadioButton", "JList and JComboBox", "Layouts", "Mouse events",
                "Colors and JColorChooser", "Simple file handling with JFileChooser", "JavaFX overview",
                "Packages", "Object-oriented programming (OOP)",  "Classes and objects", "Collections",
                "Encapsulation", "Method overloading", "Inheritance", "Polymorphism",
                "Data structures & algorithms"
            };
            foreach (var cnt in crsContents)
                modelBuilder.Entity<CourseContent>().HasData(new CourseContent()
                {
                    Id = cntStartId++,
                    CourseId = crsId,
                    Content = cnt,
                    CreatedById = 1,
                    CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                    EntityStatus = EntityStatus.Active,
                });
            //CoursesDetailsPopulator.CoursesContents.Add(crsId, new List<string>
            //{

            //});
            //CoursesDetailsPopulator.CoursesFees.Add(crsId, new List<(int ctryId, float fees)>()
            //{
            //    (datHelper.LibyaId, 300), (datHelper.EgyptId, 850), (datHelper.TurkeyId, 850),
            //    (datHelper.AmericaId, 53)
            //});
            //CoursesDetailsPopulator.CoursesInstructors.Add(crsId, new List<int>() { 1 });
            #endregion

            #region 04 Python Programming - 18H - L 200 | E 750 | T 750 | A (40 + 50 + 35) / 3 = 40
            crsId = 4;
            crsContents = new List<string>() //TODO: Modify
            {

            };
            foreach (var cnt in crsContents)
                modelBuilder.Entity<CourseContent>().HasData(new CourseContent()
                {
                    Id = cntStartId++,
                    CourseId = crsId,
                    Content = cnt,
                    CreatedById = 1,
                    CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                    EntityStatus = EntityStatus.Active,
                });
            //CoursesDetailsPopulator.CoursesContents.Add(crsId, new List<string>
            //{

            //});
            //CoursesDetailsPopulator.CoursesFees.Add(crsId, new List<(int ctryId, float fees)>()
            //{
            //    (datHelper.LibyaId, 300), (datHelper.EgyptId, 850), (datHelper.TurkeyId, 850),
            //    (datHelper.AmericaId, 53)
            //});
            //CoursesDetailsPopulator.CoursesInstructors.Add(crsId, new List<int>() { 1 });
            #endregion

            #region 05 Adv. Java Programming - 18H - L 350 | E 950 | T 950 | A (70 + 63 + 45) / 3 ~ 60
            crsId = 5;
            crsContents = new List<string>()
            {
                "Exception handling", "Method overloading", "Abstract classes", "Method overriding",
                "Interfaces", "Generics", "Annotations", "Enums", "Switch expressions", "this & static",
                "Records", "String class methods", "Lambda expressions", "Streams", "Working with XML",
                "Working with JSON", "Multithreaded programming",  "Network programming",
                "Working with relational databases", "Java Archive (JAR)",
                "JProgressBar", "JTabbedPane", "JScrollBar", "JPanel", "JSlider", "JSpinner", "JTree",
                "JMenuBar", "JPopupMenu", "JavaFX FXML", "Scene builder", "JavaFX Label & TextField",
                "JavaFX Button", "JavaFX RadioButton & CheckBox", "JavaFX Layouts", "JavaFX 2D Shapes",
                "Java FX Effects", "JavaFX Animation"
            };
            foreach (var cnt in crsContents)
                modelBuilder.Entity<CourseContent>().HasData(new CourseContent()
                {
                    Id = cntStartId++,
                    CourseId = crsId,
                    Content = cnt,
                    CreatedById = 1,
                    CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                    EntityStatus = EntityStatus.Active,
                });
            //CoursesDetailsPopulator.CoursesContents.Add(crsId, new List<string>
            //{

            //});
            //CoursesDetailsPopulator.CoursesPrerequisites.Add(crsId,
            //    new List<string>() { "Knowledge of Java language essentials" });
            //CoursesDetailsPopulator.CoursesFees.Add(crsId, new List<(int ctryId, float fees)>()
            //{
            //    (datHelper.LibyaId, 350), (datHelper.EgyptId, 950), (datHelper.TurkeyId, 950),
            //    (datHelper.AmericaId, 60)
            //});
            //CoursesDetailsPopulator.CoursesInstructors.Add(crsId, new List<int>() { 1 });
            #endregion

            #region 06 C# Programming - 24H - L 300 | E 850 | T 850 | A (60 + 57 + 41) / 3 ~ 53
            crsId = 6;
            crsContents = new List<string>()
            {
                ".NET technologies",
                "C# origins and features (desktop, web, mobile, Mac, games, IoT, AI)",
                "Microsoft Visual Studio (IDE) or Visual Studio Code",
                "C# compiler, common lang. runtime, and .NET SDK", "Hello, world",
                "Main() method", "System.Console.WriteLine() method", "Command-line arguments",
                "Variables and data types", "Statements, expressions & operators", "Operator precedence",
                "Comments", "Conditional/Decision statements (if, if else, switch)",
                "Increment, decrement and compound assignment", "Operator precedence",
                "Iteration statements (while, do while, for)", "Characters and strings",
                "Arrays", "foreach loop", "DateTime, DateOnly, TimeOnly", "Microsoft documentation",
                "Graphical User Interface (GUI)", "Windows Forms, WPF and MAUI", "Window control",
                "XAML", "Button and event handling", "Methods and return", "Label and TextBlock",
                "Text input", "CheckBox and RadioButton", "Controls position & alignment", "GroupBox",
                "ListBox and ComboBox", "Colors and Brushes", "Mouse events", "Grid and StackPanel",
                "DatePicker and Calendar", "Simple file handling with SaveFileDialog & OpenFileDialog",
                "Assemblies and namespaces", "Object-oriented programming (OOP)", "Classes and objects",
                "Collections", "Encapsulation", "Method overloading", "Inheritance", "Polymorphism",
                "Data structures & algorithms"
            };
            foreach (var cnt in crsContents)
                modelBuilder.Entity<CourseContent>().HasData(new CourseContent()
                {
                    Id = cntStartId++,
                    CourseId = crsId,
                    Content = cnt,
                    CreatedById = 1,
                    CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                    EntityStatus = EntityStatus.Active,
                });
            //CoursesDetailsPopulator.CoursesContents.Add(crsId, new List<string>
            //{

            //});
            //CoursesDetailsPopulator.CoursesFees.Add(crsId, new List<(int ctryId, float fees)>()
            //{
            //    (datHelper.LibyaId, 300), (datHelper.EgyptId, 850), (datHelper.TurkeyId, 850),
            //    (datHelper.AmericaId, 53)
            //});
            //CoursesDetailsPopulator.CoursesInstructors.Add(crsId, new List<int>() { 1 });
            #endregion

            #region 07 Adv. C# Programming - 18H - L 350 | E 950 | T 950 | A (70 + 63 + 45) / 3 ~ 60
            crsId = 7;
            crsContents = new List<string>()
            {
                "String methods and operations", "is and as operators", "Bitwise operations",
                "typeof and sizeof operators", "switch pattern matching and expressions",
                "Exception handling", "Recursion", "Delegates", "Attributes", "Generics",
                "Abstract classes", "Interfaces", "LINQ and Lambda expressions", "Files and streams",
                ".NET asynchronous programming (tasks, async and await)",
                "Debugging using Visual Studio Debugger", "WPF TextBlock", "ListView",
                "DatePicker & Calendar", "Image control", "Keyboard events", "MediaElement control",
                "ScrollViewer", "Tab control", "ToolTip", "Ribbon control",  "User control",
                "Relational database systems and SQL", "Object-relational mapping using Entity Framework"
            };
            foreach (var cnt in crsContents)
                modelBuilder.Entity<CourseContent>().HasData(new CourseContent()
                {
                    Id = cntStartId++,
                    CourseId = crsId,
                    Content = cnt,
                    CreatedById = 1,
                    CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                    EntityStatus = EntityStatus.Active,
                });
            //CoursesDetailsPopulator.CoursesContents.Add(crsId, new List<string>
            //{

            //});
            //CoursesDetailsPopulator.CoursesPrerequisites.Add(crsId,
            //    new List<string>() { "Knowledge of C# language essentials" });
            //CoursesDetailsPopulator.CoursesFees.Add(crsId, new List<(int ctryId, float fees)>()
            //{
            //    (datHelper.LibyaId, 350), (datHelper.EgyptId, 950), (datHelper.TurkeyId, 950),
            //    (datHelper.AmericaId, 60)
            //});
            //CoursesDetailsPopulator.CoursesInstructors.Add(crsId, new List<int>() { 1 });
            #endregion

            #region 08 Intro to Web Dev C# - 18H - L 350 | E 950 | T 950 | A (70 + 63 + 45) / 3 = 60
            crsId = 8;
            crsContents = new List<string>() //TODO: Modify
            {
                ".NET technologies", "Internet and Web", "Web development technologies",
                "Internet protocols (TCP/IP, HTTP, DNS, FTP, ...)", "Web domains", "Top Level Domains",
                "Features of ASP.NET Core",
                "C# origins & features (desktop, web, mobile, Mac, games, IoT, AI)",
                "Microsoft Visual Studio (IDE) or Visual Studio Code",
                "C# compiler, Common Language Runtime (CLR), and .NET SDK",
                "ASP.NET Core SDK and runtime", "First ASP.NET Core web application",
                "Hosting & web servers",  "Variables and data types",
                "Statements, expressions and operators", "Operator precedence", "Comments",
                "Conditional/Decision statements (if, if else, switch)",
                "Increment, decrement and compound assignment", "Operator precedence",
                "Iteration statements (while, do while, for)", "Characters and strings", "Arrays",
                "foreach loop", "DateTime, DateOnly, TimeOnly", "Microsoft documentation",
                "String methods", "Razor Pages and MVC",
                "Project structure of ASP.NET Core Razor Pages application", "Program class",
                "Razor page layout","HTML elements", "HTTP verbs", "HTML forms", "Razor model binding",
                "Using CSS to enhance the user interface", "JavaScript essentials",
                "JSON, jQuery, XML, and AJAX", "Session handling",  "Object-oriented programming",
                "Classes and objects", "Encapsulation", "Inheritance", "Polymorphism",
                "Data structures & algorithms", "Working with database", "Relational database concepts",
                "SQL statements", "Object-relational mapping", "Introduction to Entity Framework"
            };
            foreach (var cnt in crsContents)
                modelBuilder.Entity<CourseContent>().HasData(new CourseContent()
                {
                    Id = cntStartId++,
                    CourseId = crsId,
                    Content = cnt,
                    CreatedById = 1,
                    CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                    EntityStatus = EntityStatus.Active,
                });
            //CoursesDetailsPopulator.CoursesContents.Add(crsId, new List<string>
            //{

            //});
            //CoursesDetailsPopulator.CoursesFees.Add(crsId, new List<(int ctryId, float fees)>()
            //{
            //    (datHelper.LibyaId, 500), (datHelper.EgyptId, 1300), (datHelper.TurkeyId, 1300),
            //    (datHelper.AmericaId, 80)
            //});
            //CoursesDetailsPopulator.CoursesInstructors.Add(crsId, new List<int>() { 1 });
            #endregion

            #region 09 Web Apps C# - 30H - L 500 | E 1300 | T 1300 | A (100 + 87 + 52) / 3 = 80
            crsId = 9;
            crsContents = new List<string>()
            {
                ".NET technologies", "Internet and Web", "Web development technologies",
                "Internet protocols (TCP/IP, HTTP, DNS, FTP, ...)", "Web domains", "Top Level Domains",
                "Features of ASP.NET Core",
                "C# origins & features (desktop, web, mobile, Mac, games, IoT, AI)",
                "Microsoft Visual Studio (IDE) or Visual Studio Code",
                "C# compiler, Common Language Runtime (CLR), and .NET SDK",
                "ASP.NET Core SDK and runtime", "First ASP.NET Core web application",
                "Hosting & web servers",  "Variables and data types",
                "Statements, expressions and operators", "Operator precedence", "Comments",
                "Conditional/Decision statements (if, if else, switch)",
                "Increment, decrement and compound assignment", "Operator precedence",
                "Iteration statements (while, do while, for)", "Characters and strings", "Arrays",
                "foreach loop", "DateTime, DateOnly, TimeOnly", "Microsoft documentation",
                "String methods", "Razor Pages and MVC",
                "Project structure of ASP.NET Core Razor Pages application", "Program class",
                "Razor page layout","HTML elements", "HTTP verbs", "HTML forms", "Razor model binding",
                "Using CSS to enhance the user interface", "JavaScript essentials",
                "JSON, jQuery, XML, and AJAX", "Session handling",  "Object-oriented programming",
                "Classes and objects", "Encapsulation", "Inheritance", "Polymorphism",
                "Data structures & algorithms", "Working with database", "Relational database concepts",
                "SQL statements", "Object-relational mapping", "Introduction to Entity Framework"
            };
            foreach (var cnt in crsContents)
                modelBuilder.Entity<CourseContent>().HasData(new CourseContent()
                {
                    Id = cntStartId++,
                    CourseId = crsId,
                    Content = cnt,
                    CreatedById = 1,
                    CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                    EntityStatus = EntityStatus.Active,
                });
            //CoursesDetailsPopulator.CoursesContents.Add(crsId, new List<string>
            //{

            //});
            //CoursesDetailsPopulator.CoursesFees.Add(crsId, new List<(int ctryId, float fees)>()
            //{
            //    (datHelper.LibyaId, 500), (datHelper.EgyptId, 1300), (datHelper.TurkeyId, 1300),
            //    (datHelper.AmericaId, 80)
            //});
            //CoursesDetailsPopulator.CoursesInstructors.Add(crsId, new List<int>() { 1 });
            #endregion

            #region 10 Adv. Web Apps C# - 18H - L 400 | E 1000 | T 1000 | A (80 + 64 + 48) / 3 = 65
            crsId = 10;
            crsContents = new List<string>()
            {
                "String methods and operations", "is and as operators", "Bitwise operations",
                "typeof and sizeof operators", "switch pattern matching and expressions",
                "Exception handling", "Recursion", "Delegates", "Attributes", "Generics",
                "Abstract classes", "Interfaces", "LINQ and Lambda expressions", "Files and streams",
                ".NET asynchronous programming (tasks, async and await)",
                "Debugging using Visual Studio Debugger", "Configuration", "Routing", "Tag helpers",
                "Partial views", "Using Bootstrap for better HTML page design", "Cookies", "Caching",
                "Dependency injection", "Authentication & authorization", "ASP.NET Core Web APIs (REST)",
                "gRPC services"
            };
            foreach (var cnt in crsContents)
                modelBuilder.Entity<CourseContent>().HasData(new CourseContent()
                {
                    Id = cntStartId++,
                    CourseId = crsId,
                    Content = cnt,
                    CreatedById = 1,
                    CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                    EntityStatus = EntityStatus.Active,
                });
            //CoursesDetailsPopulator.CoursesContents.Add(crsId, new List<string>
            //{

            //});
            //CoursesDetailsPopulator.CoursesPrerequisites.Add(crsId, new List<string>()
            //    {
            //        "Knowledge of C# language essentials", "Knowledge of ASP.NET Core essentials"
            //    });
            //CoursesDetailsPopulator.CoursesFees.Add(crsId, new List<(int ctryId, float fees)>()
            //{
            //    (datHelper.LibyaId, 400), (datHelper.EgyptId, 1000), (datHelper.TurkeyId, 1000),
            //    (datHelper.AmericaId, 65)
            //});
            //CoursesDetailsPopulator.CoursesInstructors.Add(crsId, new List<int>() { 1 });
            #endregion

            #region 11 Web Apps PHP - 30H - L 500 | E 1300 | T 1300 | A (100 + 87 + 52) / 3 = 80
            crsId = 11;
            crsContents = new List<string>()
            {
                "Internet and Web", "Web development technologies",
                "Internet protocols (TCP/IP, HTTP, DNS, FTP, ...)", "Web domains", "Top Level Domains",
                "PHP features", "Installation", "Visual Studio Code", "First PHP web application",
                "Hosting & web servers",  "echo function", "Variables and data types",
                "Operators and expressions", "Increment, decrement, and compound statements",
                "Conditional/Decision statements (if, else, elseif, switch)",
                "Iteration statements (for, while, do while)", "Arrays", "Functions and return",
                "String functions", "HTML elements", "Using CSS to enhance the user interface",
                "JavaScript Essentials", "JSON, jQuery, AJAX, XML", "HTTP verbs",
                "HTML forms", "Time and date functions", "Session handling", "include and require",
                "Object-oriented programming", "Classes and objects", "Encapsulation",
                "Function overloading", "Inheritance", "Polymorphism", "Data structures & algorithms",
                "Working with database", "Relational database concepts", "NoSQL databases",
                "SQL statements", "Object-relational mapping", "Using frameworks",
                "Brief introduction to Laravel framework"
            };
            foreach (var cnt in crsContents)
                modelBuilder.Entity<CourseContent>().HasData(new CourseContent()
                {
                    Id = cntStartId++,
                    CourseId = crsId,
                    Content = cnt,
                    CreatedById = 1,
                    CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                    EntityStatus = EntityStatus.Active,
                });
            //CoursesDetailsPopulator.CoursesContents.Add(crsId, new List<string>
            //{

            //});
            //CoursesDetailsPopulator.CoursesFees.Add(crsId, new List<(int ctryId, float fees)>()
            //{
            //    (datHelper.LibyaId, 500), (datHelper.EgyptId, 1300), (datHelper.TurkeyId, 1300),
            //    (datHelper.AmericaId, 80)
            //});
            //CoursesDetailsPopulator.CoursesInstructors.Add(crsId, new List<int>() { 1 });
            #endregion

            #region 12 Android Apps Using Java - 30H - L 600 | E 1500 | T 1500 | A (120 + 100 + 59) / 3 ~ 95
            crsId = 12;
            crsContents = new List<string>()
            {
                "Android OS history and architecture", "Android versions", "Other Android dialects",
                "Android vs iOS", "Java language features",
                "Java compiler, runtime, virtual machine, and JDK", "Oracle JDK vs OpenJDK",
                "Hello, world", "Android app project structure",
                "Android SDK tools, platform tools and API levels",
                "Java variables and data types", "Statements, expressions & operators",
                "Type conversion and casting", "Decision statements (if, if else, switch)",
                "Increment, decrement and compound assignment", "Operator precedence",
                "Iteration statements (while, do while, for)", "Characters and strings",
                "Arrays", "Enhanced for loop", "Oracle Java documentation (Java Platform SE Doc)",
                "Android documentation", "Testing app on mobile", "Android app components",
                "Manifest file", "Activities", "EditText widget -- one line or more",
                "TextView widget", "Button and event listeners", "CheckBox",
                "RadioButton and RadioGroup", "Layouts",
                "DatePicker, DatePickerDialog, CalendarView, TimePicker, and TimePickerDialog",
                "Colors", "Starting activities using intent", "App icon", "App resources", "Packages",
                "Object-oriented programming", "Classes and objects", "Encapsulation",
                "Method overloading", "Inheritance", "Polymorphism", "Data structures & algorithms",
                "Kotlin language", "Flutter framework and Dart language"
            };
            foreach (var cnt in crsContents)
                modelBuilder.Entity<CourseContent>().HasData(new CourseContent()
                {
                    Id = cntStartId++,
                    CourseId = crsId,
                    Content = cnt,
                    CreatedById = 1,
                    CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                    EntityStatus = EntityStatus.Active,
                });
            //CoursesDetailsPopulator.CoursesContents.Add(crsId, new List<string>
            //{

            //});
            //CoursesDetailsPopulator.CoursesFees.Add(crsId, new List<(int ctryId, float fees)>()
            //{
            //    (datHelper.LibyaId, 600), (datHelper.EgyptId, 1500), (datHelper.TurkeyId, 1500),
            //    (datHelper.AmericaId, 95)
            //});
            //CoursesDetailsPopulator.CoursesInstructors.Add(crsId, new List<int>() { 1 });
            #endregion

            #region 13 Adv. Andr. Apps Us. Java - 18H - L 450 | E 1200 | T 1200 | A (90 + 76 + 50) / 3 ~ 75
            crsId = 13;
            crsContents = new List<string>()
            {
                "Exception handling", "Method overloading", "Abstract classes", "Method overriding",
                "Interfaces", "this & static", "Collections & Generics", "Annotations",
                "Lambda expressions", "Multithreaded programming", "Streams", "Working with XML",
                "Working with JSON", "Java Archive (JAR)", "Resources", "Intent filters",
                "Broadcast receivers", "Content providers", "Fragments", "Styles and themes",
                "Alert dialogs", "Camera", "Phone calls", "Sending SMS", "Sending email", "Sensors",
                "Location & mapping", "Consume REST service"
            };
            foreach (var cnt in crsContents)
                modelBuilder.Entity<CourseContent>().HasData(new CourseContent()
                {
                    Id = cntStartId++,
                    CourseId = crsId,
                    Content = cnt,
                    CreatedById = 1,
                    CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                    EntityStatus = EntityStatus.Active,
                });
            //CoursesDetailsPopulator.CoursesContents.Add(crsId, new List<string>
            //{

            //});
            //CoursesDetailsPopulator.CoursesPrerequisites.Add(crsId, new List<string>()
            //    {
            //        "Knowledge of Java language essentials",
            //        "Knowledge of Android programming essentials"
            //    });
            //CoursesDetailsPopulator.CoursesFees.Add(crsId, new List<(int ctryId, float fees)>()
            //{
            //    (datHelper.LibyaId, 450), (datHelper.EgyptId, 1200), (datHelper.TurkeyId, 1200),
            //    (datHelper.AmericaId, 75)
            //});
            //CoursesDetailsPopulator.CoursesInstructors.Add(crsId, new List<int>() { 1 });
            #endregion

            #region 14 Android Apps Us. Xam. - 30H - L 600 | E 1500 | T 1500 | A (120 + 100 + 59) / 3 ~ 95
            crsId = 14;
            crsContents = new List<string>()
            {
                "Android OS history and architecture", "Android versions", "Other Android dialects",
                "Android vs iOS", "Xamarin features", ".NET Technologies",
                "Xamarin Forms, Xamarin Android, Xamarin iOS, and Xamarin Mac",
                "Visual Studio vs Visual Studio Code", "Visual Studio installation",
                "First Android app (Hello, world)", "Xamarin Forms project structure",
                "C# variables and types", "Statements, expressions and operators",
                "Conditional statements", "Iteration statements", "Characters and strings",
                "Arrays and collections", "foreach loop", "DateTime, DateOnly, TimeOnly",
                "Microsoft documentation", "Button and event handling", "XML and XAML",
                "Testing app on mobile", "Entry and Editor controls", "Label control", "Layouts",
                "CheckBox", "Picker", "DatePicker and TimePicker", "Colors and brushes",
                "Pages and navigation", "App icon", "Android app resources",
                "Object-oriented programming",
                "Classes and objects", "Encapsulation", "Method overloading", "Inheritance",
                "Polymorphism", "Data structures & algorithms", "Assemblies and namespaces"
            };
            foreach (var cnt in crsContents)
                modelBuilder.Entity<CourseContent>().HasData(new CourseContent()
                {
                    Id = cntStartId++,
                    CourseId = crsId,
                    Content = cnt,
                    CreatedById = 1,
                    CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                    EntityStatus = EntityStatus.Active,
                });
            //CoursesDetailsPopulator.CoursesContents.Add(crsId, new List<string>
            //{

            //});
            //CoursesDetailsPopulator.CoursesFees.Add(crsId, new List<(int ctryId, float fees)>()
            //{
            //    (datHelper.LibyaId, 600), (datHelper.EgyptId, 1500), (datHelper.TurkeyId, 1500),
            //    (datHelper.AmericaId, 95)
            //});
            //CoursesDetailsPopulator.CoursesInstructors.Add(crsId, new List<int>() { 1 });
            #endregion

            #region 15 Adv. Andr. Apps Us. Xam. - 18H - L 450 | E 1200 | T 1200 | A (90 + 76 + 50) / 3 ~ 75
            crsId = 15;
            crsContents = new List<string>()
            {
                "String methods and operations", "is and as operators", "Bitwise operations",
                "typeof and sizeof operators", "switch pattern matching and expressions",
                "Exception handling", "Recursion", "Delegates", "Attributes", "Generics",
                "Abstract classes", "Method overriding", "Interfaces", "LINQ and Lambda expressions",
                "Files and streams", ".NET asynchronous programming (tasks, async and await)",
                "Page types", "Navigation", "Tabbed page", "Carousel page", "Modal page", "ListView",
                "CarouselView", "TableView", "Splash screen", "ActivityIndicator", "ProgressBar",
                "Xamarin Essentials", "Android API levels", "Dependency service",
                "Select image in Android", "Make phone call", "Send SMS", "Send email", "Sensors",
                "Location & mapping", "Consume REST service"
            };
            foreach (var cnt in crsContents)
                modelBuilder.Entity<CourseContent>().HasData(new CourseContent()
                {
                    Id = cntStartId++,
                    CourseId = crsId,
                    Content = cnt,
                    CreatedById = 1,
                    CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                    EntityStatus = EntityStatus.Active,
                });
            //CoursesDetailsPopulator.CoursesContents.Add(crsId, new List<string>
            //{

            //});
            //CoursesDetailsPopulator.CoursesPrerequisites.Add(crsId, new List<string>()
            //    {
            //        "Knowledge of C# language essentials",
            //        "Knowledge of Android programming essentials",
            //        "Knowledge of Xamarin Forms essentials"
            //    });
            //CoursesDetailsPopulator.CoursesFees.Add(crsId, new List<(int ctryId, float fees)>()
            //{
            //    (datHelper.LibyaId, 450), (datHelper.EgyptId, 1200), (datHelper.TurkeyId, 1200),
            //    (datHelper.AmericaId, 75)
            //});
            //CoursesDetailsPopulator.CoursesInstructors.Add(crsId, new List<int>() { 1 });
            #endregion

            #region 16 Intr. Games Prg. Unity & C# - 18H - L 600 | E 1500 | T 1500 | A (120 + 100 + 59) / 3 ~ 95
            crsId = 16;
            crsContents = new List<string>()
            {
                "Why use game engine?", "Why Unity?",
                "How design a game (concept, characters, gameplay)?",
                "Games genres (types)", "Unity user interface", "Scenes and objects", "Prefabs",
                "Lighting", "Code scripts", "Movement & camera", "Obstacles & collision",
                "Materials & effects", "Importing & integrating assets", "Audio", "Animation",
                "Basic AI & enemy behavior", "Game levels", "Win & lose"
            };
            foreach (var cnt in crsContents)
                modelBuilder.Entity<CourseContent>().HasData(new CourseContent()
                {
                    Id = cntStartId++,
                    CourseId = crsId,
                    Content = cnt,
                    CreatedById = 1,
                    CreatedOn = DateTime.UtcNow.ToString("yyyy-mm-dd hh:mm:ss.ffff"),
                    EntityStatus = EntityStatus.Active,
                });
            //CoursesDetailsPopulator.CoursesContents.Add(crsId, new List<string>
            //{

            //});
            //CoursesDetailsPopulator.CoursesPrerequisites.Add(crsId,
            //    new List<string>() { "Knowledge of C# language essentials" });
            //CoursesDetailsPopulator.CoursesFees.Add(crsId, new List<(int ctryId, float fees)>()
            //{
            //    (datHelper.LibyaId, 450), (datHelper.EgyptId, 1200), (datHelper.TurkeyId, 1500),
            //    (datHelper.AmericaId, 95)
            //});
            #endregion
        //};
        }
    }
}
