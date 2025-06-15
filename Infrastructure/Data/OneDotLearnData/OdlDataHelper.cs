using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OneDotLearnCore.Blog;
using OneDotLearnCore.Essential;
using OneDotLearnCore.Financials;
using OneDotLearnCore.Logging;
using OneDotLearnCore.People;
using OneDotLearnCore.Security;
using OneDotLearnCore.Training;

namespace OneDotLearnData
{
    public class OdlDataHelper
    {
        #region Data Members
        private static readonly Lazy<OdlDataHelper> singleton =
                                    new Lazy<OdlDataHelper>(() => new OdlDataHelper());
        #endregion

        #region Constructors
        private OdlDataHelper()
        { }
        #endregion

        #region Properties
        public static OdlDataHelper Instance => singleton.Value;
        public OdlDataContext DbCtx { get; set; }
        public string ConnectionString =>  //{ get; set; }
            "User ID = onedotlearn; Password = AaBbCcDd123; Server = localhost; "
            + "Port = 5432; Database = OneDotLearnDB; Pooling = true; timeout=500; commandtimeout=500";
        public int LibyaId => 19;
        public int EgyptId => 6;
        public int TurkeyId => 38;
        public int AmericaId => 41;
        public string PicsPath => @"C:\Users\walee\source\repos\OneDotLearnBeta7\Presentation\Web\OneDotLearnWebApp\wwwroot\images";
        //public int CourseId { get; set; }
        public OdlDataRepository<Country> Countries => new OdlDataRepository<Country>(DbCtx);
        public OdlDataRepository<ProductDomain> Domains =>
                                    new OdlDataRepository<ProductDomain>(DbCtx);
        public OdlDataRepository<Course> Courses => new OdlDataRepository<Course>(DbCtx);
        public OdlDataRepository<Prerequisite> Prerequisites => 
                                    new OdlDataRepository<Prerequisite>(DbCtx);
        public OdlDataRepository<Package> Packages => new OdlDataRepository<Package>(DbCtx);
        public OdlDataRepository<CourseContent> CoursesContents =>
                                    new OdlDataRepository<CourseContent>(DbCtx);
        public OdlDataRepository<PackageCourse> PackagesCourses =>
                                    new OdlDataRepository<PackageCourse>(DbCtx);
        public OdlDataRepository<ProductFees> ProductsFees => new OdlDataRepository<ProductFees>(DbCtx);
        public OdlDataRepository<CourseRequest> RequestedCourses =>
                                    new OdlDataRepository<CourseRequest>(DbCtx);
        public OdlDataRepository<RequestAnswer> RequestsAnswers =>
                                    new OdlDataRepository<RequestAnswer>(DbCtx);
        //public OdlDataRepository<Recruit> Recruits => new OdlDataRepository<Recruit>(DbCtx);
        public OdlDataRepository<Instructor> Instructors => new OdlDataRepository<Instructor>(DbCtx);
        public OdlDataRepository<Trainee> Trainees => new OdlDataRepository<Trainee>(DbCtx);
        public OdlDataRepository<TraineeInterest> TraineesInterests =>
                                    new OdlDataRepository<TraineeInterest>(DbCtx);
        public OdlDataRepository<Cycle> ProductsCycles => new OdlDataRepository<Cycle>(DbCtx);
        public OdlDataRepository<InstructorCourse> InstructorsCourses =>
                                    new OdlDataRepository<InstructorCourse>(DbCtx);
        public OdlDataRepository<InstructorCycle> InstructorsCycles =>
                                    new OdlDataRepository<InstructorCycle>(DbCtx);
        public OdlDataRepository<CycleRequest> RequestedCycles =>
                                    new OdlDataRepository<CycleRequest>(DbCtx);
        public OdlDataRepository<Enrolment> Enrollments => new OdlDataRepository<Enrolment>(DbCtx);
        public OdlDataRepository<Account> Accounts => new OdlDataRepository<Account>(DbCtx);
        public OdlDataRepository<Currency> Currencies => new OdlDataRepository<Currency>(DbCtx);
        public OdlDataRepository<CurrencyRate> CurrenciesRates =>
                                    new OdlDataRepository<CurrencyRate>(DbCtx);
        public OdlDataRepository<Discount> Discounts => new OdlDataRepository<Discount>(DbCtx);
        public OdlDataRepository<ReceivablePayment> ReceivablePayments =>
                                    new OdlDataRepository<ReceivablePayment>(DbCtx);
        public OdlDataRepository<PayablePayment> PayablePayments =>
                                    new OdlDataRepository<PayablePayment>(DbCtx);
        public OdlDataRepository<JournalEntry> Journal => new OdlDataRepository<JournalEntry>(DbCtx);
        public OdlDataRepository<SessionAttendance> AttendancesSheet =>
                                    new OdlDataRepository<SessionAttendance>(DbCtx);
        public OdlDataRepository<AttendedCourse> AttendedCourses =>
                                    new OdlDataRepository<AttendedCourse>(DbCtx);
        public OdlDataRepository<Notification> Notifications => 
                                new OdlDataRepository<Notification>(DbCtx);
        public OdlDataRepository<WorkExperience> Experiences =>
                                       new OdlDataRepository<WorkExperience>(DbCtx);
        public OdlDataRepository<EntityEvaluation> Evaluations =>
                                        new OdlDataRepository<EntityEvaluation>(DbCtx);
        public OdlDataRepository<EntityPicture> Pictures => new OdlDataRepository<EntityPicture>(DbCtx);
        public OdlDataRepository<FavouredCourse> FavouredCourses =>
                                            new OdlDataRepository<FavouredCourse>(DbCtx);
        public OdlDataRepository<Article> Articles => new OdlDataRepository<Article>(DbCtx);
        public OdlDataRepository<Keyword> Keywords => new OdlDataRepository<Keyword>(DbCtx);
        public OdlDataRepository<Comment> Comments => new OdlDataRepository<Comment>(DbCtx);
        public OdlDataRepository<LikedArticle> LikedArticles => 
                                                    new OdlDataRepository<LikedArticle>(DbCtx);
        public OdlDataRepository<ArticleKeyword> ArticlesKeywords => 
                                                new OdlDataRepository<ArticleKeyword>(DbCtx);
        public OdlDataRepository<Communication> ContactDetails =>
                                            new OdlDataRepository<Communication>(DbCtx);
        public OdlDataRepository<EmailAddress> EmailAddresses =>
                                            new OdlDataRepository<EmailAddress>(DbCtx);
        public OdlDataRepository<TelephoneNumber> TelephoneNumbers =>
                                            new OdlDataRepository<TelephoneNumber>(DbCtx);
        public OdlDataRepository<User> Users => new OdlDataRepository<User>(DbCtx);
        public OdlDataRepository<UserProfile> UsersProfiles => new OdlDataRepository<UserProfile>(DbCtx);
        //public TrCrsRepository<SiteVisit> Visits => new TrCrsRepository<SiteVisit>(new TrCrsDataContext());
        #endregion

        #region Methods
        //public async Task<List<Country>> GetAllCountriesAsync()
        //{
        //    try
        //    {
        //        using var dbCtx = DbCtx;

        //        var dbCntrs = dbCtx.Countries;

        //        return dbCntrs != null && dbCntrs.Any() ? await dbCntrs.ToListAsync() : null;
        //    }
        //    catch (Exception ex)
        //    {
        //        await LoggerDataHelper.Instance.LogErrorAsync(ex);
        //        throw;
        //    }
        //}

        //public async Task<Country> GetCountryByIdAsync(int id)
        //{
        //    try
        //    {
        //        using var dbCtx = DbCtx;

        //        return await dbCtx.Countries.FirstOrDefaultAsync(ct => ct.Id == id);
        //    }
        //    catch (Exception ex)
        //    {
        //        await LoggerDataHelper.Instance.LogErrorAsync(ex);
        //        throw;
        //    }
        //}

        //public async Task<List<CurrencyRate>> GetLatestCurrenciesRatesAsync()
        //{
        //    try
        //    {
        //        using var dbCtx = DbCtx;

        //        var rcntRates = from rt in dbCtx.CurrenciesRates
        //                        group rt by rt.CurrencyId into rtGrps
        //                        select rtGrps.OrderByDescending(ct => ct.CreatedOn).First();

        //        return rcntRates.ToList();
        //    }
        //    catch (Exception ex)
        //    {
        //        await LoggerDataHelper.Instance.LogErrorAsync(ex);
        //        throw;
        //    }
        //}

        //public async Task<Communication> GetContactDetailsByIdAsync(int id)
        //{
        //    try
        //    {
        //        using var dbCtx = DbCtx;

        //        return await dbCtx.ContactDetails.FirstOrDefaultAsync(ct => ct.Id == id);
        //    }
        //    catch (Exception ex)
        //    {
        //        await LoggerDataHelper.Instance.LogErrorAsync(ex);
        //        throw;
        //    }
        //}

        //public async Task<OpResult> AddContactDetailsAsync(Communication communication)
        //{
        //    try
        //    {
        //        using var dbCtx = DbCtx;

        //        var ent = await dbCtx.ContactDetails.AddAsync(communication);
        //        var nRec = await dbCtx.SaveChangesAsync();

        //        return new OpResult() { IsSuccessful = true, AddedEntityId = ent.Entity.Id };
        //    }
        //    catch (Exception ex)
        //    {
        //        await LoggerDataHelper.Instance.LogErrorAsync(ex);
        //        throw;
        //    }
        //}

        //public async Task<OpResult> AddRequestedPageAsync(RequestedPage page)
        //{
        //    try
        //    {
        //        using var dbCtx = new TrCrsDataContext();

        //        var ent = await dbCtx.RequestedPages.AddAsync(page);
        //        var nRec = await dbCtx.SaveChangesAsync();

        //        return OpResult.Succeeded;
        //    }
        //    catch (Exception ex)
        //    {
        //        await LoggerDataHelper.Instance.LogErrorAsync(ex);
        //        throw;
        //    }
        //}

        //public async Task<RequestedPage> GetLastRequestedPageAsync()
        //{
        //    try
        //    {
        //        using var dbCtx = new TrCrsDataContext();

        //        return await dbCtx.RequestedPages.LastAsync();
        //    }
        //    catch (Exception ex)
        //    {
        //        await LoggerDataHelper.Instance.LogErrorAsync(ex);
        //        throw;
        //    }
        //}
        #endregion
    }
}
