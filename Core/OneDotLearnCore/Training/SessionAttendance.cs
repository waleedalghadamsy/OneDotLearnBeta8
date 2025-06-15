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
    [Table("AttanedanceSheet", Schema = "Training")]
    public class SessionAttendance : BaseEntity
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
        [Required, DataType(DataType.DateTime)]
        public DateTimeOffset AttendedAt { get; set; }
        #endregion

        #region Methods
        #endregion
    }
}
