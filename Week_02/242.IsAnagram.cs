using System;
using System.Collections.Generic;
public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        if ((s == null || t == null) || s.Length != t.Length) return false;
        Dictionary<char, int> result = new Dictionary<char, int>();
        for (int i = 0; i < s.Length; i++)
        {
            if (result.ContainsKey(s[i]))
            {
                result[s[i]] += 1;
            }
            else
            {
                result.Add(s[i], 0);
            }
        }
        for (int i = 0; i < t.Length; i++)
        {
            if (result.ContainsKey(t[i]))
            {
                if (result[t[i]] == 0)
                {
                    result.Remove(t[i]);
                }
                else
                {
                    result[t[i]] -= 1;
                }
            }
            else
            {
                return false;
            }
        }
        return true;
    }
}
