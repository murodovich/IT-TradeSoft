using MediatR;
using Microsoft.AspNetCore.Http;

namespace TradeSoft.Application.UseCases.ProjectCalculations.Commands
{
    public class CreateProjectCalculationCommand : IRequest<bool>
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public IFormFile FilePath { get; set; }
    }
}
