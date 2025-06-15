using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OneDotLearnCore.Essential
{
    [Table("WorkPlaces", Schema = "General")]
    public class WorkPlace : BaseEntity//, IEquatable<WorkPlace>
    {
        #region Data Members
        //protected string name; 
        //protected LocationAddress locationAddress;
        //protected Communication contactDetails;
        //protected List<ContactPerson> contactPersons;
        #endregion

        #region Constructors
        #endregion

        #region Properties
        [StringLength(75)]
        public string? ArabicName { get; set; }
        [Required, StringLength(75)]
        public string? LatinName { get; set; }
        //[NotMapped]
        //public CommercialActivity Activity { get; set; }
        [NotMapped]
        public Country? Country { get; set; }
        [NotMapped]
        public City? City { get; set; }
        [NotMapped]
        public LocationAddress? Address { get; set; }
        [NotMapped]
        public Communication? ContactDetails { get; set; }
        public bool IsPrivateSector { get; set; }
        public string? Description { get; set; }
        //[ForeignKey("Activity")]
        //public int? ActivityId { get; set; }
        public int? CountryId { get; set; }
        public int? CityId { get; set; }
        public int? AddressId { get; set; }
        public int? ContactDetailsId { get; set; }
        [NotMapped]
        public string? ManagerName { get; set; }
        #endregion

        #region Methods
        //public void Method()
        //{
        //}
        #endregion

        #region IEquatable<WorkPlace> Members
        public bool Equals(WorkPlace other)
        {
            if (!string.IsNullOrWhiteSpace(ArabicName))
                return ArabicName.Equals(other.ArabicName);
            else if (!string.IsNullOrWhiteSpace(LatinName))
                return LatinName.Equals(other.LatinName);
            else
                return false;
        }
        #endregion
    }
}
