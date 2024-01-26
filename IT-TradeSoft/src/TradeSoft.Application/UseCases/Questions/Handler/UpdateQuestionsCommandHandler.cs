using MediatR;
using Microsoft.EntityFrameworkCore;
using TradeSoft.Application.Absreactions;
using TradeSoft.Application.UseCases.Questions.Commond;
using TradeSoft.Domain.Exceptions.QuestionExceptions;

namespace TradeSoft.Application.UseCases.Questions.Handler
{
    public class UpdateQuestionsCommandHandler : IRequestHandler<UpdateQuestionsCommand, bool>
    {
        private readonly ITradeSoftDBContext _dbContext;
        

        public UpdateQuestionsCommandHandler(ITradeSoftDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<bool> Handle(UpdateQuestionsCommand request, CancellationToken cancellationToken)
        {
            var result = await _dbContext.Question.FirstOrDefaultAsync(x => x.Id == request.Id);
            if (result == null) throw new QuestionNotFoundException();

            result.Name = request.Name;
            result.PhoneNumber = request.PhoneNumber;
            result.Questionies = request.Questionies;
            result.UpdatedAt = DateTime.UtcNow;

            _dbContext.Question.Update(result);
            var res = await _dbContext.SaveChangesAsync(cancellationToken);
            return res > 0;
        }
    }
}
