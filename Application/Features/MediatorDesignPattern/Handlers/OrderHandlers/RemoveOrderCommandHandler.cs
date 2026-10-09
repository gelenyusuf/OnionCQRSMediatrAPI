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
    public class RemoveOrderCommandHandler : IRequestHandler<RemoveOrderCommand>
    {
        private readonly MyContext _context;

        public RemoveOrderCommandHandler(MyContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(RemoveOrderCommand request, CancellationToken cancellationToken)
        {
            var values = await _context.Orders.FindAsync(request.ID);

            _context.Orders.Remove(values);
            await _context.SaveChangesAsync();
            return Unit.Value;

        }
    }
}
