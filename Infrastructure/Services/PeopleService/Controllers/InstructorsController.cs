using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OneDotLearnCore.Essential;
using OneDotLearnCore.Financials;
using OneDotLearnCore.People;
using OneDotLearnCore.Training;
using OneDotLearnData;

namespace PeopleService.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class InstructorsController : ControllerBase
    {
        #region Data Members
        private OdlDataHelper odlDatHlpr;
        private LoggerDataHelper logDatHlpr;
        #endregion

        #region Constructors
        public InstructorsController(OdlDataContext dbCtx, LoggingDataContext logCtx)
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
        public async Task<List<Instructor>> GetAllAsync()
        {
            try
            {
                return await odlDatHlpr.Instructors.GetAllAsync();
            }
            catch (Exception ex)
            {
                await logDatHlpr.LogErrorAsync(ex);
                throw;
            }
        }

        [ActionName("GetPageAsync")]
        [HttpGet("{pageIndex}/{pageSize}")]
        public async Task<List<Instructor>?> GetPageAsync(int pageIndex, int pageSize)
        {
            try
            {
                var instrs = await odlDatHlpr.Instructors.GetPageAsync(pageIndex, pageSize);

                if (instrs != null && instrs.Any())
                    foreach (var instr in instrs)
                        await PopulateInstructorInfoAsync(instr);

                return instrs;
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
                return await odlDatHlpr.Instructors.GetCountAsync();
            }
            catch (Exception ex)
            {
                await logDatHlpr.LogErrorAsync(ex);
                throw;
            }
        }

        [ActionName("GetAsync")]
        [HttpGet("{id}")]
        public async Task<Instructor> GetAsync(int id)
        {
            try
            {
                var instr = await odlDatHlpr.Instructors.GetByIdAsync(id);

                await PopulateInstructorInfoAsync(instr);

                return instr;
            }
            catch (Exception ex)
            {
                await logDatHlpr.LogErrorAsync(ex);
                throw;
            }
        }

        [ActionName("GetByUserIdAsync")]
        [HttpGet("{userId}")]
        public async Task<Instructor> GetByUserIdAsync(int userId)
        {
            try
            {
                return await odlDatHlpr.Instructors.GetFirstAsync(
                                instr => instr.UserId.HasValue && instr.UserId.Value == userId);
            }
            catch (Exception ex)
            {
                await logDatHlpr.LogErrorAsync(ex);
                throw;
            }
        }

        [ActionName("AddAsync")]
        [HttpPost]
        public async Task<OpResult> AddAsync(Instructor newInstructor)
        {
            OpResult rslt1, rslt2;

            try
            {
                //var trHlpr = OdsDataHelper.Instance;

                rslt1 = await odlDatHlpr.Users.AddAsync(newInstructor.User);

                if (rslt1.IsSuccessful)
                {
                    newInstructor.UserId = rslt1.AddedEntityId;//newInstructor.User.Id;

                    var cntDtl = await odlDatHlpr.ContactDetails.AddAsync(new Communication());

                    newInstructor.ContactDetailsId = cntDtl.AddedEntityId;
                    newInstructor.UserId = rslt1.AddedEntityId;

                    //if (newInstructor.WorkExperience != null && newInstructor.WorkExperience.Any())
                    //    foreach (var exp in newInstructor.WorkExperience)
                    //        await trHlpr.Experiences.AddAsync(new WorkExperience()
                    //        {
                    //            EmployeeId = newInstructor.Id,
                    //            Achievement = exp.Achievement,
                    //            CreatedById = newInstructor.CreatedById,
                    //            CreatedOn = DateTime.Now,
                    //            EntityStatus = EntityStatus.Active
                    //        });


                    var nInstrAcnts = await odlDatHlpr.Accounts.GetCountAsync(
                                                act => act.ParentId.HasValue && act.ParentId == 12);

                    var acntRslt = await odlDatHlpr.Accounts.AddAsync(new Account()
                    {
                        ParentId = 12,
                        Name = $"{newInstructor.LatinFullName}",
                        AccountType = AccountType.Liabilities,
                        AccountSide = AccountSide.Credit,
                        OwnerType = OwnerType.Instructor,
                        Number = int.Parse(string.Format("20101{0:D3}", nInstrAcnts + 1)),
                        CreatedById = newInstructor.Id,
                        CreatedOn = DateTime.UtcNow,
                        EntityStatus = EntityStatus.Active
                    });

                    newInstructor.FinancialAccountId = acntRslt.AddedEntityId;

                    rslt2 = await odlDatHlpr.Instructors.AddAsync(newInstructor);

                    if (newInstructor.ContactDetails != null)
                    {
                        var cnt = newInstructor.ContactDetails;

                        var cntRslt = await odlDatHlpr.ContactDetails.AddAsync(new Communication());

                        if (cnt.Emails != null && cnt.Emails.Any())
                            foreach (var em in cnt.Emails)
                                await odlDatHlpr.EmailAddresses.AddAsync(new EmailAddress()
                                {
                                    ContactDetailId = cntRslt.AddedEntityId,
                                    Address = em.Address,
                                    CreatedById = newInstructor.CreatedById,
                                    CreatedOn = DateTime.Now,
                                    EntityStatus = EntityStatus.Active
                                });

                        if (cnt.Mobiles != null && cnt.Mobiles.Any())
                            foreach (var ph in cnt.Mobiles)
                                await odlDatHlpr.TelephoneNumbers.AddAsync(new TelephoneNumber()
                                {
                                    ContactDetailId = cntRslt.AddedEntityId,
                                    Number = ph.Number,
                                    IsMobile = true,
                                    CreatedById = newInstructor.CreatedById,
                                    CreatedOn = DateTime.Now,
                                    EntityStatus = EntityStatus.Active
                                });
                    }

                    //if (newInstructor.Picture != null)
                    //    await trHlpr.Pictures.AddAsync(new EntityPicture()
                    //    {
                    //        Picture = newInstructor.Picture,
                    //        EntityId = newInstructor.Id,
                    //        EntityType = EntityType.Instructor,
                    //        EntityStatus = EntityStatus.Active,
                    //        CreatedById = newInstructor.CreatedById,
                    //        CreatedOn = DateTime.Now
                    //    });

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
        public async Task<OpResult> ModifyAsync(Instructor instr)
        {
            try
            {
                return await odlDatHlpr.Instructors.UpdateAsync(instr);
            }
            catch (Exception ex)
            {
                await logDatHlpr.LogErrorAsync(ex);
                throw;
            }
        }

        private async Task PopulateInstructorInfoAsync(Instructor instructor)
        {
            try
            {
                var exprs = await odlDatHlpr.Experiences.GetAsync(xp => xp.EmployeeId == instructor.Id);

                instructor.WorkExperience = exprs != null && exprs.Any() ? exprs.ToList() : null;

                if (instructor.ContactDetailsId.HasValue)
                {
                    var emails = await odlDatHlpr.EmailAddresses.GetAsync(
                                    em => em.ContactDetailId == instructor.ContactDetailsId.Value);
                    var mobiles = await odlDatHlpr.TelephoneNumbers.GetAsync(
                                    ph => ph.ContactDetailId == instructor.ContactDetailsId.Value);

                    instructor.ContactDetails.Emails = 
                                        emails != null && emails.Any() ? emails.ToList() : null;
                    instructor.ContactDetails.Mobiles = 
                                        mobiles != null && mobiles.Any() ? mobiles.ToList() : null;
                }

                var instrPic = await odlDatHlpr.Pictures.GetAsync(
                            p => p.EntityId == instructor.Id && p.EntityType == EntityType.Instructor);
                instructor.Picture = 
                            instrPic != null && instrPic.Any() ? instrPic.First().Picture : null;
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
