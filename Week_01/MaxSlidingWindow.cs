using System;
using System.Collections;
using System.Collections.Generic;
/*239.滑动窗口的最大值
 * 使用双端队列，保证队首永远是最大值，滑动窗口时每次移除队首，
 
     */
public class Class1
{
    public int[] MaxSlidingWindow(int[] nums, int k)
    {
        int[] resultarr = new int[nums.Length - k + 1];
        LinkedList<int> maxslidlist = new LinkedList<int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (maxslidlist.Count > 0 && maxslidlist.First.Value < (i - k + 1))
            {
                maxslidlist.RemoveFirst();
            }
            while (maxslidlist.Count > 0 && nums[i] >= nums[maxslidlist.Last.Value])//保证队首为最大值
            {
                maxslidlist.RemoveLast();
            }
            maxslidlist.AddLast(i);
            if (i >= k - 1)
                resultarr[i - k + 1] = nums[maxslidlist.First.Value];
        }
        return resultarr;

    }
}
