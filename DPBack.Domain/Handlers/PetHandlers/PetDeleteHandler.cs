using DPBack.Domain.Commands.PetCommands;
using DPBack.Domain.Commands.Interfaces;
using DPBack.Domain.Commands;
using DPBack.Domain.Handlers.Interfaces;
using DPBack.Domain.Repositories;


namespace DPBack.Domain.Handlers.PetHandlers
{
    public class PetDeleteHandler : IHandlerBase<PetDeleteCommand>
    {
        readonly IPetsRepository _repository;


        public PetDeleteHandler(IPetsRepository repository)
        {
            _repository = repository;
        }

        public ICommandResult Handle(PetDeleteCommand command)
        {
            if (!command.Validate())
                return new CommandResult(false, "PetDeleteCommand", "Não foi possível remover o pet", null);
            
            
                _repository.DeleteByPetId(command.PetId);
                return new CommandResult(true, "PetDeleteCommand", "Pet removido com sucesso", null);
            
        }


    }
}