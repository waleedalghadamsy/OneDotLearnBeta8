using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OneDotLearnCore.Essential;

namespace OneDotLearnCore.Essential
{
    [Table("RequestsAnswers", Schema = "General")]
    public class RequestAnswer : BaseEntity
    {
        #region Data Members
        #endregion

        #region Constructors
        #endregion

        #region Properties
        [Required]
        public RequestType RequestType { get; set; }
        [Required]
        public int RequestId { get; set; }
        [Required]
        public string? Answer { get; set; }
        #endregion

        #region Methods
        #endregion
    }
}
