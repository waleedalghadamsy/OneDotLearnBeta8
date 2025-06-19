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
    [Table("EpaymentCards", Schema = "Financials")]
    public class EpaymentCard : BaseEntity
    {
        #region Data Members
        #endregion

        #region Constructors
        #endregion

        #region Properties
        [Required, StringLength(50)]
        public string CardNumber { get; set; } = string.Empty;
        public CardValueGroup CardValueGroup { get; set; } = CardValueGroup.FiftyDinars;
        public int Value { get; set; } = 0;
        #endregion

        #region Methods
        #endregion
    }
}
