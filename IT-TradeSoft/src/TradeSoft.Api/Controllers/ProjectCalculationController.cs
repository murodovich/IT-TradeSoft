using MediatR;
using Microsoft.AspNetCore.Mvc;
using TradeSoft.Application.UseCases.ProjectCalculations.Commands;
using TradeSoft.Application.UseCases.ProjectCalculations.Query;

namespace TradeSoft.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProjectCalculationController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProjectCalculationController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost]
        public async ValueTask<IActionResult> CreateProjectCalculatorAsync([FromForm] CreateProjectCalculationCommand command)
        {
            var res =  await _mediator.Send(command);
            return Ok(res);
        }
        [HttpGet]
        public async ValueTask<IActionResult> GetAllProjectCalculationAsync()
        {
            var result = await _mediator.Send(new GetAllProjectCalculationQuery());
            return Ok(result);
        }


    }
}
