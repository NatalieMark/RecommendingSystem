﻿using System;

namespace RecommendingSystem02
{
    public class Book
    {
        private int _bookID;
        private string _name;
        private int _rating;
        private string _genre;

        public Book(int BookID, string Name, int Rating, string Genre)
        {
            _bookID = BookID;
            _name = Name;
            _rating = Rating;
            _genre = Genre;
        }

		public int BookID
		{
            get { return _bookID; }
			set
			{
				if (value > 0 && value < 11)
                    _bookID = value;
				else
					throw new InsufficientValueException();
			}
		}

        public string Name
        {
            get { return _name; }
            set
            {
                if (value != null)
                    _name = value;
                else
                    throw new ArgumentNullException();
            }
        }

        public int Rating
        {
            get { return _rating; }
            set
            {
                if (value > 0 && value < 11)
                    _rating = value;
                else
                    throw new InsufficientValueException();
            }
        }

        public string Genre
		{
            get { return _genre; }
			set
			{
				if (value != null || value == "mystery" || value == "family" || value == "horror" || value == "comedy")
                    _genre = value;
				else
                    throw new InsufficientValueException();
			}
		}
    }
}
