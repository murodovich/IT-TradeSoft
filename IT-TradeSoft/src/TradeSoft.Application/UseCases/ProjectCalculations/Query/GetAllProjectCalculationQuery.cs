using MediatR;
using TradeSoft.Domain.Entities.ProjectCalculations;

namespace TradeSoft.Application.UseCases.ProjectCalculations.Query
{
    public class GetAllProjectCalculationQuery : IRequest<List<ProjectCalculation>>
    {
    }
}
