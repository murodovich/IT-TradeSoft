using MediatR;
using TradeSoft.Application.Absreactions;
using TradeSoft.Application.FileServices;
using TradeSoft.Application.UseCases.Project.Commands;
using TradeSoft.Domain.Entities.Projects;

namespace TradeSoft.Application.UseCases.Project.Handlers
{
    public class CreateProjectCommandHandler : IRequestHandler<CreateProjectCommand, bool>
    {
        private readonly ITradeSoftDBContext _dbContext;
        private readonly IFileService _fileService;

        public CreateProjectCommandHandler(ITradeSoftDBContext dbContext, IFileService fileService)
        {
            _dbContext = dbContext;
            _fileService = fileService;
        }

        public async Task<bool> Handle(CreateProjectCommand request, CancellationToken cancellationToken)
        {
            string filepage = await _fileService.UploadImageAsync(request.ImagePath);

            var result = new Domain.Entities.Projects.Project()
            {
                Name = request.Name,
                Description = request.Description,
                ImagePath = filepage,
                CreatedAt = DateTime.UtcNow,
            };

            await _dbContext.Projects.AddAsync(result);
            var res = await _dbContext.SaveChangesAsync(cancellationToken);
            return res > 0;
        }
    }
}
