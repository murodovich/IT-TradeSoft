using MediatR;
using TradeSoft.Domain.Entities.Questions;

namespace TradeSoft.Application.UseCases.Questions.Query
{
    public class GetAllQuestionQuery : IRequest<List<Question>>
    {

    }
}
