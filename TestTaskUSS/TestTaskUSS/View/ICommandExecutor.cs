
namespace TestTaskUSS
{
    public interface ICommandExecutor
    {
        public void Register(Command command);
        public Command FindCommandByName(string name);
        public void Execute(string command);
    }
}
