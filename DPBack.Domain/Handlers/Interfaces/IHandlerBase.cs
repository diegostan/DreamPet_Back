using DPBack.Domain.Commands.Interfaces;

namespace DPBack.Domain.Handlers.Interfaces
{
    /*Nunca alterar o tipo passado para a interface! 
    Resultado => code break*/
    public interface IHandlerBase<T> where T : ICommandBase  
    {
        ICommandResult Handle(T command);
    }
}