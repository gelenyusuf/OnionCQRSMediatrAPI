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
    public class RemoveProductCommandHandler
    {
        private readonly MyContext _context;

        public RemoveProductCommandHandler(MyContext context)
        {
            _context = context;
        }

        public async Task Handle(RemoveProductCommand command)
        {

            var value = await _context.Products.FindAsync(command.ID);

            _context.Products.Remove(value);
            await _context.SaveChangesAsync();
        }
    }
}
