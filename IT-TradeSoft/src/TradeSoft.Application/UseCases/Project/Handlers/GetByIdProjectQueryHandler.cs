using MediatR;
using Microsoft.EntityFrameworkCore;
using TradeSoft.Application.Absreactions;
using TradeSoft.Application.UseCases.Project.Query;
using TradeSoft.Domain.Exceptions.ProjectCalculationExceptions;

namespace TradeSoft.Application.UseCases.Project.Handlers
{
    public class GetByIdProjectQueryHandler : IRequestHandler<GetByIdProjectQuery, Domain.Entities.Projects.Project>
    {
        private readonly ITradeSoftDBContext _dbContext;

        public GetByIdProjectQueryHandler(ITradeSoftDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Domain.Entities.Projects.Project> Handle(GetByIdProjectQuery request, CancellationToken cancellationToken)
        {
            var result = await _dbContext.Projects.FirstOrDefaultAsync(x => x.Id == request.Id);
            if (result == null) throw new ProjectNotFoundException();
            return result;
        }
    }
}
