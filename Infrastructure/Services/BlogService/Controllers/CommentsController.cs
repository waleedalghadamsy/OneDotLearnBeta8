using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OneDotLearnCore.Blog;
using OneDotLearnCore.Essential;
using OneDotLearnData;

namespace BlogService.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CommentsController : ControllerBase
    {
        #region Data Members
        private OdlDataHelper odlDatHlpr;
        private LoggerDataHelper logDatHlpr;
        #endregion

        #region Constructors
        public CommentsController(OdlDataContext dbCtx, LoggingDataContext logCtx)
        {
            odlDatHlpr = OdlDataHelper.Instance; odlDatHlpr.DbCtx = dbCtx;
            logDatHlpr = LoggerDataHelper.Instance; logDatHlpr.DbCtx = logCtx;
        }
        #endregion

        #region Properties
        #endregion

        #region Methods
        [ActionName("GetArticleCommentsAsync")]
        [HttpGet("{articleId}")]
        public async Task<List<Comment>> GetArticleCommentsAsync(int articleId)
        {
            try
            {
                var cmnts = await odlDatHlpr.Comments.GetAsync(cm => cm.ArticleId == articleId);

                return cmnts != null && cmnts.Any() ? cmnts.ToList() : null;
            }
            catch (Exception ex)
            {
                logDatHlpr.LogErrorAsync(ex);
                throw;
            }
        }

        [ActionName("AddCommentAsync")]
        [HttpPost]
        public async Task<OpResult> AddCommentAsync(Comment comment)
        {
            try
            {
                return await odlDatHlpr.Comments.AddAsync(comment);
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
