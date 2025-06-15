using OneDotLearnCore.Logging;

namespace OneDotLearnWebApp.Helpers
{
    public class LoggerHelper
    {
        #region Data Members
        #endregion

        #region Constructors
        public LoggerHelper(IConfiguration config)
        {
            LoggerServiceUrl = $"{config.GetValue<string>("LoggerServiceUrl")}/api";
        }
        #endregion

        #region Properties
        public string LoggerServiceUrl { get; set; }
        public string LoggingServiceController => $"{LoggerServiceUrl}/Logging";
        #endregion

        #region Methods
        public void LogDebug(string msg)
        {
            try
            {
                Task.Run(async () => await LogDebugAsync(msg));
            }
            catch (Exception)
            {

            }
        }

        public async Task LogDebugAsync(string msg)
        {
            try
            {
                var thisMoment = DateTime.UtcNow;
                var method = new System.Diagnostics.StackFrame(4).GetMethod();
                var methodContainer = method.DeclaringType;

                var logEvent = new DebugEvent()
                {
                    Level = OneDotLearnCore.Logging.LogLevel.Debug,
                    SourceClass = $"{methodContainer.FullName}",
                    SourceMethod = $"{method.Name}",
                    Message = msg,
                    Date = thisMoment.ToString("dd-MM-yyyy"),
                    Time = thisMoment.ToString("HH:mm:ss.fffff")
                };

                using var httpClnt = new System.Net.Http.HttpClient();

                var jsonStr = System.Text.Json.JsonSerializer.Serialize(logEvent);
                var jsonCnt = new System.Net.Http.StringContent(
                        jsonStr, System.Text.Encoding.UTF8, "application/json");

                var result = await httpClnt.PostAsync(
                                            $"{LoggingServiceController}/LogDebugAsync", jsonCnt);
            }
            catch //(Exception ex)
            {

                throw;
            }
        }

        public void LogError(Exception ex)
        {
            try
            {
                Task.Run(async () => await LogErrorAsync(ex));
            }
            catch
            {

            }
        }

        public async Task LogErrorAsync(Exception ex)
        {
            try
            {
                var thisMoment = DateTime.UtcNow;
                var method = new System.Diagnostics.StackFrame(4).GetMethod();
                var methodContainer = method.DeclaringType;

                var errEvent = new ErrorEvent()
                {
                    Level = OneDotLearnCore.Logging.ErrorLevel.Dangerous,
                    SourceClass = $"{methodContainer.FullName}",
                    SourceMethod = $"{method.Name}",
                    ExceptionClass = $"{ex.GetType().Name}",
                    Message = GetInnerExceptions(ex),
                    StackTrace = ex.StackTrace,
                    Date = thisMoment.ToString("dd-MM-yyyy"),
                    Time = thisMoment.ToString("HH:mm:ss.fffff")
                };

                using var httpClnt = new System.Net.Http.HttpClient();

                var jsonStr = System.Text.Json.JsonSerializer.Serialize(errEvent);
                var jsonCnt = new System.Net.Http.StringContent(
                                jsonStr, System.Text.Encoding.UTF8, "application/json");

                var result = await httpClnt.PostAsync($"{LoggingServiceController}/LogErrorAsync", jsonCnt);

                //var msg = await result.Content.ReadAsStringAsync();
                //var msg = Newtonsoft.Json.JsonConvert.DeserializeObject<string>(await result.Content.ReadAsStringAsync());
            }
            catch //(Exception exp)
            {

                throw;
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
