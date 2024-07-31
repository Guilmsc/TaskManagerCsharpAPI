using TaskManager.Communication.Request;
using TaskManager.Communication.Response;

namespace TaskManager.Application.UseCases.Tasks.Register
{
    public class RegisterTaskUseCase
    {
        public ResponseCreateTaskJson Execute(RequestCreateTaskJson request)
        {
            return new ResponseCreateTaskJson
            {
                Id = request.Id,
                Name = request.Name,
                Description = request.Description,
                LimitDate = request.LimitDate,
                Priority = request.Priority,
                Status = request.Status
            };
        }
    }
}
