using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.MediatorDesignPattern.Commands.OrderCommands
{
    public class RemoveOrderCommand:IRequest
    {
        public RemoveOrderCommand(int id)
        {
            ID = id;
        }

        public int ID { get; set; }
       
    }
}
