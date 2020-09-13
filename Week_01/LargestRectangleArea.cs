using System;
using System.Collections.Generic;
/*84. 柱状图中最大的矩形
      使用两个栈分别记录当前元素以及其数组下标，
      当前数组元素小于栈顶元素则入栈，否则计算当前栈顶元素的最大矩形面积
     */

public class Class1
{
    public int LargestRectangleArea(int[] heights)
    {
        int area = 0;
        if (heights.Length == 0) return 0;
        if (heights.Length == 1) return heights[0];
        Stack<int> heightStact = new Stack<int>();
        Stack<int> indexStact = new Stack<int>();
        heightStact.Push(-1);
        int s = 0;
        for (int i = 0; i < heights.Length; i++)
        {
            s = 0;
            while (heightStact.Peek() > heights[i])
            {
                area = Math.Max(heightStact.Pop() * (i - indexStact.Pop()), area);
                s++;
            }
            heightStact.Push(heights[i]);
            indexStact.Push(i - s);
        }
        s = 0;
        int len = indexStact.Count;
        while (heightStact.Count > 1)
        {
            int pop = heightStact.Pop();
            if (pop == heightStact.Peek())
            {
                s++;
                heightStact.Pop();
            }
            area = Math.Max(pop * (len - indexStact.Pop() + s), area);
        }
        return area;

    }
}
