using OneDotLearnCore.Essential;
using OneDotLearnCore.Training;

namespace OneDotLearnWebApp.Helpers
{
    public class TraineesHelper
    {
        #region Data Memebers
        private OneDotLearnWebHelper glbWHlpr;
        private LoggerHelper _logHlpr;
        #endregion

        #region Constructors
        public TraineesHelper(IConfiguration config, LoggerHelper lgHlpr)
        {
            PeopleServiceUrl = $"{config.GetValue<string>("PeopleServiceUrl")}/api";

            _logHlpr = lgHlpr;
        }
        #endregion

        #region Properties
        public string PeopleServiceUrl { get; set; }
        public string TraineesController => $"{PeopleServiceUrl}/Trainees";
        #endregion

        #region Methods
        public async Task<List<Trainee>> GetAllAsync()
        {
            try
            {
                return null;
            }
            catch (Exception ex)
            {
                await _logHlpr.LogErrorAsync(ex);
                throw;
            }
        }

        public async Task<List<Trainee>> GetPageAsync()
        {
            try
            {
                return null;
            }
            catch (Exception ex)
            {
                await _logHlpr.LogErrorAsync(ex);
                throw;
            }
        }

        public async Task<Trainee> GetAsync(int id)
        {
            try
            {
                return null;
            }
            catch (Exception ex)
            {
                await _logHlpr.LogErrorAsync(ex);
                throw;
            }
        }

        public async Task<OpResult> AddAsync(Trainee trainee)
        {
            try
            {
                var rslt = await glbWHlpr.PostAsync(trainee, $"{TraineesController}/AddAsync");

                return OpResult.Succeeded;
            }
            catch (Exception ex)
            {
                await _logHlpr.LogErrorAsync(ex);
                throw;
            }
        }

        public async Task<OpResult> ModifyAsync(Trainee trainee)
        {
            try
            {
                return OpResult.Succeeded;
            }
            catch (Exception ex)
            {
                await _logHlpr.LogErrorAsync(ex);
                throw;
            }
        }

        public async Task<OpResult> ChangePasswordAsync(Trainee trainee)
        {
            try
            {
                return OpResult.Succeeded;
            }
            catch (Exception ex)
            {
                await _logHlpr.LogErrorAsync(ex);
                throw;
            }
        }

        public async Task<List<Trainee>> SearchAsync(string searchTerm)
        {
            try
            {
                return null;
            }
            catch (Exception ex)
            {
                await _logHlpr.LogErrorAsync(ex);
                throw;
            }
        }
        #endregion
    }
}
