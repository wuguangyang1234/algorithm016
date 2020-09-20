using System;
using System.Collections.Generic;
public class Solution
{
    public string RemoveOuterParentheses(string S)
    {
        StringBuilder result = new StringBuilder();
        int count = 0;
        for (int i = 0; i < S.Length; i++)
        {
            if (S[i] == ')') count--;
            if (count > 0) result.Append(S[i]);
            if (S[i] == '(') count++;
        }
        return result.ToString();
    }
}
