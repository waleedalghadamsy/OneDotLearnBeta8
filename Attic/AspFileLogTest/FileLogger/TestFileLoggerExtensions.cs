using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Logging.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace AspFileLogTest.FileLogger
{
    public static partial class TestFileLoggerExtensions
    {
        public static ILoggingBuilder AddOdlFileLogger(this ILoggingBuilder builder,
                                                    Action<TestFileLoggerOptions> configure)
        {
            builder.Services.AddSingleton<ILoggerProvider, TestFileLogProvider>();
            builder.Services.Configure(configure);
            return builder;
        }
    }
}
