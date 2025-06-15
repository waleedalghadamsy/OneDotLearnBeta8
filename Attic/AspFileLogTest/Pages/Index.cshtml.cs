using AspFileLogTest.Helpers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AspFileLogTest.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            try
            {
                var logCats = TestWebHelper.LogCategories;

                _logger.LogInformation("Into Index.OnGet...");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error in Index.OnGet");
                throw;
            }
        }
    }
}