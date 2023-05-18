using commander.Models;

namespace commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public void CreateCommand(Command command)
        {
            throw new NotImplementedException();
        }

        public void DeleteCommand(Command command)
        {
            throw new NotImplementedException();
        }

        public Command GetCommandById(int id)
        {
            return new Command { HowTo = "This is how to", Id=0, Line="some code line ", Platform="ASP.Net 6"};
        }

        public IEnumerable<Command> GetCommands()
        {
            var commands = new List<Command> { 
                new Command { HowTo = "This is how to", Id = 0, Line = "some code line ", Platform = "ASP.Net 6" },
                new Command { HowTo = "This is how to2", Id=1, Line="some code line 1", Platform="Flutter"},
                new Command { HowTo = "This is how to3", Id = 2, Line = "some code line2 ", Platform = "Flutter2" }
        };
              return commands;
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void UpdateCommand(Command command)
        {
            throw new NotImplementedException();
        }
    }
}
