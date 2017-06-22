using System;
namespace RecommendingSystem02
{
    public class Controller
    {
        private IRecommendingSystem _recommendingSystem;
        private ICLI _cli;

        public Controller(IRecommendingSystem RecommendingSystem, ICLI CLI)
        {
            _recommendingSystem = RecommendingSystem;
            _cli = CLI;
            _cli.CommandEntered += Input;
        }

        public void Input(string command)
        {
            Console.Clear();
            if (command.Length != 0)
            {
                _recommendingSystem.PrintTopRecommendations(_recommendingSystem.RecommendedBooks(_recommendingSystem.FindAllRecommendations(command)));
            }
            else
                _cli.PrintMissingInput();
        }
    }
}
