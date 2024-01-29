using Microsoft.EntityFrameworkCore;
using TradeSoft.Domain.Entities.Addreses;
using TradeSoft.Domain.Entities.ProjectCalculations;
using TradeSoft.Domain.Entities.Projects;
using TradeSoft.Domain.Entities.Questions;
namespace TradeSoft.Application.Absreactions
{
    public interface ITradeSoftDBContext
    {
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<ProjectCalculation> Calculations { get; set; }
        public DbSet<Question> Question { get; set; }
        public Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
