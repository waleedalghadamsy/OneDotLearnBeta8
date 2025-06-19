using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OneDotLearnCore.Essential;
using OneDotLearnCore.Financials;
using OneDotLearnData;

namespace FinancialsService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EpaymentCardsController : ControllerBase
    {
        #region Data Members
        private OdlDataHelper odlDatHlpr;
        private LoggerDataHelper logDatHlpr;
        #endregion

        #region Constructors
        public EpaymentCardsController(OdlDataContext dbCtx, LoggingDataContext logCtx)
        {
            odlDatHlpr = OdlDataHelper.Instance; odlDatHlpr.DbCtx = dbCtx;
            logDatHlpr = LoggerDataHelper.Instance; logDatHlpr.DbCtx = logCtx;
        }
        #endregion

        #region Properties
        #endregion

        #region Methods
        [ActionName("GenerateCardAsync")]
        [HttpPost]
        public async Task<EpaymentCard> GenerateCardAsync()
        {
            try
            {
                //var random = new Random();
                return new EpaymentCard()
                {
                    CardNumber = Guid.NewGuid().ToString(),
                    CardValueGroup = CardValueGroup.OneHundredDinars,
                    Value = (int)CardValueGroup.OneHundredDinars
                };
            }
            catch (Exception ex)
            {
                await logDatHlpr.LogErrorAsync(ex);
                throw;
            }
        }

        [ActionName("DeliverCardBatchAsync")]
        [HttpPost]
        public async Task<OpResult> DeliverCardBatchAsync()
        {
            try
            {
                return null;
            }
            catch (Exception)
            {

                throw;
            }
        }

        [ActionName("GenerateCardBatchAsync")]
        [HttpPost]
        public async Task<FileResult> GenerateCardBatchAsync()
        {
            try
            {
                return null;
            }
            catch (Exception)
            {

                throw;
            }
        }

        [ActionName("ConsumeCardAsync")]
        [HttpPost]
        public async Task<OpResult> ConsumeCardAsync(EpConsumedCard consumedCard)
        {
            try
            {
                // Here you would implement the logic to consume the card
                // For now, we will just return a successful result
                return OpResult.Succeeded;
            }
            catch (Exception ex)
            {
                await logDatHlpr.LogErrorAsync(ex);
                return OpResult.Failed;
            }
        }
        #endregion
    }
}
