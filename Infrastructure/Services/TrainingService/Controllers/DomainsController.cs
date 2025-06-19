using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OneDotLearnCore.Essential;
using OneDotLearnCore.Training;
using OneDotLearnData;

namespace TrainingService.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class DomainsController : ControllerBase
    {
        #region Data Members
        private OdlDataHelper odlDatHlpr;
        private LoggerDataHelper logDatHlpr;
        #endregion

        #region Constructors
        public DomainsController(OdlDataContext dbCtx, LoggingDataContext logCtx)
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
        public async Task<List<ProductDomain>> GetAllAsync()
        {
            List<ProductDomain> allCats;
            IEnumerable<ProductDomain> subCats;

            try
            {
                allCats = await odlDatHlpr.Domains.GetAllAsync();
                var parents = allCats.Where(ct => !ct.ParentId.HasValue);
                var crsDomains = new List<ProductDomain>();

                foreach (var dmn in parents)
                {
                    dmn.SubDomains = await GetSubDomainsAsync(dmn);

                    crsDomains.Add(dmn);
                }

                return crsDomains;
            }
            catch (Exception ex)
            {
                await logDatHlpr.LogErrorAsync(ex);
                throw;
            }

            async Task<List<ProductDomain>?> GetSubDomainsAsync(ProductDomain cat)
            {
                try
                {
                    subCats = allCats.Where(ct => ct.ParentId.HasValue && ct.ParentId.Value == cat.Id);

                    if (subCats != null && subCats.Any())
                    {
                        foreach (var subCat in subCats)
                        {
                            subCat.SubDomains = await GetSubDomainsAsync(subCat);

                            subCat.NoOfCourses = await odlDatHlpr.Courses.GetCountAsync(
                                                            crs => crs.CategoryId == cat.Id);

                            if (subCat.SubDomains != null && subCat.SubDomains.Any())
                                subCat.NoOfCourses += subCat.SubDomains.Sum(sc => sc.NoOfCourses);
                        }

                        if (cat.SubDomains != null && cat.SubDomains.Any())
                            cat.NoOfCourses += cat.SubDomains.Sum(sc => sc.NoOfCourses);

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
        public async Task<List<ProductDomain>?> GetTraineeInterestsAsync(int id)
        {
            try
            {
                var trnItrsts = await odlDatHlpr.TraineesInterests.GetAsync(ti => ti.TraineeId == id);

                if (trnItrsts != null && trnItrsts.Any())
                {
                    var cts = await odlDatHlpr.Domains.GetAsync(
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
        public async Task<OpResult> AddAsync(ProductDomain domain)
        {
            try
            {
                return await odlDatHlpr.Domains.AddAsync(domain);
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
