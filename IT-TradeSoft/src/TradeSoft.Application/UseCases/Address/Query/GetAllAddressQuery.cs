using MediatR;

namespace TradeSoft.Application.UseCases.Address.Query
{
    public class GetAllAddressQuery : IRequest<List<Domain.Entities.Addreses.Address>>
    {
    }
}
