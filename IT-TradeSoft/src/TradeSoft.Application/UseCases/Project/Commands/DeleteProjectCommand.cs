using MediatR;

namespace TradeSoft.Application.UseCases.Project.Commands
{
    public class DeleteProjectCommand : IRequest<bool>
    {
        public int Id { get; set; }
    }
}
