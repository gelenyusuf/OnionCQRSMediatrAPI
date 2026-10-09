using Application.Features.CQRSDesignPattern.Commands.CategoryCommands;
using Domain.Entities;
using Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.CQRSDesignPattern.Handlers.CategoryHandlers
{
    public class CreateCategoryCommandHandler
    {
        private readonly MyContext _context;
        
        public CreateCategoryCommandHandler(MyContext context)
        {
            _context = context;
        }

        public async Task Handle(CreateCategoryCommand command) {

            _context.Categories.Add(new Category
            {
                CategoryName = command.CategoryName,
                Description = command.Description

            });
            await _context.SaveChangesAsync(); 
        }
    }
}
