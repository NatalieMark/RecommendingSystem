using System;
using System.Collections.Generic;

namespace RecommendingSystem02
{
    public class User
    {
        private string _username;
        private List<int> _readBookID;

		public User(string Username, List<int> ReadBookID)
        {
            _username = Username;
            _readBookID = ReadBookID;
        }

        public string Username
		{
            get { return _username; }
			set
			{
				if (value != null)
                    _username = value;
				else
					throw new ArgumentNullException();
			}
		}

        public void AddToReadBookIDList(int i)
        {
            int same = 0;
            foreach (int bookID in _readBookID)
                if (bookID == i)
                    same++;

            if (same == 0)
                _readBookID.Add(i);
        }

        public List<int> GetBookIDList()
        {
            return _readBookID;
        }
    }
}