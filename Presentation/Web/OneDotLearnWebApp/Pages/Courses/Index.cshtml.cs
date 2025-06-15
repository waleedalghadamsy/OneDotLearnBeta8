using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OneDotLearnWebApp.Helpers;

namespace OneDotLearnWebApp.Pages.Courses
{
    public class IndexModel : PageModel
    {
        #region Data Members
        LoggerHelper logHlpr;
        #endregion

        #region Constructors
        public IndexModel(LoggerHelper lgHlpr )
        {
            logHlpr = lgHlpr;
        }
        #endregion

        #region Properties
        [BindProperty]
        public int NoOfCourses { get; set; }
        #endregion

        #region Methods
        public async Task<IActionResult> OnGetAsync()
        {
            try
            {
                return Page();
            }
            catch (Exception ex)
            {
                await logHlpr.LogErrorAsync(ex);

                return Page();
            }
        }
        #endregion
    }
}
