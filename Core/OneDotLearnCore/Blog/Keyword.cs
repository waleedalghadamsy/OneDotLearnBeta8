using OneDotLearnCore.Essential;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneDotLearnCore.Blog
{
    [Table("Keywords", Schema = "Blog")]
    public class Keyword : BaseEntity
    {
        #region Data Members
        #endregion

        #region Constructors
        #endregion

        #region Properties
        [Required, StringLength(50)]
        public string? Text { get; set; }
        #endregion

        #region Methods
        #endregion
    }
}
