using Application.Features.CQRSDesignPattern.Commands.CategoryCommands;
using Application.Features.CQRSDesignPattern.Commands.ProductCommands;
using Domain.Entities;
using Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.CQRSDesignPattern.Handlers.ProductHandlers
{
    public  class CreateProductCommandHandler
    {
        private readonly MyContext _context;

        public CreateProductCommandHandler(MyContext context)
        {
            _context = context;
        }

        public async Task Handle(CreateProductCommand command)
        {

            _context.Products.Add(new Product
            {
               ProductName = command.ProductName, 
               UnitPrice = command.UnitPrice, 

            });
            await _context.SaveChangesAsync();
        }
    }
}
