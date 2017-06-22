using NUnit.Framework;
using System;
using System.IO;
using RecommendingSystem02;

namespace Test
{
    [TestFixture()]
    public class Test
    {
        RecommendingSystem Recommending = new RecommendingSystem();

		[Test()]
		public void Test_FindAllRecommendations()
		{
            int[] i = { 1, 3, 4, 2, 5 };
			Assert.AreEqual(i, Recommending.FindAllRecommendations("fmikkelsen"));
		}
        /*
        [Test()]
        public void Test_AmountOfUsers()
        {
            LoadingFile lf = new LoadingFile();
            Assert.AreEqual(20, lf.ListOf("users").Count);
		}

        
        [Test()]
        public void Test_GetUser()
        {
            Assert.AreEqual("fmikkelsen", RS.GetUser("fmikkelsen").Username);
        }
        */
    }
}
