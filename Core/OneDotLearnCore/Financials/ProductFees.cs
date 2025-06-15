using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OneDotLearnCore.Essential;

namespace OneDotLearnCore.Financials
{
    [Table("ProductsFees", Schema = "Financials")]
    public class ProductFees : BaseEntity
    {
        #region Data Members
        #endregion

        #region Constructors
        #endregion

        #region Properties
        [Required]
        public ProductType ProductType { get; set; }
        [Required]
        public int ProductId { get; set; }
        [Required]
        public int CurrencyId { get; set; }
        [Required]
        public float Fees { get; set; }
        #endregion

        #region Methods
        #endregion
    }
}
