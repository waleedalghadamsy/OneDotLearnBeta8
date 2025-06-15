using OneDotLearnCore.Essential;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneDotLearnCore.Financials
{
    public class CyclePayment : BaseEntity
    {
        #region Data Members
        #endregion

        #region Constructors
        #endregion

        #region Properties
        public int CycleId { get; set; }
        public int TraineeId { get; set; }
        public float Fees { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public DateTime? PaidOn { get; set; }
        #endregion

        #region Methods
        #endregion
    }
}
