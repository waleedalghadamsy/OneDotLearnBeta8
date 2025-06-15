using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneDotLearnCore.Search
{
    public class SearchResult
    {
        #region Data Members
        #endregion

        #region Constructors
        #endregion

        #region Properties
        public SearchTarget Target { get; set; }
        public string? Title { get; set; }
        public string? PartialContent { get; set; }
        [DataType(DataType.DateTime)]
        public DateTimeOffset? ArticleDateTime { get; set; }
        #endregion

        #region Methods
        #endregion
    }
}
