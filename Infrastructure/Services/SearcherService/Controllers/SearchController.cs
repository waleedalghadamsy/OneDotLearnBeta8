using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OneDotLearnData;

namespace SearcherService.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class SearchController : ControllerBase
    {
        #region Data Members
        #endregion

        #region Constructors
        #endregion

        #region Properties
        #endregion

        #region Methods
        //Search in:
        //Courses: title, contents
        //Blog articles: title, contents
        public async Task<string> FindAsync(string searchTerm)
        {
            try
            {

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
