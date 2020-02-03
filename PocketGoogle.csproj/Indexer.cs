using System;
using System.Collections.Generic;
using System.Linq;

namespace PocketGoogle
{
    public class Indexer : IIndexer
    {
        private readonly Dictionary<int, Dictionary<string, List<int>>> wordsAndPosByIndex = new Dictionary<int, Dictionary<string, List<int>>>();
        private readonly Dictionary<string, HashSet<int>> indexByWord = new Dictionary<string, HashSet<int>>();

        public void Add(int id, string documentText)
        {
            string[] text = documentText.Split(' ', '.', ',', '!', '?', ':', '-', '\r', '\n');
            wordsAndPosByIndex.Add(id, new Dictionary<string, List<int>>());

            int currentPos = 0;
            foreach (string word in text)
            {
                if (!indexByWord.ContainsKey(word))
                    indexByWord[word] = new HashSet<int>();
                if (!indexByWord[word].Contains(id))
                    indexByWord[word].Add(id);
                if (!wordsAndPosByIndex[id].ContainsKey(word))
                    wordsAndPosByIndex[id].Add(word, new List<int>()); wordsAndPosByIndex[id][word].Add(currentPos);
                currentPos += word.Length + 1;
            }
        }

        public List<int> GetIds(string word)
        {
            return indexByWord.ContainsKey(word) ? indexByWord[word].ToList() : new List<int>();
        }

        public List<int> GetPositions(int id, string word)
        {
            List<int> positions = new List<int>();

            if (wordsAndPosByIndex.ContainsKey(id) && wordsAndPosByIndex[id].ContainsKey(word))
                positions = wordsAndPosByIndex[id][word];

            return positions;
        }

        public void Remove(int id)
        {
            string[] words = wordsAndPosByIndex[id].Keys.ToArray();

            foreach (var word in words)
                indexByWord[word].Remove(id);

            wordsAndPosByIndex.Remove(id);
        }
    }
}
