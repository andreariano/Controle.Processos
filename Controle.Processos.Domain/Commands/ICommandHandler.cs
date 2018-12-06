using System.Threading.Tasks;

namespace Controle.Processos.Domain.Commands
{
    public interface ICommandHandler<in TCommand> where TCommand : ICommand
    {
        Task ExecuteAsync(TCommand command);
    }
}