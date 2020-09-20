using System;
using System.Collections.Generic;
public class Solution
{
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        IList<IList<string>> result = new List<IList<string>>();
        Dictionary<string, List<string>> wordsDic = new Dictionary<string, List<string>>();
        for (int i = 0; i < strs.Length; i++)
        {
            char[] schar = strs[i].ToCharArray();
            Array.Sort(schar);
            string s = new string(schar);
            if (!wordsDic.ContainsKey(s))
                wordsDic.Add(s, new List<string>() { strs[i] });
            else
                wordsDic[s].Add(strs[i]);
        }
        foreach (string item in wordsDic.Keys)
        {
            result.Add(wordsDic[item]);
        }
        return result;

    }
}
