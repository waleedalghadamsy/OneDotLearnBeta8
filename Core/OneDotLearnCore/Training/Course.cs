using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using OneDotLearnCore.Essential;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using OneDotLearnCore.Financials;
using OneDotLearnCore.People;

namespace OneDotLearnCore.Training
{
    [Table("Courses", Schema = "Training")]
    public class Course : BaseEntity
    {
        #region Data Members
        //private short duration;
        #endregion

        #region Constructors
        //public Course(string name, string code, short duration)
        //{
        //    Name = name; Code = code; Duration = duration; ProductType = TrainingProductType.Course;
        //}
        #endregion

        #region Properties
        [NotMapped]
        public ProductCategory Category { get; set; }
        [Required]
        //TODO: Temporarily hardcoded to 1. Later on, I should activate courses categories
        public int CategoryId => 1;//{ get; set; } 
        //public TrainingProductType ProductType { get; set; }
        [Required, StringLength(150)]
        public string ArabicTitle { get; set; }
        [Required, StringLength(150)]
        public string LatinTitle { get; set; }
        [Required, StringLength(10)]
        public string Code { get; set; }
        public string? Description { get; set; }
        //public Vendor Vendor { get; set; }
        //public Provider Provider { get; set; }
        [Required]
        public byte Duration { get; set; }
        [Required]
        public ProductLevel Level { get; set; }
        [NotMapped]
        public List<ProductFees>? Fees { get; set; }
        [NotMapped]
        public List<string>? Prerequisites { get; set; }
        [NotMapped]
        public List<string>? Contents { get; set; }
        public byte[]? Picture { get; set; }
        [NotMapped]
        public List<Instructor>? Instructors { get; set; }
        [Required]
        public byte InstructorFeesShare { get; set; } //Percent of course fees paid to instructor
        [Required]
        public int FinancialAccountId { get; set; }
        [Required]
        public ProductStatus Status { get; set; }
        #endregion

        #region Methods
        //public void Load<T>(T dbEntity)
        //{
        //    throw new NotImplementedException();
        //}

        //public void Save()
        //{
        //    throw new NotImplementedException();
        //}
        #endregion

        #region IEquatable<Course> Members
        //public bool Equals(Course other)
        //{
        //    return ((Name.ToLower() == other.Name.ToLower()) ||
        //        (Code.ToLower() == other.Code.ToLower()));
        //}

        //public void Load()
        //{
        //    throw new NotImplementedException();
        //}
        #endregion
    }
}
