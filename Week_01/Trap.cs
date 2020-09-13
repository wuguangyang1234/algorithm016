using System;
/*42.接雨水
 * 使用单调栈，对比数组元素，在当前元素大于栈顶元素时，计算当前栈顶元素所能接的雨水量
 * 将当前栈顶元素出栈，并将当前元素与栈顶元素继续进行比较，直到小于当前栈顶元素
 */
public class Class1
{
    public int Trap(int[] height)
    {
        Stack<int> indexStact = new Stack<int>();
        int area = 0;
        for (int i = 0; i < height.Length; i++)
        {
            while (indexStact.Count > 0 && height[i] > height[indexStact.Peek()])
            {
                int peek = indexStact.Pop();
                if (indexStact.Count == 0) break;
                area += (Math.Min(height[i], height[indexStact.Peek()]) - height[peek]) * (i - indexStact.Peek() - 1);
            }
            indexStact.Push(i);
        }
        return area;
    }
}
