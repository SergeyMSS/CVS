using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            IReadOnlyList<string> phrases = new string[] { "a", "ab", "abc" };
            string prefix = "aa";
            int left = -1;
            int right = phrases.Count;

            Console.WriteLine(GetRightBorderIndex(phrases, prefix, left, right));

            Console.ReadLine();
        }

        public static int GetRightBorderIndex(IReadOnlyList<string> phrases, string prefix, int left, int right)
        {
            while (left < right)
            {
                var middle = (left + right) / 2;

                if (string.Compare(prefix, phrases[middle], StringComparison.OrdinalIgnoreCase) < 0)
                {
                    right = middle;
                }
                else
                    left = middle + 1;
            }
            if (prefix == phrases[right])
            {
                return right;
            }
            else
            {

            }

            return prefix.Length;

            //for (int i = phrases.Count - 1; i >= 0; i--)
            //{
            //    if (string.Compare(prefix, phrases[i], StringComparison.OrdinalIgnoreCase) >= 0
            //        || phrases[i].StartsWith(prefix, StringComparison.OrdinalIgnoreCase))
            //        return i + 1;
            //}
            //return 0;
        }
    }
}
