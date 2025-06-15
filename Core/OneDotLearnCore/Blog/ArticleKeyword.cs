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
    [Table("ArticlesKeywords", Schema = "Blog")]
    public class ArticleKeyword : BaseEntity
    {
        #region Data Members
        #endregion

        #region Constructors
        #endregion

        #region Properties
        [Required]
        public int ArticleId { get; set; }
        [Required]
        public int KeywordId { get; set; }
        #endregion

        #region Methods
        #endregion
    }
}
