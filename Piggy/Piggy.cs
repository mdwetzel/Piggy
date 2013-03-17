using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Piggy
{
    static class Piggy
    {
        public static string Convert(string input)
        {
            StringBuilder builder = new StringBuilder();

            // Strip any punctuation. 
            input = Regex.Replace(input, @"[^\w\s]", "");

            foreach (string word in input.Split(' ')) {
                char firstLetter = word[0];
                string pigFormat = firstLetter.IsVowel() ?
                    string.Format("{0}-ay", word) :
                    string.Format("{0}-{1}ay", word.Substring(1, word.Length - 1), firstLetter);
                builder.Append(pigFormat + " ");
            }
            return builder.ToString();
        }
    }
}
