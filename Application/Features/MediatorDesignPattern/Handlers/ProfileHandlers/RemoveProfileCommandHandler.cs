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
    public class RemoveProfileCommandHandler : IRequestHandler<RemoveProfileCommand>
    {
        private readonly MyContext _context;

        public RemoveProfileCommandHandler(MyContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(RemoveProfileCommand request, CancellationToken cancellationToken)
        {
            var values = await _context.Profiles.FindAsync(request.ID);

            _context.Profiles.Remove(values);
            await _context.SaveChangesAsync();
            return Unit.Value;

        }
    
    }
}
