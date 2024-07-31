using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Communication.Response;

namespace TaskManager.Application.UseCases.Tasks.GetAll
{
    public class GetAllTasksUseCase
    {
        public ResponseAllTaskJson Execute()
        {
            return new ResponseAllTaskJson
            {
                Tasks = new List<ResponseShortTaskJson>
                {
                    new ResponseShortTaskJson
                    {

                    }
                }
            };
        }
    }
}
