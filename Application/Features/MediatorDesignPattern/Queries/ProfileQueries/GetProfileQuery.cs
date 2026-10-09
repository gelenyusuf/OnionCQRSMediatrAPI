using Application.Features.MediatorDesignPattern.Results.ProfileResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.MediatorDesignPattern.Queries.ProfileQueries
{
    public class GetProfileQuery  : IRequest<List<GetProfileQueryResult>>
    {
    }
}
