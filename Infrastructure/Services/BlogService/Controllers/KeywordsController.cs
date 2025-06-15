using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OneDotLearnCore.Blog;
using OneDotLearnCore.Essential;
using OneDotLearnData;

namespace BlogService.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class KeywordsController : ControllerBase
    {
        #region Data Members
        private OdlDataHelper odlDatHlpr;
        private LoggerDataHelper logDatHlpr;
        #endregion

        #region Constructors
        public KeywordsController(OdlDataContext dbCtx, LoggingDataContext logCtx)
        {
            odlDatHlpr = OdlDataHelper.Instance; odlDatHlpr.DbCtx = dbCtx;
            logDatHlpr = LoggerDataHelper.Instance; logDatHlpr.DbCtx = logCtx;
        }
        #endregion

        #region Properties
        #endregion

        #region Methods
        [ActionName("GetArticleKeywordsAsync")]
        [HttpGet("{articleId}")]
        public async Task<List<Keyword>> GetArticleKeywordsAsync(int articleId)
        {
            try
            {
                var arkws = await odlDatHlpr.ArticlesKeywords.GetAsync(
                                                        akw => akw.ArticleId == articleId);

                if (arkws != null && arkws.Any())
                {
                    var kws = await odlDatHlpr.Keywords.GetAsync(
                                                    kw => arkws.Any(ak => ak.KeywordId == kw.Id));

                    return kws != null && kws.Any() ? kws.ToList() : null;
                }
                else
                    return null;
            }
            catch (Exception ex)
            {
                logDatHlpr.LogErrorAsync(ex);
                throw;
            }
        }

        [ActionName("AddKeywordAsync")]
        [HttpPost]
        public async Task<OpResult> AddKeywordAsync(Keyword keyword)
        {
            try
            {
                return await odlDatHlpr.Keywords.AddAsync(keyword);
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
