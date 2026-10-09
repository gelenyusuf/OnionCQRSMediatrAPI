using Application.Features.CQRSDesignPattern.Results.CategoryResults;
using Application.Features.CQRSDesignPattern.Results.ProductResults;
using Microsoft.EntityFrameworkCore;
using Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.CQRSDesignPattern.Handlers.ProductHandlers
{
    public class GetProductQueryHandler
    {
        private readonly MyContext _context;

        public GetProductQueryHandler(MyContext context)
        {
            _context = context;
        }


        public async Task<List<GetProductQueryResult>> Handle()
        {


            var values = await _context.Products.ToListAsync();
            return values.Select(c => new GetProductQueryResult
            {
                
            }).ToList();
        }
    }
}
