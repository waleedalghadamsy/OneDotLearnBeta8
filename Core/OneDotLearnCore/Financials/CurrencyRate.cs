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
    [Table("CurrenciesRates", Schema = "Financials")]
    public class CurrencyRate : BaseEntity
    {
        #region Data Members
        #endregion

        #region Constructors
        #endregion

        #region Properties
        [Required]
        public int CurrencyId { get; set; }
        [Required]
        public float Rate { get; set; }
        #endregion

        #region Methods
        #endregion
    }
}
