using System;
using System.Collections.Generic;

namespace RecommendingSystem02
{
    public interface IRecommendingSystem
    {
        void LoadingFiles();
        User GetUser(string Username);
        Book GetBook(int BookID);
        void AddBookToListOfBooks(User U, Book B);
        List<int> FindAllRecommendations(string Username);
        void RecommendNewBook(User U);
        //void CalculateNewRating(Book book);
        void SaveFiles(User U);
    }
}
