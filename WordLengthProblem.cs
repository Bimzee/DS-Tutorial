using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    public class WordLengthProblem
    {
        public static string SpinWords(string sentence)
        {
            var words = sentence.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > 4)
                {
                    words[i] = Reverse(words[i]);
                }
            }
            return string.Join(" ", words);
        }
        public static string Reverse(string word)
        {
            char[] str = word.ToCharArray();
            Array.Reverse(str);
            return new string(str);
        }
    }
}
