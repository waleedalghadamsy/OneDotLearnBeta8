using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OneDotLearnCore.Essential;
using OneDotLearnCore.Training;
using OneDotLearnData;

namespace TrainingService.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        #region Data Members
        private OdlDataHelper odlDatHlpr;
        private LoggerDataHelper logDatHlpr;
        #endregion

        #region Constructors
        public CategoriesController(OdlDataContext dbCtx, LoggingDataContext logCtx)
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
        public async Task<List<ProductCategory>> GetAllAsync()
        {
            List<ProductCategory> allCats;
            IEnumerable<ProductCategory> subCats;

            try
            {
                allCats = await odlDatHlpr.Categories.GetAllAsync();
                var parents = allCats.Where(ct => !ct.ParentId.HasValue);
                var categories = new List<ProductCategory>();

                foreach (var cat in parents)
                {
                    cat.SubCategories = await GetSubCategoriesAsync(cat);

                    categories.Add(cat);
                }

                return categories;
            }
            catch (Exception ex)
            {
                await logDatHlpr.LogErrorAsync(ex);
                throw;
            }

            async Task<List<ProductCategory>?> GetSubCategoriesAsync(ProductCategory cat)
            {
                try
                {
                    subCats = allCats.Where(ct => ct.ParentId.HasValue && ct.ParentId.Value == cat.Id);

                    if (subCats != null && subCats.Any())
                    {
                        foreach (var subCat in subCats)
                        {
                            subCat.SubCategories = await GetSubCategoriesAsync(subCat);

                            subCat.NoOfCourses = await odlDatHlpr.Courses.GetCountAsync(
                                                            crs => crs.CategoryId == cat.Id);

                            if (subCat.SubCategories != null && subCat.SubCategories.Any())
                                subCat.NoOfCourses += subCat.SubCategories.Sum(sc => sc.NoOfCourses);
                        }

                        if (cat.SubCategories != null && cat.SubCategories.Any())
                            cat.NoOfCourses += cat.SubCategories.Sum(sc => sc.NoOfCourses);

                        return subCats.ToList();
                    }
                    else
                        return null;
                }
                catch (Exception ex)
                {
                    //logDatHlpr.LogError(ex);
                    throw;
                }
            }
        }

        [ActionName("GetTraineeInterestsAsync")]
        [HttpGet("{id}")]
        public async Task<List<ProductCategory>?> GetTraineeInterestsAsync(int id)
        {
            try
            {
                var trnItrsts = await odlDatHlpr.TraineesInterests.GetAsync(ti => ti.TraineeId == id);

                if (trnItrsts != null && trnItrsts.Any())
                {
                    var cts = await odlDatHlpr.Categories.GetAsync(
                                            ct => trnItrsts.Any(ti => ti.CategoryId == ct.Id));

                    return cts != null && cts.Any() ? cts.ToList() : null;
                }
                else
                    return null;
            }
            catch (Exception ex)
            {
                await logDatHlpr.LogErrorAsync(ex);
                throw;
            }
        }

        [ActionName("AddAsync")]
        [HttpPost]
        public async Task<OpResult> AddAsync(ProductCategory category)
        {
            try
            {
                return await odlDatHlpr.Categories.AddAsync(category);
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
