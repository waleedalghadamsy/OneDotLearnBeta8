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
    [Table("Journal", Schema = "Financials")]
    public class JournalEntry : BaseEntity
    {
        #region Data Members
        #endregion

        #region Constructors
        #endregion

        #region Properties
        [Required]
        public TransactionType Type { get; set; }
        [Required]
        public int DebitAccountId { get; set; }
        [Required]
        public int CreditAccountId { get; set; }
        [Required]
        public float Amount { get; set; }
        [Required]
        public int CurrencyId { get; set; }
        public string? Description { get; set; }
        #endregion

        #region Methods
        #endregion
    }
}
