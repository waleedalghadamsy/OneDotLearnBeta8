using OneDotLearnCore.Essential;
using OneDotLearnCore.Training;

namespace OneDotLearnWebApp.Helpers
{
    public class CyclesHelper
    {
        #region Data Memebers
        #endregion

        #region Constructors
        public CyclesHelper(IConfiguration config)
        {
            TrainingServiceUrl = $"{config.GetValue<string>("TrainingServiceUrl")}/api";
        }
        #endregion

        #region Properties
        public string TrainingServiceUrl { get; set; }
        public string CyclesController => $"{TrainingServiceUrl}/Cycles";
        #endregion

        #region Methods
        public async Task<List<Cycle>> GetAllAsync()
        {
            try
            {
                return null;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<Cycle>> GetPageAsync()
        {
            try
            {
                return null;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<Cycle> GetAsync(int id)
        {
            try
            {
                return null;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<OpResult> AddAsync(Cycle Cycle)
        {
            try
            {
                return OpResult.Succeeded;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<OpResult> ModifyAsync(Cycle Cycle)
        {
            try
            {
                return OpResult.Succeeded;
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion
    }
}
