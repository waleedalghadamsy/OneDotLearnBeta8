using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OneDotLearnCore.Essential
{
    
    public class City : BaseEntity
    {
        #region Constructors
        public City()
        {
            LatinName = "";
        }

        public City(string cityName, Country theCountry)
        {
            LatinName = cityName; CountryId = (short)theCountry.Id;
        }
        #endregion

        #region Properties
        [StringLength(30)]
        public string? ArabicName { get; set; }
        [Required, StringLength(45)]
        public string LatinName { get; set; }
        public int? MunicipalityId { get; set; }
        [Required]
        public short CountryId { get; set; }
        #endregion

        #region Methods
        public void Load<T>(T dbEntity)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
        #endregion

        //#region IEquatable<City> Members
        //public bool Equals(City other)
        //{
        //    return LatinName.Trim().Equals(other.LatinName.Trim(), StringComparison.OrdinalIgnoreCase);
        //}
        //#endregion
    }
}
