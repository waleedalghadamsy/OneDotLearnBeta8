using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using OneDotLearnCore.Essential;
using OneDotLearnCore.Financials;
using OneDotLearnCore.People;

namespace OneDotLearnCore.Training
{
    [Table("Trainees", Schema = "Training")]
    public class Trainee : Person//, IEquatable<Trainee>
    {
        #region Constructors
        //public Trainee(ArabicName arabicFirstName, Gender gender)
        //    : base(arabicFirstName, gender)
        //{
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
        public string? OtherInterests { get; set; }
        [NotMapped]
        public List<Enrolment>? Enrollments { get; set; }
        [Required]
        public int FinancialAccountId { get; set; }
        [NotMapped]
        public List<PayablePayment>? Payments { get; set; }
        [NotMapped]
        public List<Course>? Favourites { get; set; }
        #endregion

        #region IEquatable<Trainee> Members

        //public bool Equals(Trainee other)
        //{
        //    return ArabicName.Equals(other.ArabicName) || EnglishName.Equals(other.EnglishName);
        //}

        #endregion
    }
}
