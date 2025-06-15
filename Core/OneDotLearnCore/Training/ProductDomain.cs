using OneDotLearnCore.Essential;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneDotLearnCore.Training
{
    [Table("ProductsDomains", Schema = "Training")]
    public class ProductDomain : BaseEntity
    {
        #region Data Members
        #endregion

        #region Constructors
        #endregion

        #region Properties
        public int? ParentId { get; set; }
        [Required, StringLength(100)]
        public string? Name { get; set; }
        [NotMapped]
        public List<ProductDomain>? SubDomains { get; set; }
        [NotMapped]
        public int NoOfCourses { get; set; }
        #endregion

        #region Methods
        #endregion
    }
}
