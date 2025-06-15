using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OneDotLearnCore.Essential;
using OneDotLearnCore.Financials;
using OneDotLearnData;

namespace FinancialsService.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CurrenciesController : ControllerBase
    {
        #region Data Members
        private OdlDataHelper odlDatHlpr;
        private LoggerDataHelper logDatHlpr;
        #endregion

        #region Constructors
        public CurrenciesController(OdlDataContext dbCtx, LoggingDataContext logCtx)
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
        public async Task<List<Currency>> GetAllAsync()
        {
            try
            {
                return await odlDatHlpr.Currencies.GetAllAsync();
            }
            catch (Exception ex)
            {
                await logDatHlpr.LogErrorAsync(ex);
                throw;
            }
        }

        [ActionName("GetPageAsync")]
        [HttpGet("{pageIndex}/{pageSize}")]
        public async Task<List<Currency>> GetPageAsync(int pageIndex, int pageSize)
        {
            try
            {
                return await odlDatHlpr.Currencies.GetPageAsync(pageIndex, pageSize);
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
                return await odlDatHlpr.Currencies.GetCountAsync();
            }
            catch (Exception ex)
            {
                await logDatHlpr.LogErrorAsync(ex);
                throw;
            }
        }

        [ActionName("GetAsync")]
        [HttpGet("{id}")]
        public async Task<Currency> GetAsync(int id)
        {
            try
            {
                return await odlDatHlpr.Currencies.GetByIdAsync(id);
            }
            catch (Exception ex)
            {
                await logDatHlpr.LogErrorAsync(ex);
                throw;
            }
        }

        [ActionName("AddAsync")]
        [HttpPost]
        public async Task<OpResult> AddAsync(Currency newCurrency)
        {
            try
            {
                return await odlDatHlpr.Currencies.AddAsync(newCurrency);
            }
            catch (Exception ex)
            {
                await logDatHlpr.LogErrorAsync(ex);
                throw;
            }
        }

        [ActionName("ModifyAsync")]
        [HttpPut]
        public async Task<OpResult> ModifyAsync(Currency cr)
        {
            try
            {
                return await odlDatHlpr.Currencies.UpdateAsync(cr);
            }
            catch (Exception ex)
            {
                await logDatHlpr.LogErrorAsync(ex);
                throw;
            }
        }

        [ActionName("GetRecentRatesAsync")]
        [HttpGet]
        public async Task<List<CurrencyRate>> GetRecentRatesAsync()
        {
            try
            {
                var allRates = await odlDatHlpr.CurrenciesRates.GetAllAsync();
                var rcntRates = from rt in allRates
                                group rt by rt.CurrencyId into rtGrps
                                select rtGrps.OrderByDescending(ct => ct.CreatedOn).First();

                return rcntRates.ToList();
            }
            catch (Exception ex)
            {
                await logDatHlpr.LogErrorAsync(ex);
                throw;
            }
        }

        [ActionName("GetRateAsync")]
        [HttpGet("{id}")]
        public async Task<CurrencyRate> GetRateAsync(int id)
        {
            try
            {
                return await odlDatHlpr.CurrenciesRates.GetLastAsync(cr => cr.CurrencyId == id);
            }
            catch (Exception ex)
            {
                await logDatHlpr.LogErrorAsync(ex);
                throw;
            }
        }

        [ActionName("AddRateAsync")]
        [HttpPost]
        public async Task<OpResult> AddRateAsync(CurrencyRate rate)
        {
            try
            {
                return await odlDatHlpr.CurrenciesRates.AddAsync(rate);
            }
            catch (Exception ex)
            {
                await logDatHlpr.LogErrorAsync(ex);
                throw;
            }
        }

        [ActionName("AddRatesAsync")]
        [HttpPost]
        public async Task<OpResult> AddRatesAsync(List<CurrencyRate> rates)
        {
            try
            {
                return await odlDatHlpr.CurrenciesRates.AddRangeAsync(rates);
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
