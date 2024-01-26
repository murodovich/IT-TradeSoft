using MediatR;
using Microsoft.AspNetCore.Mvc;
using TradeSoft.Application.UseCases.Questions.Commond;
using TradeSoft.Application.UseCases.Questions.Query;

namespace TradeSoft.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class QuestionController : ControllerBase
    {
        private readonly IMediator _mediator;

        public QuestionController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async ValueTask<IActionResult> GetAllQuestionsAsync()
        {
            var result = await _mediator.Send(new GetAllQuestionQuery());
            return Ok(result);
        }
        [HttpPost]
        public async ValueTask<IActionResult> CreateQuestionsAsync(CreateQuestionCommand command)
        {
            var res = await _mediator.Send(command);
            return Ok(res);
        }
        [HttpGet]
        public async ValueTask<IActionResult> GetByIdQuestionsAsync(int Id)
        {
            var result = await _mediator.Send(new GetByIdQuestionQuery() { Id = Id });
            return Ok(result);
        }
        [HttpPut]
        public async ValueTask<IActionResult> UpdateQuestionsAsync(UpdateQuestionsCommand command)
        {
            await _mediator.Send(command);
            return Ok("Updated");
        }
        [HttpDelete]
        public async ValueTask<IActionResult> DeleteQuestionAsync(int Id)
        {
            await _mediator.Send(new DeleteQuestionsCommand() { Id = Id });
            return Ok("Deleted");
        }
    }
}
