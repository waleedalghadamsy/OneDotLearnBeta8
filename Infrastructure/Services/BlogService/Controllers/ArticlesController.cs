using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OneDotLearnCore.Blog;
using OneDotLearnCore.Essential;
using OneDotLearnData;

namespace BlogService.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ArticlesController : ControllerBase
    {
        #region Data Members
        private OdlDataHelper odlDatHlpr;
        private LoggerDataHelper logDatHlpr;
        #endregion

        #region Constructors
        public ArticlesController(OdlDataContext dbCtx, LoggingDataContext logCtx)
        {
            odlDatHlpr = OdlDataHelper.Instance; odlDatHlpr.DbCtx = dbCtx;
            logDatHlpr = LoggerDataHelper.Instance; logDatHlpr.DbCtx = logCtx;
        }
        #endregion

        #region Properties
        #endregion

        #region Methods
        [ActionName("GetArticlesPageAsync")]
        [HttpGet("{}/{}")]
        public async Task<List<Article>> GetArticlesPageAsync(Article article)
        {
            try
            {
                return null;
            }
            catch (Exception ex)
            {
                logDatHlpr.LogErrorAsync(ex);
                throw;
            }
        }

        [ActionName("GetArticleAsync")]
        [HttpGet("{id}")]
        public async Task<Article> GetArticleAsync(int id)
        {
            try
            {
                return await odlDatHlpr.Articles.GetByIdAsync(id);
            }
            catch (Exception ex)
            {
                logDatHlpr.LogErrorAsync(ex);
                throw;
            }
        }

        [ActionName("AddArticleAsync")]
        [HttpPost]
        public async Task<OpResult> AddArticleAsync(Article article)
        {
            try
            {
                return await odlDatHlpr.Articles.AddAsync(article);
            }
            catch (Exception ex)
            {
                logDatHlpr.LogErrorAsync(ex);
                throw;
            }
        }
        #endregion
    }
}
