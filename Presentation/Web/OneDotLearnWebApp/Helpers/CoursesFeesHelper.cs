using OneDotLearnCore.Essential;
using OneDotLearnCore.Training;

namespace OneDotLearnWebApp.Helpers
{
    public class CoursesFeesHelper
    {
        #region Data Memebers
        #endregion

        #region Constructors
        public CoursesFeesHelper() { }
        #endregion

        #region Properties
        #endregion

        #region Methods
        public async Task<List<Trainee>> GetAllAsync()
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

        public async Task<List<Trainee>> GetPageAsync()
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

        public async Task<Trainee> GetAsync(int id)
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

        public async Task<OpResult> AddAsync(Trainee trainee)
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

        public async Task<OpResult> ModifyAsync(Trainee trainee)
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
