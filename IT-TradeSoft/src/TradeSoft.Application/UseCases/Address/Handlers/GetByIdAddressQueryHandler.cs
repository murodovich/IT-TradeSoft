using MediatR;
using Microsoft.EntityFrameworkCore;
using TradeSoft.Application.Absreactions;
using TradeSoft.Application.UseCases.Address.Query;
using TradeSoft.Domain.Exceptions.AddressExceptions;
namespace TradeSoft.Application.UseCases.Address.Handlers
{
    public class GetByIdAddressQueryHandler : IRequestHandler<GetByIdAddressQuery, Domain.Entities.Addreses.Address>
    {
        private readonly ITradeSoftDBContext _dbContext;

        public GetByIdAddressQueryHandler(ITradeSoftDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Domain.Entities.Addreses.Address> Handle(GetByIdAddressQuery request, CancellationToken cancellationToken)
        {
            var result = await _dbContext.Addresses.FirstOrDefaultAsync(x => x.Id == request.Id);
            if (result == null) throw new AddressNotFoundExceptions();
            return result;
        }
    }
}
