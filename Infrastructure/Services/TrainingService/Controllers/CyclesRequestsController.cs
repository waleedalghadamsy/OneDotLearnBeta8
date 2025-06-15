using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OneDotLearnCore.Essential;
using OneDotLearnCore.Training;
using OneDotLearnData;

namespace TrainingService.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CyclesRequestsController : ControllerBase
    {
        #region Data Members
        private OdlDataHelper odlDatHlpr;
        private LoggerDataHelper logDatHlpr;
        #endregion

        #region Constructors
        public CyclesRequestsController(OdlDataContext dbCtx, LoggingDataContext logCtx)
        {
            odlDatHlpr = OdlDataHelper.Instance; odlDatHlpr.DbCtx = dbCtx;
            logDatHlpr = LoggerDataHelper.Instance; logDatHlpr.DbCtx = logCtx;
        }
        #endregion

        #region Properties
        #endregion

        #region Methods
        [ActionName("GetPageAsync")]
        [HttpGet("{pageIndex}/{pageSize}")]
        public async Task<List<CycleRequest>> GetPageAsync(int pageIndex, int pageSize)
        {
            try
            {
                var cylReqs = await odlDatHlpr.RequestedCycles.GetPageAsync(pageIndex, pageSize);

                //if (cylReqs != null && cylReqs.Any())
                //    foreach (var cr in cylReqs)
                //        await PopulateCourseAsync(cr);

                return cylReqs;
            }
            catch (Exception ex)
            {
                await logDatHlpr.LogErrorAsync(ex);
                throw;
            }
        }

        [ActionName("GetCountAsync")]
        [HttpGet]
        public async Task<int> GetCountAsync()
        {
            try
            {
                return await odlDatHlpr.RequestedCycles.GetCountAsync();
            }
            catch (Exception ex)
            {
                await logDatHlpr.LogErrorAsync(ex);
                throw;
            }
        }

        [ActionName("GetAsync")]
        [HttpGet("{id}")]
        public async Task<CycleRequest> GetAsync(int id)
        {
            try
            {
                var cylReq = await odlDatHlpr.RequestedCycles.GetByIdAsync(id);
                //var crsCnts = await TrCrsDataHelper.Instance.CoursesContents.GetAsync(cc => cc.CourseId == id);
                //var crsFees = await TrCrsDataHelper.Instance.CoursesFees.GetAsync(cf => cf.CourseId == id);

                //course.Contents = crsCnts != null && crsCnts.Any() ? crsCnts.Select(cc => cc.Content).ToList() : null;
                //course.Fees = crsFees != null && crsFees.Any() ? crsFees.ToList() : null;

                //await PopulateCourseAsync(course, false);

                return cylReq;
            }
            catch (Exception ex)
            {
                await logDatHlpr.LogErrorAsync(ex);
                throw;
            }
        }

        [ActionName("AddAsync")]
        [HttpPost]
        public async Task<OpResult> AddAsync(CycleRequest req)
        {
            try
            {
                return await odlDatHlpr.RequestedCycles.AddAsync(req);
            }
            catch (Exception ex)
            {
                await logDatHlpr.LogErrorAsync(ex);
                throw;
            }
        }
        #endregion
    }
}
