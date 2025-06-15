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
    [Table("Invoices", Schema = "Financials")]
    public class Invoice : BaseEntity
    {
        #region Data Members
        #endregion

        #region Constructors
        #endregion

        #region Properties
        [Required]
        public int ProductId { get; set; }
        [Required]
        public int TraineeId { get; set; }
        [Required, StringLength(10)]
        public string? Number { get; set; }
        public string? Description { get; set; }
        [Required]
        public float GrossTotal { get; set; }
        public float? Discount { get; set; }
        [Required]
        public float NetTotal { get; set; }
        #endregion

        #region Methods
        #endregion
    }
}
