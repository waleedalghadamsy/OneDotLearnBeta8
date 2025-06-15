using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OneDotLearnCore.Logging;
using OneDotLearnCore.Essential;

namespace OneDotLearnData
{
    public class LoggerDataHelper
    {
        #region Data Members
        private static readonly Lazy<LoggerDataHelper> singleton = 
                                    new Lazy<LoggerDataHelper>(() => new LoggerDataHelper());
        private string libPath = $@"C:\For Waleed\Personal\TempFileLog.log";
        #endregion

        #region Constructors
        private LoggerDataHelper()
        { }
        #endregion

        #region Properties
        public static LoggerDataHelper Instance => singleton.Value;
        public string ConnectionString =>  //{ get; set; }
            "User ID = onedotlearn; Password = AaBbCcDd123; Server = localhost; "
            + "Port = 5432; Database = OneDotLearnLogDB; Integrated Security = true; "
            + "Pooling = true; timeout=500; commandtimeout=500";
        public LoggingDataContext DbCtx { get; set; }
        public LoggingDataRepository<RequestedPage> RequestedPages => 
                                        new LoggingDataRepository<RequestedPage>(DbCtx);
        public LoggingDataRepository<DebugEvent> DebugEvents =>
                                        new LoggingDataRepository<DebugEvent>(DbCtx);
        public LoggingDataRepository<ErrorEvent> ErrorEvents =>
                                        new LoggingDataRepository<ErrorEvent>(DbCtx);
        #endregion

        #region Methods
        public async Task LogAsync(DebugEvent DebugEvent)
        {
            try
            {
                var newEntry = await DbCtx.DebugLog.AddAsync(DebugEvent); 
                await DbCtx.SaveChangesAsync();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task LogAsync(ErrorEvent errorEvent)
        {
            try
            {
                var newEntry = await DbCtx.ErrorsLog.AddAsync(errorEvent);
                await DbCtx.SaveChangesAsync();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void Log(DebugEvent DebugEvent)
        {
            try
            {
                var newEntry = DbCtx.DebugLog.Add(DebugEvent);
                DbCtx.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void Log(ErrorEvent errorEvent)
        {
            try
            {
                var newEntry = DbCtx.ErrorsLog.Add(errorEvent);
                DbCtx.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task LogAsync(LogLevel level, string msg)
        {
            try
            {
                var thisMoment = DateTime.Now;
                var method = new System.Diagnostics.StackFrame(4).GetMethod(); 
                var methodContainer = method.DeclaringType;

                await LogAsync(
                    new DebugEvent()
                    {
                        Level = level,
                        SourceClass = $"{methodContainer.FullName}",
                        SourceMethod = $"{method.Name}",
                        Message = msg,
                        Date = thisMoment.ToString("dd-MM-yyyy"),
                        Time = thisMoment.ToString("HH:mm:ss.fffff")
                    });
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task LogDebugAsync(string msg)
        {
            try
            {
                var thisMoment = DateTime.Now;
                var method = new System.Diagnostics.StackFrame(4).GetMethod(); 
                var methodContainer = method.DeclaringType;
                //var mtdAttrs = method.GetCustomAttributes(false);
                //var lgRlAttr = mtdAttrs.FirstOrDefault(atr => atr.GetType().Name.Contains("LoggerRulesAttribute"));
                //var lgRule = lgRlAttr != null ? (LoggingRule?)(lgRlAttr as LoggerRulesAttribute).Rule : null;
                //var theRule = lgRule != null ? lgRule.Value : LoggingRule.None;

                //if (theRule == LoggingRule.None || theRule == LoggingRule.AllLoggingOn
                //                        || theRule == LoggingRule.OnlyExceptionLoggingOff)
                await LogAsync(
                    new DebugEvent()
                    {
                        Level = LogLevel.Debug,
                        SourceClass = $"{methodContainer.FullName}",
                        SourceMethod = $"{method.Name}",
                        Message = msg,
                        Date = thisMoment.ToString("dd-MM-yyyy"),
                        Time = thisMoment.ToString("HH:mm:ss.fffff")
                    });
            }
            catch
            {
            }
        }

        public async Task LogErrorAsync(Exception ex)
        {
            try
            {
                var thisMoment = DateTime.Now;
                var method = new System.Diagnostics.StackFrame(4).GetMethod(); 
                var methodContainer = method.DeclaringType;

                await LogAsync(
                    new ErrorEvent()
                    {
                        Level = ErrorLevel.Dangerous,
                        SourceClass = $"{methodContainer.FullName}",
                        SourceMethod = $"{method.Name}",
                        ExceptionClass = $"{ex.GetType().Name}",
                        Message = GetInnerExceptions(ex),
                        StackTrace = ex.StackTrace,
                        Date = thisMoment.ToString("dd-MM-yyyy"),
                        Time = thisMoment.ToString("HH:mm:ss.fffff")
                    });
            }
            catch
            {
            }
        }

        //public async Task LogInternalAsync(DebugEvent DebugEvent)
        //{
        //    try
        //    {
        //        await LogAsync(DebugEvent);
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //}

        public void LogDebug(string msg)
        {
            try
            {
                var thisMoment = DateTime.Now;
                var method = new System.Diagnostics.StackFrame(4).GetMethod();
                var methodContainer = method.DeclaringType;
                
                Log(new DebugEvent()
                    {
                        Level = LogLevel.Debug,
                        SourceClass = $"{methodContainer.FullName}",
                        SourceMethod = $"{method.Name}",
                        Message = msg,
                        Date = thisMoment.ToString("dd-MM-yyyy"),
                        Time = thisMoment.ToString("HH:mm:ss.fffff")
                    });
            }
            catch
            {
            }
        }

        public void TempFileLog(string msg)
        {
            try
            {
                System.IO.File.AppendAllLines(libPath, new List<string>() { msg });
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<DebugEvent>> GetLastNLogEventsAsync(int noOfEvents)
        {
            try
            {
                //TODO: Resolve this issue
                using var dbCtx = new LoggingDataContext();// null);

                return await dbCtx.DebugLog.OrderByDescending(lv => lv.Id).Take(noOfEvents).ToListAsync();
            }
            catch (Exception ex)
            {
                await LogErrorAsync(ex);

                return null;
            }
        }

        public async Task<DebugEvent> GetLogEventAsync(int id)
        {
            try
            {
                //TODO: Resolve this issue
                using var dbCtx = new LoggingDataContext();// null);

                var prm = new Npgsql.NpgsqlParameter("idParam", id);
                var rslt = dbCtx.DebugLog.FromSqlRaw("SELECT * FROM \"Logger\" WHERE \"Id\" = @idParam", prm);

                return rslt != null && await rslt.AnyAsync() ? await rslt.FirstAsync() : null;
            }
            catch (Exception ex)
            {
                await LogErrorAsync(ex);

                return null;
            }
        }

        public async Task<List<ErrorEvent>> GetLastNErrorEventsAsync(int noOfEvents)
        {
            try
            {
                //TODO: Resolve this issue
                using var dbCtx = new LoggingDataContext();// null);

                return await dbCtx.ErrorsLog
                                .OrderByDescending(lv => lv.Id)
                                .Take(noOfEvents)
                                .ToListAsync();
            }
            catch (Exception ex)
            {
                await LogErrorAsync(ex);

                return null;
            }
        }

        public async Task<ErrorEvent> GetErrorEventAsync(int id)
        {
            try
            {
                //TODO: Resolve this issue
                using var dbCtx = new LoggingDataContext();// null);

                var prm = new Npgsql.NpgsqlParameter("idParam", id);
                var rslt = 
                    dbCtx.ErrorsLog.FromSqlRaw("SELECT * FROM \"Logger\" WHERE \"Id\" = @idParam", prm);

                return rslt != null && await rslt.AnyAsync() ? await rslt.FirstAsync() : null;
            }
            catch (Exception ex)
            {
                await LogErrorAsync(ex);

                return null;
            }
        }

        private string GetInnerExceptions(Exception ex)
        {
            string exceptionMessage = string.Format("[{2}] Message: {0} {1}", ex.Message,
                                        (!string.IsNullOrWhiteSpace(ex.Source) ? "Source: " + ex.Source : ""),
                                        ex.GetType().FullName);

            if (ex.InnerException != null)
                exceptionMessage += " -- INNER: " + GetInnerExceptions(ex.InnerException);

            return exceptionMessage;
        }
        #endregion
    }
}
