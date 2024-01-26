using MediatR;
using TradeSoft.Application.Absreactions;
using TradeSoft.Application.FileServices;
using TradeSoft.Application.UseCases.ProjectCalculations.Commands;
using TradeSoft.Domain.Entities.ProjectCalculations;

namespace TradeSoft.Application.UseCases.ProjectCalculations.Handler
{
    public class CreateProjectCalculationCommandHandler : IRequestHandler<CreateProjectCalculationCommand, bool>
    {
        private readonly ITradeSoftDBContext _dbContext;
        private readonly IFileService _fileService;
        public CreateProjectCalculationCommandHandler(ITradeSoftDBContext dbContext, IFileService fileService)
        {
            _dbContext = dbContext;
            _fileService = fileService;
        }

        public async Task<bool> Handle(CreateProjectCalculationCommand request, CancellationToken cancellationToken)
        {
            string filepage = await _fileService.UploadFileAsync(request.FilePath);

            var result = new ProjectCalculation()
            {
                Name = request.Name,
                Email = request.Email,
                PhoneNumber = request.PhoneNumber,
                FilePath = filepage,
                CreatedAt = DateTime.UtcNow,
            };

            await _dbContext.Calculations.AddAsync(result);
            var res = await _dbContext.SaveChangesAsync(cancellationToken);
            return res > 0;
        }
    }
}
