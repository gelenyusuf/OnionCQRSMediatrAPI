using Application.Features.MediatorDesignPattern.Queries.OrderQueries;
using Application.Features.MediatorDesignPattern.Results.OrderResults;
using MediatR;
using Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.MediatorDesignPattern.Handlers.OrderHandlers
{
    public class GetOrderByIdQueryHandler : IRequestHandler<GetOrderByIdQuery, GetOrderByIdQueryResult>
    {
        private readonly MyContext _context;

        public GetOrderByIdQueryHandler(MyContext context)
        {
            _context = context;
        }

    
        public async Task<GetOrderByIdQueryResult> Handle(GetOrderByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _context.Orders.FindAsync(request.ID);
            return new GetOrderByIdQueryResult
            {
                ShippingAddress = value.ShippingAddress 

            };
        }
    }
    }

