using MediatR;
using Microsoft.EntityFrameworkCore;
using TradeSoft.Application.Absreactions;
using TradeSoft.Application.UseCases.Questions.Commond;

namespace TradeSoft.Application.UseCases.Questions.Handler
{
    public class DeleteQuestionsCommandHandler : IRequestHandler<DeleteQuestionsCommand, bool>
    {
        private readonly ITradeSoftDBContext _dbContext;

        public DeleteQuestionsCommandHandler(ITradeSoftDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<bool> Handle(DeleteQuestionsCommand request, CancellationToken cancellationToken)
        {
            var result = await _dbContext.Question.FirstOrDefaultAsync(x => x.Id == request.Id);
            if (result == null) throw new Exception();

            _dbContext.Question.Remove(result);
            var res = await _dbContext.SaveChangesAsync(cancellationToken);
            return res > 0;
        }
    }
}
