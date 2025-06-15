using OneDotLearnCore.Search;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneDotLearnData
{
    public class SearchDataHelper
    {
        #region Data Members
        #endregion

        #region Constructors
        #endregion

        #region Properties
        #endregion

        #region Methods
        public async Task<List<SearchResult>> Find(string searchTerm)
        {
            List<SearchResult> rslt = new ();

            try
            {
                var crsRslt = await SearchCourses(searchTerm);
                var blgRslt = await SearchBlogArticles(searchTerm);
                var rslt1 = crsRslt != null && crsRslt.Any() ? crsRslt : null;
                var rslt2 = blgRslt != null && blgRslt.Any() ? blgRslt : null;

                if (rslt1 != null)
                    rslt = new List<SearchResult>(rslt1);
                else if (rslt2 != null)
                    rslt = new List<SearchResult>(rslt2);

                if (rslt1 != null && rslt2 != null)
                    rslt.AddRange(rslt2);

                return rslt.Any() ? rslt : null;
            }
            catch (Exception ex)
            {
                await LoggerDataHelper.Instance.LogErrorAsync(ex);
                throw;
            }
        }

        private async Task<List<SearchResult>> SearchCourses(string searchTerm)
        {
            try
            {
                var rsltInTtl = OdlDataHelper.Instance.Courses.GetAsync(c =>
                                                        c.LatinTitle.Contains(searchTerm));
                var rsltInCntnt = OdlDataHelper.Instance.Courses.GetAsync(c =>
                                                        c.LatinTitle.Contains(searchTerm));
                return null;
            }
            catch (Exception ex)
            {
                await LoggerDataHelper.Instance.LogErrorAsync(ex);
                throw;
            }
        }

        private async Task<List<SearchResult>> SearchBlogArticles(string searchTerm)
        {
            try
            {
                return null;
            }
            catch (Exception ex)
            {
                await LoggerDataHelper.Instance.LogErrorAsync(ex);
                throw;
            }
        }
        #endregion
    }
}
