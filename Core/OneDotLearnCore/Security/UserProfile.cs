using OneDotLearnCore.Essential;
using OneDotLearnCore.People;
using OneDotLearnCore.Training;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneDotLearnCore.Security
{
    [Table("UsersProfiles", Schema = "Security")]
    public class UserProfile : BaseEntity
    {
        #region Data Members
        #endregion

        #region Constructors
        #endregion

        #region Properties
        [Required]
        public int UserId { get; set; }
        [StringLength(150)]
        public string? FullName { get; set; }
        //[Required]
        public ExperienceLevel? ProgExperience { get; set; }
        //[Required]
        public ProgrammingLanguages? ProgLanguages { get; set; }
        public string? OtherProgLanguages { get; set; }
        //[Required]
        public ExperienceLevel? RdbmsLevel { get; set; }
        //[Required]
        public SWDevTechnologies? SWDevTechnologies { get; set; }
        public string? OtherTechnologies { get; set; }
        [NotMapped]
        public List<ProductCategory>? Interests { get; set; }
        public string? OtherInterests { get; set; }
        #endregion

        #region Methods
        #endregion
    }
}
