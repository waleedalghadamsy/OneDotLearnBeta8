using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OneDotLearnCore.Essential;
using OneDotLearnCore.Training;
using OneDotLearnData;

namespace TrainingService.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class InstructorsController : ControllerBase
    {
        #region Data Members
        private OdlDataHelper odlDatHlpr;
        private LoggerDataHelper logDatHlpr;
        #endregion

        #region Constructors
        public InstructorsController(OdlDataContext dbCtx, LoggingDataContext logCtx)
        {
            odlDatHlpr = OdlDataHelper.Instance; odlDatHlpr.DbCtx = dbCtx;
            logDatHlpr = LoggerDataHelper.Instance; logDatHlpr.DbCtx = logCtx;
        }
        #endregion

        #region Properties
        #endregion

        #region Methods
        [ActionName("GetInstructorCoursesAsync")]
        [HttpGet("{id}")]
        public async Task<List<Course>?> GetInstructorCoursesAsync(int id)
        {
            try
            {
                var instrCrs = await odlDatHlpr.InstructorsCourses.GetAsync(icr => icr.InstructorId == id);

                if (instrCrs != null && instrCrs.Any())
                {
                    var dbCrs = await odlDatHlpr.Courses.GetAsync(
                                                    cr => instrCrs.Any(c => c.CourseId == cr.Id));

                    return dbCrs.ToList();
                }
                else
                    return null;
            }
            catch (Exception ex)
            {
                await logDatHlpr.LogErrorAsync(ex);
                throw;
            }
        }

        [ActionName("GetInstructorsCoursesMapAsync")]
        [HttpGet]
        public async Task<List<InstructorCourse>> GetInstructorsCoursesMapAsync()
        {
            try
            {
                return await odlDatHlpr.InstructorsCourses.GetAllAsync();
            }
            catch (Exception ex)
            {
                await logDatHlpr.LogErrorAsync(ex);
                throw;
            }
        }

        [ActionName("AddInstructorCoursesMapAsync")]
        [HttpPost]
        public async Task<OpResult> AddInstructorCoursesMapAsync(List<InstructorCourse> instrCourses)
        {
            try
            {
                return await odlDatHlpr.InstructorsCourses.AddRangeAsync(instrCourses);
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
