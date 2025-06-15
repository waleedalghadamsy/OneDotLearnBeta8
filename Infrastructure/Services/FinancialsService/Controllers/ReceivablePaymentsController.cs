using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OneDotLearnCore.Essential;
using OneDotLearnCore.Financials;
using OneDotLearnData;

namespace FinancialsService.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ReceivablePaymentsController : ControllerBase
    {
        #region Data Members
        private OdlDataHelper odlDatHlpr;
        private LoggerDataHelper logDatHlpr;
        #endregion

        #region Constructors
        public ReceivablePaymentsController(OdlDataContext dtCtx, LoggingDataContext logCtx)
        {
            odlDatHlpr = OdlDataHelper.Instance; odlDatHlpr.DbCtx = dtCtx;
            logDatHlpr = LoggerDataHelper.Instance; logDatHlpr.DbCtx = logCtx;
        }
        #endregion

        #region Properties
        #endregion

        #region Methods
        [ActionName("GetPageAsync")]
        [HttpGet("{pageIndex}/{pageSize}")]
        public async Task<List<ReceivablePayment>> GetPageAsync(int pageIndex, int pageSize)
        {
            try
            {
                return await odlDatHlpr.ReceivablePayments.GetPageAsync(pageIndex, pageSize);
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
                return await odlDatHlpr.ReceivablePayments.GetCountAsync();
            }
            catch (Exception ex)
            {
                await logDatHlpr.LogErrorAsync(ex);
                throw;
            }
        }

        [ActionName("GetAsync")]
        [HttpGet("{id}")]
        public async Task<ReceivablePayment> GetAsync(int id)
        {
            try
            {
                return await odlDatHlpr.ReceivablePayments.GetByIdAsync(id);
            }
            catch (Exception ex)
            {
                await logDatHlpr.LogErrorAsync(ex);
                throw;
            }
        }

        [ActionName("AddAsync")]
        [HttpPost]
        public async Task<OpResult> AddAsync(ReceivablePayment newPayment)
        {
            try
            {
                var rslt = await odlDatHlpr.ReceivablePayments.AddAsync(newPayment);

                if (rslt.IsSuccessful)
                    await odlDatHlpr.Journal.AddAsync(new JournalEntry()
                    {
                        Type = TransactionType.ReceivablePayment,
                        DebitAccountId = newPayment.DebitAccountId,
                        CreditAccountId = newPayment.CreditAccountId,
                        Amount = newPayment.Amount,
                        CurrencyId = newPayment.CurrencyId,
                        CreatedById = newPayment.CreatedById,
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

        [HttpGet("{trnId}/{cylId}"), ActionName("ConfirmCycleCashPayment")]
        public async Task<OpResult> ConfirmCycleCashPayment(int trnId, int cylId)
        {
            try
            {
                //TODO: Implement
                return OpResult.Succeeded;
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
