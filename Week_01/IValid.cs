using System;
/*
 20.有效的括号
     */
public class Solution
{
    public bool IsValid(string s)
    {
        if (s.Length < 2) return false;
        Stack<char> result = new Stack<char>();
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '(') result.Push(')');
            else if (s[i] == '[') result.Push(']');
            else if (s[i] == '{') result.Push('}');
            else if (result.Count > 0 && result.Peek() == s[i]) result.Pop();
            else return false;
        }
        if (result.Count == 0) return true;
        return false;
    }
}
