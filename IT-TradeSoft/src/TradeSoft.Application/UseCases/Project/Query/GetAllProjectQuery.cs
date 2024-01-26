using MediatR;
namespace TradeSoft.Application.UseCases.Project.Query
{
    public class GetAllProjectQuery : IRequest<List<Domain.Entities.Projects.Project>>
    {
    }
}
