using OneDotLearnCore.Essential;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneDotLearnCore.Financials
{
    [Table("Currencies", Schema = "Financials")]
    public class Currency : BaseEntity
    {
        #region Data Members
        #endregion

        #region Constructors
        #endregion

        #region Properties
        [Required]
        public int CountryId { get; set; }
        [StringLength(75)]
        public string? ArabicName { get; set; }
        [Required, StringLength(75)]
        public string? LatinName { get; set; }
        [Required, StringLength(3)]
        public string? IsoCode { get; set; }
        [StringLength(5)]
        public string? ArabicSymbol { get; set; }
        [Required, StringLength(5)]
        public string? LatinSymbol { get; set; }
        #endregion

        #region Methods
        #endregion
    }
}
