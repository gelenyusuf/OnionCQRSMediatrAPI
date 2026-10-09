using Application.Features.MediatorDesignPattern.Queries.OrderQueries;
using Application.Features.MediatorDesignPattern.Results.OrderResults;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.MediatorDesignPattern.Handlers.OrderHandlers
{
    public  class GetOrderQueryHandler : IRequestHandler<GetOrderQuery, List<GetOrderQueryResult>>
    {

        private readonly MyContext _context;

        public GetOrderQueryHandler(MyContext context)
        {
            _context = context;
        }

        public async Task<List<GetOrderQueryResult>> Handle(GetOrderQuery request, CancellationToken cancellationToken)
        {
            var value = await _context.Orders.ToListAsync();
            return value.Select(c => new GetOrderQueryResult
            {
                ID = c.ID,
                ShippingAddress = c.ShippingAddress 
            }).ToList();
        }
    
    }
}
