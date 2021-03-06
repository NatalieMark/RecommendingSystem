﻿using System;
using System.Collections.Generic;

namespace RecommendingSystem02
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            IRecommendingSystem recommendingsystem = new RecommendingSystem();
            ICLI cli = new CLI(recommendingsystem);
            Controller controller = new Controller(recommendingsystem, cli);
            cli.Start();
        }
    }
}
