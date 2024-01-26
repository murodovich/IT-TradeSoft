using MediatR;

namespace TradeSoft.Application.UseCases.Project.Query
{
    public class GetByIdProjectQuery : IRequest<Domain.Entities.Projects.Project>
    {
        public int Id { get; set; }
    }
}
