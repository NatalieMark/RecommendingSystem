using System;
using System.Linq;
using System.Collections.Generic;

namespace RecommendingSystem02
{
    public class RecommendingSystem : IRecommendingSystem
    {
        private List<Book> _listOfBooks = new List<Book>();
        private List<User> _listOfUsers = new List<User>();

        public RecommendingSystem()
        {
            LoadingFiles();
        }

        public void LoadingFiles()
        {
            LoadingFile loadingFile = new LoadingFile();
            List<string[]> books = loadingFile.ListOf("books");
            List<string[]> users = loadingFile.ListOf("users");

            foreach (string[] line in books)
            {
                int temp;
                int iD;
                string name;
                int rating;
                string genre;

                if (int.TryParse(line[0], out temp))
                    iD = temp;
                else
                    throw new ParsingFailedException();

                if (line[1] != null)
                    name = line[1];
                else
                    throw new ArgumentNullException();

                if (int.TryParse(line[2], out temp))
                    rating = temp;
                else
                    throw new ParsingFailedException();

                if (line[3] != null)
                    genre = line[3];
                else
                    throw new ArgumentNullException();
                
                _listOfBooks.Add(new Book(iD, name, rating, genre));
            }

            foreach (string[] line in users)
            {
                string username;
                List<int> readBookID;

                if (line[0] != null)
                    username = line[0];
                else
                    throw new ArgumentNullException();

                readBookID = line[1].Split(',').Select(Int32.Parse).ToList<int>();

                _listOfUsers.Add(new User(username, readBookID));
            }
        }

        public User GetUser(string Username)
        {
            return _listOfUsers.First(a => a.Username == Username);
        }

        public Book GetBook(int BookID)
        {
            return _listOfBooks.First(a => a.BookID == BookID);
        }

        public void AddBookToListOfBooks(User U, Book B)
        {
            U.AddToReadBookIDList(B.BookID);
        }

        public List<int> FindAllRecommendations(string Username)
        {
            User User1 = GetUser(Username);
            List<int> User1BookID = User1.GetBookIDList();
            List<int> Recommendations = new List<int>();
            bool IdenticalBookID = false;

            foreach (int User1ID in User1BookID)
            {
                foreach (User User2 in _listOfUsers)
                {
                    if (!User1.Equals(User2))
                    {
						foreach (int User2ID in User2.GetBookIDList())
						{
							if (User1ID == User2ID)
								IdenticalBookID = true;
						}
						if (IdenticalBookID)
						{
							Recommendations.AddRange(User2.GetBookIDList());
							IdenticalBookID = false;
						}
                    }
                }
            }
            return Recommendations;
        }

		public void RecommendNewBook(User U)
        {
            
        }

		public void SaveFiles(User U)
        {
            SavingLogFile slf = new SavingLogFile();
            slf.WritingUsersFile(U);
        }
    }
}
