using OneDotLearnCore.Essential;
using OneDotLearnCore.Training;

namespace OneDotLearnWebApp.Helpers
{
    public class CoursesHelper
    {
        #region Data Memebers
        #endregion

        #region Constructors
        public CoursesHelper(IConfiguration config)
        {
            TrainingServiceUrl = $"{config.GetValue<string>("TrainingServiceUrl")}/api";
        }
        #endregion

        #region Properties
        public string TrainingServiceUrl { get; set; }
        public string CoursesController => $"{TrainingServiceUrl}/Courses";
        #endregion

        #region Methods
        public async Task<List<Course>> GetAllAsync()
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

        public async Task<List<Course>> GetPageAsync()
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

        public async Task<Course> GetAsync(int id)
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

        public async Task<OpResult> AddAsync(Course Course)
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

        public async Task<OpResult> ModifyAsync(Course Course)
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
