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
    [Table("RequestedCourses", Schema = "Training")]
    public class CourseRequest : BaseEntity
    {
        #region Data Members
        #endregion

        #region Constructors
        #endregion

        #region Properties
        [Required]
        public RequestSource Source { get; set; }
        [Required, StringLength(150)]
        public string? Title { get; set; }
        public string? Topics { get; set; }
        public float? Fees { get; set; }
        public int? CurrencyId { get; set; }
        [Required]
        public bool IsAnswered { get; set; }
        #endregion

        #region Methods
        #endregion
    }
}
