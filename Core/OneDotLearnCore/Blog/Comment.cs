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
    [Table("Comments", Schema = "Blog")]
    public class Comment : BaseEntity
    {
        #region Data Members
        #endregion

        #region Constructors
        #endregion

        #region Properties
        public int? ParentCommentId { get; set; }
        [Required]
        public int ArticleId { get; set; }
        [Required]
        public int AuthorId { get; set; }
        [Required]
        public string? Content { get; set; }
        #endregion

        #region Methods
        #endregion
    }
}
