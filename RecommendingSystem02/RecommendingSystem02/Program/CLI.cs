﻿using System;
namespace RecommendingSystem02
{
    public class CLI : ICLI
    {
        private bool _running = true;
        private IRecommendingSystem _recommendingSystem;

        public CLI(IRecommendingSystem Recommending)
        {
            _recommendingSystem = Recommending;
        }

        public void PrintMissingInput()
        {
            Console.WriteLine("The input was empty, try again");
        }

        public void Start()
        {
            while (_running)
            {
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
