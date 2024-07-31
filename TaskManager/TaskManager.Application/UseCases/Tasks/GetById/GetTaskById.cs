using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Communication.Response;

namespace TaskManager.Application.UseCases.Tasks.GetById
{
    public class GetTaskById
    {
        public ResponseTaskJson Execute(int id)
        {
            return new ResponseTaskJson();
        }
    }
}
