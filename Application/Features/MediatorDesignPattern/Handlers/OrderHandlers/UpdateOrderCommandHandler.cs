using Application.Features.MediatorDesignPattern.Commands.OrderCommands;
using MediatR;
using Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.MediatorDesignPattern.Handlers.OrderHandlers
{
    public class UpdateOrderCommandHandler : IRequestHandler<UpdateOrderCommand>
    {
        private readonly MyContext _context;

        public UpdateOrderCommandHandler(MyContext context)
        {
            _context = context;
        }
        public async Task<Unit> Handle(UpdateOrderCommand request, CancellationToken cancellationToken)
        {
            var values = await _context.Orders.FindAsync(request.ID);

            values.ShippingAddress = request.ShippingAddress; 

           
            await _context.SaveChangesAsync();
            return Unit.Value;
        }
    }
}
