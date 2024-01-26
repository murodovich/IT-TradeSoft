using MediatR;

namespace TradeSoft.Application.UseCases.Questions.Commond
{
    public class UpdateQuestionsCommand : IRequest<bool>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Questionies { get; set; }
    }
}
