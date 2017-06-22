using System;
namespace RecommendingSystem02
{
    public class Controller
    {
        private IRecommendingSystem _recommendingSystem;

        public Controller(IRecommendingSystem RecommendingSystem)
        {
            _recommendingSystem = RecommendingSystem;
        }

        public void Login(string command)
        {
            if (command != null)
            {
                
            }
        }
    }
}
