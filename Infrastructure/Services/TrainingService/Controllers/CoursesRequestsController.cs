using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OneDotLearnCore.Essential;
using OneDotLearnCore.Training;
using OneDotLearnData;

namespace TrainingService.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CoursesRequestsController : ControllerBase
    {
        #region Data Members
        private OdlDataHelper odlDatHlpr;
        private LoggerDataHelper logDatHlpr;
        #endregion

        #region Constructors
        public CoursesRequestsController(OdlDataContext dbCtx, LoggingDataContext logCtx)
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
        public async Task<List<CourseRequest>> GetPageAsync(int pageIndex, int pageSize)
        {
            try
            {
                var crsRqs = await odlDatHlpr.RequestedCourses.GetPageAsync(pageIndex, pageSize);

                //if (crsRqs != null && crsRqs.Any())
                //    foreach (var crsRq in crsRqs)
                //        await PopulateCourseRequestAsync(crsRq);

                return crsRqs;
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
                return await odlDatHlpr.RequestedCourses.GetCountAsync();
            }
            catch (Exception ex)
            {
                await logDatHlpr.LogErrorAsync(ex);
                throw;
            }
        }

        [ActionName("GetAsync")]
        [HttpGet("{id}")]
        public async Task<CourseRequest> GetAsync(int id)
        {
            try
            {
                var crsRq = await odlDatHlpr.RequestedCourses.GetByIdAsync(id);

                //await PopulateCourseRequestAsync(crsRq);

                return crsRq;
            }
            catch (Exception ex)
            {
                await logDatHlpr.LogErrorAsync(ex);
                throw;
            }
        }

        [ActionName("GetTraineeRequestsAsync")]
        [HttpGet("{trnId}")]
        public async Task<List<CourseRequest>?> GetTraineeRequestsAsync(int trnId)
        {
            try
            {
                var trnReqs = await odlDatHlpr.RequestedCourses.GetAsync(
                                rc => rc.Source == RequestSource.Trainee && rc.CreatedById == trnId);

                //await PopulateCourseRequestAsync(crsRq);

                return trnReqs != null && trnReqs.Any() ? trnReqs.ToList() : null;
            }
            catch (Exception ex)
            {
                await logDatHlpr.LogErrorAsync(ex);
                throw;
            }
        }

        [ActionName("AddAsync")]
        [HttpPost]
        public async Task<OpResult> AddAsync(CourseRequest crsRequest)
        {
            try
            {
                return await odlDatHlpr.RequestedCourses.AddAsync(crsRequest);
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
