using OneDotLearnCore.Essential;
using OneDotLearnCore.Security;

namespace OneDotLearnWebApp.Helpers
{
    public class SecurityHelper
    {
        #region Data Members
        #endregion

        #region Constructors
        #endregion

        #region Properties
        #endregion

        #region Methods
        public async Task<OpResult> AddUserAsync(User user)
        {
            return OpResult.Succeeded;
        }

        public async Task<bool> IsLoginNameUsedAsync(string loginName)
        {
            return true;
        }

        public bool IsPasswordCompliant(string password)
        {
            return true;
        }
        #endregion
    }
}
