using MediatR;
using Microsoft.AspNetCore.Mvc;
using TradeSoft.Application.UseCases.Address.Commonds;
using TradeSoft.Application.UseCases.Address.Query;

namespace TradeSoft.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AddressController : ControllerBase
    {
        private readonly IMediator _mediatr;

        public AddressController(IMediator mediatr)
        {
            _mediatr = mediatr;
        }

        [HttpGet]
        public async ValueTask<IActionResult> GetByIdAddressAsync(int Id)
        {
            var result = await _mediatr.Send(new GetByIdAddressQuery() { Id = Id });
            return Ok(result);
        }

        [HttpGet]
        public async ValueTask<IActionResult> GetAllAddressAsync()
        {
            var result = await _mediatr.Send(new GetAllAddressQuery());
            return Ok(result);
        }
        [HttpPost]
        public async ValueTask<IActionResult> CreateAddressAsync(CreateAddressCommond command)
        {
            var res = await _mediatr.Send(command);
            return Ok(res);
        }
    }
}
