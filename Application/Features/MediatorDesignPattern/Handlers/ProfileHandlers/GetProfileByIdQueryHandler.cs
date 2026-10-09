using Application.Features.MediatorDesignPattern.Queries.OrderQueries;
using Application.Features.MediatorDesignPattern.Queries.ProfileQueries;
using Application.Features.MediatorDesignPattern.Results.OrderResults;
using Application.Features.MediatorDesignPattern.Results.ProfileResults;
using MediatR;
using Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.MediatorDesignPattern.Handlers.ProfileHandlers
{
    public class GetProfileByIdQueryHandler : IRequestHandler<GetProfileByIdQuery, GetProfileByIdQueryResult>
    {
        private readonly MyContext _context;

        public GetProfileByIdQueryHandler(MyContext context)
        {
            _context = context;
        }


        public async Task<GetProfileByIdQueryResult> Handle(GetProfileByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _context.Profiles.FindAsync(request.ID);
            return new GetProfileByIdQueryResult
            {
               FirstName = value.FirstName, 
                LastName = value.LastName, 

            };
        }
    
    }
}
