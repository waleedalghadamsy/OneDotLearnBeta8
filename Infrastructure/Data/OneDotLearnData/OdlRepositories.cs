using Microsoft.EntityFrameworkCore;
using OneDotLearnCore.Essential;
using OneDotLearnCore.Financials;
using OneDotLearnCore.People;
using OneDotLearnCore.Security;
using OneDotLearnCore.Training;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneDotLearnData.EntitiesRepositories
{
    public interface IRepositoryWrapper
    {
        CountryRepository Countries { get; }
        CurrencyRepository Currencies { get; }
        CourseContentsRepository CoursesContents { get; }
        InstructorRepository Instructors { get; }
        ExperienceRepository Experiences { get; }
        TraineeRepoistory Trainees { get; }
        EnrolmentRepository Enrolments { get; }
        SessionAttendanceRepository AttendanceSheet { get; }
        EmailAddressRepository EmailAddresses { get; }
        TelephoneNumberRepository TelephoneNumbers { get; }
        
        UserRepository Users { get; }
        UserProfileRepository UsersProfiles { get; }
    }

    public class RepositoryWrapper : IRepositoryWrapper
    {
        private OdlDataContext _context;

        public RepositoryWrapper(OdlDataContext dbCtx)
        {
            _context = dbCtx;
        }

        public CountryRepository Countries => new CountryRepository(_context);
        public CurrencyRepository Currencies => new CurrencyRepository(_context);
        public CourseContentsRepository CoursesContents => new CourseContentsRepository(_context);
        public ExperienceRepository Experiences => new ExperienceRepository(_context);
        public TraineeRepoistory Trainees => new TraineeRepoistory(_context);
        public EnrolmentRepository Enrolments => new EnrolmentRepository(_context);
        public SessionAttendanceRepository AttendanceSheet => new SessionAttendanceRepository(_context);
        public EmailAddressRepository EmailAddresses => new EmailAddressRepository(_context);
        public TelephoneNumberRepository TelephoneNumbers => new TelephoneNumberRepository(_context);
        public InstructorRepository Instructors => new InstructorRepository(_context);
        public UserRepository Users => new UserRepository(_context);
        public UserProfileRepository UsersProfiles => new UserProfileRepository(_context);
    }

    public class CountryRepository : OdlDataRepository<Country>
    {
        public CountryRepository(OdlDataContext dbCtx) : base(dbCtx) { }
    }

    public class CurrencyRepository : OdlDataRepository<Currency>
    {
        public CurrencyRepository(OdlDataContext dbCtx) : base(dbCtx) { }
    }

    public class CourseContentsRepository : OdlDataRepository<CourseContent>
    {
        public CourseContentsRepository(OdlDataContext dbCtx) : base(dbCtx) { }
    }
    public class ExperienceRepository : OdlDataRepository<WorkExperience>
    {
        public ExperienceRepository(OdlDataContext dbCtx) : base(dbCtx) { }
    }
    public class TraineeRepoistory : OdlDataRepository<Trainee>
    {
        public TraineeRepoistory(OdlDataContext dbCtx) : base(dbCtx) { }
    }

    public class EnrolmentRepository : OdlDataRepository<Enrolment>
    {
        public EnrolmentRepository(OdlDataContext dbCtx) : base(dbCtx) { }
    }

    public class SessionAttendanceRepository : OdlDataRepository<SessionAttendance>
    {
        public SessionAttendanceRepository(OdlDataContext dbCtx) : base(dbCtx) { }
    }

    public class EmailAddressRepository : OdlDataRepository<EmailAddress>
    {
        public EmailAddressRepository(OdlDataContext dbCtx) : base(dbCtx) { }
    }

    public class TelephoneNumberRepository : OdlDataRepository<TelephoneNumber>
    {
        public TelephoneNumberRepository(OdlDataContext dbCtx) : base(dbCtx) { }
    }

    public class InstructorRepository : OdlDataRepository<Instructor>
    {
        public InstructorRepository(OdlDataContext dbCtx) : base(dbCtx) { }
    }

    public class UserRepository : OdlDataRepository<User>
    {
        public UserRepository(OdlDataContext dbCtx) : base(dbCtx) { }
    }

    public class UserProfileRepository : OdlDataRepository<UserProfile>
    {
        public UserProfileRepository(OdlDataContext dbCtx) : base(dbCtx) { }
    }
}
