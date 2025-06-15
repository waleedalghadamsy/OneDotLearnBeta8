using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OneDotLearnCore.Essential;

namespace OneDotLearnCore.Training
{
    [Table("CyclesEvalutations", Schema = "Training")]
    public class CycleEvaluation : BaseEntity
    {
        #region Data Members
        #endregion

        #region Constructors
        #endregion

        #region Properties
        [Required]
        public int CycleId { get; set; }
        [Required]
        public int TraineeId { get; set; }
        [Required]
        public EvaluationDegree Degree { get; set; }
        public string? Details { get; set; }
        #endregion

        #region Methods
        #endregion
    }
}
