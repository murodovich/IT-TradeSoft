using MediatR;
using Microsoft.EntityFrameworkCore;
using TradeSoft.Application.Absreactions;
using TradeSoft.Application.UseCases.Address.Query;
using TradeSoft.Domain.Exceptions.AddressExceptions;
namespace TradeSoft.Application.UseCases.Address.Handlers
{
    public class GetAllAddressQueryHandler : IRequestHandler<GetAllAddressQuery, List<Domain.Entities.Addreses.Address>>
    {
        private readonly ITradeSoftDBContext _dbContext;

        public GetAllAddressQueryHandler(ITradeSoftDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<Domain.Entities.Addreses.Address>> Handle(GetAllAddressQuery request, CancellationToken cancellationToken)
        {

            var result = await _dbContext.Addresses.ToListAsync(cancellationToken);
            if (result.Count() == 0) throw new AddressNotFoundExceptions();
            return result;
        }
    }
}
