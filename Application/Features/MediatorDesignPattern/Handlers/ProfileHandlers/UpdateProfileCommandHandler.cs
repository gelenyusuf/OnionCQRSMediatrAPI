using Application.Features.MediatorDesignPattern.Commands.OrderCommands;
using Application.Features.MediatorDesignPattern.Commands.ProfileCommands;
using MediatR;
using Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.MediatorDesignPattern.Handlers.ProfileHandlers
{
    public class UpdateProfileCommandHandler : IRequestHandler<UpdateProfileCommand>
    {
        private readonly MyContext _context;

        public UpdateProfileCommandHandler(MyContext context)
        {
            _context = context;
        }
        public async Task<Unit> Handle(UpdateProfileCommand request, CancellationToken cancellationToken)
        {
            var values = await _context.Profiles.FindAsync(request.ID);

            values.FirstName = request.FirstName; 
            values.LastName = request.LastName; 


            await _context.SaveChangesAsync();
            return Unit.Value;
        }
    
    }
}
