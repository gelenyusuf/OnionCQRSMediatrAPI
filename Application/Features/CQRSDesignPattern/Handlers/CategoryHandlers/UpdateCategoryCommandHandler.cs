using Application.Features.CQRSDesignPattern.Commands.CategoryCommands;
using Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.CQRSDesignPattern.Handlers.CategoryHandlers
{
    public class UpdateCategoryCommandHandler
    {

        private readonly MyContext _context; 
        
        public UpdateCategoryCommandHandler(MyContext context)
        {
            _context = context;
        }
        public async Task Handle(UpdateCategoryCommand command) { 
            
            var value  = _context.Categories.Find(command.ID);
            
                value.CategoryName = command.CategoryName;
                value.Description = command.Description;
                await _context.SaveChangesAsync();
            
        } 
    }
}
