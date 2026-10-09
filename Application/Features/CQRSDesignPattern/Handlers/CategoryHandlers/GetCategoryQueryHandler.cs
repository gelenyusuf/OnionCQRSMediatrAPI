using Application.Features.CQRSDesignPattern.Results.CategoryResults;
using Microsoft.EntityFrameworkCore;
using Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.CQRSDesignPattern.Handlers.CategoryHandlers
{
    public class GetCategoryQueryHandler
    {
        private readonly MyContext _context;

        public GetCategoryQueryHandler(MyContext context)
        {
            _context = context;
        }

        public async Task<List<GetCategoryQueryResult>> Handle() {


            var value = await _context.Categories.ToListAsync();

            return value.Select(x => new GetCategoryQueryResult
            {
                ID = x.ID,
                CategoryName = x.CategoryName,
                Description = x.Description

            }).ToList();
        }
    }
}
