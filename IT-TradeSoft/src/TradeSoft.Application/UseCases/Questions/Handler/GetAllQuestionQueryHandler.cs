using MediatR;
using Microsoft.EntityFrameworkCore;
using TradeSoft.Application.Absreactions;
using TradeSoft.Application.UseCases.Questions.Query;
using TradeSoft.Domain.Entities.Questions;
using TradeSoft.Domain.Exceptions.QuestionExceptions;

namespace TradeSoft.Application.UseCases.Questions.Handler
{
    public class GetAllQuestionQueryHandler : IRequestHandler<GetAllQuestionQuery, List<Question>>
    {
        private readonly ITradeSoftDBContext _dbContext;

        public GetAllQuestionQueryHandler(ITradeSoftDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Question>> Handle(GetAllQuestionQuery request, CancellationToken cancellationToken)
        {
            var result = await _dbContext.Question.ToListAsync();
            if (result.Count == 0) throw new QuestionNotFoundException();
            return result;
        }
    }
}
