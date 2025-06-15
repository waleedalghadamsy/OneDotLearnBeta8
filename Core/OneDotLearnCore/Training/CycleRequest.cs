using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using OneDotLearnCore.Essential;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using OneDotLearnCore.People;

namespace OneDotLearnCore.Training
{
    [Table("RequestedCycles", Schema = "Training")]
    public class CycleRequest : BaseEntity
    {
        #region Constructors
        #endregion

        #region Properties
        [NotMapped]
        public Course? Course { get; set; }
        [Required]
        public int CourseId { get; set; }
        [NotMapped]
        public Trainee? Trainee { get; set; }
        [Required]
        public int TraineeId { get; set; }
        [Required]
        public byte CanStartAfterNDays { get; set; }
        [Required]
        public byte StartTime { get; set; }
        [Required]
        public byte EndTime { get; set; }
        [Required]
        public WeekDays WeekDays { get; set; }
        #endregion

        #region Methods
        //public void Method()
        //{
        //}
        #endregion
    }
}
