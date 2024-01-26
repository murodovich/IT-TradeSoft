using MediatR;
using TradeSoft.Domain.Entities.Questions;

namespace TradeSoft.Application.UseCases.Questions.Query
{
    public class GetByIdQuestionQuery  : IRequest<Question>
    {
        public int Id { get; set; }
    }
}
