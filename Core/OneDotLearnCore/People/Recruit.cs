using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using OneDotLearnCore.Essential;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace OneDotLearnCore.People
{
    public class Recruit : Person
    {
        #region Constrcutors
        #endregion

        #region Properties
        //[DataMember]
        //public int Id { get; set; }
        [NotMapped]
        public CurriculumVitae? Résumé { get; set; }
        [NotMapped]
        public Job? RecruitedFor { get; set; }
        [NotMapped]
        public List<Interview>? Interviews { get; set; }
        //[NotMapped]
        //public List<EvaluationTest> Tests { get; set; }
        //[DataMember]
        //public short LastSalary { get; set; }
        //[DataMember]
        //public short RequiredSalary { get; set; }
        [Required]
        public int RésuméId { get; set; }
        [Required]
        public int RecruitedForId { get; set; }
        [Required]
        public string FinalEvaluation { get; set; }
        #endregion
    }
}
