using System;
namespace RecommendingSystem02
{
    public interface ICLI
    {
        void PrintMissingInput();
        void Start();
        void ShutDown();
        event RecommendingSystemEvent CommandEntered;
    }
}
