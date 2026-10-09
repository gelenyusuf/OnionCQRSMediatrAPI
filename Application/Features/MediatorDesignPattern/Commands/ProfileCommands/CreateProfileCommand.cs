using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.MediatorDesignPattern.Commands.ProfileCommands
{
    public class CreateProfileCommand:IRequest 
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
