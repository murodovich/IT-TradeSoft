using MediatR;
using TradeSoft.Application.Absreactions;
using TradeSoft.Application.UseCases.Questions.Commond;

namespace TradeSoft.Application.UseCases.Questions.Handler
{
    public class CreateQuestionCommondHandler : IRequestHandler<CreateQuestionCommand, bool>
    {
        private readonly ITradeSoftDBContext _dbContext;

        public CreateQuestionCommondHandler(ITradeSoftDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<bool> Handle(CreateQuestionCommand request, CancellationToken cancellationToken)
        {
            var result = new Domain.Entities.Questions.Question()
            {
                Name = request.Name,
                PhoneNumber = request.PhoneNumber,
                Questionies = request.Questionies,
                CreatedAt = DateTime.UtcNow,

            };

            await _dbContext.Question.AddAsync(result);
            var res = await _dbContext.SaveChangesAsync(cancellationToken);
            return res > 0;
        }
    }
}
