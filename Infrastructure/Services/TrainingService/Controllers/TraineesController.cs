using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OneDotLearnCore.Training;
using OneDotLearnData;

namespace TrainingService.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TraineesController : ControllerBase
    {
        #region Data Members
        private OdlDataHelper odlDatHlpr;
        private LoggerDataHelper logDatHlpr;
        #endregion

        #region Constructors
        public TraineesController(OdlDataContext dbCtx, LoggingDataContext logCtx)
        {
            odlDatHlpr = OdlDataHelper.Instance; odlDatHlpr.DbCtx = dbCtx;
            logDatHlpr = LoggerDataHelper.Instance; logDatHlpr.DbCtx = logCtx;
        }
        #endregion

        #region Properties
        #endregion

        #region Methods
        [ActionName("GetTraineeCyclesAsync")]
        [HttpGet("{traineeId}")]
        public async Task<List<Cycle>?> GetTraineeCyclesAsync(int traineeId)
        {
            try
            {
                var trCrHelper = odlDatHlpr;
                var trnEnrls = await trCrHelper.Enrollments.GetAsync(erl => erl.TraineeId == traineeId);

                if (trnEnrls != null && trnEnrls.Any())
                {
                    var cylIds = trnEnrls.Select(erl => erl.CycleId);

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

        [ActionName("GetCycleTraineesAsync")]
        [HttpGet("{cycleId}")]
        public async Task<List<Trainee>?> GetCycleTraineesAsync(int cycleId)
        {
            try
            {
                var trCrHelper = odlDatHlpr;
                var cycleEnrls = await trCrHelper.Enrollments.GetAsync(erl => erl.CycleId == cycleId);

                if (cycleEnrls != null && cycleEnrls.Any())
                {
                    var trnIds = cycleEnrls.Select(erl => erl.TraineeId);

                    return (await trCrHelper.Trainees.GetAsync(
                                            tr => trnIds.Any(ti => tr.Id == ti))).ToList();
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
        #endregion
    }
}
