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
    [Table("Articles", Schema = "Blog")]
    public class Article : BaseEntity
    {
        #region Data Members
        #endregion

        #region Constructors
        #endregion

        #region Properties
        [Required]
        public int AuthorId { get; set; }
        [Required, DataType(DataType.DateTime)]
        public DateTimeOffset DateTime { get; set; }
        [Required]
        public string? Content { get; set; }
        [NotMapped]
        public List<Comment>? Comments { get; set; }
        [NotMapped]
        public List<LikedArticle>? Likes { get; set; }
        [NotMapped]
        public List<Keyword>? Keywords { get; set; }
        #endregion

        #region Methods
        #endregion
    }
}
