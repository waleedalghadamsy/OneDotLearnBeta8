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
    [Table("LikedArticles", Schema = "Blog")]
    public class LikedArticle : BaseEntity
    {
        #region Data Members
        #endregion

        #region Constructors
        #endregion

        #region Properties
        [Required]
        public int ArticleId { get; set; }
        [Required]
        public int UserId { get; set; }
        #endregion

        #region Methods
        #endregion
    }
}
