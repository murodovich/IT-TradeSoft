using MediatR;

namespace TradeSoft.Application.UseCases.Questions.Commond
{
    public class DeleteQuestionsCommand : IRequest<bool>
    {
        public int Id { get; set; }
    }
}
