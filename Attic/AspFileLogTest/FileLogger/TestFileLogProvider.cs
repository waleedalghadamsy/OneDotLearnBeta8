using AspFileLogTest.Helpers;
using Microsoft.Extensions.Options;

namespace AspFileLogTest.FileLogger
{
    public class TestFileLogProvider : ILoggerProvider//, ISupportExternalScope, IAsyncDisposable
    {
        public readonly TestFileLoggerOptions Options;

        public TestFileLogProvider(IOptions<TestFileLoggerOptions> _options)
        {
            Options = _options.Value;

            if (!Directory.Exists(Options.FolderPath))
            {
                Directory.CreateDirectory(Options.FolderPath);
            }
        }

        public ILogger CreateLogger(string categoryName)
        {
            if (TestWebHelper.LogCategories == null)
                TestWebHelper.LogCategories = new List<string>();

            TestWebHelper.LogCategories.Add(categoryName);

            return new TestFileLogger(this);
        }

        public void Dispose()
        {
        }

    }
}
