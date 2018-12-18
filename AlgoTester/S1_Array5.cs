using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTester
{
    class S1_Array5
    {
        public static string LongestPalindrome(string s)
        {
            var s2 = new List<char>();
            for (int i = 0; i < s.Length; i++)
            {
                s2.Add('#');
                s2.Add(s[i]);
            }
            s2.Add('#');
            List<int> p = new List<int>(new int[2020]);
            int center = 0;
            int centerTail = 0;
            for (int i = 0; i < s2.Count; i++)
            {
                centerTail = center + p[center];
                if (centerTail > i)
                {
                    int mirrorPoint = center - (i - center);
                    p[i] = Math.Min(p[mirrorPoint], centerTail - i);
                }
                while ((i + p[i] + 1 < s2.Count) && (i - p[i] - 1 >= 0))
                {
                    if (s2[i + p[i] + 1] == s2[i - p[i] - 1]) p[i]++;
                    else break;
                }
                if (centerTail < i + p[i])
                {
                    center = i;
                    centerTail = i + p[i];
                }
            }
            center = p.IndexOf(p.Max());
            string ans = string.Empty;
            for (int i = center - p[center]; i <= center + p[center]; i++)
            {
                if ((s2.Count > 0) && (!s2[i].Equals('#'))) ans += s2[i];
            }
            return ans;
        }
    }
}
