using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OneDotLearnCore.Logging;
using OneDotLearnData;

namespace LoggerService.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class LoggerController : ControllerBase
    {
        #region Data Members
        #endregion

        #region Constructors
        public LoggerController(OneDotLearnData.LoggingDataContext dbCtx)
        {
            LoggerDataHelper.Instance.DataContext = dbCtx;
        }
        #endregion

        #region Properties
        #endregion

        #region Methods
        [ActionName("LogDebugAsync")]
        [HttpPost]
        public async Task LogDebugAsync(DebugEvent debugEvent)
        {
            try
            {
                await LoggerDataHelper.Instance.LogAsync(debugEvent);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        [ActionName("LogErrorAsync")]
        [HttpPost]
        public async Task LogErrorAsync(ErrorEvent errorEvent)
        {
            try
            {
                await LoggerDataHelper.Instance.LogAsync(errorEvent);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        [ActionName("GetLastNDebuEventsAsync")]
        [HttpGet("{nLogEvents}")]
        public async Task<List<DebugEvent>> GetLastNDebugEventsAsync(int nLogEvents)
        {
            try
            {
                return await LoggerDataHelper.Instance.GetLastNLogEventsAsync(nLogEvents);
            }
            catch (Exception ex)
            {
                await LoggerDataHelper.Instance.LogErrorAsync(ex);
                throw;
            }
        }

        [ActionName("GetDebugEventAsync")]
        [HttpGet("{lgEvId}")]
        public async Task<DebugEvent> GetDebugEventAsync(int lgEvId)
        {
            try
            {
                return await LoggerDataHelper.Instance.GetLogEventAsync(lgEvId);
            }
            catch (Exception ex)
            {
                await LoggerDataHelper.Instance.LogErrorAsync(ex);
                throw;
            }
        }

        [ActionName("GetLastNErrorEventsAsync")]
        [HttpGet("{nErrEvents}")]
        public async Task<List<ErrorEvent>> GetLastNErrorEventsAsync(int nErrEvents)
        {
            try
            {
                return await LoggerDataHelper.Instance.GetLastNErrorEventsAsync(nErrEvents);
            }
            catch (Exception ex)
            {
                await LoggerDataHelper.Instance.LogErrorAsync(ex);
                throw;
            }
        }

        [ActionName("GetErrorEventAsync")]
        [HttpGet("{errEvId}")]
        public async Task<ErrorEvent> GetErrorLogEventAsync(int errEvId)
        {
            try
            {
                return await LoggerDataHelper.Instance.GetErrorEventAsync(errEvId);
            }
            catch (Exception ex)
            {
                await LoggerDataHelper.Instance.LogErrorAsync(ex);
                throw;
            }
        }

        //[ActionName("GetLastNLogEventsAsXml")]
        //[HttpGet("{nLogEvents}")]
        //public async Task<string> GetLastNLogEventsAsXml(int nLogEvents)
        //{
        //    try
        //    {
        //        return MyCareSysDataHelper.FormatLogEventsAsXml(await MyCareSysDataHelper.GetLastNLogEvents(nLogEvents));
        //    }
        //    catch (Exception ex)
        //    {
        //        await MyCareSysDataHelper.LogError(ex);
        //        throw ex;
        //    }
        //}

        //[ActionName("GetLastNUsersActions")]
        //[HttpGet("{noOfActions}")]
        //public async Task<List<UserAction>> GetLastNUsersActions(int noOfActions)
        //{
        //    try
        //    {
        //        return await MyCareSysDataHelper.GetLastNUsersActions(noOfActions);
        //    }
        //    catch (Exception ex)
        //    {
        //        await MyCareSysDataHelper.LogError(ex);
        //        throw ex;
        //    }
        //}

        //[ActionName("RetrieveRecords")]
        //[HttpGet("{selStmt}")]
        //public async Task<List<string>> RetrieveRecords(string selStmt)
        //{
        //    try
        //    {
        //        return await MyCareSysDataHelper.RetrieveRecords(selStmt);
        //    }
        //    catch (Exception ex)
        //    {
        //        await MyCareSysDataHelper.LogError(ex);
        //        throw ex;
        //    }
        //}
        #endregion
    }
}
