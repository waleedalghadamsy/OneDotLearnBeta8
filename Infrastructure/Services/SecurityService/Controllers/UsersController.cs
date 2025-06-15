using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OneDotLearnCore.Essential;
using OneDotLearnCore.Security;
using OneDotLearnData;

namespace SecurityService.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        #region Data Members
        private OdlDataHelper odlDatHlpr;
        private LoggerDataHelper logDatHlpr;
        #endregion

        #region Constructors
        public UsersController(OdlDataContext dbCtx, LoggingDataContext logCtx)
        {
            odlDatHlpr = OdlDataHelper.Instance; odlDatHlpr.DbCtx = dbCtx;
            logDatHlpr = LoggerDataHelper.Instance; logDatHlpr.DbCtx = logCtx;
        }
        #endregion

        #region Properties
        #endregion

        #region Methods
        [ActionName("GetAllAsync")]
        [HttpGet]
        public async Task<List<User>> GetAllAsync()
        {
            try
            {
                return await odlDatHlpr.Users.GetAllAsync();
            }
            catch (Exception ex)
            {
                await logDatHlpr.LogErrorAsync(ex);
                throw;
            }
        }

        [ActionName("GetPageAsync")]
        [HttpGet("{pageIndex}/{pageSize}")]
        public async Task<List<User>> GetPageAsync(int pageIndex, int pageSize)
        {
            try
            {
                return await odlDatHlpr.Users.GetPageAsync(pageIndex, pageSize);
            }
            catch (Exception ex)
            {
                await logDatHlpr.LogErrorAsync(ex);
                throw;
            }
        }

        [ActionName("GetCountAsync")]
        [HttpGet]
        public async Task<int> GetCountAsync()
        {
            try
            {
                return await odlDatHlpr.Users.GetCountAsync();
            }
            catch (Exception ex)
            {
                await logDatHlpr.LogErrorAsync(ex);
                throw;
            }
        }

        [ActionName("IsLoginNameUsedAsync")]
        [HttpGet("{loginName}")]
        public async Task<bool> IsLoginNameUsedAsync(string loginName)
        {
            try
            {
                logDatHlpr.LogDebug($"Checking login name {loginName}");

                var user = await odlDatHlpr.Users.GetFirstAsync(
                            u => u.LoginName.Equals(loginName, StringComparison.OrdinalIgnoreCase));

                return user != null;
            }
            catch (Exception ex)
            {
                await logDatHlpr.LogErrorAsync(ex);
                throw;
            }
        }

        [ActionName("GetAsync")]
        [HttpGet("{id}")]
        public async Task<User> GetAsync(int id)
        {
            try
            {
                return await odlDatHlpr.Users.GetByIdAsync(id);
            }
            catch (Exception ex)
            {
                await logDatHlpr.LogErrorAsync(ex);
                throw;
            }
        }

        [ActionName("AddAsync")]
        [HttpPost]
        public async Task<OpResult> AddAsync(User newUser)
        {
            try
            {
                return await odlDatHlpr.Users.AddAsync(newUser);
            }
            catch (Exception ex)
            {
                await logDatHlpr.LogErrorAsync(ex);
                throw;
            }
        }

        [ActionName("SignInAsync")]
        [HttpGet("{loginName}")]
        public async Task<User> SignInAsync(string loginName)
        {
            try
            {
                //if (loginName.Contains('@') && loginName.Contains('.'))
                //{
                //    var email = await TrCrsDataHelper.Instance.EmailAddresses.GetFirstAsync(
                //                    em => em.Address.Equals(loginName, StringComparison.OrdinalIgnoreCase));

                //    if (email != null)
                //    {
                //        var trn = await TrCrsDataHelper.Instance.Trainees.GetFirstAsync(
                //                                    tr => tr.ContactDetailsId.HasValue 
                //                                    && tr.ContactDetailsId.Value == email.ContactDetailId
                //                                    && tr.UserId.HasValue);
                //        return trn != null
                //                    ? await TrCrsDataHelper.Instance.Users.GetFirstAsync(
                //                        u => u.Id == trn.UserId.Value)                                    
                //                    : null;
                //    }
                //    else
                //        return null;
                //}
                //else
                return await odlDatHlpr.Users.GetFirstAsync(
                        u => u.LoginName.Equals(loginName, StringComparison.OrdinalIgnoreCase), "");
            }
            catch (Exception ex)
            {
                await logDatHlpr.LogErrorAsync(ex);
                throw;
            }
        }

        [ActionName("ChangePasswordAsync")]
        [HttpPut]
        public async Task<OpResult> ChangePasswordAsync(string[] idAndPassword)
        {
            try
            {
                var userId = int.Parse(idAndPassword[0]);
                var newPwd = idAndPassword[1];
                var user = await odlDatHlpr.Users.GetByIdAsync(userId);

                user.HashedPassword = newPwd;

                return await odlDatHlpr.Users.UpdateAsync(user);
            }
            catch (Exception ex)
            {
                await logDatHlpr.LogErrorAsync(ex);
                throw;
            }
        }

        [ActionName("ChangeRoleAsync")]
        [HttpPut]
        public async Task<OpResult> ChangeRoleAsync(string[] idAndRole)
        {
            try
            {
                var userId = int.Parse(idAndRole[0]);
                var newRole = (UserRole)Enum.Parse(typeof(UserRole), idAndRole[1]);
                var user = await odlDatHlpr.Users.GetByIdAsync(userId);

                user.Role = newRole;

                return await odlDatHlpr.Users.UpdateAsync(user);
            }
            catch (Exception ex)
            {
                await logDatHlpr.LogErrorAsync(ex);
                throw;
            }
        }

        [ActionName("SetLastSignedInAtAsync")]
        [HttpPut]
        public async Task<OpResult> SetLastSignedInAtAsync(int userId)
        {
            try
            {
                var user = await odlDatHlpr.Users.GetByIdAsync(userId);

                user.LastSignedInAt = DateTime.Now;

                return await odlDatHlpr.Users.UpdateAsync(user);
            }
            catch (Exception ex)
            {
                await logDatHlpr.LogErrorAsync(ex);
                throw;
            }
        }
        #endregion
    }
}
