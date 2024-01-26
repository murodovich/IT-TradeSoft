using MediatR;
using Microsoft.EntityFrameworkCore;
using TradeSoft.Application.Absreactions;
using TradeSoft.Application.UseCases.Questions.Query;
using TradeSoft.Domain.Entities.Questions;

namespace TradeSoft.Application.UseCases.Questions.Handler
{
    public class GetByIdQuestionQueryHandler : IRequestHandler<GetByIdQuestionQuery, Question>
    {
        private readonly ITradeSoftDBContext _dbContext;

        public GetByIdQuestionQueryHandler(ITradeSoftDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Question> Handle(GetByIdQuestionQuery request, CancellationToken cancellationToken)
        {
            var result = await _dbContext.Question.FirstOrDefaultAsync(x => x.Id == request.Id);
            if (result == null) throw new Exception();
            return result;
        }
    }
}
