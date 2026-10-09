using Application.Features.CQRSDesignPattern.Queries.CategoryQueries;
using Application.Features.CQRSDesignPattern.Queries.ProductQueries;
using Application.Features.CQRSDesignPattern.Results.CategoryResults;
using Application.Features.CQRSDesignPattern.Results.ProductResults;
using Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.CQRSDesignPattern.Handlers.ProductHandlers
{
    public class GetProductByIdQueryHandler
    {
        private readonly MyContext _context;

        public GetProductByIdQueryHandler(MyContext context)
        {
            _context = context;
        }

        public async Task<GetProductByIdQueryResult> Handle(GetProductByIdQuery query)
        {

            var value = await _context.Products.FindAsync(query.ID);

            return new GetProductByIdQueryResult
            {
                ID = value.ID,
                ProductName = value.ProductName, 
                UnitPrice = value.UnitPrice, 

            };
        }
    }
}
