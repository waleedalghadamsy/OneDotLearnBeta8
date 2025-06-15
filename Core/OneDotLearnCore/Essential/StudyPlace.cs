using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace OneDotLearnCore.Essential
{
    [Table("StudyPlaces", Schema = "General")]
    public class StudyPlace : BaseEntity
    {
        #region Data Members
        #endregion

        #region Constructors
        #endregion

        #region Properties
        [StringLength(150)]
        public string? ArabicName { get; set; }
        [Required, StringLength(150)]
        public string? LatinName { get; set; }
        //public CommercialActivity Activity { get; set; }
        [NotMapped]
        public Country? Country { get; set; }
        [NotMapped]
        public City? City { get; set; }
        [NotMapped]
        public Communication? ContactDetails { get; set; }
        public bool IsPrivateSector { get; set; }
        //[ForeignKey("Activity")]
        //public int? ActivityId { get; set; }
        public int? CountryId { get; set; }
        public int? CityId { get; set; }
        [Required]
        public StudyPlaceLevel Level { get; set; }
        #endregion

        #region Methods
        //public void Method()
        //{
        //}
        #endregion
    }
}
