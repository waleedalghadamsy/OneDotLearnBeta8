using OneDotLearnCore.Security;

namespace OneDotLearnWebApp.Helpers
{
    public class SecurityHelper
    {
        #region Data Memebers
        #endregion
        #region Constructors
        public SecurityHelper(IConfiguration config)
        {
            SecurityServiceUrl = $"{config.GetValue<string>("SecurityServiceUrl")}/api";
        }
        #endregion
        #region Properties
        public string SecurityServiceUrl { get; set; }
        public string UsersController => $"{SecurityServiceUrl}/Users";
        public List<User> AllUsers { get; set; }
        public User? CurrentUser { get; set; }
        public bool IsAuthenticated { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
