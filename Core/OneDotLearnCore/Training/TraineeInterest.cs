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
    [Table("TraineesInterests", Schema = "Training")]
    public class TraineeInterest : BaseEntity
    {
        #region Data Members
        #endregion

        #region Constructors
        #endregion

        #region Properties
        [Required]
        public int TraineeId { get; set; }
        [Required]
        public int CategoryId { get; set; }
        #endregion

        #region Methods
        #endregion
    }
}
