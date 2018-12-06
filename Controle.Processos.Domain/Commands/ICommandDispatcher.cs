namespace Controle.Processos.Domain.Commands
{
    public interface ICommandDispatcher
    {
        void ExecuteAsync(ICommand command);
    }
}