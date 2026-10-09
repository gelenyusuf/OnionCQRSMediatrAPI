using Application.Features.CQRSDesignPattern.Commands.CategoryCommands;
using Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.CQRSDesignPattern.Handlers.CategoryHandlers
{
    public class RemoveCategoryCommandHandler
    {

        private readonly MyContext _context; 

        public RemoveCategoryCommandHandler(MyContext context)
        {
            _context = context;
        }

        public async Task Handle(RemoveCategoryCommand command) { 
        
        var value  = _context.Categories.Find(command.ID);
           
               _context.Categories.Remove(value);
               await _context.SaveChangesAsync();
            
        }
    }
}
