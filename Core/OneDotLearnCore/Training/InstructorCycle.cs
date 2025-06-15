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
    [Table("InstructorsCycles", Schema = "Training")]
    public class InstructorCycle : BaseEntity
    {
        #region Data Members
        #endregion

        #region Constructors
        #endregion

        #region Properties
        [Required]
        public int InstructorId { get; set; }
        [Required]
        public int CycleId { get; set; }
        #endregion

        #region Methods
        #endregion
    }
}
