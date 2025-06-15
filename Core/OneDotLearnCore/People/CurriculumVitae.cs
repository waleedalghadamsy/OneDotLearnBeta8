using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace OneDotLearnCore.People
{
    public class CurriculumVitae
    {
        #region Properties
        public List<Education>? EducationQualifications { get; set; }
        public List<WorkExperience>? WorkExperience { get; set; }
        //public List<Training> TrainingAttended { get; set; }
        //public List<ProfessionalCertification> Certifications { get; set; }
        public List<string>? Expertise { get; set; }
        public List<string>? RecruitNotes { get; set; }
        public List<string>? EvaluatorNotes { get; set; }
        #endregion
    }
}
