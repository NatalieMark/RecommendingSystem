using System;
namespace RecommendingSystem02
{
    public class Controller
    {
        private IRecommendingSystem _system;
        private ICLI _cli;

        public Controller(IRecommendingSystem System, ICLI CLI)
        {
            _system = System;
            _cli = CLI;
            _cli.CommandEntered += Input;
        }

        public void Input(string Command)
        {
            Console.Clear();
            if (Command.Length != 0)
            {
                if (Command == _system.GetUser(Command).Username)
                    PrintListOfBooks(Command);
                else
                    _cli.PrintUserDoesNotExist(Command);
            }
            else
                _cli.PrintMissingInput();
        }

        public void PrintListOfBooks(string Command)
        {
            _cli.PrintBooks(
                _system.RecommendedBooks(
                    _system.PriorityTop10(
                        _system.FindAllRecommendations(Command))));
        }
    }
}
