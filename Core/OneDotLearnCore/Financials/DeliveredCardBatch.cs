using OneDotLearnCore.Essential;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneDotLearnCore.Financials
{
    [Table("DeliveredCardBatches", Schema = "Financials")]
    public class DeliveredCardBatch : BaseEntity
    {
        #region Data Members
        #endregion

        #region Constructors
        #endregion

        #region Properties
        public int FromCardId { get; set; }
        public int ToCardId { get; set; }
        #endregion

        #region Methods
        #endregion
    }
}
