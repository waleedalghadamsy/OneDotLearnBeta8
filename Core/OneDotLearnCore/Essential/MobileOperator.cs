using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneDotLearnCore.Essential
{
    [Table("MobileOperators", Schema = "General")]
    public class MobileOperator : BaseEntity
    {
        #region Data Members
        #endregion

        #region Constructors
        #endregion

        #region Properties
        public int CountryId { get; set; }
        public short Code { get; set; }
        public byte NumberOfDigits { get; set; }
        #endregion

        #region Methods
        #endregion
    }
}
