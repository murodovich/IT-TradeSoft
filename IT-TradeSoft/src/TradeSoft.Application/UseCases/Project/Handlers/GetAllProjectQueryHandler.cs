using MediatR;
using Microsoft.EntityFrameworkCore;
using TradeSoft.Application.Absreactions;
using TradeSoft.Application.UseCases.Project.Query;
using TradeSoft.Domain.Exceptions.ProjectCalculationExceptions;

namespace TradeSoft.Application.UseCases.Project.Handlers
{
    public class GetAllProjectQueryHandler : IRequestHandler<GetAllProjectQuery, List<Domain.Entities.Projects.Project>>
    {
        private readonly ITradeSoftDBContext _dbContext;

        public GetAllProjectQueryHandler(ITradeSoftDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Domain.Entities.Projects.Project>> Handle(GetAllProjectQuery request, CancellationToken cancellationToken)
        {
            var result = await _dbContext.Projects.ToListAsync(cancellationToken);
            if (result.Count == 0) throw new ProjectNotFoundException();
            return result;
        }
    }
}
