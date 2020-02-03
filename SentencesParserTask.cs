using System.Collections.Generic;

namespace TextAnalysis
{
    static class SentencesParserTask
    {
        public static List<List<string>> ParseSentences(string text)
        {
            var sentencesList = new List<List<string>>();
            List<string> lines = new List<string>();

            string[] sentenses = text.Split('.', '!', '?', ';', ':', '(', ')');
            foreach (string line in sentenses)
            {
                if (string.IsNullOrEmpty(line))
                {
                    continue;
                }
                else
                {
                    lines.Add(line);
                }
            }



            return sentencesList;
        }

        public static
    }
}