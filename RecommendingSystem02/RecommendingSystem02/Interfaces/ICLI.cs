using System;
using System.Collections.Generic;

namespace RecommendingSystem02
{
    public interface ICLI
    {
        void PrintMissingInput();
        void PrintHello();
        void PrintBooks(List<Book> ListOfBooks);
        void PrintUserDoesNotExist(string Command);
        void Start();
        void ShutDown();
        event RecommendingSystemEvent CommandEntered;
    }
}
