using MediatR;
using TradeSoft.Application.Absreactions;
using TradeSoft.Application.UseCases.Address.Commonds;

namespace TradeSoft.Application.UseCases.Address.Handlers
{
    public class CreateAddressCommondHandler : IRequestHandler<CreateAddressCommond, bool>
    {
        private readonly ITradeSoftDBContext _dbContext;

        public CreateAddressCommondHandler(ITradeSoftDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<bool> Handle(CreateAddressCommond request, CancellationToken cancellationToken)
        {
            var result = new Domain.Entities.Addreses.Address()
            {
                PhoneNumber = request.PhoneNumber,
                Email = request.Email,
                City = request.City,
                CreatedAt = DateTime.UtcNow,
            };

            await _dbContext.Addresses.AddAsync(result);
            var res = await _dbContext.SaveChangesAsync(cancellationToken);
            return res > 0;
        }
    }
}
