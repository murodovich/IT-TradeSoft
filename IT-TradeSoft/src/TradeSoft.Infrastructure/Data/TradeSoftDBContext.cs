using Microsoft.EntityFrameworkCore;
using TradeSoft.Application.Absreactions;
using TradeSoft.Domain.Entities.Addreses;
using TradeSoft.Domain.Entities.ProjectCalculations;
using TradeSoft.Domain.Entities.Projects;
using TradeSoft.Domain.Entities.Questions;

namespace TradeSoft.Infrastructure.Data
{
    public class TradeSoftDBContext : DbContext,ITradeSoftDBContext
    {
        public TradeSoftDBContext(DbContextOptions<TradeSoftDBContext> options) : base(options)
        {
            Database.Migrate();
        }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<ProjectCalculation> Calculations { get; set; }
        public DbSet<Question> Question { get; set; }

    }
}
