using System;
using System.IO;
using System.Linq;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.TenkeumiaffoSL.Sprint6.Task6.V11.Lib
{
    public class DataService : ISprint6Task6V11
    {
        public string CollectTextFromFile(string path)
        {
            if (!File.Exists(path))
                throw new FileNotFoundException("Файл не найден: " + path);

            string[] lines = File.ReadAllLines(path);

            string result = "";

            foreach (string line in lines)
            {
                string[] words = line
                    .Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

                if (words.Length >= 2)
                {
                    string penultimate = words[words.Length - 2];
                    result += penultimate + " ";
                }
            }

            return result.Trim();
        }
    }
}
