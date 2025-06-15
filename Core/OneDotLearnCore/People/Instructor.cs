using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using OneDotLearnCore.Essential;
using OneDotLearnCore.Training;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace OneDotLearnCore.People
{
    [Table("Instructors", Schema = "People")]
    public class Instructor : Person
    {
        #region Constructors
        //public Instructor(ArabicName arabicName, List<Course> courses)
        //    :this(arabicName, Gender.Male, courses)
        //{
        //}
        //public Instructor(ArabicName arabicName, Gender gender, List<Course> courses)
        //    : this(arabicName, null, gender, courses)
        //{
        //}
        //public Instructor(EnglishName englishName, List<Course> courses)
        //    : this(englishName, Gender.Male, courses)
        //{
        //}
        //public Instructor(EnglishName englishName, Gender gender, List<Course> courses)
        //    : this(null, englishName, gender, courses)
        //{
        //}
        //public Instructor(ArabicName arabicName, EnglishName englishName, List<Course> courses)
        //    : this(arabicName, englishName, Gender.Male, courses)
        //{
        //}
        //public Instructor(ArabicName arabicName, EnglishName englishName, Gender gender, List<Course> courses)
        //    : base(arabicName, englishName, gender, new Job("Instructor"))
        //{
        //    TrainingFields = new List<TrainingField>(); Courses = courses; 
        //}
        #endregion

        #region Properties
        //[Required]
        //public int CountryId { get; set; }
        //[StringLength(50)]
        //public string OtherCountry { get; set; }
        //[Required]
        //public EducationLevel EducationLevel { get; set; }
        //[StringLength(100)]
        //public string AcademicSpecialization { get; set; }
        [NotMapped]
        public List<WorkExperience> WorkExperience { get; set; }
        [NotMapped]
        public List<ProductCategory> TrainingFields { get; set; }
        public string? OtherFields { get; set; }
        [NotMapped]
        public List<Course> Courses { get; set; }
        public string? OtherCourses { get; set; }
        [NotMapped]
        public Schedule Schedule { get; set; }
        [Required]
        public int FinancialAccountId { get; set; }
        #endregion

        #region Methods
        //public bool Equals(Instructor other)
        //{
        //    return ((ArabicName != null && other.ArabicName != null && ArabicName == other.ArabicName) || 
        //        (EnglishName != null && other.EnglishName != null && EnglishName == other.EnglishName));
        //}
        #endregion
    }
}
