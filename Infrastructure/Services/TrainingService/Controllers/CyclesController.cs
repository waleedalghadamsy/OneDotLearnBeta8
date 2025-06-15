using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OneDotLearnCore.Essential;
using OneDotLearnCore.Training;
using OneDotLearnData;

namespace TrainingService.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CyclesController : ControllerBase
    {
        #region Data Members
        private OdlDataHelper odlDatHlpr;
        private LoggerDataHelper logDatHlpr;
        #endregion

        #region Constructors
        public CyclesController(OdlDataContext dbCtx, LoggingDataContext logCtx)
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
        public async Task<List<Cycle>?> GetPageAsync(int pageIndex, int pageSize)
        {
            try
            {
                var cycles = await odlDatHlpr.ProductsCycles.GetPageAsync(pageIndex, pageSize);

                if (cycles != null && cycles.Any())
                    foreach (var cycle in cycles)
                    {
                        await PopulateCycleInfoAsync(cycle);
                        //cycle.Level = course.Level; cycle.CourseFees = course.Fees;
                    }

                return cycles;
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
                return await odlDatHlpr.ProductsCycles.GetCountAsync();
            }
            catch (Exception ex)
            {
                await logDatHlpr.LogErrorAsync(ex);
                throw;
            }
        }

        [ActionName("GetAsync")]
        [HttpGet("{id}")]
        public async Task<Cycle> GetAsync(int id)
        {
            try
            {
                var cycle = await odlDatHlpr.ProductsCycles.GetByIdAsync(id);

                await PopulateCycleInfoAsync(cycle);

                return cycle;
            }
            catch (Exception ex)
            {
                await logDatHlpr.LogErrorAsync(ex);
                throw;
            }
        }

        [ActionName("GetAllCourseCyclesAsync")]
        [HttpGet("{courseId}")]
        public async Task<List<Cycle>?> GetAllCourseCyclesAsync(int courseId)
        {
            try
            {
                var trCrHelper = odlDatHlpr;
                var crsCyls = await trCrHelper.ProductsCycles.GetAsync(cyl => cyl.ProductId == courseId);

                if (crsCyls != null && crsCyls.Any())
                {
                    var cylIds = crsCyls.Select(cc => cc.Id);

                    return (await trCrHelper.ProductsCycles.GetAsync(
                                        cyl => cylIds.Any(ci => cyl.Id == ci))).ToList();
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

        [ActionName("GetCourseCyclesAsync")]
        [HttpGet("{courseId}/{startAfterTicks}/{startBeforeTicks}")]
        public async Task<List<Cycle>?> GetCourseCyclesAsync(int courseId, long startAfterTicks, long startBeforeTicks)
        {
            try
            {
                var trCrHelper = odlDatHlpr;
                var crsCyls = await trCrHelper.ProductsCycles.GetAsync(cyl => cyl.ProductId == courseId);

                if (AreThereCycles(crsCyls))
                {
                    if (startAfterTicks > 0)
                        crsCyls = crsCyls.Where(cyl => cyl.PlannedStartDate.Ticks >= startAfterTicks);

                    if (AreThereCycles(crsCyls) && startBeforeTicks > 0)
                        crsCyls = crsCyls.Where(cyl => cyl.PlannedStartDate.Ticks <= startBeforeTicks);

                    if (AreThereCycles(crsCyls))
                    {
                        var cylIds = crsCyls.Select(cc => cc.Id);

                        return (await trCrHelper.ProductsCycles.GetAsync(
                                        cyl => cylIds.Any(ci => cyl.Id == ci))).ToList();
                    }
                    else
                        return null;
                }
                else
                    return null;
            }
            catch (Exception ex)
            {
                await logDatHlpr.LogErrorAsync(ex);
                throw;
            }

            bool AreThereCycles(IEnumerable<Cycle> dbCycles)
            {
                return dbCycles != null && dbCycles.Any();
            }
        }

        [ActionName("GetCurrentCourseCyclesAsync")]
        [HttpGet("{courseId}")]
        public async Task<List<Cycle>?> GetCurrentCourseCyclesAsync(int courseId)
        {
            try
            {
                var trCrHelper = odlDatHlpr;
                var crsCyls = await trCrHelper.ProductsCycles.GetAsync(cyl =>
                                    cyl.ProductId == courseId
                                    && (cyl.Status == CycleStatus.Planned || cyl.Status == CycleStatus.Started));

                if (crsCyls != null && crsCyls.Any())
                {
                    var cylIds = crsCyls.Select(cc => cc.Id);

                    return (await trCrHelper.ProductsCycles.GetAsync(cyl => cylIds.Any(ci => cyl.Id == ci))).ToList();
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
        public async Task<OpResult> AddAsync(Cycle newCycle)
        {
            try
            {
                return await odlDatHlpr.ProductsCycles.AddAsync(newCycle);
            }
            catch (Exception ex)
            {
                await logDatHlpr.LogErrorAsync(ex);
                throw;
            }
        }

        //[ActionName("AddEvaluationAsync")]
        //[HttpPost]
        //public async Task<OpResult> AddEvaluationAsync(Evaluation evaluation)
        //{
        //    try
        //    {
        //        return await TrCrsDataHelper.Instance.CyclesEvaluations.AddAsync(evaluation);
        //    }
        //    catch (Exception ex)
        //    {
        //        await logDatHlpr.LogErrorAsync(ex);
        //        throw;
        //    }
        //}

        [ActionName("RequestAsync")]
        [HttpPost]
        public async Task<OpResult> RequestAsync(CycleRequest cylRequest)
        {
            try
            {
                return await odlDatHlpr.RequestedCycles.AddAsync(cylRequest);
            }
            catch (Exception ex)
            {
                await logDatHlpr.LogErrorAsync(ex);
                throw;
            }
        }

        [ActionName("StartAsync")]
        [HttpPut]
        public async Task<OpResult> StartAsync(int id)
        {
            try
            {
                var trHlpr = odlDatHlpr;
                var cycle = await trHlpr.ProductsCycles.GetByIdAsync(id);

                cycle.Status = CycleStatus.Started;

                return await odlDatHlpr.ProductsCycles.UpdateAsync(cycle);
            }
            catch (Exception ex)
            {
                await logDatHlpr.LogErrorAsync(ex);
                throw;
            }
        }

        [ActionName("PauseAsync")]
        [HttpPut]
        public async Task<OpResult> PauseAsync(int id)
        {
            try
            {
                var trHlpr = odlDatHlpr;
                var cycle = await trHlpr.ProductsCycles.GetByIdAsync(id);

                cycle.Status = CycleStatus.Paused;

                return await odlDatHlpr.ProductsCycles.UpdateAsync(cycle);
            }
            catch (Exception ex)
            {
                await logDatHlpr.LogErrorAsync(ex);
                throw;
            }
        }

        [ActionName("FinishAsync")]
        [HttpPut]
        public async Task<OpResult> FinishAsync(int id)
        {
            try
            {
                var trHlpr = odlDatHlpr;
                var cycle = await trHlpr.ProductsCycles.GetByIdAsync(id);

                cycle.Status = CycleStatus.Finished;

                return await odlDatHlpr.ProductsCycles.UpdateAsync(cycle);
            }
            catch (Exception ex)
            {
                await logDatHlpr.LogErrorAsync(ex);
                throw;
            }
        }

        [ActionName("CancelAsync")]
        [HttpPut]
        public async Task<OpResult> CancelAsync(int id)
        {
            try
            {
                var trHlpr = odlDatHlpr;
                var cycle = await trHlpr.ProductsCycles.GetByIdAsync(id);

                cycle.Status = CycleStatus.Cancelled;

                return await odlDatHlpr.ProductsCycles.UpdateAsync(cycle);
            }
            catch (Exception ex)
            {
                await logDatHlpr.LogErrorAsync(ex);
                throw;
            }
        }

        [ActionName("ModifyAsync")]
        [HttpPut]
        public async Task<OpResult> ModifyAsync(Cycle cycle)
        {
            try
            {
                return await odlDatHlpr.ProductsCycles.UpdateAsync(cycle);
            }
            catch (Exception ex)
            {
                await logDatHlpr.LogErrorAsync(ex);
                throw;
            }
        }

        private async Task PopulateCycleInfoAsync(Cycle cycle)
        {
            try
            {
                var trCrsDatHelper = odlDatHlpr;
                cycle.TrainingProduct = await trCrsDatHelper.Courses.GetByIdAsync(cycle.ProductId);
                cycle.Instructor = await trCrsDatHelper.Instructors.GetByIdAsync(cycle.InstructorId);
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
