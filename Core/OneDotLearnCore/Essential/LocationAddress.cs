using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OneDotLearnCore.Essential
{
    public class LocationAddress : BaseEntity//IEquatable<LocationAddress>
    {
        #region Data Members
        #endregion

        #region Constructors
        //public LocationAddress()
        //{
        //}
        #endregion

        #region Properties
        [NotMapped]
        public Country? Country { get; set; }
        [NotMapped]
        public City? City { get; set; }
        [StringLength(200)]
        public string? StreetName { get; set; }
        [StringLength(7)]
        public string? BuildingNumber { get; set; }
        [StringLength(100)]
        public string? BuildingDescription { get; set; }
        [StringLength(100)]
        public string? LocationDescription { get; set; }
        public byte? FloorNumber { get; set; }
        [StringLength(7)]
        public string? ApartmentNumber { get; set; }
        public byte[]? Map { get; set; }
        public string? GoogleMapsUrl { get; set; }
        public int? CountryId { get; set; }
        public int? CityId { get; set; }
        //[NotMapped]
        //public string ShortAddress => City != null ? $"{City.LatinName} -- {BuildingNumber} {StreetName}" : string.Empty;
        #endregion

        #region Methods
        //public void Method()
        //{
        //}
        #endregion

        #region IEquatable<LocationAddress> Members

        public bool Equals(LocationAddress other) => City?.LatinName == other.City?.LatinName
                && StreetName == other.StreetName
                && BuildingNumber == other.BuildingNumber
                && FloorNumber == other.FloorNumber
                && ApartmentNumber == other.ApartmentNumber;

        #endregion
    }
}
