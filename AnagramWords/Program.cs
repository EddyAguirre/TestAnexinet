using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnagramWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe la primera palabra...");
            string wordA = Console.ReadLine();
            Console.WriteLine("Escribe la segunda palabra...");
            string wordB = Console.ReadLine();
            if (IsAnagram(wordA, wordB))
                Console.WriteLine("Es anagrama...");
            else
                Console.WriteLine("No es anagrama...");
            Console.ReadKey();
        }

        /// <summary>
        /// Indicates whether the input strings are anagrams or not
        /// </summary>
        /// <param name="wordA">First word of the anagram</param>
        /// <param name="wordB">Second word of the anagram</param>
        /// <returns>Returns "True" if the strings are anagrams</returns>
        static bool IsAnagram(string wordA, string wordB)
        {
            if (wordA.Length != wordB.Length)
                return false;
            List<KeyValuePair<char, int>> charCountA = CharCount(wordA);
            List<KeyValuePair<char, int>> charCountB = CharCount(wordB);
            if (charCountA.SequenceEqual(charCountB))
                return true;
            return false;
        }

        /// <summary>
        /// Get the list of letters from a string
        /// </summary>
        /// <param name="word">string to count </param>
        /// <returns>Returns a list of chars with its counter</returns>
        static List<KeyValuePair<char, int>> CharCount(string word)
        {
            Dictionary<char, int> charCount = new Dictionary<char, int>();
            foreach (char item in word)
            {
                if (charCount.ContainsKey(item))
                    charCount[item]++;
                else
                    charCount.Add(item, 1);
            }
            return new List<KeyValuePair<char, int>>(charCount.OrderBy(el => el.Key));
        }
    }
}
