using MediatR;
using Microsoft.AspNetCore.Mvc;
using TradeSoft.Application.UseCases.Project.Commands;
using TradeSoft.Application.UseCases.Project.Query;

namespace TradeSoft.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProjectController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async ValueTask<IActionResult> GetAllProjectAsync()
        {
            var result = await _mediator.Send(new GetAllProjectQuery());
            return Ok(result);
        }
        [HttpGet]
        public async ValueTask<IActionResult> GetByIdProjectAsync(int Id)
        {
            var result = await _mediator.Send(new GetByIdProjectQuery() { Id=Id});
            return Ok(result);
        }

        [HttpPost]
        public async ValueTask<IActionResult> CreateProjectAsync([FromForm] CreateProjectCommand createProject)
        {
            var result =await _mediator.Send(createProject);
            return Ok(result);
        }

        [HttpDelete]
        public async ValueTask<IActionResult> DeleteProjectAsync(int id)
        {
            var res =  await _mediator.Send(new DeleteProjectCommand() { Id = id });
            return Ok(res);
        }   
    }
}
