using OneDotLearnCore.Essential;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneDotLearnCore.Training
{
    [Table("Prerequisites", Schema = "Training")]
    public class Prerequisite : BaseEntity
    {
        #region Data Members
        #endregion

        #region Constructors
        #endregion

        #region Properties
        [Required]
        public int ProductId { get; set; }
        [Required]
        public ProductType ProductType { get; set; }
        [Required, StringLength(200)]
        public string Detail { get; set; }
        #endregion

        #region Methods
        #endregion
    }
}
