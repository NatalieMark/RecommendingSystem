using System;
using System.Collections.Generic;

namespace RecommendingSystem02
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            IRecommendingSystem recommendingsystem = new RecommendingSystem();
            List<int> list = recommendingsystem.FindAllRecommendations("fmikkelsen");
            foreach (int i in list)
                Console.WriteLine(i);
        }
    }
}
