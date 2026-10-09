using Application.Features.MediatorDesignPattern.Queries.OrderQueries;
using Application.Features.MediatorDesignPattern.Queries.ProfileQueries;
using Application.Features.MediatorDesignPattern.Results.OrderResults;
using Application.Features.MediatorDesignPattern.Results.ProfileResults;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.MediatorDesignPattern.Handlers.ProfileHandlers
{
    public  class GetProfileQueryHandler : IRequestHandler<GetProfileQuery, List<GetProfileQueryResult>>
    {

        private readonly MyContext _context;

        public GetProfileQueryHandler(MyContext context)
        {
            _context = context;
        }

        public async Task<List<GetProfileQueryResult>> Handle(GetProfileQuery request, CancellationToken cancellationToken)
        {
            var value = await _context.Profiles.ToListAsync();
            return value.Select(c => new GetProfileQueryResult
            {
                ID = c.ID,
                FirstName = c.FirstName, 
                LastName = c.LastName 
            }).ToList();
        }
    
    }
}
