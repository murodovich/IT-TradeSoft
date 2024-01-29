using MediatR;
namespace TradeSoft.Application.UseCases.Address.Commonds
{
    public class CreateAddressCommond : IRequest<bool>
    {
        public string PhoneNumber { get; set; }
        public string City { get; set; }
        public string Email { get; set; }
    }
}
