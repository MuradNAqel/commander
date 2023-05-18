using commander.Models;

namespace commander.Data
{
    public class SqlCommanderRepo : ICommanderRepo
    {
        private readonly CommanderContext _context;

        public SqlCommanderRepo(CommanderContext context)
        {
            _context = context;
        }

        public void CreateCommand(Command command)
        {
            if(command == null)
            {
                throw new ArgumentNullException(nameof(command));
            }
            _context.Commands.Add(command);
            _context.SaveChanges();
        }

        public void DeleteCommand(Command command)
        {
            if (command == null)
            { throw new ArgumentNullException(nameof(command)); }
            _context.Commands.Remove(command);
        }

        public Command GetCommandById(int id)
        {
            Command? cmd = _context.Commands.FirstOrDefault(cmd => cmd.Id == id);
            if (cmd == null)
            {
                throw new ArgumentNullException(nameof(cmd));
            }
            else
                return cmd;
        }

        public IEnumerable<Command> GetCommands()
        {
            return _context.Commands.ToList();
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges()>=0);
        }

        public void UpdateCommand(Command command)
        {
            //empty
        }
    }
}
