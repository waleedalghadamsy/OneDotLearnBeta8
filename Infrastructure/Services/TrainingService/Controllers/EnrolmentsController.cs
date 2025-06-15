using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OneDotLearnCore.Essential;
using OneDotLearnCore.Training;
using OneDotLearnData;

namespace TrainingService.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class EnrolmentsController : ControllerBase
    {
        #region Data Members
        private OdlDataHelper odlDatHlpr;
        private LoggerDataHelper logDatHlpr;
        #endregion

        #region Constructors
        public EnrolmentsController(OdlDataContext dbCtx, LoggingDataContext logCtx)
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
        public async Task<List<Enrolment>?> GetPageAsync(int pageIndex, int pageSize)
        {
            try
            {
                var regsts = await odlDatHlpr.Enrollments.GetPageAsync(pageIndex, pageSize);

                if (regsts != null && regsts.Any())
                    foreach (var reg in regsts)
                        await PopulateEnrollmentInfoAsync(reg);

                return regsts;
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
                return await odlDatHlpr.Enrollments.GetCountAsync();
            }
            catch (Exception ex)
            {
                await logDatHlpr.LogErrorAsync(ex);
                throw;
            }
        }

        [ActionName("GetCycleEnrollmentsAsync")]
        [HttpGet("{cycleId}")]
        public async Task<List<Enrolment>?> GetCycleEnrollmentsAsync(int cycleId)
        {
            try
            {
                var cylEnrls = await odlDatHlpr.Enrollments.GetAsync(
                                                                        rg => rg.CycleId == cycleId);
                if (cylEnrls != null && cylEnrls.Any())
                {
                    foreach (var enrl in cylEnrls)
                        await PopulateEnrollmentInfoAsync(enrl);

                    return cylEnrls.ToList();
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

        [ActionName("GetTraineeEnrollmentsAsync")]
        [HttpGet("{traineeId}")]
        public async Task<List<Enrolment>?> GetTraineeEnrollmentsAsync(int traineeId)
        {
            try
            {
                var trnEnrls = await odlDatHlpr.Enrollments.GetAsync(
                                                                    rg => rg.TraineeId == traineeId);

                if (trnEnrls != null && trnEnrls.Any())
                {
                    foreach (var enrl in trnEnrls)
                        await PopulateEnrollmentInfoAsync(enrl);

                    return trnEnrls.ToList();
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

        [ActionName("GetAsync")]
        [HttpGet("{id}")]
        public async Task<Enrolment> GetAsync(int id)
        {
            try
            {
                var enrl = await odlDatHlpr.Enrollments.GetByIdAsync(id);

                await PopulateEnrollmentInfoAsync(enrl);

                return enrl;
            }
            catch (Exception ex)
            {
                await logDatHlpr.LogErrorAsync(ex);
                throw;
            }
        }

        [ActionName("AddAsync")]
        [HttpPost]
        public async Task<OpResult> AddAsync(Enrolment enrollment)
        {
            try
            {
                var rslt = await odlDatHlpr.Enrollments.AddAsync(enrollment);

                if (rslt.IsSuccessful)
                {


                    //await TrCrsDataHelper.Instance.Ledger.AddAsync(new JournalEntry()
                    //{
                    //    Type = TransactionType.ReceivablePayment,
                    //    DebitAccountId = newPayment.DebitAccountId,
                    //    CreditAccountId = newPayment.CreditAccountId,
                    //    Amount = newPayment.Amount,
                    //    CurrencyId = newPayment.CurrencyId,
                    //    CreatedById = newPayment.CreatedById,
                    //    CreatedOn = DateTime.Now,
                    //    EntityStatus = EntityStatus.Active
                    //});
                }

                return rslt;
            }
            catch (Exception ex)
            {
                await logDatHlpr.LogErrorAsync(ex);
                throw;
            }
        }

        [ActionName("CancelAsync")]
        [HttpPost]
        public async Task<OpResult> CancelAsync(int enrlId)
        {
            try
            {
                var enrl = await odlDatHlpr.Enrollments.GetByIdAsync(enrlId);

                enrl.IsCancelled = true; enrl.CancelledOn = DateTime.Now;

                return await odlDatHlpr.Enrollments.UpdateAsync(enrl);
            }
            catch (Exception ex)
            {
                await logDatHlpr.LogErrorAsync(ex);
                throw;
            }
        }

        private async Task PopulateEnrollmentInfoAsync(Enrolment enrl)
        {
            try
            {
                var cycle = await odlDatHlpr.ProductsCycles.GetByIdAsync(enrl.CycleId);
                var trn = await odlDatHlpr.Trainees.GetByIdAsync(enrl.TraineeId);

                cycle.Instructor = await odlDatHlpr.Instructors.GetByIdAsync(cycle.InstructorId);

                enrl.Cycle = cycle; enrl.Trainee = trn;
                enrl.Country = await odlDatHlpr.Countries.GetByIdAsync(enrl.CountryId);
                enrl.Currency = await odlDatHlpr.Currencies.GetByIdAsync(enrl.CurrencyId);
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
