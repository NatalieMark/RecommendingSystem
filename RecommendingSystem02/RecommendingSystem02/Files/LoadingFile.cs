using System;
using System.Collections.Generic;
using System.IO;

namespace RecommendingSystem02
{
	/// <summary>
	/// Loading the info from a .csv file into the program
	/// </summary>
	public class LoadingFile
    {
        // This method returns a list of a stringarray,
        // which contains every line of the file
        public List<string[]> ListOf(string Filename)
        {
            StreamReader file = new StreamReader($"{Filename}.csv");
            List<string[]> list = new List<string[]>();

            file.ReadLine();

            string line;

            while ((line = file.ReadLine()) != null)
                list.Add(line.Split(';'));

            return list;
        }
    }
}
