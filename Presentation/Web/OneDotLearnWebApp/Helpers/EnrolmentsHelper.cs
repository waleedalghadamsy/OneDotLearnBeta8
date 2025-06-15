using OneDotLearnCore.Essential;
using OneDotLearnCore.Training;

namespace OneDotLearnWebApp.Helpers
{
    public class EnrolmentsHelper
    {
        #region Data Memebers
        #endregion

        #region Constructors
        public EnrolmentsHelper(IConfiguration config)
        {
            TrainingServiceUrl = $"{config.GetValue<string>("TrainingServiceUrl")}/api";
        }
        #endregion

        #region Properties
        public string TrainingServiceUrl { get; set; }
        public string EntrolmentsController => $"{TrainingServiceUrl}/Enrolments";
        #endregion

        #region Methods
        public async Task<List<Enrolment>> GetAllAsync()
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

        public async Task<List<Enrolment>> GetPageAsync()
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

        public async Task<Enrolment> GetAsync(int id)
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

        public async Task<OpResult> AddAsync(Enrolment Enrolment)
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

        public async Task<OpResult> ModifyAsync(Enrolment Enrolment)
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
