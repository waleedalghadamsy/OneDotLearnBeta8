using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OneDotLearnCore.Essential;
using OneDotLearnCore.JobInterviews;

namespace OneDotLearnCore.People
{
    public class Interviewee : Person
    {
        #region Data Members
        #endregion

        #region Constructors
        #endregion

        #region Properties
        [NotMapped]
        public CurriculumVitae Résumé { get; set; }
        [NotMapped]
        public Job InterviewingFor { get; set; }
        [NotMapped]
        public List<InterviewRequest> InterviewsRequests { get; set; }
        [NotMapped]
        public List<Interview> Interviews { get; set; }
        [Required]
        public int RésuméId { get; set; }
        [Required]
        public int InterviewingForId { get; set; }
        [Required]
        public string FinalEvaluation { get; set; }
        public int? FinancialAccountId { get; set; }
        #endregion

        #region Methods
        #endregion
    }
}
