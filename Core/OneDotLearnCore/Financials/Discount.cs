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
    [Table("Discounts", Schema = "Financials")]
    public class Discount : BaseEntity
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
        public byte Percent { get; set; }
        [DataType(DataType.Date)]
        public DateTimeOffset? From { get; set; }
        [DataType(DataType.Date)]
        public DateTimeOffset? To { get; set; }
        #endregion

        #region Methods
        #endregion
    }
}
