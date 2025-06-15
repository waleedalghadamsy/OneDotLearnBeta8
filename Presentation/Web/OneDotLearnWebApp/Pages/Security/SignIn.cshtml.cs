using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OneDotLearnCore.Security;
using OneDotLearnWebApp.Helpers;

namespace OneDotLearnWebApp.Pages.Security
{
    public class SignInModel : PageModel
    {
        #region Data Members
        private SecurityHelper secHlpr;
        #endregion

        #region Constructors
        public SignInModel(SecurityHelper securityHelper)
        {
            secHlpr = securityHelper;
        }
        #endregion

        #region Properties
        [BindProperty]
        public User SignInUser { get; set; }
        #endregion

        #region Methods
        public void OnGet()
        {
            secHlpr.IsAuthenticated = false;
        }

        public void OnPost()
        {
            secHlpr.CurrentUser = secHlpr.AllUsers.First();
            secHlpr.IsAuthenticated = true;
        }
        #endregion


    }
}
