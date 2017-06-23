using System;
using System.Collections.Generic;

namespace RecommendingSystem02
{
    public class CLI : ICLI
    {
        private bool _running = true;
        private IRecommendingSystem _system;

        public CLI(IRecommendingSystem System)
        {
            _system = System;
        }

        public void PrintMissingInput()
        {
            Console.WriteLine("The input was empty, try again");
        }

        public void PrintHello()
        {
            Console.WriteLine("Hello and welcome to the recommendation system");
            Console.WriteLine("Write your username below:");
            Console.WriteLine();
        }

		public void PrintBooks(List<Book> ListOfBooks)
		{
			Console.WriteLine("Recommendations: \n");
            foreach (Book B in ListOfBooks)
				Console.WriteLine($"{B.Name}, {B.Genre} ");
		}

        public void PrintUserDoesNotExist(string Command)
        {
            Console.WriteLine($"{Command} is not an existing user");
        }

        public void Start()
        {
            while (_running)
            {
                PrintHello();
                string command = Console.ReadLine();
                CommandEntered?.Invoke(command);
            }   
        }

        public void ShutDown()
        {
            _running = false;
            string command = Console.ReadLine();
            CommandEntered?.Invoke(command);
            Console.ReadLine();
        }

        public event RecommendingSystemEvent CommandEntered;
    }
	public delegate void RecommendingSystemEvent(string command);
}
