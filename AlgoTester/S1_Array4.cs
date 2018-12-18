using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTester
{
    class S1_Array4
    {
        public static int LengthOfLongestSubstring(string s)
        {
            if (s.Length == 0) return 0;
            var map = new Dictionary<char, int>();
            int tail = 0;
            int ans = -1;
            for (int i = 0; i < s.Length; i++)
            {
                //Console.WriteLine("i = {0}", i);
                if (map.ContainsKey(s[i]))
                {
                    var tailTo = map[s[i]] + 1;
                    for (int j = tail; j < tailTo - 1; j++)
                    {
                        map.Remove(s[j]);
                    }
                    tail = tailTo;
                    map[s[i]] = i;
                }
                else
                {
                    map.Add(s[i], i);
                }

                var thisLength = i - tail + 1;
                if (thisLength > ans)
                {
                    ans = thisLength;
                    //Console.WriteLine("{0}: {1} - {2}", ans, tail, i);
                }
            }
            return ans;
        }
    }
}
