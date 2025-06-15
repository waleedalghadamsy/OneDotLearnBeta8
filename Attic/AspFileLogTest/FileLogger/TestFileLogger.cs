using System.Diagnostics.CodeAnalysis;

namespace AspFileLogTest.FileLogger
{
    public class TestFileLogger : ILogger
    {
        protected readonly TestFileLogProvider _tstLoggerFileProvider;

        public TestFileLogger([NotNull] TestFileLogProvider odlLoggerFileProvider)
        {
            _tstLoggerFileProvider = odlLoggerFileProvider;
        }

        public IDisposable BeginScope<TState>(TState state)
        {
            return null;
        }

        public bool IsEnabled(LogLevel logLevel)
        {
            return logLevel != LogLevel.None;
        }

        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception,
                                            Func<TState, Exception, string> formatter)
        {
            if (!IsEnabled(logLevel))
            {
                return;
            }

            var fullFilePath = $"{_tstLoggerFileProvider.Options.FolderPath}/" 
                + _tstLoggerFileProvider.Options.FilePath.Replace("{date}", 
                    DateTimeOffset.UtcNow.ToString("yyyyMMdd"));
            var logRecord = string.Format("{0} [{1}] {2} {3}", 
                "[" + DateTimeOffset.UtcNow.ToString("yyyy-MM-dd HH:mm:ss+00:00") + "]", 
                logLevel.ToString(), 
                formatter(state, exception), exception != null ? exception.StackTrace : "");

            using (var streamWriter = new StreamWriter(fullFilePath, true))
            {
                streamWriter.WriteLine(logRecord);
            }
        }
    }
}
