using Application.Features.CQRSDesignPattern.Queries.CategoryQueries;
using Application.Features.CQRSDesignPattern.Results.CategoryResults;
using Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.CQRSDesignPattern.Handlers.CategoryHandlers
{
    public class GetCategoryByIdQueryHandler
    {
        private readonly MyContext _context;

        public GetCategoryByIdQueryHandler(MyContext context)
        {
            _context = context;
        }

        public async Task<GetCategoryByIdQueryResult> Handle(GetCategoryByIdQuery query)
        {

            var value = await _context.Categories.FindAsync(query.ID);

            return new GetCategoryByIdQueryResult
            {
                ID = value.ID,
                CategoryName = value.CategoryName,
                Description = value.Description

            };

        }
    }
}
