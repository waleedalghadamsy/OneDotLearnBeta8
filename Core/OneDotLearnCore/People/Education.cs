using OneDotLearnCore.Essential;
using OneDotLearnCore.Training;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace OneDotLearnCore.People
{
    [Table("EmployeesStudies", Schema = "People")]
    public class Education : BaseEntity
    {
        #region Properties
        [NotMapped]
        public StudyPlace StudyPlace { get; set; }
        [Required]
        public short FromYear { get; set; }
        [Required]
        public short ToYear { get; set; }
        public EducationLevel? AttainedDegree { get; set; }
        //public Evaluation Grade { get; set; }
        public int? StudyPlaceId { get; set; }
        #endregion
    }
}
