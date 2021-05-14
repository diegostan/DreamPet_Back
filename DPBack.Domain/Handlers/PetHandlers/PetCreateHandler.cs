using DPBack.Domain.Commands.PetCommands;
using DPBack.Domain.Commands.Interfaces;
using DPBack.Domain.Commands;
using DPBack.Domain.Entities;
using DPBack.Domain.Handlers.Interfaces;
using DPBack.Domain.Repositories;


namespace DPBack.Domain.Handlers.PetHandlers
{
    public class PetCreateHandler:IHandlerBase<PetCreateCommand>
    {
        readonly IPetsRepository _repository;

        public PetCreateHandler(IPetsRepository repository)
        {
            _repository = repository;
        }

        public ICommandResult Handle(PetCreateCommand command)
        {            
            if(!command.Validate())
            {
                var notifications = command.Notifications;
                return new CommandResult(false, "PetCreateCommand", "Não foi possivel criar o pet"
                , notifications);
            }

            var pet = new Pet(command.Name, command.OwnerID, command.Specie, command.Personality
            , command.Breed);   
            _repository.Create(pet); 
            return new CommandResult(true, "PetCreateCommand", "Pet criado com sucesso", null);
        }
    }
}