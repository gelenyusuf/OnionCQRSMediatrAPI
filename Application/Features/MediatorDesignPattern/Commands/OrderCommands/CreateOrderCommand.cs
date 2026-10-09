using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.MediatorDesignPattern.Commands.OrderCommands
{
    public class CreateOrderCommand:IRequest
    {
 
        public string ShippingAddress { get; set; }
    }
}
