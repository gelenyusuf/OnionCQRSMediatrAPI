using Application.Features.MediatorDesignPattern.Results.OrderResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.MediatorDesignPattern.Queries.OrderQueries
{
    public class GetOrderQuery :IRequest<List<GetOrderQueryResult>>
    {
    }
}
