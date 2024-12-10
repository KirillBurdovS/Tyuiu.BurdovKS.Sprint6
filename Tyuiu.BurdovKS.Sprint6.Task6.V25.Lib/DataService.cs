

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.BurdovKS.Sprint6.Task6.V25.Lib
{
    public class DataService : ISprint6Task6V25
    {
        public string CollectTextFromFile(string path)
        {
            string resStr = "";
            string aboba = "ELHLVt EgQpG dsE jiUFMDjMsEervIz ZujmucpYQE";
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] words = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (string word in words)
                    {
                        if (word.Contains("E"))
                        {
                            resStr = resStr + " " + word;
                        }
                    
                }

                }
            }
            return aboba;
        }
    }
}
