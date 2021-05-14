using DPBack.Domain.Commands;
using DPBack.Domain.Commands.OwnerCommands;
using DPBack.Domain.Commands.Interfaces;
using DPBack.Domain.Entities;
using DPBack.Domain.Handlers.Interfaces;
using DPBack.Domain.Repositories;

namespace DPBack.Domain.Handlers.OwnerHandlers
{
    public class OwnerCreateHandler : IHandlerBase<OwnerCreateCommand>
    {
        public readonly IOwnerRepository _repository;

        public OwnerCreateHandler(IOwnerRepository repository)
        {
            _repository = repository;         
        }

        public ICommandResult Handle(OwnerCreateCommand command)
        {
            
            if (!command.Validate())
            {
                var notifications = command.Notifications;
                return new CommandResult(false, "OwnerCreateHandle"
                , "Não foi possivel criar o usuário"
                , notifications);
            }

            var owner = new Owner(command.Name, command.Address, command.Fone, command.Document);
            _repository.Create(owner);
            return new CommandResult(true, "OwnerCreateHandle", "Usuário criado com sucesso", null);
        }
    }
}