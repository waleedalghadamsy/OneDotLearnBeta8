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
    [Table("ConsumedCards", Schema = "Financials")]
    public class EpConsumedCard : BaseEntity
    {
        #region Data Members
        #endregion

        #region Constructors
        #endregion

        #region Properties
        [Required]
        public int UserId { get; set; }
        [Required]
        public int CardId { get; set; }
        [Required]
        public int ProductId { get; set; }
        #endregion

        #region Methods
        #endregion
    }
}
