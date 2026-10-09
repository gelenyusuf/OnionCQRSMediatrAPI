using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.MediatorDesignPattern.Commands.ProfileCommands
{
    public class RemoveProfileCommand:IRequest
    {
        public RemoveProfileCommand(int id)
        {
            ID = id;
        }

        public int ID { get; set; }
    }
}
