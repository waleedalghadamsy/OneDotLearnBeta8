using OneDotLearnCore.People;
using OneDotLearnCore.Security;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OneDotLearnCore.Essential
{
    public class Person : BaseEntity
    {
        #region Data Members
        #endregion

        #region Constructors
        #endregion

        #region Properties
        [Required, StringLength(25)]
        public string? ArFirstName { get; set; }
        [StringLength(25)]
        public string? ArFatherName { get; set; }
        [StringLength(25)]
        public string? ArGrandfatherName { get; set; }
        [Required, StringLength(25)]
        public string? ArFamilyName { get; set; }
        [NotMapped]
        public string ArabicFullName
        {
            get
            {
                var ftrNm = !string.IsNullOrWhiteSpace(ArFatherName) ? $" {ArFatherName}" : "";
                var grFtrNm = !string.IsNullOrWhiteSpace(ArGrandfatherName) ? $" {ArGrandfatherName}" : "";

                return $"{ArFirstName}{ftrNm}{grFtrNm} {ArFamilyName}";
            }
        }
        [Required, StringLength(25)]
        public string? LtnFirstName { get; set; }
        [StringLength(25)]
        public string? LtnFatherName { get; set; }
        [StringLength(25)]
        public string? LtnGrandfatherName { get; set; }
        [Required, StringLength(25)]
        public string? LtnFamilyName { get; set; }
        [NotMapped]
        public string LatinFullName
        {
            get
            {
                var ftrNm = !string.IsNullOrWhiteSpace(LtnFatherName) ? $" {LtnFatherName}" : "";
                var grFtrNm = 
                    !string.IsNullOrWhiteSpace(LtnGrandfatherName) ? $" {LtnGrandfatherName}" : "";

                return $"{LtnFirstName}{ftrNm}{grFtrNm} {LtnFamilyName}";
            }
        }
        [Required]
        public Gender Gender { get; set; }
        [Required, DataType(DataType.Date)]
        public DateOnly BirthDate { get; set; }
        [Required]
        public bool IsArabic { get; set; }
        [NotMapped]
        public Country? Nationality { get; set; }
        public short? NationalityId { get; set; }
        [StringLength(50)]
        public string? OtherNationality { get; set; }
        [Required]
        public int? ResidenceCountryId { get; set; }
        [StringLength(50)]
        public string? OtherResidenceCountry { get; set; }
        [Required]
        public EducationLevel EducationLevel { get; set; }
        [StringLength(100)]
        public string? AcademicSpecialization { get; set; }
        [NotMapped]
        public LocationAddress? Address { get; set; }
        public int? AddressId { get; set; }
        [NotMapped]
        public Communication? ContactDetails { get; set; }
        public int? ContactDetailsId { get; set; }
        [NotMapped]
        public byte[]? Picture { get; set; }
        [NotMapped]
        public User? User { get; set; }
        public int? UserId { get; set; }
        #endregion

        #region Methods
        #endregion
    }
}
