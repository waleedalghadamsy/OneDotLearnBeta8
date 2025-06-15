using OneDotLearnCore.Essential;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace OneDotLearnCore.People
{
    public class Interview : BaseEntity
    {
        #region Properties
        [Required]
        public string? Purpose { get; set; }
        [Required, DataType(DataType.Date)]
        public DateTimeOffset PlannedDate { get; set; }
        [DataType(DataType.Date)]
        public DateTimeOffset? ActualDate { get; set; }
        [Required]
        public int InterviewerId { get; set; }
        [Required]
        public int RecruitId { get; set; }
        public string? Notes { get; set; }
        [Required]
        public EvaluationDegree Evaluation { get; set; }
        [Required]
        public string? Result { get; set; }
        #endregion
    }
}
