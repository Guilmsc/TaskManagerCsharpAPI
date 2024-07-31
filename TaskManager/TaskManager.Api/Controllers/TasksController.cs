using Microsoft.AspNetCore.Mvc;
using TaskManager.Application.UseCases.Tasks.Delete;
using TaskManager.Application.UseCases.Tasks.GetAll;
using TaskManager.Application.UseCases.Tasks.GetById;
using TaskManager.Application.UseCases.Tasks.Register;
using TaskManager.Application.UseCases.Tasks.Update;
using TaskManager.Communication.Request;
using TaskManager.Communication.Response;

namespace TaskManager.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {

        [HttpPost]
        [ProducesResponseType(typeof(ResponseCreateTaskJson), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(ResponseErrorJson), StatusCodes.Status400BadRequest)]
        public IActionResult Criar([FromBody] RequestCreateTaskJson request)
        {
            var response = new RegisterTaskUseCase().Execute(request);
            return Created();
        }
        [HttpPut]
        [Route("{id}")]
        [ProducesResponseType(typeof(ResponseCreateTaskJson), StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(ResponseErrorJson), StatusCodes.Status400BadRequest)]
        public IActionResult Update([FromRoute] int id, [FromBody] RequestCreateTaskJson request)
        {
            var useCase = new UpdateTaskUseCase();
            useCase.Execute(id, request);

            return NoContent();
        }

        [HttpGet]
        [ProducesResponseType(typeof(ResponseAllTaskJson), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        
        public IActionResult GetAll()
        {
            var useCase = new GetAllTasksUseCase();   
            var response = useCase.Execute();

            if (response.Tasks.Any())
            {
                return Ok(response);
            }
            else
            {
                return NoContent();
            }
            
        }
        [HttpGet]
        [Route("{id}")]
        [ProducesResponseType(typeof(ResponseTaskJson), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseErrorJson), StatusCodes.Status404NotFound)]
        public IActionResult Get(int id)
        {
            var useCase = new GetTaskById();
            var response = useCase.Execute(id);
            return Ok(response);
        }
        [HttpDelete]
        [Route("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(ResponseErrorJson), StatusCodes.Status404NotFound)]
        public IActionResult Delete(int id)
        {
            var useCase = new DeleteTaskByIdUseCase();
            useCase.Execute(id);
            return NoContent();
        }
    }
}
