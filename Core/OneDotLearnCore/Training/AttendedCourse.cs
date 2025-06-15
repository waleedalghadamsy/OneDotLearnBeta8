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
    [Table("AttendedCourses", Schema = "Training")]
    public class AttendedCourse : BaseEntity
    {
        #region Data Members
        #endregion

        #region Constructors
        #endregion

        #region Properties
        [Required]
        public int CourseId { get; set; }
        [Required]
        public int TraineeId { get; set; }
        #endregion

        #region Methods
        #endregion
    }
}
