using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OneDotLearnCore.Essential
{
    public class CityArea : BaseEntity
    {
        #region Data Members
        #endregion

        #region Constructors
        public CityArea() => (Name, City) = ("", new City());
        public CityArea(string areaName, City theCity) => (Name, City) = (areaName, theCity);
        #endregion

        #region Properties
        [Required]
        public string Name { get; set; }
        [NotMapped]
        public City City { get; set; }
        [Required]
        public short CityId { get; set; }
        #endregion

        #region Methods
        //public void Method()
        //{
        //}
        #endregion

        //#region IEquatable<CityArea> Members

        //public bool Equals(CityArea other)
        //{
        //    return (Name.ToLower() == other.Name.ToLower() && City.Equals(other.City));
        //}

        //#endregion
    }
}
