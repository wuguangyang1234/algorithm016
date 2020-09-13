using System;
using System.Collections.Generic;

/* 
 * 双指针法，先将数组排序
 * 第一层循环，建立基准数值，就是待比较的对象
 * 第二层循环，设定左右指针i，j，同时向内移动，找到符合三个数之和等于0的数字遇到重复值则跳过
*/
public class Class1
{
    public IList<IList<int>> ThreeSum(int[] nums)
    {
        IList<IList<int>> result = new List<IList<int>>();
        Array.Sort(nums);
        for (int k = 0; k < nums.Length - 2; k++)
        {
            if (k > 0 && nums[k] == nums[k - 1]) continue;
            int i = k + 1, j = nums.Length - 1;
            while (i < j)
            {
                if (nums[i] + nums[j] == -nums[k])
                {
                    result.Add(new List<int>() { nums[k], nums[i], nums[j] });
                    while (i < j && nums[i] == nums[++i]) ;
                    while (j > i && nums[j] == nums[--j]) ;
                }
                else if (nums[i] + nums[j] > -nums[k]) --j;
                else if (nums[i] + nums[j] < -nums[k]) ++i;
            }
        }
        return result;
    }
}
