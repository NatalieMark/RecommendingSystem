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
        List<int> DeleteAlreadyReadFromList(User U, List<int> FullList);
        //List<int> PriorityTop10(List<int> AllRecommendations);
		List<Book> RecommendedBooks(List<int> PriorityList);
        void PrintTopRecommendations(List<Book> TopRecommendations); //Not Done yet
        //void
        //void CalculateNewRating(Book book);
        void SaveFiles(User U);
    }
}
