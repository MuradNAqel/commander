using commander.Models;

namespace commander.Data
{
    public interface ICommanderRepo
    {
        bool SaveChanges();
        IEnumerable<Command> GetCommands();
        Command GetCommandById(int id);

        void CreateCommand(Command command);
        void UpdateCommand(Command command);

        void DeleteCommand(Command command);
    }
}
