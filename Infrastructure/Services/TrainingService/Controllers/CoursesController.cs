using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OneDotLearnCore.Essential;
using OneDotLearnCore.People;
using OneDotLearnCore.Training;
using OneDotLearnData;

namespace TrainingService.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        #region Data Members
        private OdlDataHelper odlDatHlpr;
        private LoggerDataHelper logDatHlpr;
        #endregion

        #region Constructors
        public CoursesController(OdlDataContext dbCtx, LoggingDataContext logCtx)
        {
            odlDatHlpr = OdlDataHelper.Instance; odlDatHlpr.DbCtx = dbCtx;
            logDatHlpr = LoggerDataHelper.Instance; logDatHlpr.DbCtx = logCtx;
        }
        #endregion

        #region Properties
        #endregion

        #region Methods
        [ActionName("GetAllAsync")]
        [HttpGet]
        public async Task<List<Course>?> GetAllAsync()
        {
            try
            {
                var allCrs = await odlDatHlpr.Courses.GetAllAsync();

                if (allCrs != null && allCrs.Any())
                    foreach (var crs in allCrs)
                        await PopulateCourseAsync(crs);

                return allCrs;
            }
            catch (Exception ex)
            {
                await logDatHlpr.LogErrorAsync(ex);
                throw;
            }
        }

        [ActionName("GetPageAsync")]
        [HttpGet("{pageIndex}/{pageSize}")]
        public async Task<List<Course>?> GetPageAsync(int pageIndex, int pageSize)
        {
            try
            {
                var courses = await odlDatHlpr.Courses.GetPageAsync(pageIndex, pageSize);

                if (courses != null && courses.Any())
                    foreach (var crs in courses)
                        await PopulateCourseAsync(crs);

                return courses;
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
                return await odlDatHlpr.Courses.GetCountAsync();
            }
            catch (Exception ex)
            {
                await logDatHlpr.LogErrorAsync(ex);
                throw;
            }
        }

        [ActionName("GetAsync")]
        [HttpGet("{id}")]
        public async Task<Course> GetAsync(int id)
        {
            try
            {
                var course = await odlDatHlpr.Courses.GetByIdAsync(id);

                await PopulateCourseAsync(course, false);

                return course;
            }
            catch (Exception ex)
            {
                await logDatHlpr.LogErrorAsync(ex);
                throw;
            }
        }

        [ActionName("GetPrerequisitesAsync")]
        [HttpGet("{id}")]
        public async Task<List<Prerequisite>?> GetPrerequisitesAsync(int id)
        {
            try
            {
                var crsPrq = await odlDatHlpr.Prerequisites.GetAsync(
                                pr => pr.ProductType == ProductType.Course && pr.ProductId == id);

                return crsPrq != null && crsPrq.Any() ? crsPrq.ToList() : null;
            }
            catch (Exception ex)
            {
                await logDatHlpr.LogErrorAsync(ex);
                throw;
            }
        }

        [ActionName("GetInstrcutorsAsync")]
        [HttpGet("{id}")]
        public async Task<List<Instructor>?> GetInstrcutorsAsync(int id)
        {
            try
            {
                var trHlpr = odlDatHlpr;
                var crsInstr = await trHlpr.InstructorsCourses.GetAsync(icr => icr.CourseId == id);

                if (crsInstr != null && crsInstr.Any())
                {
                    var instsIds = crsInstr.Select(ci => ci.InstructorId);
                    var instrs = new List<Instructor>();

                    foreach (var instId in instsIds)
                        instrs.Add(await trHlpr.Instructors.GetByIdAsync(instId));

                    return instrs;
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

        [ActionName("AddAsync")]
        [HttpPost]
        public async Task<OpResult> AddAsync(Course newCourse)
        {
            try
            {
                var rslt = await odlDatHlpr.Courses.AddAsync(newCourse);

                if (newCourse.Contents != null && newCourse.Contents.Any())
                    foreach (var cnt in newCourse.Contents)
                        await odlDatHlpr.CoursesContents.AddAsync(new CourseContent()
                        {
                            CourseId = rslt.AddedEntityId,
                            Content = cnt,
                            CreatedById = newCourse.CreatedById,
                            CreatedOn = DateTime.Now,
                            EntityStatus = EntityStatus.Active
                        });

                if (newCourse.Instructors != null && newCourse.Instructors.Any())
                    foreach (var instr in newCourse.Instructors)
                        await odlDatHlpr.InstructorsCourses.AddAsync(new InstructorCourse()
                        {
                            CourseId = rslt.AddedEntityId,
                            InstructorId = instr.Id,
                            CreatedById = newCourse.CreatedById,
                            CreatedOn = DateTime.Now,
                            EntityStatus = EntityStatus.Active
                        });

                return rslt;
            }
            catch (Exception ex)
            {
                await logDatHlpr.LogErrorAsync(ex);
                throw;
            }
        }

        [ActionName("ModifyAsync")]
        [HttpPut]
        public async Task<OpResult> ModifyAsync(Course course)
        {
            try
            {
                return await odlDatHlpr.Courses.UpdateAsync(course);
            }
            catch (Exception ex)
            {
                await logDatHlpr.LogErrorAsync(ex);
                throw;
            }
        }

        [ActionName("ModifyContentsAsync")]
        [HttpPut]
        public async Task<OpResult> ModifyContentsAsync(Course course)
        {
            try
            {
                var trHlpr = odlDatHlpr;
                var crsCnts = await trHlpr.CoursesContents.GetAsync(cc => cc.CourseId == course.Id);

                if (crsCnts != null && crsCnts.Any())
                    foreach (var cnt in crsCnts)
                        await trHlpr.CoursesContents.DeleteAsync(cnt.Id);

                foreach (var cnt in course.Contents)
                    await trHlpr.CoursesContents.AddAsync(new CourseContent()
                    {
                        CourseId = course.Id,
                        Content = cnt,
                        CreatedById = course.CreatedById,
                        CreatedOn = DateTime.Now,
                        EntityStatus = EntityStatus.Active
                    });

                return new OpResult() { IsSuccessful = true };
            }
            catch (Exception ex)
            {
                await logDatHlpr.LogErrorAsync(ex);
                throw;
            }
        }

        private async Task PopulateCourseAsync(Course course, bool includeContents = true)
        {
            try
            {
                var trHelper = odlDatHlpr;
                var crsId = course.Id;
                var crsFees = await trHelper.ProductsFees.GetAsync(
                            pf => pf.ProductType == ProductType.Course && pf.ProductId == crsId);
                //var crsInstrs = await trHelper.InstructorsCourses.GetAsync(ic => ic.CourseId == crsId);
                //var instrs = crsInstrs != null && crsInstrs.Any() 
                //    ? (await trHelper.Instructors
                //            .GetAsync(ins => crsInstrs.Any(ci => ci.InstructorId == ins.Id))).ToList() 
                //    : null;

                course.Fees = crsFees != null && crsFees.Any() ? crsFees.ToList() : null;
                //course.Instructors = instrs;

                if (includeContents)
                {
                    var crsCnts = await trHelper.CoursesContents.GetAsync(cc => cc.CourseId == crsId);
                    course.Contents = crsCnts != null && crsCnts.Any()
                        ? crsCnts.OrderBy(cc => cc.Id).Select(cc => cc.Content).ToList() : null;
                }

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
