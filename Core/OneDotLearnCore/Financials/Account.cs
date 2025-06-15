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
    [Table("Accounts", Schema = "Financials")]
    public class Account : BaseEntity
    {
        #region Data Members
        #endregion

        #region Constructors
        #endregion

        #region Properties
        public int? ParentId { get; set; }
        [Required]
        public AccountType AccountType { get; set; }
        [Required]
        public AccountSide AccountSide { get; set; }
        [Required]
        public OwnerType OwnerType { get; set; }
        //[Required]
        //public int OwnerId { get; set; }
        [Required, StringLength(150)]
        public string? Name { get; set; }
        [Required, StringLength(50)]
        public int Number { get; set; }
        [Required]
        public float Balance { get; set; }
        public int? CurrencyId { get; set; }
        #endregion

        #region Methods
        #endregion
    }
}
