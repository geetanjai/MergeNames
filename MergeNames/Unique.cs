using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MergeNames
{
    class MergeNames
    {
        public static string[] UniqueNames(string[] names1, string[] names2)
        {
            Dictionary<string, int> value = new Dictionary<string, int>();
            string[] val = null;
            int i = 0;
            for (i = 0; i < names1.Length; i++)
            {
                value.Add(names1[i], i);
            }
            for (int j = 0; j < names2.Length; j++)
            {
                if (!value.ContainsKey(names2[j]))
                {
                    value.Add(names2[j], i);
                }
               
            }
            val = value.Select(z => z.Key).ToArray();
            return val;
        }
    }
}
