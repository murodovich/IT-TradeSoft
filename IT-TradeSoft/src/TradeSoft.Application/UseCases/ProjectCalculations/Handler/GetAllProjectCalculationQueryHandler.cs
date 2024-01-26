using MediatR;
using Microsoft.EntityFrameworkCore;
using TradeSoft.Application.Absreactions;
using TradeSoft.Application.UseCases.ProjectCalculations.Query;
using TradeSoft.Domain.Entities.ProjectCalculations;
using TradeSoft.Domain.Exceptions.ProjectCalculationExceptions;

namespace TradeSoft.Application.UseCases.ProjectCalculations.Handler
{
    public class GetAllProjectCalculationQueryHandler : IRequestHandler<GetAllProjectCalculationQuery, List<ProjectCalculation>>
    {
        private readonly ITradeSoftDBContext _dbContext;

        public GetAllProjectCalculationQueryHandler(ITradeSoftDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<ProjectCalculation>> Handle(GetAllProjectCalculationQuery request, CancellationToken cancellationToken)
        {
            var result = await _dbContext.Calculations.ToListAsync();
            if (result.Count() == 0) throw new ProjectNotFoundException();
            return result;
        }
    }
}
