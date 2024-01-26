using MediatR;

namespace TradeSoft.Application.UseCases.Questions.Commond
{
    public class CreateQuestionCommand : IRequest<bool>
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Questionies { get; set; }

    }
}
