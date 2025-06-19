using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OneDotLearnCore.Essential;
using OneDotLearnCore.Financials;
using OneDotLearnCore.Training;
using OneDotLearnData;

namespace PeopleService.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TraineesController : ControllerBase
    {
        #region Data Members
        private OdlDataHelper odlDatHlpr;
        private LoggerDataHelper logDatHlpr;
        #endregion

        #region Constructors
        public TraineesController(OdlDataContext dbCtx, LoggingDataContext logCtx)
        {
            odlDatHlpr = OdlDataHelper.Instance; odlDatHlpr.DbCtx = dbCtx;
            logDatHlpr = LoggerDataHelper.Instance; logDatHlpr.DbCtx = logCtx;
        }
        #endregion

        #region Properties
        #endregion

        #region Methods
        [ActionName("GetPageAsync")]
        [HttpGet("{pageIndex}/{pageSize}")]
        public async Task<List<Trainee>> GetPageAsync(int pageIndex, int pageSize)
        {
            try
            {
                return await odlDatHlpr.Trainees.GetPageAsync(pageIndex, pageSize);
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
                return await odlDatHlpr.Trainees.GetCountAsync();
            }
            catch (Exception ex)
            {
                await logDatHlpr.LogErrorAsync(ex);
                throw;
            }
        }

        [ActionName("GetAsync")]
        [HttpGet("{id}")]
        public async Task<Trainee> GetAsync(int id)
        {
            try
            {
                var trn = await odlDatHlpr.Trainees.GetByIdAsync(id);
                var trnItrsts = await odlDatHlpr.TraineesInterests.GetAsync(ti => ti.TraineeId == id);

                if (trnItrsts != null && trnItrsts.Any())
                {
                    var cts = await odlDatHlpr.Domains.GetAsync(
                                            ct => trnItrsts.Any(ti => ti.CategoryId == ct.Id));

                    //trn.Interests = cts != null && cts.Any() ? cts.ToList() : null;
                }

                return trn;
            }
            catch (Exception ex)
            {
                await logDatHlpr.LogErrorAsync(ex);
                throw;
            }
        }

        [ActionName("GetByUserIdAsync")]
        [HttpGet("{userId}")]
        public async Task<Trainee> GetByUserIdAsync(int userId)
        {
            try
            {
                return await odlDatHlpr.Trainees.GetFirstAsync(
                                    tr => tr.UserId.HasValue && tr.UserId.Value == userId);
            }
            catch (Exception ex)
            {
                await logDatHlpr.LogErrorAsync(ex);
                throw;
            }
        }

        [ActionName("AddAsync")]
        [HttpPost]
        public async Task<OpResult> AddAsync(Trainee newTrainee)
        {
            OpResult rslt1, rslt2;

            try
            {
                await logDatHlpr.LogDebugAsync(
                                    $"Storing user {newTrainee.User.LoginName}...");

                rslt1 = await odlDatHlpr.Users.AddAsync(newTrainee.User);

                if (rslt1.IsSuccessful)
                {
                    //await logDatHlpr.LogDebugAsync("Creating cont. det.");

                    var cntDtl = await odlDatHlpr.ContactDetails.AddAsync(new Communication());

                    newTrainee.ContactDetailsId = cntDtl.AddedEntityId;
                    newTrainee.UserId = rslt1.AddedEntityId;

                    var nTrnAcnts = await odlDatHlpr.Accounts.GetCountAsync(
                                        act => act.ParentId.HasValue && act.ParentId == 10);

                    //await logDatHlpr.LogDebugAsync("Storing trn fin account...");

                    var acntRslt = await odlDatHlpr.Accounts.AddAsync(new Account()
                    {
                        ParentId = 10,
                        Name = $"{newTrainee.LatinFullName}",
                        AccountType = AccountType.Assets,
                        AccountSide = AccountSide.Debit,
                        OwnerType = OwnerType.Trainee,
                        Number = int.Parse(string.Format("10601{0:D4}", nTrnAcnts + 1)),
                        CurrencyId = newTrainee.ResidenceCountryId,
                        CreatedById = newTrainee.Id,
                        CreatedOn = DateTime.UtcNow,
                        EntityStatus = EntityStatus.Active
                    });

                    newTrainee.FinancialAccountId = acntRslt.AddedEntityId;

                    await logDatHlpr.LogDebugAsync(
                                        $"Storing trainee {newTrainee.LatinFullName}...");

                    rslt2 = await odlDatHlpr.Trainees.AddAsync(newTrainee);

                    //if (newTrainee.Interests != null && newTrainee.Interests.Any())
                    //{
                    //    foreach (var tri in newTrainee.Interests)
                    //        await trHlpr.TraineesInterests.AddAsync(new TraineeInterest()
                    //        {
                    //            TraineeId = tri.Id,
                    //            CategoryId = tri.ParentId.Value,
                    //            CreatedById = newTrainee.Id,
                    //            CreatedOn = DateTime.Now
                    //        });
                    //}

                    //await logDatHlpr.LogDebugAsync("Storing email...");

                    await odlDatHlpr.EmailAddresses.AddAsync(new EmailAddress()
                    {
                        ContactDetailId = cntDtl.AddedEntityId,
                        Address = newTrainee.ContactDetails.Emails[0].Address,
                        CreatedById = newTrainee.CreatedById,
                        CreatedOn = DateTime.UtcNow,
                        EntityStatus = EntityStatus.Active
                    });

                    //await logDatHlpr.LogDebugAsync("Storing mobile phone...");

                    await odlDatHlpr.TelephoneNumbers.AddAsync(new TelephoneNumber()
                    {
                        ContactDetailId = cntDtl.AddedEntityId,
                        Number = newTrainee.ContactDetails.Mobiles[0].Number,
                        IsMobile = true,
                        CreatedById = newTrainee.CreatedById,
                        CreatedOn = DateTime.UtcNow,
                        EntityStatus = EntityStatus.Active
                    });


                    await logDatHlpr.LogDebugAsync($"Save done: {rslt2.IsSuccessful}");

                    return rslt2;
                }
                else
                    return new OpResult() { IsSuccessful = false };
            }
            catch (Exception ex)
            {
                await logDatHlpr.LogErrorAsync(ex);
                throw;
            }
        }

        [ActionName("ModifyAsync")]
        [HttpPut]
        public async Task<OpResult> ModifyAsync(Trainee trainee)
        {
            try
            {
                return await odlDatHlpr.Trainees.UpdateAsync(trainee);
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
