using Application.Features.CQRSDesignPattern.Commands.CategoryCommands;
using Application.Features.CQRSDesignPattern.Commands.ProductCommands;
using Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.CQRSDesignPattern.Handlers.ProductHandlers
{
    public class UpdateProductCommandHandler
    {

        private readonly MyContext _context;

        public UpdateProductCommandHandler(MyContext context)
        {
            _context = context;
        }

        public async Task Handle(UpdateProductCommand command)
        {

            var value = await _context.Products.FindAsync(command.ID);

            value.ProductName = command.ProductName;
            value.UnitPrice = command.UnitPrice; 
            await _context.SaveChangesAsync();


        }
    }
}
