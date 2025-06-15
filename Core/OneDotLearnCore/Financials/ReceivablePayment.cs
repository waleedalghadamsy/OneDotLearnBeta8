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
    [Table("ReceivablePayments", Schema = "Financials")]
    public class ReceivablePayment : BaseEntity
    {
        #region Data Members
        #endregion

        #region Constructors
        #endregion

        #region Properties
        [Required]
        public int DebitAccountId { get; set; }
        [Required]
        public int CreditAccountId { get; set; }
        [Required]
        public float GrossAmount { get; set; }
        [Required]
        public float Discount { get; set; }
        [Required]
        public float Amount { get; set; }
        [Required]
        public int CurrencyId { get; set; }
        public byte[]? Receipt { get; set; }
        public string? Notes { get; set; }
        #endregion

        #region Methods
        #endregion
    }
}
