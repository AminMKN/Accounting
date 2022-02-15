using System.Data.Entity;

namespace Accounting.Infrastructure.Models
{
    public class Context : DbContext
    {
        public Context()
           : base("name=AccountingDB")
        {
        }

        public DbSet<PrintBreakDown> PrintBreakDowns { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<RemainingReport> RemainingReports { get; set; }
        public DbSet<SewingBreakDown> SewingBreakDowns { get; set; }
    }
}
