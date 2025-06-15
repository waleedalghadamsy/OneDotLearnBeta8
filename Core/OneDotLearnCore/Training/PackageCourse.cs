using OneDotLearnCore.Essential;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneDotLearnCore.Training
{
    [Table("PackagesCourses", Schema = "Training")]
    public class PackageCourse : BaseEntity
    {
        #region Data Members
        #endregion

        #region Constructors
        #endregion

        #region Properties
        [Required]
        public int PackageId { get; set; }
        [Required]
        public int CourseId { get; set; }
        #endregion

        #region Methods
        #endregion
    }
}
