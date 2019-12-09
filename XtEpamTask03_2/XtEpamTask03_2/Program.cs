using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XtEpamTask03_2 // 
{
    class Program
    {
        /// <summary>
        /// Frequency of word
        /// </summary>
        /// <param name="text">Text</param>

        static Dictionary<string, float> WordFrequencyCollector(string text)
        {
            Dictionary<string, float> output = new Dictionary<string, float>();

            List<string> words = text.Split(new char[] { ' ', '.' }).ToList(); //we covert With splitting into array but further have to convert it to List, so it would be better practice to make it work, in sacrfice for little bit speed of code
            HashSet<string> uniq_words = new HashSet<string>(); //to cut off the doubled words in a line
            foreach (string word in words)
            {
                uniq_words.Add(word.ToLower());
            }
            int countWords = words.Count;

            foreach (string word in uniq_words)
            {
                float frequencyWord = (float)words.FindAll(t => t.ToLower() == word).Count / countWords;
                output.Add(word, frequencyWord);
            }

            return output;
        
    }
        static void Main(string[] args)
        {
            Console.Write("Enter the text: ");
            string text = Console.ReadLine();

            Dictionary<string, float> frequencyWordKeeper = WordFrequencyCollector(text);

            foreach (var item in frequencyWordKeeper)
            {
                Console.WriteLine("Frequency word {0}: {1}", item.Key, item.Value);
            }
        }
    }
}
