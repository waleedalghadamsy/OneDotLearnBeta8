using Microsoft.EntityFrameworkCore;
using OneDotLearnCore.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneDotLearnData
{
    public class LoggingDataContext : DbContext
    {
        #region Data Members
        #endregion

        #region Constructors
        public LoggingDataContext() { }
        public LoggingDataContext(DbContextOptions<LoggingDataContext> op) : base(op)
        {
        }
        #endregion

        #region Properties
        public DbSet<RequestedPage> RequestedPages { get; set; }
        public DbSet<DebugEvent> DebugLog { get; set; }
        public DbSet<ErrorEvent> ErrorsLog { get; set; }
        #endregion

        #region Methods
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(LoggerDataHelper.Instance.ConnectionString);
        }
        #endregion
    }
}
