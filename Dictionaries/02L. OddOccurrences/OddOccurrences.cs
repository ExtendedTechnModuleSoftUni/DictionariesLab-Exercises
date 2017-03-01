namespace _02L.OddOccurrences
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class OddOccurrences
    {
        public static void Main()
        {
            var wordsLine = Console.ReadLine().ToLower().Split().ToArray();

            Dictionary<string, int> wordsCount = CountWordsOccurrences(wordsLine);

            List<string> oddCountWords = GetOddCountWords(wordsCount);

            Console.WriteLine(string.Join(", ", oddCountWords));
        }

        private static Dictionary<string, int> CountWordsOccurrences(string[] wordsLine)
        {
            var wordsCount = new Dictionary<string, int>();

            foreach (var word in wordsLine)
            {
                if (!wordsCount.ContainsKey(word))
                {
                    wordsCount[word] = 0;
                }

                wordsCount[word]++;
            }

            return wordsCount;
        }

        private static List<string> GetOddCountWords(Dictionary<string, int> wordsCount)
        {
            var oddCountWords = new List<string>();

            foreach (var kvp in wordsCount)
            {
                if (kvp.Value % 2 == 1)
                {
                    oddCountWords.Add(kvp.Key);
                }
            }

            return oddCountWords;
        }
    }
}
