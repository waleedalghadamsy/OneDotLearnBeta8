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
        private LoggerDataHelper logDatHlpr;
        #endregion

        #region Constructors
        public LoggerController(LoggingDataContext logCtx)
        {
            logDatHlpr = LoggerDataHelper.Instance; logDatHlpr.DbCtx = logCtx;
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
                await logDatHlpr.LogAsync(debugEvent);
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
                await logDatHlpr.LogAsync(errorEvent);
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
                return await logDatHlpr.GetLastNLogEventsAsync(nLogEvents);
            }
            catch (Exception ex)
            {
                await logDatHlpr.LogErrorAsync(ex);
                throw;
            }
        }

        [ActionName("GetDebugEventAsync")]
        [HttpGet("{lgEvId}")]
        public async Task<DebugEvent> GetDebugEventAsync(int lgEvId)
        {
            try
            {
                return await logDatHlpr.GetLogEventAsync(lgEvId);
            }
            catch (Exception ex)
            {
                await logDatHlpr.LogErrorAsync(ex);
                throw;
            }
        }

        [ActionName("GetLastNErrorEventsAsync")]
        [HttpGet("{nErrEvents}")]
        public async Task<List<ErrorEvent>> GetLastNErrorEventsAsync(int nErrEvents)
        {
            try
            {
                return await logDatHlpr.GetLastNErrorEventsAsync(nErrEvents);
            }
            catch (Exception ex)
            {
                await logDatHlpr.LogErrorAsync(ex);
                throw;
            }
        }

        [ActionName("GetErrorEventAsync")]
        [HttpGet("{errEvId}")]
        public async Task<ErrorEvent> GetErrorLogEventAsync(int errEvId)
        {
            try
            {
                return await logDatHlpr.GetErrorEventAsync(errEvId);
            }
            catch (Exception ex)
            {
                await logDatHlpr.LogErrorAsync(ex);
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
