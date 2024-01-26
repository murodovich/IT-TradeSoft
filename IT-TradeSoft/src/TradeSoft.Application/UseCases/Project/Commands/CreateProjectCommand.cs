using MediatR;
using Microsoft.AspNetCore.Http;

namespace TradeSoft.Application.UseCases.Project.Commands
{
    public class CreateProjectCommand : IRequest<bool>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public IFormFile ImagePath { get; set; }
    }
}
