using Application.Features.MediatorDesignPattern.Commands.OrderCommands;
using Domain.Entities;
using MediatR;
using Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.MediatorDesignPattern.Handlers.OrderHandlers
{
    public class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommand>
    {
        private readonly MyContext _context;

        public CreateOrderCommandHandler(MyContext context)
        {
            _context = context;
        }

      
            public async Task<Unit> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
            {
                await _context.Orders.AddAsync(new Order
                {
                    ShippingAddress = request.ShippingAddress
                }, cancellationToken);
                await _context.SaveChangesAsync(cancellationToken);
                return Unit.Value;
            }
        }
    }
   

