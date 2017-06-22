using System;
using System.IO;
using System.Collections.Generic;

namespace RecommendingSystem02
{
    public class SavingLogFile
    {
        public SavingLogFile()
		{
			Header();
		}

		public void Header()
		{
			StreamWriter file = new StreamWriter("logfile.csv"); //",true" to not delete file

			using (file)
			{
                file.WriteLine($"user;bookID");
			}
		}

        public void WritingUsersFile(User user)
		{
			StreamWriter file = new StreamWriter("logfile.csv", true);

			using (file)
			{
                string name = user.Username;
                List<int> bookID = user.GetBookIDList();

                file.Write($"{name};");

                foreach (int id in bookID)
                {
                    file.Write($"{id},");
                }

                file.WriteLine();
			}
		}
    }
}
