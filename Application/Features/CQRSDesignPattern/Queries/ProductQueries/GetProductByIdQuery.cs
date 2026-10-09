using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.CQRSDesignPattern.Queries.ProductQueries
{
    public class GetProductByIdQuery
    {
        public GetProductByIdQuery(int id)
        {
            ID = id;
        }

        public int ID { get; set; }
    }
}
