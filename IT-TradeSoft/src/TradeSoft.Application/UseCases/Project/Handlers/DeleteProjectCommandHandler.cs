using MediatR;
using Microsoft.EntityFrameworkCore;
using TradeSoft.Application.Absreactions;
using TradeSoft.Application.UseCases.Project.Commands;
using TradeSoft.Domain.Exceptions.ImageExceptions;

namespace TradeSoft.Application.UseCases.Project.Handlers
{
    public class DeleteProjectCommandHandler : IRequestHandler<DeleteProjectCommand, bool>
    {
        private readonly ITradeSoftDBContext _dbContext;

        public DeleteProjectCommandHandler(ITradeSoftDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<bool> Handle(DeleteProjectCommand request, CancellationToken cancellationToken)
        {
            var result = await _dbContext.Projects.FirstOrDefaultAsync(x => x.Id == request.Id);
            if (result == null) throw new ImageNotValidExceptions();
            _dbContext.Projects.Remove(result);
            var res = await _dbContext.SaveChangesAsync(cancellationToken);
            return res > 0;
        }
    }
}
