using Application.Features.MediatorDesignPattern.Commands.OrderCommands;
using Application.Features.MediatorDesignPattern.Commands.ProfileCommands;
using Domain.Entities;
using MediatR;
using Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.MediatorDesignPattern.Handlers.ProfileHandlers
{
    public  class CreateProfileCommandHandler : IRequestHandler<CreateProfileCommand>
    {
        private readonly MyContext _context;

        public CreateProfileCommandHandler(MyContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(CreateProfileCommand request, CancellationToken cancellationToken)
        {
            await _context.Profiles.AddAsync(new AppUserProfile
            {
                FirstName = request.FirstName, 
                LastName = request.LastName 
            }, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);
            return Unit.Value;
        }
    }
}
