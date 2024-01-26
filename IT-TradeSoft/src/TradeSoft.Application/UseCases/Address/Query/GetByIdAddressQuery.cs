using MediatR;

namespace TradeSoft.Application.UseCases.Address.Query
{
    public class GetByIdAddressQuery : IRequest<Domain.Entities.Addreses.Address>
    {
        public int Id { get; set; }
    }
}
