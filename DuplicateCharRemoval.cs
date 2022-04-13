using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructure
{
    public class DuplicateCharRemoval
    {
        public string RemoveDuplicate(string key)
        {
            //StringBuilder result = new StringBuilder();
            StringBuilder table = new StringBuilder();

            foreach (var item in key)
            {
                if(table.ToString().IndexOf(item) == -1)
                {
                    table.Append(item);
                    //result.Append(item);
                }
            }



            return table.ToString();
        }

        public bool IsAnagram(string key1, string key2)
        {
            bool IsAnagram= false;
            var input1 = key1.ToLower().ToCharArray();
            var input2 = key2.ToLower().ToCharArray();

            if(input1.Length == input2.Length)
            {
                var output = input1.Intersect(input2);
                IsAnagram = output.Count() == input1.Length;
            }

            return IsAnagram;
        }
    }
}
