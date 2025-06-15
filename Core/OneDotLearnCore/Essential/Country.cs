using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OneDotLearnCore.Essential
{
    [Table("Countries", Schema = "General")]
    public class Country : BaseEntity//: IEquatable<Country>//, IDatabaseEntity
    {
        #region Data Members
        #endregion

        #region Constructors
        public Country()
        {
            ArabicName = ""; LatinName = ""; TimeZoneId = "";
        }
        public Country(string countryName, string tmZnId, Continent theContinent)
        {
            ArabicName = countryName; LatinName = countryName; TimeZoneId = tmZnId;
            //Capital = new City(capitalName, this);
            Continent = theContinent; Cities = new List<City>();
        }
        #endregion

        #region Properties
        [Required, StringLength(75)]
        public string ArabicName { get; set; }
        [Required, StringLength(75)]
        public string LatinName { get; set; }
        //[StringLength(20)]
        //public string ShortName { get; set; }
        [NotMapped]
        public string Name => $"{LatinName} | {ArabicName}";
        [NotMapped]
        public City? Capital { get; set; }
        public byte[]? Flag { get; set; }
        [NotMapped]
        public Continent Continent { get; set; }
        [NotMapped]
        public List<City>? Cities { get; set; }
        [Required]
        public short ItuCode { get; set; }
        [Required]
        public string TimeZoneId { get; set; }
        [Required]
        public bool IsArabic { get; set; }
        //[Required, StringLength(20)]
        //public string CurrencyName { get; set; }
        //[Required, StringLength(4)]
        //public string CurrencySymbol { get; set; }
        #endregion

        #region Methods
        public void Load()
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
        #endregion

        //#region IEquatable<Country> Members

        //public bool Equals(Country other)
        //{
        //    return (Name.ToLower() == other.Name.ToLower());
        //}

        //#endregion
    }
}
