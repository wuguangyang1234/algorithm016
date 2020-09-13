using System;
/* 11盛最多水的容器
   使用双指针法
     */
public class Solution
{
    public int MaxArea(int[] height)
    {
        int max = 0;
        for (int i = 0, j = height.Length - 1; i < j;)
        {
            int min = height[i] > height[j] ? height[j--] : height[i++];
            max = Math.Max(min * (j - i + 1), max);
        }
        return max;
    }
}
